using src.game.utils.containers;

namespace src.libs.src.services.core.inputaction
{
    public interface IInputActionService
    {
        void SetSpriteColor(ctxs.general.delay.systems.GameEntity entity, Color color, float delay = 0);
    }
}