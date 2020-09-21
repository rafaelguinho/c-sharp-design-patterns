
using State.Handles;
using State.Interfaces;

namespace State.Abstract
{
    public abstract class Rocket
    {
        public Rocket(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public IStage CurrentStage { get; set; } = new Ready();

        public int Velocity { get; private set; } = 0;

        public void Acelerate()
        {
            Velocity += 20;
        }

        public void Launch()
        {
            CurrentStage.Launch(this);
        }

        public void Ascent()
        {
            CurrentStage.Ascent(this);
        }

        public void Staging()
        {
            CurrentStage.Staging(this);
        }

        public void Burn()
        {
            CurrentStage.Burn(this);
        }

        public void CutOffEngine()
        {
            CurrentStage.CutOffEngine(this);
        }
    }
}
