using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
		public const int GL_SPIR_V_BINARY = 0x9552;
		public const int GL_PARAMETER_BUFFER = 0x80EE;
		public const int GL_PARAMETER_BUFFER_BINDING = 0x80EF;
		public const int GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
		public const int GL_VERTICES_SUBMITTED = 0x82EE;
		public const int GL_PRIMITIVES_SUBMITTED = 0x82EF;
		public const int GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;
		public const int GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;
		public const int GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
		public const int GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
		public const int GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
		public const int GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;
		public const int GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;
		public const int GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
		public const int GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
		public const int GL_SPIR_V_EXTENSIONS = 0x9553;
		public const int GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
		public const int GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
		public const int GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
		public const int GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
		public const int GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
		#endregion // Constants
		
		public static void glSpecializeShader(int shader, IntPtr pEntryPoint, int numSpecializationConstants, IntPtr pConstantIndex, IntPtr pConstantValue)
		{
			unsafe
			{
				Capabilities.nglSpecializeShader(shader, (byte*)pEntryPoint.ToPointer(), numSpecializationConstants, (int*)pConstantIndex.ToPointer(), (int*)pConstantValue.ToPointer());
			}
		}
		
		public static void glSpecializeShader(int shader, byte[] pEntryPoint, int numSpecializationConstants, int[] pConstantIndex, int[] pConstantValue)
		{
			unsafe
			{
				fixed (byte* pEntryPointPtr = pEntryPoint)
				{
					fixed (int* pConstantIndexPtr = pConstantIndex)
					{
						fixed (int* pConstantValuePtr = pConstantValue)
						{
							Capabilities.nglSpecializeShader(shader, pEntryPointPtr, numSpecializationConstants, pConstantIndexPtr, pConstantValuePtr);
						}
					}
				}
			}
		}
		
		public static void glMultiDrawArraysIndirectCount(int mode, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			unsafe
			{
				Capabilities.nglMultiDrawArraysIndirectCount(mode, indirect.ToPointer(), drawcount, maxdrawcount, stride);
			}
		}
		
		public static void glMultiDrawElementsIndirectCount(int mode, int type, IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride)
		{
			unsafe
			{
				Capabilities.nglMultiDrawElementsIndirectCount(mode, type, indirect.ToPointer(), drawcount, maxdrawcount, stride);
			}
		}
		
		public static void glPolygonOffsetClamp(float factor, float units, float clamp) =>
			Capabilities.nglPolygonOffsetClamp(factor, units, clamp);
		
		
	}
}
