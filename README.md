# Unhandled Access of Uninitialized Member Variable in C#
This code snippet demonstrates a potential bug in C# where a member variable is accessed before it's been assigned a value.  Accessing an uninitialized member variable can lead to unpredictable behavior and runtime errors.

## Problem:
The `MyClass` class has a property `MyProperty`.  The `MyMethod` function attempts to print the value of `MyProperty` before any value has been assigned to it.  This results in `MyProperty` having its default value (0 for an integer), potentially leading to unexpected results if a different default is expected.

## Solution:
The solution involves initializing `MyProperty` with a default value or assigning it a value before accessing it in `MyMethod`.