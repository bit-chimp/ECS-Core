﻿namespace src.libs.src.services.core.time
{
    public interface ITimeService
    {
        float GetTime();
        float GetDeltaTime();
        float GetFixedDeltaTime();

        //TODO : Should I create an Application service for this?
        int GetApplicationFrameRate();
    }
}