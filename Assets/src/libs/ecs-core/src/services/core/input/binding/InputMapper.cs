using System.Collections.Generic;
using System.Linq;
using src.libs.src.services.core.input.service;
using UnityEngine.Assertions;

namespace src.libs.src.services.core.input.binding
{
    public abstract class InputMapper<T> : IInputMapper<T>
    {
        private Dictionary<KeyId, T> _mapTo;

        private Dictionary<T, KeyId> _mapFrom;


        public T ConvertTo(KeyId id)
        {
            Assert.IsTrue(_mapTo.ContainsKey(id), "Key Map not found " + id);
            return _mapTo[id];
        }

        public KeyId ConvertFrom(T id)
        {
            return _mapFrom[id];
        }

        protected InputMapper()
        {
            _mapTo = new Dictionary<KeyId, T>();
            _mapFrom = _mapTo.ToDictionary(el => el.Value, el => el.Key);
        }

        protected abstract void AddKeys();

        protected void AddKeyMap(KeyId keyId, T keyCode)
        {
            _mapTo.Add(keyId, keyCode);
        }
    }
}
