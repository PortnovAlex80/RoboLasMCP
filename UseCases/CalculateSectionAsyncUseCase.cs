using LAS_TERRAIN.Service;
using Topomatic.Cad.View;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("calculation_async_section")]
    public class CalculateSectionAsyncUseCase : ISectionUseCase
    {
        public string Name => "calculation_async_section";

        public void Run(SectionEnv env)
        {
            var context = new SectionExecutionContext
            {
                CadView = env.CadView,
                IsNeedGenerateCrossSection = false,
                Step = null,
                Async = true,
            };
            SectionBaseUseCase.ExecuteSections(context);
        }
    }
}
