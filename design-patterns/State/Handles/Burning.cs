using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class Burning : IStage
    {
        public void Ascent(Rocket rocket)
        {
            throw new Exception("Already ascented");
        }

        public void Burn(Rocket rocket)
        {
            throw new Exception("Already burning");
        }

        public void CutOffEngine(Rocket rocket)
        {
            if (rocket.Velocity < 100)
            {
                throw new Exception("You need to reach 100 of velocity");
            }

            rocket.CurrentStage = new CuttedOffEngine();
        }

        public void Launch(Rocket rocket)
        {
            throw new Exception("Already launched");
        }

        public void Staging(Rocket rocket)
        {
            throw new Exception("Already staged");
        }
    }
}