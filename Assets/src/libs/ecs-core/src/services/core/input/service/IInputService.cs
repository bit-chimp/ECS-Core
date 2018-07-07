using src.libs.src.services.core.input.binding;

namespace src.libs.src.services.core.input.service
{
    public interface IInputService
    {
        bool IsKeyBindDown(string inputConfigurationId, string action);
        bool IsKeyBindUp(string inputConfigurationId, string action);
        bool IsKeyBindHeldDown(string inputConfigurationId, string action);
        IInputBindConfiguration GetBindConfiguration(string bindConfigurationId);
        void AddBindConfiguration(IInputBindConfiguration inputBindConfiguration);

        //TODO : Toggle gameplay input binds (open_grid, pan camera etc)
        //TODO : Toggle cutscene input binds (skip_cutscene, pause etc)
    }
}