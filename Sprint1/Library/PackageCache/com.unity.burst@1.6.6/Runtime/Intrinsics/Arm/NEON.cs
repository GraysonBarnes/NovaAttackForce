using System;
using System.Diagnostics;

namespace Unity.Burst.Intrinsics
{
    /// <summary>
    /// Static methods and properties for Arm instruction intrinsics.
    /// </summary>
    public unsafe static partial class Arm
    {
        /// <summary>
        /// Neon intrinsics
        /// </summary>
        public unsafe partial class Neon
        {
            /// <summary>
            /// Evaluates to true at compile time if Neon intrinsics are supported.
            /// </summary>
            public static bool IsNeonSupported { get { return false; } }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Dd,Dn,Dm</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_u8(v64 a0, v64 a1)
            {
                return vadd_s8(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_u8(v128 a0, v128 a1)
            {
                return vaddq_s8(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_u16(v64 a0, v64 a1)
            {
                return vadd_s16(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_u16(v128 a0, v128 a1)
            {
                return vaddq_s16(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_u32(v64 a0, v64 a1)
            {
                return vadd_s32(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_u32(v128 a0, v128 a1)
            {
                return vaddq_s32(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Dd,Dn,Dm</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_u64(v64 a0, v64 a1)
            {
                return vadd_s64(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_u64(v128 a0, v128 a1)
            {
                return vaddq_s64(a0, a1);
            }

            /// <summary>Floating-point Add (vector). This instruction adds corresponding vector elements in the two source SIMD&amp;FP registers, writes the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>64-bit vector</returns>
            [DebuggerStepThrough]
            public static v64 vadd_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Add (vector). This instruction adds corresponding vector elements in the two source SIMD&amp;FP registers, writes the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">128-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.8H,Vn.8H,Vm.8B</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_s8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.4S,Vn.4S,Vm.4H</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_s16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.2D,Vn.2D,Vm.2S</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_s32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.8H,Vn.8H,Vm.8B</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_u8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.4S,Vn.4S,Vm.4H</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_u16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.2D,Vn.2D,Vm.2S</c></summary>
            /// <param name="a0">128-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>
            /// <returns>128-bit vector</returns>
            [DebuggerStepThrough]
            public static v128 vaddw_u32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            /// <param name="a0">64-bit vector a0</param>
            /// <param name="a1">64-bit vector a1</param>