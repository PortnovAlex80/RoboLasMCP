
using LAS_TERRAIN.Infrastructure;
using System.Diagnostics;
using System.Windows.Forms;
using Topomatic.Cad.View;
using Topomatic.Controls.Dialogs;

namespace LAS_TERRAIN
{
    public static class SectionCommandRunner
    {
        public static void Run(string commandName, CadView cadView)
        {
            using (PluginOperationGate.Lease operation = PluginOperationGate.TryEnter())
            {
                if (operation == null)
                {
                    // A modal warning here could nest inside the active progress dialog.
                    Trace.WriteLine("[LAS_TERRAIN] Команда отклонена: операция плагина уже выполняется.");
                    return;
                }

                var useCase = SectionRegistry.Resolve(commandName);
                if (useCase == null)
                {
                    MessageDlg.Show(
                        string.Format("Команда «{0}» не найдена.", commandName),
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                useCase.Run(new SectionEnv(cadView));
            }
        }
    }



}
