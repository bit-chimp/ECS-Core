using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.input.service;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class InputServiceComponent : IComponent
    {
        public IInputService service;
    }
}