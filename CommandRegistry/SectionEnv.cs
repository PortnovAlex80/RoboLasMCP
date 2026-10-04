using Topomatic.Cad.View;
namespace LAS_TERRAIN
{
    public class SectionEnv
    {
        public CadView CadView { get; }
        public SectionEnv(CadView cadView /*, другие зависимости*/)
        {
            CadView = cadView;
        }
    }
}