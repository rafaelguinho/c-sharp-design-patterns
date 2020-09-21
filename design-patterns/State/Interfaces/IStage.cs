using State.Abstract;

namespace State.Interfaces
{
    public interface IStage
    {
        void Launch(Rocket rocket);

        void Ascent(Rocket rocket);

        void Staging(Rocket rocket);

        void Burn(Rocket rocket);

        void CutOffEngine(Rocket rocket);
    }
}
