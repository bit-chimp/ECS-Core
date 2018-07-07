using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace src.libs.src.ctxs.general.id.components
{
    [Game, InputAction]
    public class IdComponent : IComponent
    {
        [PrimaryEntityIndex] public int value;
    }
}