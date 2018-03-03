using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace btcp.ECS.src.Components.Position.Components
{
    [Game, Event(false)]
    public sealed class PositionComponent : Entitas.IComponent
    {
        public Vector2 value;
    }
}