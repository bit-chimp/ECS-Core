using btcp.ECS.src.Services.Interfaces;
using UnityEngine;

namespace btcp.ECS.src.Services.Unity
{
    public class UnityViewService : IAssetListener
    {

        private readonly Transform _parent;
        private readonly Contexts _contexts;
        
        private UnityViewService(Contexts contexts, Transform parent)
        {
            _contexts = contexts;
            _parent = parent;
            contexts.game.CreateEntity().AddAssetListener(this);
        }

        public static UnityViewService Create(Contexts contexts, Transform parent)
        {
            var service = new UnityViewService(contexts, parent);
            return service;
        }

        public void OnAsset(GameEntity entity, string path)
        {
            var prefab = Resources.Load<GameObject>(path);
            var view = Object.Instantiate(prefab, _parent).GetComponent<IView>();
            view.Link(entity, _contexts.game);
        }
    }
}