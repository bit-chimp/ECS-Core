using System.Collections.Generic;
using Entitas;

namespace src.libs.src.ctxs.general.delay.systems
{
    public class UpdateDelaySystem : MultiReactiveSystem<IDelayedEntity, Contexts>
    {
        private readonly Contexts _contexts;

        public UpdateDelaySystem(Contexts contexts) : base(contexts)
        {
            _contexts = contexts;
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]
            {
                contexts.game.CreateCollector(GameMatcher.Delay),
                contexts.inputAction.CreateCollector(InputActionMatcher.Delay),
            };
        }

        protected override bool Filter(IDelayedEntity entity)
        {
            return entity.hasDelay;
        }

        protected override void Execute(List<IDelayedEntity> entities)
        {
            foreach (var delayedEntity in entities)
            {
                var delay = delayedEntity.delay;

                delay.seconds -= _contexts.meta.timeService.time.GetDeltaTime();

                if (delay.seconds <= 0)
                {
                    delayedEntity.RemoveDelay();
                }
                
                delayedEntity.ReplaceDelay(delay.seconds);
            }
        }
    }

    public interface IDelayedEntity : IEntity, IDelayEntity
    {
    }

    public partial class GameEntity : IDelayedEntity
    {
    }

    public partial class InputActionEntity : IDelayedEntity
    {
    }
}