using System;

namespace IGIProject
{
    public interface IWeapon
    {
        void DoDamage();
    }

    public class Rifle: IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shooting Rifle.");
            
        }
    }

    public class MedKit: IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Healing fellow fighters.");
            
        }
    }

    public class Aircraft: IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Going on a bombing run.");
            
        }
    }
}