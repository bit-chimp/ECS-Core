using Entitas;

namespace src.libs.src.ctxs.general.delay.components
{
    [Game, InputAction]
    public class DelayComponent : IComponent
    {
        public float seconds;
    }
}