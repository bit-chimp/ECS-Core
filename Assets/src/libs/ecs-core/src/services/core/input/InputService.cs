using System.Collections.Generic;
using src.libs.src.services.core.input.binding;
using src.libs.src.services.core.input.controller;
using src.libs.src.services.core.input.service;

namespace src.libs.src.services.core.input
{
    public class InputService : IInputService
    {
        private readonly List<IInputBindConfiguration> _bindConfigs;
        private MetaContext _metaContext;

        private readonly IInputController _inputController;

        public InputService(Contexts contexts, IInputController inputController)
        {
            _inputController = inputController;
            _metaContext = contexts.meta;
            _bindConfigs = new List<IInputBindConfiguration>();
        }


        public bool IsKeyBindDown(string inputBindConfigurationId, string action)
        {
            IInputBindConfiguration bindConfiguration = GetBindConfiguration(inputBindConfigurationId);
            var binds = bindConfiguration.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyDown(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsKeyBindUp(string inputBindConfigurationId, string action)
        {
            IInputBindConfiguration bindConfiguration = GetBindConfiguration(inputBindConfigurationId);
            var binds = bindConfiguration.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyUp(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsKeyBindHeldDown(string inputBindConfigurationId, string action)
        {
            IInputBindConfiguration bindConfiguration = GetBindConfiguration(inputBindConfigurationId);
            var binds = bindConfiguration.GetBinds(action);


            foreach (var bind in binds)
            {
                if (IsKeyHeldDown(bind.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public IInputBindConfiguration GetBindConfiguration(string bindConfigurationId)
        {
            foreach (var inputBindConfiguration in _bindConfigs)
            {
                if (inputBindConfiguration.GetConfigurationId() == bindConfigurationId)
                {
                    return inputBindConfiguration;
                }
            }

            return null;
        }

        public void AddBindConfiguration(IInputBindConfiguration inputBindConfiguration)
        {
            _bindConfigs.Add(inputBindConfiguration);
        }


        public bool IsKeyHeldDown(KeyId id)
        {
            return _inputController.IsKeyHeldDown(id);
        }

        public bool IsKeyDown(KeyId id)
        {
            return _inputController.IsKeyDown(id);
        }

        public bool IsKeyUp(KeyId id)
        {
            return _inputController.IsKeyUp(id);
        }

        public bool IsMouseUp()
        {
            return _inputController.IsMouseUp();
        }

        public bool IsMouseDown()
        {
            return _inputController.IsMouseDown();
        }
    }
}