using LAS_TERRAIN.Service;
using Topomatic.Cad.View;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("calculation_async_custom_step")]
    public class CalculateCustomStepSectionAsyncUseCase : ISectionUseCase
    {
        public string Name => "calculation_async_custom_step";

        public void Run(SectionEnv env)
        {
            var context = new SectionExecutionContext
            {
                CadView = env.CadView,
                IsNeedGenerateCrossSection = true,
                Step = null,
                Async = true,
            };
            SectionBaseUseCase.ExecuteSections(context);
        }
    }
}
