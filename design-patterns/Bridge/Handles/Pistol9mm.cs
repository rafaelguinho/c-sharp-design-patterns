using Bridge.Interfaces;
using System;

namespace Bridge.Handles
{
    public class Pistol9mm : IWeapon<IAmmunition>
    {
        public void Shoot(IAmmunition ammunition)
        {
            Type type = ammunition.GetType();

            if (type != typeof(_9mmLuger))
            {
                throw new Exception($"The type {type.Name} is not a pistol ammunition");
            }

            Console.WriteLine($"Bullet weight : {((_9mmLuger)ammunition).Weight}");
        }
    }
}
