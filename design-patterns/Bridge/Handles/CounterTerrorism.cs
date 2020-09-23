using Bridge.Interfaces;

namespace Bridge.Handles
{
    public class CounterTerrorism : IForceOrganization
    {
        public IWeapon<IAmmunition> Weapon { get; set; }

        public void Shoot(IAmmunition ammunition)
        {
            Weapon.Shoot(ammunition);
        }
    }
}
