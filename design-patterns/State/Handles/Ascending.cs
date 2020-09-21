using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class Ascending : IStage
    {
        public void Ascent(Rocket rocket)
        {
            throw new Exception("Already Ascending");
        }

        public void Burn(Rocket rocket)
        {
            throw new Exception("Not done yet");
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
            if (rocket.Velocity < 60)
            {
                throw new Exception("You need to reach 60 of velocity");
            }

            rocket.CurrentStage = new Staged();
        }
    }
}