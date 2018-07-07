using Entitas;

namespace src.libs.src.services
{
    public interface IInitializeController
    {
        void Initialize(Contexts contexts, IEntity entity);
    }
}