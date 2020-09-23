using Bridge.Handles;
using Bridge.Interfaces;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IForceOrganization forceOrganization = new CounterTerrorism();
            Rifle rifle = new Rifle();

            Dot50Bmg dot50Bmg = new Dot50Bmg();
            dot50Bmg.BulletDiameter = 50;

            Dot38 dot38 = new Dot38();

            forceOrganization.Weapon = rifle;
            forceOrganization.Shoot(dot50Bmg);


            Pistol9mm pistol9mm = new Pistol9mm();
            _9mmLuger _9mmLuger = new _9mmLuger();
            _9mmLuger.Weight = 115;

            forceOrganization.Weapon = pistol9mm;
            forceOrganization.Shoot(_9mmLuger);
        }
    }
}
