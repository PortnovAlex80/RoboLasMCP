// Read-only probe of the copied Rail 16 parallel helper. No host or project is opened.
using System;
using System.IO;
using System.Reflection;

internal static class TopomaticParallelProbe
{
    private static string sdkDirectory;

    private static Assembly Resolve(object sender, ResolveEventArgs args)
    {
        string path = Path.Combine(sdkDirectory, new AssemblyName(args.Name).Name + ".dll");
        return File.Exists(path) ? Assembly.LoadFrom(path) : null;
    }

    private static void Assert(bool value, string message)
    {
        if (!value) throw new InvalidOperationException(message);
    }

    private static int Main(string[] args)
    {
        if (args.Length != 1 || !Directory.Exists(args[0])) return 2;
        sdkDirectory = Path.GetFullPath(args[0]);
        AppDomain.CurrentDomain.AssemblyResolve += Resolve;
        try
        {
            Assembly foundation = Assembly.LoadFrom(Path.Combine(sdkDirectory,
                "Topomatic.FoundationClasses.dll"));
            Type type = foundation.GetType("Topomatic.FoundationClasses.Parallel.Parallel", true);
            MethodInfo generic = null;
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                if (method.Name == "ForEach" && method.IsGenericMethodDefinition &&
                    method.GetParameters().Length == 2)
                    generic = method;
            Assert(generic != null, "ForEach<T> is absent");
            MethodInfo forEach = generic.MakeGenericMethod(typeof(int));
            int[] outerCalls = new int[4];
            int[] innerCalls = new int[3];
            Action<int> inner = delegate(int index) { innerCalls[index]++; };
            Action<int> outer = delegate(int index)
            {
                outerCalls[index]++;
                if (index == 1)
                    forEach.Invoke(null, new object[] { new int[] { 0, 1, 2 }, inner });
            };
            forEach.Invoke(null, new object[] { new int[] { 0, 1, 2, 3 }, outer });
            for (int i = 0; i < outerCalls.Length; i++)
                Assert(outerCalls[i] == 1, "Outer work not completed exactly once");
            for (int i = 0; i < innerCalls.Length; i++)
                Assert(innerCalls[i] == 1, "Nested work not completed exactly once");
            Console.WriteLine("Copied Rail 16 parallel helper: synchronous nested traversal passed.");
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
    }
}
