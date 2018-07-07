using src.libs.src.services.core.collision.services;
using src.libs.src.services.core.input.service;
using src.libs.src.services.core.inputaction;
using src.libs.src.services.core.selection;
using src.libs.src.services.core.tick;
using src.libs.src.services.core.time;
using src.libs.src.services.core.view;

namespace src.libs.src.services
{
    public class Services
    {
        public readonly IViewService View;
        public readonly IInputActionService InputAction;
        public readonly ISelectionService Selection;
        public readonly ITimeService Time;
        public readonly ITickService Tick;
        public readonly IInputService Input;
        public readonly ICollisionService Collision;

        public Services(IViewService view, IInputActionService inputAction, ISelectionService selection, ITimeService time, ITickService tick, ICollisionService collision, IInputService input)
        {
            View = view;
            InputAction = inputAction;
            Selection = selection;
            Time = time;
            Tick = tick;
            Collision = collision;
            Input = input;
        }

    }
}