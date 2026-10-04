using LAS_TERRAIN.Configuration;
using LAS_TERRAIN.Infrastructure;

namespace LAS_TERRAIN.UseCases
{
    [SectionCmd("set_split_merge_tolerance")]
    public class SetSplitMergeToleranceUseCase : ISectionUseCase
    {
        public string Name { get { return "set_split_merge_tolerance"; } }

        public void Run(SectionEnv env)
        {
            if (!UserDialogs.IsCadViewValid(env.CadView)) return;

            double current = Settings.Instance.SplitMergeTolerance;
            double? value = UserDialogs.GetOptionalDouble(env.CadView,
                "Введите допуск Split&Merge", current);

            if (!value.HasValue) return;

            double tol = value.Value;
            if (tol <= 0 || double.IsNaN(tol) || double.IsInfinity(tol))
            {
                UserDialogs.ShowWarning("Значение должно быть > 0 и конечным.");
                return;
            }

            Settings.Instance.SplitMergeTolerance = tol;
            RuntimeConfig.SplitMergeTolerance = tol;

            UserDialogs.ShowInfo("Допуск обновлён: " + tol.ToString("0.###"));
        }
    }
}
