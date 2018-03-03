using Entitas;

namespace btcp.ECS.Services.Interfaces
{
    public interface IView
    {
        void Link(IEntity entity, IContext context);
    }
}