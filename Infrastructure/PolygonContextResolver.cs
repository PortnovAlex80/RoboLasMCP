using System;
using System.IO;
using LAS_TERRAIN.Domain.Persistence;
using Topomatic.Alg;
using Topomatic.ApplicationPlatform;
using Topomatic.ApplicationPlatform.Plugins;
using Topomatic.FoundationClasses;

namespace LAS_TERRAIN.Infrastructure
{
    /// <summary>
    /// Resolves polygon ownership from the alignment's project model, never from a LiDAR buffer.
    /// Call on the host/UI thread when a command starts.
    /// </summary>
    internal static class PolygonContextResolver
    {
        public static PolygonScope ResolveProject(Alignment alignment, PolygonGeometryKind geometryKind)
        {
            if (alignment == null)
                throw new ArgumentNullException("alignment");

            var model = PluginCoreOps.FindModel(alignment);
            if (model == null || model.Project == null)
                throw new InvalidOperationException("Не найдена модель проекта для трассы.");

            Project project = model.Project;
            Project activeProject = ApplicationHost.Current == null ? null : ApplicationHost.Current.ActiveProject;
            if (activeProject == null || !Object.ReferenceEquals(activeProject, project))
                throw new InvalidOperationException("Активный проект не совпадает с проектом трассы.");

            URI target = project.TargetProjectUri;
            if (target == null || !target.IsAbsoluteUri)
                throw new InvalidOperationException("Сохраните проект перед сохранением полигонов.");
            Uri fileUri;
            if (!Uri.TryCreate(target.AsAbsoluteUri, UriKind.Absolute, out fileUri) ||
                !(fileUri.IsFile ||
                  (String.Equals(fileUri.Scheme, "local", StringComparison.OrdinalIgnoreCase) &&
                   String.IsNullOrEmpty(fileUri.Host))))
                throw new InvalidOperationException("Полигоны можно сохранить только рядом с локальным файлом проекта.");

            string projectPath = target.AsFilePath;
            if (String.IsNullOrEmpty(projectPath) || !Path.IsPathRooted(projectPath))
                throw new InvalidOperationException("Сохраните проект перед сохранением полигонов.");
            string storageRoot;
            if (File.Exists(projectPath))
                storageRoot = Path.GetDirectoryName(Path.GetFullPath(projectPath));
            else
                throw new InvalidOperationException("Сохраните проект перед сохранением полигонов.");

            // Rail 16 uses local:/// for the same local file that tests and
            // other SDK paths expose as file:///. Keep one owner across both.
            string projectUri = new Uri(Path.GetFullPath(projectPath)).AbsoluteUri;
            string modelUri = model.Uri == null ? null : model.Uri.ToString();
            if (String.IsNullOrEmpty(modelUri))
                throw new InvalidOperationException("Не удалось определить идентификатор модели трассы.");

            Guid alignmentId = AlignmentValueConverter.GetId(alignment);
            if (geometryKind == PolygonGeometryKind.Crs && alignmentId == Guid.Empty)
                throw new InvalidOperationException("Не удалось определить идентификатор трассы.");

            return PolygonScope.ForProject(geometryKind, storageRoot, projectUri, project.Alias,
                geometryKind == PolygonGeometryKind.Crs ? modelUri : null,
                geometryKind == PolygonGeometryKind.Crs ? alignmentId : Guid.Empty);
        }

    }
}
