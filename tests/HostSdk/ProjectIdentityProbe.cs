// Read-only Rail16 SDK identity probe. It does not initialize ApplicationHost,
// create a project, save a model, or alter a user profile.
using System;
using System.IO;
using System.Reflection;

namespace LAS_TERRAIN.Tests.HostSdk
{
    internal static class ProjectIdentityProbe
    {
        private static string sdkDirectory;

        private static Assembly Resolve(object sender, ResolveEventArgs args)
        {
            string simpleName = new AssemblyName(args.Name).Name;
            string path = Path.Combine(sdkDirectory, simpleName + ".dll");
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        }

        private static Type Required(Assembly assembly, string name)
        {
            Type type = assembly.GetType(name, false);
            if (type == null) throw new InvalidOperationException("Missing SDK type: " + name);
            return type;
        }

        private static void Property(Type type, string name)
        {
            PropertyInfo property = type.GetProperty(name);
            if (property == null) throw new InvalidOperationException(type.FullName + " lacks " + name);
            Console.WriteLine(type.FullName + "." + name + "=" + property.PropertyType.FullName +
                " getter=" + (property.GetGetMethod() != null) +
                " setter=" + (property.GetSetMethod() != null));
        }

        private static void Method(Type type, string name)
        {
            MethodInfo method = type.GetMethod(name, BindingFlags.Public | BindingFlags.Static |
                BindingFlags.Instance);
            Console.WriteLine(type.FullName + "." + name + "=" +
                (method == null ? "missing" : method.ToString()));
        }

        private static void UriRoundTrip(Type uriType)
        {
            string path = Path.Combine(Path.GetTempPath(),
                "robolas-identity-probe-" + Guid.NewGuid().ToString("N") + ".rbr");
            string fileUri = new Uri(path).AbsoluteUri;
            object sdkUri = Activator.CreateInstance(uriType, new object[] { fileUri });
            string absolute = (string)uriType.GetProperty("AsAbsoluteUri").GetValue(sdkUri, null);
            string filePath = (string)uriType.GetProperty("AsFilePath").GetValue(sdkUri, null);
            if (!String.Equals(Path.GetFullPath(filePath), Path.GetFullPath(path),
                StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("SDK URI did not round-trip the temporary path.");
            Console.WriteLine("URI round-trip PASS: " + absolute + " -> " + filePath);
            Console.WriteLine("URI round-trip created no file: " + !File.Exists(path));
        }

        private static void LocalUriRoundTrip(Type uriType)
        {
            string path = Path.Combine(Path.GetTempPath(),
                "robolas-local-" + Guid.NewGuid().ToString("N") + "-Проект с пробелом.rbr");
            string localUri = "local:///" + new Uri(path).AbsolutePath.TrimStart('/');
            object sdkUri = Activator.CreateInstance(uriType, new object[] { localUri });
            bool absolute = (bool)uriType.GetProperty("IsAbsoluteUri").GetValue(sdkUri, null);
            string filePath = (string)uriType.GetProperty("AsFilePath").GetValue(sdkUri, null);
            if (!absolute ||
                !String.Equals(Path.GetFullPath(filePath), Path.GetFullPath(path),
                    StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("SDK local URI did not round-trip the project path.");
            Console.WriteLine("Local URI round-trip PASS: " + localUri + " -> " + filePath);
            Console.WriteLine("Local URI round-trip created no file: " + !File.Exists(path));
        }

        private static int Main(string[] args)
        {
            if (args.Length != 1 || !Directory.Exists(args[0]))
            {
                Console.Error.WriteLine("Usage: ProjectIdentityProbe.exe <copied Rail16 DLL directory>");
                return 2;
            }
            sdkDirectory = Path.GetFullPath(args[0]);
            AppDomain.CurrentDomain.AssemblyResolve += Resolve;
            try
            {
                Assembly foundation = Assembly.LoadFrom(Path.Combine(sdkDirectory,
                    "Topomatic.FoundationClasses.dll"));
                Assembly platform = Assembly.LoadFrom(Path.Combine(sdkDirectory,
                    "Topomatic.ApplicationPlatform.dll"));
                Assembly alg = Assembly.LoadFrom(Path.Combine(sdkDirectory, "Topomatic.Alg.dll"));
                Assembly algModel = Assembly.LoadFrom(Path.Combine(sdkDirectory,
                    "Topomatic.Alg.Model.dll"));

                Type project = Required(platform, "Topomatic.ApplicationPlatform.Project");
                Type modelProject = Required(platform,
                    "Topomatic.ApplicationPlatform.Core.ModelProject");
                Type projectModel = Required(platform,
                    "Topomatic.ApplicationPlatform.Core.IProjectModel");
                Type alignment = Required(alg, "Topomatic.Alg.Alignment");
                Type alignmentModel = Required(algModel,
                    "Topomatic.Alg.Model.AlignmentModel");
                Type converter = Required(alg, "Topomatic.Alg.AlignmentValueConverter");
                Type uri = Required(foundation, "Topomatic.FoundationClasses.URI");

                Console.WriteLine("Project abstract=" + project.IsAbstract);
                Console.WriteLine("ModelProject abstract=" + modelProject.IsAbstract);
                Console.WriteLine("AlignmentModel abstract=" + alignmentModel.IsAbstract);
                Property(project, "Alias");
                Property(project, "TargetProjectUri");
                Property(projectModel, "Uri");
                Property(projectModel, "Project");
                Property(alignment, "Owner");
                Property(alignmentModel, "Id");
                Method(alignmentModel, "GenerateNewId");
                Method(converter, "GetId");
                UriRoundTrip(uri);
                LocalUriRoundTrip(uri);
                Console.WriteLine("No project/model Save As semantics exercised: a live host is required.");
                return 0;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(error);
                return 1;
            }
        }
    }
}
