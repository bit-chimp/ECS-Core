using System.Collections.Generic;
using Entitas;

namespace src.libs.src.ctxs.inputaction.command.systems
{
    public class UpdateCommandDelaySystem : ReactiveSystem<general.delay.systems.InputActionEntity>
    {
        public UpdateCommandDelaySystem(Contexts contexts) : base(contexts.inputAction)
        {
        }

        protected override ICollector<general.delay.systems.InputActionEntity> GetTrigger(IContext<general.delay.systems.InputActionEntity> context)
        {
            return context.CreateCollector(InputActionMatcher.Delay.Removed());
        }

        protected override bool Filter(general.delay.systems.InputActionEntity entity)
        {
            return entity.isCommand == false && entity.hasDelay == false;
        }

        protected override void Execute(List<general.delay.systems.InputActionEntity> entities)
        {
            foreach (var inputActionEntity in entities)
            {
                inputActionEntity.isCommand = true;
            }
        }
    }
}