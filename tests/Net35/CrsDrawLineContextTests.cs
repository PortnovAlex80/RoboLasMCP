using System;
using LAS_TERRAIN.Domain.Service;

namespace LAS_TERRAIN.Tests
{
    internal static class CrsDrawLineContextTests
    {
        private static int _checks;

        private static void Check(bool value, string name)
        {
            if (!value) throw new Exception(name);
            _checks++;
        }

        public static int Main()
        {
            try
            {
                object alignment = new object();
                object model = new object();
                object project = new object();
                object sourceView = new object();
                object crossView = new object();
                object document = new object();
                Guid id = Guid.NewGuid();
                uint[] sectionIds = { 10, 11, 12 };
                double[] stations = { 0.0, 5.0, 10.0 };
                CrsDrawLineContext context = new CrsDrawLineContext(alignment, model,
                    project, id, sourceView, crossView, document, 1, sectionIds, stations);

                Check(Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "unchanged context rejected");
                Check(!Current(context, new object(), model, project, id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "changed alignment accepted");
                Check(!Current(context, alignment, new object(), project, id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "changed model accepted");
                Check(!Current(context, alignment, model, project, Guid.NewGuid(), sourceView,
                    crossView, document, true, 1, sectionIds, stations), "changed alignment ID accepted");
                Check(!Current(context, alignment, model, new object(), id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "changed project accepted");
                Check(!Current(context, alignment, model, project, id, new object(),
                    crossView, document, true, 1, sectionIds, stations), "changed source view accepted");
                Check(!Current(context, alignment, model, project, id, sourceView,
                    new object(), document, true, 1, sectionIds, stations), "changed cross view accepted");
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, new object(), true, 1, sectionIds, stations), "changed document accepted");
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, false, 1, sectionIds, stations), "closed view accepted");
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 2, sectionIds, stations), "changed selected section accepted");

                uint[] rebuiltIds = { 10, 91, 12 };
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, rebuiltIds, stations), "rebuilt section accepted");
                uint[] reorderedIds = { 10, 12, 11 };
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, reorderedIds, stations), "reordered sections accepted");
                double[] changedStations = { 0.0, 5.0, 10.1 };
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, sectionIds, changedStations),
                    "changed nonselected section accepted");

                // The constructor must retain the original values, not caller-owned arrays.
                sectionIds[1] = 99;
                Check(!Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "mutated input array changed capture");
                sectionIds[1] = 11;
                Check(Current(context, alignment, model, project, id, sourceView,
                    crossView, document, true, 1, sectionIds, stations), "restored section rejected");

                Console.WriteLine("PASS CRS drawing context: " + _checks + " checks");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("FAIL CRS drawing context: " + ex);
                return 1;
            }
        }

        private static bool Current(CrsDrawLineContext context, object alignment,
            object model, object project, Guid id, object sourceView, object crossView,
            object document, bool viewsAlive, int selected, uint[] sectionIds, double[] stations)
        {
            return context.IsCurrent(alignment, model, project, id, sourceView,
                crossView, document, viewsAlive, selected, sectionIds.Length,
                delegate(int i) { return sectionIds[i]; },
                delegate(int i) { return stations[i]; });
        }
    }
}
