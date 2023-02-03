using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Burst.Intrinsics
{
    /// <summary>
    /// Represents a 128-bit SIMD value
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
	[DebuggerTypeProxy(typeof(V128DebugView))]
    public struct v128
    {
		/// <summary>
		/// Get the 0th Byte of the vector
		/// </summary>
        [FieldOffset(0)] public byte Byte0;
		/// <summary>
		/// Get the 1st Byte of the vector
		/// </summary>
        [FieldOffset(1)] public byte Byte1;
		/// <summary>
		/// Get the 2nd Byte of the vector
		/// </summary>
        [FieldOffset(2)] public byte Byte2;
		/// <su