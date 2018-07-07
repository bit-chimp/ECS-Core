using src.libs.src.services;

namespace src.libs.src.ctxs.meta.services.systems
{
    public class RegisterServicesSystem : Feature
    {

        public RegisterServicesSystem(Contexts contexts, Services services)
        {
            Add(new RegisterInputActionSystem(contexts, services.InputAction));
            Add(new RegisterViewServiceSystem(contexts, services.View));
            Add(new RegisterCollisionServiceSystem(contexts, services.Collision));
            Add(new RegisterInputServiceSystem(contexts, services.Input));
            Add(new RegisterSelectionServiceSystem(contexts, services.Selection));
            Add(new RegisterTickServiceSystem(contexts, services.Tick));
            Add(new RegisterTimeServiceSystem(contexts, services.Time));

            //            Add(new RegisterInputControllerSystem(contexts, services.InputController));
        }
    }
}