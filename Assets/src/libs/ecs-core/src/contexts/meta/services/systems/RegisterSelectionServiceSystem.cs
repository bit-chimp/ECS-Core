using Entitas;
using src.libs.src.services.core.selection;

namespace src.libs.src.ctxs.meta.services.systems
{
    public class RegisterSelectionServiceSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ISelectionService _selection;

        public RegisterSelectionServiceSystem(Contexts contexts, ISelectionService selection)
        {
            _contexts = contexts;
            _selection = selection;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceSelectionService(_selection);
        }
    }
}