using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.time;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService time;

    }
}