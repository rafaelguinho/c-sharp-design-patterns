using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class Staged : IStage
    {
        public void Ascent(Rocket rocket)
        {
            throw new Exception("Already ascented");
        }

        public void Burn(Rocket rocket)
        {
            rocket.CurrentStage = new Burning();
        }

        public void CutOffEngine(Rocket rocket)
        {
            throw new Exception("Not done yet");
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