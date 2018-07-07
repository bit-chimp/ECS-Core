using Entitas;

namespace src.libs.src.ctxs.inputaction.command.systems
{
    public class RemoveCommandSystem : IExecuteSystem
    {
        private IGroup<general.delay.systems.InputActionEntity> _group;
        
        public RemoveCommandSystem(Contexts contexts)
        {
            _group = contexts.inputAction.GetGroup(InputActionMatcher.Command);
        }
        
        public void Execute()
        {
            foreach (var inputActionEntity in _group.GetEntities())
            {
                //TODO : Implement destroy
//                inputActionEntity.isDestroyed = true;
            }
        }
    }
}