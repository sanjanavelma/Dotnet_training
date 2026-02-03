using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public abstract class Extrafeatures
{
    public abstract void MusicSystem();
    //public abstract void TopCamera();
}
public interface IGear //Interface cannot be static
{
    public void GearTest1();
    public void GearTest2();
    public void GearTest3();
    public void GearTest4();
    public void GearTest5();
    public void GearTest6();
    public void ReverseGear();
}
public class Toyota : Extrafeatures, IGear
    {
        public void GearTest1()
    {
        Console.WriteLine("Gear 1 is tested");
    }
    public void GearTest2()
    {
        Console.WriteLine("Gear 2 is tested");
    }
    public  void GearTest3()
    {
        Console.WriteLine("Gear 3 is tested");
    }
    public void GearTest4()
    {
        Console.WriteLine("Gear 4 is tested");
    }
    public  void GearTest5()
    {
        Console.WriteLine("Gear 5 is tested");
    }
    public void GearTest6()
    {
        Console.WriteLine("Gear 6 is tested");
    }
    public void ReverseGear()
    {
        Console.WriteLine("ReverseGear is tested");
    }
    public override void MusicSystem()
    {
        Console.WriteLine("Music System is tested");
    }
    // public override void TopCamera()
    // {
    //     Console.WriteLine("Camera is Good");
    // }
    }
