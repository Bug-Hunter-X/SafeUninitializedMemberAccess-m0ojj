public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Potential bug: Accessing MyProperty before it's initialized
        Console.WriteLine(MyProperty); 
    }
}