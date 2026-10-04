using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LAS_TERRAIN.Domain.Persistence
{
    public enum PolygonGeometryKind { Plan, Crs }
    public enum PolygonScopeKind { Project, SharedCloud }

    /// <summary>An explicit, immutable owner for a v2 polygon file.</summary>
    public sealed class PolygonScope
    {
        public PolygonScopeKind Kind { get; private set; }
        public PolygonGeometryKind GeometryKind { get; private set; }
        public string StorageRoot { get; private set; }
        public string ProjectUri { get; private set; }
        public string ProjectAlias { get; private set; }
        public string SharedCloudKey { get; private set; }
        public string ModelUri { get; private set; }
        public Guid AlignmentId { get; private set; }
        public string ScopeKey { get; private set; }
        public string FilePath { get; private set; }

        private PolygonScope(PolygonScopeKind scopeKind, PolygonGeometryKind geometryKind,
            string storageRoot, string projectUri, string projectAlias, string sharedCloudKey,
            string modelUri, Guid alignmentId)
        {
            if (!Enum.IsDefined(typeof(PolygonGeometryKind), geometryKind))
                throw new ArgumentOutOfRangeException("geometryKind");
            if (String.IsNullOrEmpty(storageRoot)) throw new ArgumentException("Storage root is required.", "storageRoot");
            if (geometryKind == PolygonGeometryKind.Crs &&
                (String.IsNullOrEmpty(modelUri) || alignmentId == Guid.Empty))
                throw new ArgumentException("CRS polygons require a model URI and alignment ID.");
            if (geometryKind == PolygonGeometryKind.Plan &&
                (!String.IsNullOrEmpty(modelUri) || alignmentId != Guid.Empty))
                throw new ArgumentException("Plan polygons are scoped to the project or shared cloud.");

            Kind = scopeKind;
            GeometryKind = geometryKind;
            StorageRoot = Path.GetFullPath(storageRoot);
            ProjectUri = projectUri;
            ProjectAlias = projectAlias;
            SharedCloudKey = sharedCloudKey;
            ModelUri = modelUri;
            AlignmentId = alignmentId;

            // Length-prefix every component so no separator or path spelling can alias another key.
            StringBuilder identity = new StringBuilder();
            Part(identity, "polygon-v2");
            Part(identity, scopeKind.ToString());
            Part(identity, geometryKind.ToString());
            if (scopeKind == PolygonScopeKind.Project)
            {
                Part(identity, projectUri);
            }
            else
            {
                Part(identity, sharedCloudKey);
            }
            if (geometryKind == PolygonGeometryKind.Crs)
            {
                Part(identity, modelUri);
                Part(identity, alignmentId.ToString("N"));
            }
            ScopeKey = Hash(Encoding.UTF8.GetBytes(identity.ToString()));
            FilePath = Path.Combine(Path.Combine(Path.Combine(StorageRoot, ".las_terrain"),
                "polygon_scopes_v2"), ScopeKey + (geometryKind == PolygonGeometryKind.Plan ? ".plan.json" : ".crs.json"));
        }

        public static PolygonScope ForProject(PolygonGeometryKind kind, string storageRoot,
            string projectUri, string projectAlias, string modelUri, Guid alignmentId)
        {
            if (String.IsNullOrEmpty(projectUri))
                throw new ArgumentException("A saved project URI is required.", "projectUri");
            return new PolygonScope(PolygonScopeKind.Project, kind, storageRoot,
                projectUri, projectAlias, null, modelUri, alignmentId);
        }

        public static PolygonScope ForSharedCloud(PolygonGeometryKind kind, string storageRoot,
            string sharedCloudKey, string modelUri, Guid alignmentId)
        {
            if (String.IsNullOrEmpty(sharedCloudKey))
                throw new ArgumentException("An explicitly selected shared cloud key is required.", "sharedCloudKey");
            return new PolygonScope(PolygonScopeKind.SharedCloud, kind, storageRoot,
                null, null, sharedCloudKey, modelUri, alignmentId);
        }

        private static void Part(StringBuilder builder, string value)
        {
            value = value ?? String.Empty;
            builder.Append(value.Length).Append(':').Append(value);
        }

        internal static string Hash(byte[] bytes)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(bytes);
                StringBuilder result = new StringBuilder(hash.Length * 2);
                foreach (byte value in hash) result.Append(value.ToString("x2"));
                return result.ToString();
            }
        }
    }
}
