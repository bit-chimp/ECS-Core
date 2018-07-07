using Entitas;
using src.libs.src.services.core.view;

namespace src.libs.src.ctxs.meta.services.systems
{
    public class RegisterViewServiceSystem :IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly IViewService _view;

        public RegisterViewServiceSystem(Contexts contexts, IViewService view)
        {
            _contexts = contexts;
            _view = view;
        }
        
        public void Initialize()
        {
            _contexts.meta.ReplaceViewService(_view);
        }
    }
}