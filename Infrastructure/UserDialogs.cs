using System;
using System.Windows.Forms;
using Topomatic.Alg;
using Topomatic.Cad.View;
using Topomatic.Cad.View.Hints;
using Topomatic.Controls.Dialogs;
using Topomatic.FoundationClasses;
using Topomatic.Sfc;
using Topomatic.Sfc.Layer;

namespace LAS_TERRAIN.Infrastructure
{
    public static class UserDialogs
    {
        public static void ShowWarning(string message)
        {
            MessageDlg.Show(message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfo(string message)
        {
            MessageDlg.Show(message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool AskYesNo(string question)
        {
            return MessageDlg.Show(question, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static double? GetOptionalDouble(CadView cadView, string prompt, double defaultValue)
        {
            double value = defaultValue;
            var result = CadCursors.GetDouble(cadView, ref value, prompt, null);
            return result == GetPointResult.Accept ? (double?)value : null;
        }

        public static string GetSaveFilePath(string title, string defaultFileName = "output.las")
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = title;
                dialog.Filter = "LAS files (*.las)|*.las|All files (*.*)|*.*";
                dialog.DefaultExt = "las";
                dialog.AddExtension = true;
                dialog.OverwritePrompt = true;
                dialog.FileName = defaultFileName;

                var result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(dialog.FileName))
                    return dialog.FileName;
                return null;
            }
        }

        public static double? GetBorderThickness(CadView cadView, double defaultValue)
        {
            double? value = GetOptionalDouble(cadView, "Введите толщину сечения", defaultValue);
            if (value == null)
                return null;
            if (double.IsNaN(value.Value) || double.IsInfinity(value.Value) ||
                value <= 0 || value < 0.0001)
            {
                ShowWarning("Введено слишком маленькое или отрицательное значение. Используется значение по умолчанию (0.25 м)");
                return 0.25;
            }
            return value.Value;
        }

        // Infrastructure/UserDialogs.cs
        public static double? GetSectionStep(CadView cadView, double lastStep)
        {
            double? step = GetOptionalDouble(cadView, "Введите шаг секций (м)", lastStep);
            if (step == null)
                return null;
            if (double.IsNaN(step.Value) || double.IsInfinity(step.Value))
            {
                ShowWarning("Шаг секций должен быть конечным числом.");
                return null;
            }
            if (step.Value <= 0.0)
            {
                ShowWarning("Введено слишком маленькое или отрицательное значение. Используется значение по умолчанию (1.0 м)");
                return 1.0;
            }
            return step.Value;
        }

        // Infrastructure/UserDialogs.cs
        public static Alignment SelectAlignment(CadView cadView)
        {
            var wrapped = cadView.SelectionSet.PickOneObjectAtScreen(
                o => o is IWrapped && ((IWrapped)o).WrappedObject is Alignment,
                "Укажите трассу") as IWrapped;
            return (wrapped != null && wrapped.WrappedObject is Alignment alg) ? alg : null;
        }

        // Infrastructure/UserDialogs.cs
        public static SurfaceLayer GetSurfaceLayerOrShow(CadView cadView)
        {
            var surfaceLayer = SurfaceLayer.GetSurfaceLayer(cadView);
            if (surfaceLayer == null)
            {
                ShowWarning("Перед построением поверхности земли необходимо активировать ЦММ, содержащий точки лазерных отражений.");
                return null;
            }
            return surfaceLayer;
        }


        public static StructureLine SelectStructureLine(
    CadView cadView,
    string prompt = "Выберите структурную линию (Esc — отмена)",
    bool onlyFromActiveSurface = false)
        {
            if (!IsCadViewValid(cadView)) return null;

            SurfaceLayer active = null;
            if (onlyFromActiveSurface)
            {
                active = GetSurfaceLayerOrShow(cadView);
                if (active == null) return null;
            }

            Predicate<object> match = o =>
            {
                var sl = (o as StructureLine) ??
                         ((o as IWrapped)?.WrappedObject as StructureLine);
                if (sl == null) return false;
                return !onlyFromActiveSurface || sl.Surface == active.Surface;
            };

            var picked = cadView.SelectionSet.PickOneObjectAtScreen(match, prompt);
            if (picked == null) return null;

            var w = picked as IWrapped;
            return (w?.WrappedObject as StructureLine) ?? (picked as StructureLine);
        }

        // Infrastructure/UserDialogs.cs
        public static bool IsCadViewValid(CadView cadView)
        {
            if (cadView != null) return true;
            ShowWarning("Перед построением поверхности земли необходимо перейти в окно плана.");
            return false;
        }

        // Infrastructure/UserDialogs.cs
        public static bool ConfirmOverwriteBuffers()
        {
            return MessageDlg.Show(
                "Перезаписать все исходные буферы лазерных точек?\nЭто действие невозможно отменить.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }





    }
}
