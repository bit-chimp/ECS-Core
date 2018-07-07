using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.tick;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class TickServiceComponent : IComponent
    {
        public ITickService instance;
    }
}