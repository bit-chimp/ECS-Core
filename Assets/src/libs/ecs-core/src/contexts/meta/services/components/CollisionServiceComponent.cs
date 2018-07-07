using Entitas;
using Entitas.CodeGeneration.Attributes;
using src.libs.src.services.core.collision.services;

namespace src.libs.src.ctxs.meta.services.components
{
    [Meta, Unique]
    public class CollisionServiceComponent : IComponent
    {
        public ICollisionService service;
    }
}