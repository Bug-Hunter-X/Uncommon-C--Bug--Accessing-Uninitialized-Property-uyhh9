public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass() 
    {
        MyProperty = 0; // Initialize in the constructor
    }

    public void MyMethod()
    {
        //Now property is explicitly initialized
        Console.WriteLine(MyProperty); 
    }
}