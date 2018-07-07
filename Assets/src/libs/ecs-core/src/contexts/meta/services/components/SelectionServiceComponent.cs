using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.selection;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class SelectionServiceComponent : IComponent
    {
        public ISelectionService selection;
    }
}