namespace src.libs.src.services.core.input.binding
{
    public struct InputBind
    {
        public KeyId Key;
        public string Action;

        public InputBind(KeyId id, string action)
        {
            Key = id;
            Action = action;
        }

        public override string ToString()
        {
            return "Key ID: '" + Key + "'" + " Action: " + Action;
        }
    }
}