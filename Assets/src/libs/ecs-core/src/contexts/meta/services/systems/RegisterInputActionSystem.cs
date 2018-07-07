using Entitas;
using src.libs.src.services.core.inputaction;

namespace src.libs.src.ctxs.meta.services.systems
{
    public class RegisterInputActionSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly IInputActionService _inputActionService;

        public RegisterInputActionSystem(Contexts contexts, IInputActionService inputActionService)
        {
            _contexts = contexts;
            _inputActionService = inputActionService;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceInputActionService(_inputActionService);
        }
    }
}