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

        public override string ToString()
        {
            return "Rifle";
        }
    }

    public class MedKit: IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Healing fellow fighters.");
        }
        public override string ToString()
        {
            return "MedKit";
        }
    }

    public class Aircraft: IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Going on a bombing run.");
        }
        public override string ToString()
        {
            return "Aircraft";
        }
    }
}