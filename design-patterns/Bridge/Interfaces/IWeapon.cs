namespace Bridge.Interfaces
{
    public interface IWeapon<T> where T : IAmmunition
    {
        public void Shoot(T ammunition);
    }
}
