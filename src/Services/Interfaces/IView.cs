using Entitas;

namespace btcp.ECS.src.Services.Interfaces
{
    public interface IView
    {
        void Link(IEntity entity, IContext context);
    }
}