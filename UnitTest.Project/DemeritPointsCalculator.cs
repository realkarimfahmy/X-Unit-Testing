using System;
using System.Collections.Generic;
using System.Text;

namespace UnitProject
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 65;
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > 300)
                throw new ArgumentOutOfRangeException();
            if (speed <= SpeedLimit) return 0;
            const int KmPerDemeritPoint = 5;
            var demeritPoint = (speed - SpeedLimit) / KmPerDemeritPoint;
            return demeritPoint;
        }
    }
}
