using LAS_TERRAIN.Service;
using LAS_TERRAIN.UI;
using System.Windows.Forms;
using Topomatic.ApplicationPlatform.Plugins;

namespace LAS_TERRAIN
{
    partial class Module : Topomatic.ApplicationPlatform.Plugins.PluginInitializator

    {
        public void Run(string commandName)
        {
            SectionCommandRunner.Run(commandName, CadView);
        }

        [cmd("create_las_settings_panel")]
        private Control CreateLasSettingsPanel()
        {
            return new LasSettingsPanel();
        }

        [cmd("refresh_las_settings_panel")]
        private void RefreshLasSettingsPanel(LasSettingsPanel panel)
        {
            panel?.RefreshFromSettings();
        }
        [cmd("calculation_async_section")]
        public void CalculateSectionAsyncCommandExecutor()
        {
            SectionCommandRunner.Run("calculation_async_section", CadView);
        }

        [cmd("calculation_async_one_meter_section")]
        public void CalculateOneMeterSectionAsyncCommandExecutor()
        {
            SectionCommandRunner.Run("calculation_async_one_meter_section", CadView);
        }

        [cmd("calculation_async_custom_step")]
        public void CalculateCustomStepSectionAsyncCommandExecutor()
        {
            SectionCommandRunner.Run("calculation_async_custom_step", CadView);
        }

        [cmd("reduce_las_async_to_percent")]
        public void ReduceLasAsyncToPercentCommandExecutor()
        {
            SectionCommandRunner.Run("reduce_las_async_to_percent", CadView);
        } 

        [cmd("reduce_with_ground_red_sector")]
        public void ReduceWithGroundRedSectorCommandExecutor()
        {
            SectionCommandRunner.Run("reduce_with_ground_red_sector", CadView);
        }

        [cmd("split_las_by_offset")]
        public void SplitLasByOffsetCommandExecutor()
        {
            SectionCommandRunner.Run("split_las_by_offset", CadView);
        }

        [cmd("set_split_merge_tolerance")]
        public void SetSplitMergeToleranceCommandExecutor()
        {
            SectionCommandRunner.Run("set_split_merge_tolerance", CadView);
        }

        [cmd("crs_draw_line")]
        public void CrsDrawLineCommandExecutor()
        {
            SectionCommandRunner.Run("crs_draw_line", CadView);
        }

        [cmd("crs_delete_points")]
        public void CrsDeletePointsCommandExecutor()
        {
            SectionCommandRunner.Run("crs_delete_points", CadView);
        }

        [cmd("crs_clear_polygons")]
        public void CrsClearPolygonsCommandExecutor()
        {
            SectionCommandRunner.Run("crs_clear_polygons", CadView);
        }

        [cmd("plan_draw_polygon")]
        public void PlanDrawPolygonCommandExecutor()
        {
            SectionCommandRunner.Run("plan_draw_polygon", CadView);
        }

        [cmd("plan_delete_points")]
        public void PlanDeletePointsCommandExecutor()
        {
            SectionCommandRunner.Run("plan_delete_points", CadView);
        }

        [cmd("plan_clear_polygons")]
        public void PlanClearPolygonsCommandExecutor()
        {
            SectionCommandRunner.Run("plan_clear_polygons", CadView);
        }

        [cmd("polygon_save_as")]
        public void SavePolygonsAsCommandExecutor()
        {
            SectionCommandRunner.Run("polygon_save_as", CadView);
        }

        [cmd("las_start_mcp")]
        public void StartMcpCommandExecutor()
        {
            Topomatic.ApplicationPlatform.ApplicationHost.Current.Plugins.Execute("mcp_run");
        }

        [cmd("polygon_load")]
        public void LoadPolygonsCommandExecutor()
        {
            SectionCommandRunner.Run("polygon_load", CadView);
        }


        [cmd("plan_polygon_polynomial_surface")]
        public void PlanPolygonPolynomialSurfaceCommandExecutor()
        {
            SectionCommandRunner.Run("plan_polygon_polynomial_surface", CadView);
        }

        [cmd("plan_polygon_grid_surface")]
        public void PlanPolygonGridSurfaceCommandExecutor()
        {
            SectionCommandRunner.Run("plan_polygon_grid_surface", CadView);
        }


    }
}

