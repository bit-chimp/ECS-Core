using Entitas.CodeGeneration.Attributes;

namespace btcp.ECS.src.Components.Sprite.Components
{
    [Event(false)]
    public sealed class SpriteComponent : Entitas.IComponent
    {
        public string path;
    }
}