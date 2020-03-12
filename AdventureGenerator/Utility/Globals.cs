using System;

namespace AdventureGenerator.Utility
{
    public static class Globals
    {
        #region Standalone methods

        public static float RadiansToDegrees(float angle)
        {
            return (float)(angle*180/Math.PI);
        }

        public static float DegreesToRadians(float angle)
        {
            return (float)(angle*Math.PI/180);
        }

        #endregion
    }
}
