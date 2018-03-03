using Entitas.CodeGeneration.Attributes;

namespace btcp.ECS.Asset.Components
{
    [Event(false)]
    public sealed class AssetComponent : Entitas.IComponent
    {
        public string path;
    }
}