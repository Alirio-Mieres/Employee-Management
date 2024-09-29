// Unions are not directly supported in C# but can be simulated using the FieldOffset attribute. 
// The FieldOffset attribute allows you to specify the offset of a field within a structure. 
// By setting the offset of multiple fields to the same value, you can create a union-like structure 
// where the fields share the same memory location. 
// This allows you to access the same memory location using different data types.

// Define a structure with explicit memory layout
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct UnionExample
{
    // Define an int field at offset 0
    [FieldOffset(0)]
    public int IntValue;

    // Define a float field at the same offset 0
    [FieldOffset(0)]
    public float FloatValue;

    // Define a byte field at the same offset 0
    [FieldOffset(0)]
    public byte ByteValue;
}
