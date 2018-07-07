using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.inputaction;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class InputActionServiceComponent : IComponent
    {
        public IInputActionService instance;
    }
}