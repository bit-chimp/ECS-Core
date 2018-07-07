using src.libs.src.ctxs.inputaction.command.systems;

namespace src.game.ecs
{
    public class CommandSystems : Feature
    {
        public CommandSystems(Contexts contexts)
        {
            Add(new UpdateCommandDelaySystem(contexts));

            //Add Command Intercept Systems Here
            //Add Command Execute Systems Here
            
            Add(new RemoveCommandSystem(contexts));
        }
    }
}