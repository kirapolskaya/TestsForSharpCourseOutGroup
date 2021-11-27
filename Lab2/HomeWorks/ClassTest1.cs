namespace Lab2.HomeWorks
{
   class GFG : Abstract_Class, Interface
{
     
    // Method definition for abstract method
    public override void abstract_method()
    {
        Console.WriteLine("I am the method of abstract class");
    }
     
    // Method definition for interface
    public void interface_method()
    {
        Console.WriteLine("I am the method of interface");
    }
}
 
}