using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class Launched : IStage
    {
        public void Ascent(Rocket rocket)
        {
            rocket.CurrentStage = new Ascending();
        }

        public void Burn(Rocket rocket)
        {
            throw new Exception("Not done yet");
        }

        public void CutOffEngine(Rocket rocket)
        {
            throw new Exception("Not done yet");
        }

        public void Staging(Rocket rocket)
        {
            throw new Exception("Not done yet");
        }

        public void Launch(Rocket rocket)
        {
            throw new Exception("Already launched");
        }
    }
}