using LAS_TERRAIN.Service;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("calculation_async_one_meter_section")]
    public class CalculateOneMeterSectionAsyncUseCase : ISectionUseCase
    {
        public string Name => "calculation_async_one_meter_section";

        public void Run(SectionEnv env)
        {
            var context = new SectionExecutionContext
            {
                CadView = env.CadView,
                IsNeedGenerateCrossSection = true,
                Step = 1.0,
                Async = true,
            };
            SectionBaseUseCase.ExecuteSections(context);
        }

    }
}
