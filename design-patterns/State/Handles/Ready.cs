using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class Ready : IStage
    {
        public void Ascent(Rocket rocket)
        {
            throw new NotImplementedException();
        }

        public void Burn(Rocket rocket)
        {
            throw new NotImplementedException();
        }

        public void CutOffEngine(Rocket rocket)
        {
            throw new NotImplementedException();
        }

        public void Launch(Rocket rocket)
        {
            rocket.CurrentStage = new Launched();
        }

        public void Staging(Rocket rocket)
        {
            throw new NotImplementedException();
        }
    }
}
