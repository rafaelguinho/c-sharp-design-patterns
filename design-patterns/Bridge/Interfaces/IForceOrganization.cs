namespace Bridge.Interfaces
{
    public interface IForceOrganization
    {
        public IWeapon<IAmmunition> Weapon { get; set; }

        public void Shoot(IAmmunition ammunition);
    }
}
