using System.Collections.Generic;
using Entitas;
using src.libs.src.services.core.tick;

namespace src.libs.src.ctxs.game.tick.components
{
    [Game, Input]
    public class TickComponent : IComponent
    {
        public Dictionary<TickEnum, Tick> ticks;
    }

    public enum TickEnum
    {
        AiMovement,
        PlayerMovement,
        MapEditor_AssetLoading
    }
}