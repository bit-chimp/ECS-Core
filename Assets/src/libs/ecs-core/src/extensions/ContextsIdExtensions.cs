using System;
using Entitas;
using src.libs.src.ctxs.general.id.components;

namespace src.libs.src.extensions
{
    public static class ContextsIdExtensions
    {

        public static void SubscribeId(this Contexts contexts)
        {
            foreach(IContext context in contexts.allContexts)
            {
                if (Array.FindIndex(context.contextInfo.componentTypes, v => v == typeof(IdComponent)) >= 0)
                {
                    context.OnEntityCreated += AddId;
                }
            }
        }

        private static void AddId(IContext context, IEntity entity)
        {
            (entity as IIdEntity).ReplaceId(entity.creationIndex);
        }
    }
}