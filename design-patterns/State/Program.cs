using State.Models;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var saturnV = new SaturnV();

            saturnV.Launch();
            saturnV.Ascent();

            saturnV.Acelerate();
            saturnV.Acelerate();
            saturnV.Acelerate();

            saturnV.Staging();
            saturnV.Burn();

            saturnV.Acelerate();
            saturnV.Acelerate();

            saturnV.CutOffEngine();
        }
    }
}
