namespace src.libs.src.extensions
{
    public static class InputActionContextsExtension
    {

        public static ctxs.general.delay.systems.InputActionEntity CreateQueuedCommand(this InputActionContext inputActionContext, float delay = 0)
        {
            var e = CreateCommand(inputActionContext, delay);
            e.isCommandQueued = true;
            return e;
        }
        
        
        public static ctxs.general.delay.systems.InputActionEntity CreateCommand(this InputActionContext inputActionContext, float delay = 0)
        {
            var e = inputActionContext.CreateEntity();
            e.AddDelay(delay);
            return e;
        }
    }
}