using Entitas;

namespace src.libs.src.services.core.view
{
    public interface IViewService
    {
        IViewController LoadView(Contexts contexts, IEntity entity, string assetPath);
    }
}