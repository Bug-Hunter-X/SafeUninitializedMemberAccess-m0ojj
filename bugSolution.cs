public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialized with default value

    public void MyMethod() {
        Console.WriteLine(MyProperty); 
    }
    public void MyMethod2(){
        MyProperty = 5; // Assigned a value before access
        Console.WriteLine(MyProperty);
    }
}