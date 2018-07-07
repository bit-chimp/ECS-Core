using System.Collections.Generic;
using Entitas;

namespace src.libs.src.ctxs.game.collision.components
{
    [Game]
    public class CollisionComponent : IComponent
    {
        public List<int> collisions;
    }
}