﻿using System.Collections.Generic;

namespace src.libs.src.services.core.collision.services
{
    public interface ICollisionService
    {
        void OnCollisionEnter(int entityAId, int entityBId);
        void OnCollisionExit(int entityAId, int entityBId);
        List<int> GetCollisions(int entity);
        bool AreColliding(int entityAId, int entityBId);
        bool AreColliding(int entityAId, List<int> entities);
    }
}