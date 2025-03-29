using System;

class BaseClass1
{
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
}

// Interface ที่จะใช้สำหรับการเข้าถึงฟังก์ชันจาก BaseClass2
interface IBaseClass2
{
    void MethodFromBaseClass2();
}

// DerivedClass สืบทอดจาก BaseClass1 และ Implement Interface IBaseClass2
class DerivedClass : BaseClass1, IBaseClass2
{
    public DerivedClass() : base() // เรียก constructor ของ BaseClass1
    {
        System.Console.WriteLine("This is DerivedClass");
    }

    // Implement ฟังก์ชันจาก Interface
    public void MethodFromBaseClass2()
    {
        System.Console.WriteLine("This method is from BaseClass2");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        dc.MethodFromBaseClass2(); // เรียกใช้ method ที่มาจาก BaseClass2
    }
}
