using Bridge.Abstract;
using Bridge.Interfaces;
using System;

namespace Bridge.Handles
{
    public class Rifle : IWeapon<IAmmunition>
    {
        public void Shoot(IAmmunition ammunition)
        {
            Type type = ammunition.GetType();

            if(type.BaseType != typeof(RifleAmmunition))
            {
                throw new Exception($"The type {type.Name} is not a Rifle ammunition");
            }

            if (type == typeof(Dot50Bmg))
            {
                IAmmunition obj = ammunition;

                Console.WriteLine($"Bullet diameter : {((Dot50Bmg)obj).BulletDiameter}");
            }
            else if (type == typeof(Dot223RemPolymer))
            {
                IAmmunition obj = ammunition;

                Console.WriteLine($"Bullet weight : {((Dot223RemPolymer)obj).Weight}");
            }
        }
    }
}
