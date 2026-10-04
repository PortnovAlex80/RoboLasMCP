// Automation/LasAutomationDtos.cs
// DTO-контракты headless-фасада RoboLas. Только примитивы и List<> —
// чтобы внешний MCP-адаптер мог сериализовать их в JSON без ссылок на
// типы Topomatic SDK.
using System;
using System.Collections.Generic;

namespace LAS_TERRAIN.Automation
{
    /// <summary>Сводное состояние проекта/трассы/ЦММ/облака для агента.</summary>
    public class LasAutomationContext
    {
        public string PluginVersion { get; set; }
        public string ProjectAlias { get; set; }
        public string ProjectUri { get; set; }
        public bool HasActiveAlignment { get; set; }
        public string ActiveAlignment { get; set; }
        public bool HasSurface { get; set; }
        public long SurfacePoints { get; set; }
        public long SurfaceTriangles { get; set; }
        public bool HasLidarSource { get; set; }
        public List<string> LidarFiles { get; set; }
        public List<LasLidarSourceInfo> LidarSources { get; set; }
        public long LidarPointCount { get; set; }
        public int SectionsCount { get; set; }
        public double FirstStation { get; set; }
        public double LastStation { get; set; }
        /// <summary>"onepass" (по умолчанию) или "legacy".</summary>
        public string CollectMode { get; set; }
        /// <summary>"spline" (RobustGroundSpline) или "minweight" (медиана).</summary>
        public string FilterMode { get; set; }

        public LasAutomationContext()
        {
            LidarFiles = new List<string>();
            LidarSources = new List<LasLidarSourceInfo>();
        }
    }

    public class LasLidarSourceInfo
    {
        public string ProviderType { get; set; }
        public string ProviderPath { get; set; }
        public string CachePath { get; set; }
        public string CacheFormatStatus { get; set; }
        public int? CacheFormatVersion { get; set; }
        public string CacheReadError { get; set; }
        public int SdkIndexerCount { get; set; }
        public string ProviderPathReadError { get; set; }
        public bool ProviderPathIsLas { get; set; }
        public long PointCount { get; set; }
        public long SdkColorByteCount { get; set; }
        public string AttributeStatus { get; set; }
    }

    /// <summary>Трасса проекта.</summary>
    public class LasAlignmentInfo
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    /// <summary>Сечение трассы.</summary>
    public class LasSectionInfo
    {
        public uint Id { get; set; }
        public double Station { get; set; }
    }

    /// <summary>Список сечений (возможно, усечённый).</summary>
    public class LasSectionListResult
    {
        /// <summary>Число возвращённых записей (TotalCount — всего сечений у трассы).</summary>
        public int Count { get; set; }
        public double FirstStation { get; set; }
        public double LastStation { get; set; }
        public List<LasSectionInfo> Sections { get; set; }
        public bool Truncated { get; set; }
        public int TotalCount { get; set; }

        public LasSectionListResult()
        {
            Sections = new List<LasSectionInfo>();
        }
    }

    /// <summary>Результат активации трассы.</summary>
    public class LasAlignmentActivationResult
    {
        public string Name { get; set; }
        public bool Activated { get; set; }
    }

    /// <summary>Результат построения ЦММ / разбивки сечений.</summary>
    public class LasTerrainResult
    {
        /// <summary>"generated" (по шагу) или "existing" (по готовым сечениям).</summary>
        public string Mode { get; set; }
        public int StationsPlanned { get; set; }
        public int SectionsCreated { get; set; }
        public int PointsCollected { get; set; }
        public int PointsInserted { get; set; }
        public double Thickness { get; set; }
        public double Step { get; set; }
        public string FilterUsed { get; set; }
        public bool Cancelled { get; set; }
        public double ElapsedSeconds { get; set; }
        public string SurfacePointsAfter { get; set; }
        public string Note { get; set; }
    }

