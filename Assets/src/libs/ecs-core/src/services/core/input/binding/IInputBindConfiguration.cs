using System.Collections.Generic;

namespace src.libs.src.services.core.input.binding
{
    public interface IInputBindConfiguration
    {
        string GetConfigurationId();
        List<InputBind> GetBinds(KeyId id);
        List<InputBind> GetBinds(string action);
        bool DoesBindExist(KeyId id, string action);
        void RemoveBinds(KeyId id);
        void RemoveBind(KeyId id, string action);
    }
}