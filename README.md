# Uncommon C# Bug: Accessing Uninitialized Property

This repository demonstrates a subtle bug in C# that can be easily overlooked: accessing a property before it's explicitly initialized.  While the compiler doesn't always throw an error, the result can be unpredictable and lead to hard-to-debug issues.

## The Bug

The `bug.cs` file contains a class with a property `MyProperty` that is accessed within the `MyMethod` before any value is assigned to it. This can lead to unexpected behavior, such as printing 0 or some garbage value, as the property will initially hold its default value (0 for `int`).

## The Solution

The `bugSolution.cs` file shows the corrected version. The `MyProperty` is explicitly initialized in the constructor or in the `MyMethod` before accessing it, ensuring predictable results.