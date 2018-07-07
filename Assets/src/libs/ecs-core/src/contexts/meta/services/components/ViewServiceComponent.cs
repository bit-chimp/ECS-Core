using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.view;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService instance;
    }
}