namespace src.libs.src.services.core.input.controller
{
    public interface IInputController
    {
        bool IsKeyHeldDown(KeyId id);
        bool IsKeyDown(KeyId id);
        bool IsKeyUp(KeyId id);
        bool IsMouseUp();
        bool IsMouseDown();
    }
}