    /// <summary>Результат прореживания облака (обычного или с ground-фильтром).</summary>
    public class LasReduceResult
    {
        public bool RgbPreserved { get; set; }
        public string OutputPath { get; set; }
        public double Percent { get; set; }
        public bool GroundFilterUsed { get; set; }
        public long TotalRaw { get; set; }
        public long TotalGround { get; set; }
        public long TotalReduced { get; set; }
        public bool Published { get; set; }
        public bool Cancelled { get; set; }
        public string Note { get; set; }
    }

    /// <summary>Результат разделения облака на полосу/обочины.</summary>
    public class LasSplitResult
    {
        public bool RgbPreserved { get; set; }
        public string PrimaryPath { get; set; }
        public string EdgePath { get; set; }
        public double LeftOffset { get; set; }
        public double RightOffset { get; set; }
        public double PercentCenter { get; set; }
        public double PercentEdge { get; set; }
        public long CenterPoints { get; set; }
        public long EdgePoints { get; set; }
        public bool Published { get; set; }
        public bool Recovered { get; set; }
        public bool Cancelled { get; set; }
        public string Note { get; set; }
    }

    /// <summary>Один полигон в хранилище scope'ов.</summary>
    public class LasPolygonInfo
    {
        public int Index { get; set; }
        public DateTime CreatedAt { get; set; }
        public int VertexCount { get; set; }
        /// <summary>Пары [x, y]: план — мировые X,Y; CRS — локальные (offset, Z) сечения.</summary>
        public List<double[]> Vertices { get; set; }
        public uint SectionId { get; set; }
        public double SectionStation { get; set; }
        public double Thickness { get; set; }

        public LasPolygonInfo()
        {
            Vertices = new List<double[]>();
        }
    }

    /// <summary>Список полигонов scope'а.</summary>
    public class LasPolygonListResult
    {
        public string Scope { get; set; }
        public int Count { get; set; }
        public List<LasPolygonInfo> Polygons { get; set; }

        public LasPolygonListResult()
        {
            Polygons = new List<LasPolygonInfo>();
        }
    }

    /// <summary>Результат изменения набора полигонов (добавление/очистка).</summary>
    public class LasPolygonMutationResult
    {
        public string Scope { get; set; }
        public int TotalPolygons { get; set; }
        public bool Added { get; set; }
        public bool Cleared { get; set; }
    }

    /// <summary>Результат удаления точек по полигонам (экспорт нового LAS).</summary>
    public class LasDeletePointsResult
    {
        public bool RgbPreserved { get; set; }
        public string Scope { get; set; }
        public string OutputPath { get; set; }
        public long Deleted { get; set; }
        public long Kept { get; set; }
        public bool Published { get; set; }
        public bool PolygonsCleared { get; set; }
        public bool Cancelled { get; set; }
        public string Note { get; set; }
    }

    /// <summary>Результат построения ЦММ по полигонам.</summary>
    public sealed class LasSurfaceByPolygonsResult
    {
        /// <summary>"grid" (min-Z сетка) или "polynomial".</summary>
        public string Method { get; set; }
        public int Polygons { get; set; }
        public long PointsInCloud { get; set; }
        public long SupportPoints { get; set; }
        public long FeaturePoints { get; set; }
        public long Inserted { get; set; }
        public int Degree { get; set; }
        public double GridStep { get; set; }
        public bool Cancelled { get; set; }
        public string Note { get; set; }
    }

    /// <summary>Состояние активного вида после активации вида со слоем ЦММ.</summary>
    public sealed class LasSurfaceViewState
    {
        public bool HasSurfaceLayer { get; set; }
        public bool HasSurface { get; set; }
        public long SurfacePoints { get; set; }
        public long SurfaceTriangles { get; set; }
        public string ActivatedView { get; set; }
        public string Note { get; set; }
        /// <summary>Диагностика: открытые виды, слои, кандидаты узла ЦММ в дереве проекта.</summary>
        public List<string> Diagnostics { get; set; }

        public LasSurfaceViewState()
        {
            Diagnostics = new List<string>();
        }
    }
}
