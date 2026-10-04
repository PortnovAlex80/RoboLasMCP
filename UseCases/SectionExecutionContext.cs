using Topomatic.Cad.View;

public class SectionExecutionContext
{
    public CadView CadView { get; set; }
    public bool IsNeedGenerateCrossSection { get; set; }
    public double? Step { get; set; }
    public bool Async { get; set; }
    public SectionExecutionContext() { }
    public SectionExecutionContext(
        CadView cadView,
        bool isNeedGenerateCrossSection = false,
        double? step = null,
        bool async = true
    )
    {
        CadView = cadView;
        IsNeedGenerateCrossSection = isNeedGenerateCrossSection;
        Step = step;
        Async = async;
    }
}
