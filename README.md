# Unit
Provides `Unit` type (an empty struct).

## What
The type which has the exactly one stateless value is called *the unit type*. Call the value *the unit value*.

While `bool` value represents 1 bit (yes/no), the unit value provides no information. For example, if a method gets an argument of the unit type, it has nothing to do because it knows the argument equals the unit value beforehand and it can use the unit value instead of the argument.

## Why
`Unit` is useful as type argument where the value of the type should be ignored.

## Usage
Install this package via NuGet.

```csharp
using DotNetKit.Misc;

// Get the unit value.
F(default(Unit));
```
