using Entitas;
using src.libs.src.services.core.tick;

namespace src.libs.src.ctxs.meta.services.systems
{
    public class RegisterTickServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ITickService _tickService;

        public RegisterTickServiceSystem(Contexts contexts, ITickService tickService)
        {
            _contexts = contexts;
            _tickService = tickService;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceTickService(_tickService);
        }
    }
}