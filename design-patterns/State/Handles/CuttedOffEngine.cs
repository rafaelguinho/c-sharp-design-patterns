using State.Abstract;
using State.Interfaces;
using System;

namespace State.Handles
{
    internal class CuttedOffEngine : IStage
    {
        public void Ascent(Rocket rocket)
        {
            throw new Exception("The engines is cutted off, just enjoy the orbit");
        }

        public void Burn(Rocket rocket)
        {
            throw new Exception("The engines is cutted off, just enjoy the orbit");
        }

        public void CutOffEngine(Rocket rocket)
        {
            throw new Exception("The engines is cutted off, just enjoy the orbit");
        }

        public void Launch(Rocket rocket)
        {
            throw new Exception("The engines is cutted off, just enjoy the orbit");
        }

        public void Staging(Rocket rocket)
        {
            throw new Exception("The engines is cutted off, just enjoy the orbit");
        }
    }
}