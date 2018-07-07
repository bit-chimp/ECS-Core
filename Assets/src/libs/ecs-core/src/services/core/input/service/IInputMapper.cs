namespace src.libs.src.services.core.input.service
{
    public interface IInputMapper<T>
    {
        T ConvertTo(KeyId id);
        KeyId ConvertFrom(T id);

    }
}