using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_SAMPLE_SHADING = 0x8C36;
		public const int GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const int GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const int GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const int GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const int GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const int GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const int GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const int GL_MAX_VERTEX_STREAMS = 0x8E71;
		public const int GL_DOUBLE_VEC2 = 0x8FFC;
		public const int GL_DOUBLE_VEC3 = 0x8FFD;
		public const int GL_DOUBLE_VEC4 = 0x8FFE;
		public const int GL_DOUBLE_MAT2 = 0x8F46;
		public const int GL_DOUBLE_MAT3 = 0x8F47;
		public const int GL_DOUBLE_MAT4 = 0x8F48;
		public const int GL_DOUBLE_MAT2x3 = 0x8F49;
		public const int GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const int GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const int GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const int GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const int GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const int GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const int GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const int GL_MAX_SUBROUTINES = 0x8DE7;
		public const int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const int GL_PATCHES = 0x000E;
		public const int GL_PATCH_VERTICES = 0x8E72;
		public const int GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const int GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const int GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const int GL_TESS_GEN_MODE = 0x8E76;
		public const int GL_TESS_GEN_SPACING = 0x8E77;
		public const int GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const int GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const int GL_ISOLINES = 0x8E7A;
		public const int GL_FRACTIONAL_ODD = 0x8E7B;
		public const int GL_FRACTIONAL_EVEN = 0x8E7C;
		public const int GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const int GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const int GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const int GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const int GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const int GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const int GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const int GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const int GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const int GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const int GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const int GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const int GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const int GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const int GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const int GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const int GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const int GL_TESS_CONTROL_SHADER = 0x8E88;
		public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		#endregion // Constants
		
		public static void glMinSampleShading(float value) =>
			Capabilities.nglMinSampleShading(value);
		
		public static void glBlendEquationi(int buf, int mode) =>
			Capabilities.nglBlendEquationi(buf, mode);
		
		public static void glBlendEquationSeparatei(int buf, int modeRGB, int modeAlpha) =>
			Capabilities.nglBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		
		public static void glBlendFunci(int buf, int src, int dst) =>
			Capabilities.nglBlendFunci(buf, src, dst);
		
		public static void glBlendFuncSeparatei(int buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha) =>
			Capabilities.nglBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		
		public static void glDrawArraysIndirect(int mode, IntPtr indirect)
		{
			unsafe
			{
				Capabilities.nglDrawArraysIndirect(mode, indirect.ToPointer());
			}
		}
		
		public static void glDrawElementsIndirect(int mode, int type, IntPtr indirect)
		{
			unsafe
			{
				Capabilities.nglDrawElementsIndirect(mode, type, indirect.ToPointer());
			}
		}
		
		public static void glUniform1d(int location, double x) =>
			Capabilities.nglUniform1d(location, x);
		
		public static void glUniform2d(int location, double x, double y) =>
			Capabilities.nglUniform2d(location, x, y);
		
		public static void glUniform3d(int location, double x, double y, double z) =>
			Capabilities.nglUniform3d(location, x, y, z);
		
		public static void glUniform4d(int location, double x, double y, double z, double w) =>
			Capabilities.nglUniform4d(location, x, y, z, w);
		
		public static void glUniform1dv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform1dv(location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glUniform1dv(int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform1dv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform1dv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform1dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform1dv(int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniform1dv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform2dv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform2dv(location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glUniform2dv(int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform2dv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform2dv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform2dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform2dv(int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniform2dv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform3dv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform3dv(location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glUniform3dv(int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform3dv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform3dv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform3dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform3dv(int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniform3dv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform4dv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform4dv(location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glUniform4dv(int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform4dv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform4dv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform4dv(location, count, (double*)ptr);
			}
		}
		
		public static void glUniform4dv(int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniform4dv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix2dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix2x3dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2x3dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2x3dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2x3dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix2x4dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2x4dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2x4dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2x4dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3x2dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3x2dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3x2dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3x2dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3x4dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3x4dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3x4dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3x4dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3x4dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4x2dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4x2dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4x2dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4x2dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4x2dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4x3dv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4x3dv(location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4x3dv(int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3dv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3dv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4x3dv(location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3dv(int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4x3dv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glGetUniformdv(int program, int location, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetUniformdv(program, location, (double*)_params.ToPointer());
			}
		}
		
		public static void glGetUniformdv(int program, int location, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformdv(program, location, (double*)ptr);
			}
		}
		
		public static void glGetUniformdv<T>(int program, int location, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformdv(program, location, (double*)ptr);
			}
		}
		
		public static void glGetUniformdv<T>(int program, int location, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetUniformdv(program, location, (double*)ptr);
			}
		}
		
		public static void glGetUniformdv(int program, int location, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglGetUniformdv(program, location, _paramsPtr);
				}
			}
		}
		
		public static int glGetSubroutineUniformLocation(int program, int shadertype, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetSubroutineUniformLocation(program, shadertype, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetSubroutineUniformLocation(int program, int shadertype, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetSubroutineUniformLocation(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineUniformLocation<T>(int program, int shadertype, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetSubroutineUniformLocation(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineUniformLocation<T>(int program, int shadertype, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetSubroutineUniformLocation(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineUniformLocation(int program, int shadertype, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetSubroutineUniformLocation(program, shadertype, namePtr);
				}
			}
		}
		
		public static int glGetSubroutineIndex(int program, int shadertype, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetSubroutineIndex(program, shadertype, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetSubroutineIndex(int program, int shadertype, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetSubroutineIndex(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineIndex<T>(int program, int shadertype, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetSubroutineIndex(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineIndex<T>(int program, int shadertype, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetSubroutineIndex(program, shadertype, (byte*)ptr);
			}
		}
		
		public static void glGetSubroutineIndex(int program, int shadertype, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetSubroutineIndex(program, shadertype, namePtr);
				}
			}
		}
		
		public static void glGetActiveSubroutineUniformiv(int program, int shadertype, int index, int pname, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetActiveSubroutineUniformiv(program, shadertype, index, pname, (int*)values.ToPointer());
			}
		}
		
		public static void glGetActiveSubroutineUniformiv(int program, int shadertype, int index, int pname, ref int values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetActiveSubroutineUniformiv(program, shadertype, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveSubroutineUniformiv<T>(int program, int shadertype, int index, int pname, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetActiveSubroutineUniformiv(program, shadertype, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveSubroutineUniformiv<T>(int program, int shadertype, int index, int pname, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetActiveSubroutineUniformiv(program, shadertype, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveSubroutineUniformiv(int program, int shadertype, int index, int pname, int[] values)
		{
			unsafe
			{
				fixed (int* valuesPtr = values)
				{
					Capabilities.nglGetActiveSubroutineUniformiv(program, shadertype, index, pname, valuesPtr);
				}
			}
		}
		
		public static void glGetActiveSubroutineUniformName(int program, int shadertype, int index, int bufSize, IntPtr length, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetActiveSubroutineUniformName(program, shadertype, index, bufSize, (int*)length.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetActiveSubroutineUniformName(int program, int shadertype, int index, int bufSize, int[] length, byte[] name)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* namePtr = name)
					{
						Capabilities.nglGetActiveSubroutineUniformName(program, shadertype, index, bufSize, lengthPtr, namePtr);
					}
				}
			}
		}
		
		public static void glGetActiveSubroutineName(int program, int shadertype, int index, int bufSize, IntPtr length, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetActiveSubroutineName(program, shadertype, index, bufSize, (int*)length.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetActiveSubroutineName(int program, int shadertype, int index, int bufSize, int[] length, byte[] name)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* namePtr = name)
					{
						Capabilities.nglGetActiveSubroutineName(program, shadertype, index, bufSize, lengthPtr, namePtr);
					}
				}
			}
		}
		
		public static void glUniformSubroutinesuiv(int shadertype, int count, IntPtr indices)
		{
			unsafe
			{
				Capabilities.nglUniformSubroutinesuiv(shadertype, count, (int*)indices.ToPointer());
			}
		}
		
		public static void glUniformSubroutinesuiv(int shadertype, int count, ref int indices)
		{
			unsafe
			{
				fixed (void* ptr = &indices) Capabilities.nglUniformSubroutinesuiv(shadertype, count, (int*)ptr);
			}
		}
		
		public static void glUniformSubroutinesuiv<T>(int shadertype, int count, ref T indices) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &indices) Capabilities.nglUniformSubroutinesuiv(shadertype, count, (int*)ptr);
			}
		}
		
		public static void glUniformSubroutinesuiv<T>(int shadertype, int count, T[] indices) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = indices) Capabilities.nglUniformSubroutinesuiv(shadertype, count, (int*)ptr);
			}
		}
		
		public static void glUniformSubroutinesuiv(int shadertype, int count, int[] indices)
		{
			unsafe
			{
				fixed (int* indicesPtr = indices)
				{
					Capabilities.nglUniformSubroutinesuiv(shadertype, count, indicesPtr);
				}
			}
		}
		
		public static void glGetUniformSubroutineuiv(int shadertype, int location, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetUniformSubroutineuiv(shadertype, location, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetUniformSubroutineuiv(int shadertype, int location, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformSubroutineuiv(shadertype, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformSubroutineuiv<T>(int shadertype, int location, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformSubroutineuiv(shadertype, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformSubroutineuiv<T>(int shadertype, int location, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetUniformSubroutineuiv(shadertype, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformSubroutineuiv(int shadertype, int location, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetUniformSubroutineuiv(shadertype, location, _paramsPtr);
				}
			}
		}
		
		public static void glGetProgramStageiv(int program, int shadertype, int pname, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetProgramStageiv(program, shadertype, pname, (int*)values.ToPointer());
			}
		}
		
		public static void glGetProgramStageiv(int program, int shadertype, int pname, ref int values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetProgramStageiv(program, shadertype, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramStageiv<T>(int program, int shadertype, int pname, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetProgramStageiv(program, shadertype, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramStageiv<T>(int program, int shadertype, int pname, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetProgramStageiv(program, shadertype, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramStageiv(int program, int shadertype, int pname, int[] values)
		{
			unsafe
			{
				fixed (int* valuesPtr = values)
				{
					Capabilities.nglGetProgramStageiv(program, shadertype, pname, valuesPtr);
				}
			}
		}
		
		public static void glPatchParameteri(int pname, int value) =>
			Capabilities.nglPatchParameteri(pname, value);
		
		public static void glPatchParameterfv(int pname, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglPatchParameterfv(pname, (float*)values.ToPointer());
			}
		}
		
		public static void glPatchParameterfv(int pname, ref float values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPatchParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPatchParameterfv<T>(int pname, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPatchParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPatchParameterfv<T>(int pname, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglPatchParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPatchParameterfv(int pname, float[] values)
		{
			unsafe
			{
				fixed (float* valuesPtr = values)
				{
					Capabilities.nglPatchParameterfv(pname, valuesPtr);
				}
			}
		}
		
		public static void glBindTransformFeedback(int target, int id) =>
			Capabilities.nglBindTransformFeedback(target, id);
		
		public static void glDeleteTransformFeedbacks(int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglDeleteTransformFeedbacks(n, (int*)ids.ToPointer());
			}
		}
		
		public static void glDeleteTransformFeedbacks(int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDeleteTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTransformFeedbacks<T>(int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDeleteTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTransformFeedbacks<T>(int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglDeleteTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTransformFeedbacks(int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglDeleteTransformFeedbacks(n, idsPtr);
				}
			}
		}
		
		public static void glDeleteTransformFeedbacks(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteTransformFeedbacks(1, &name);
			}
		}
		
		public static void glDeleteTransformFeedbacks(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteTransformFeedbacks(names.Length, ptr);
			}
		}
		
		public static void glGenTransformFeedbacks(int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglGenTransformFeedbacks(n, (int*)ids.ToPointer());
			}
		}
		
		public static void glGenTransformFeedbacks(int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglGenTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glGenTransformFeedbacks<T>(int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglGenTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glGenTransformFeedbacks<T>(int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglGenTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glGenTransformFeedbacks(int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglGenTransformFeedbacks(n, idsPtr);
				}
			}
		}
		
		public static int glGenTransformFeedbacks()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenTransformFeedbacks(1, &val);
				return val;
			}
		}
		
		public static void glGenTransformFeedbacks(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenTransformFeedbacks(names.Length, ptr);
			}
		}
		
		public static byte glIsTransformFeedback(int id) =>
			Capabilities.nglIsTransformFeedback(id);
		
		public static void glPauseTransformFeedback() =>
			Capabilities.nglPauseTransformFeedback();
		
		public static void glResumeTransformFeedback() =>
			Capabilities.nglResumeTransformFeedback();
		
		public static void glDrawTransformFeedback(int mode, int id) =>
			Capabilities.nglDrawTransformFeedback(mode, id);
		
		public static void glDrawTransformFeedbackStream(int mode, int id, int stream) =>
			Capabilities.nglDrawTransformFeedbackStream(mode, id, stream);
		
		public static void glBeginQueryIndexed(int target, int index, int id) =>
			Capabilities.nglBeginQueryIndexed(target, index, id);
		
		public static void glEndQueryIndexed(int target, int index) =>
			Capabilities.nglEndQueryIndexed(target, index);
		
		public static void glGetQueryIndexediv(int target, int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryIndexediv(target, index, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryIndexediv(int target, int index, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryIndexediv(target, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryIndexediv<T>(int target, int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryIndexediv(target, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryIndexediv<T>(int target, int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryIndexediv(target, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryIndexediv(int target, int index, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryIndexediv(target, index, pname, _paramsPtr);
				}
			}
		}
		
		
	}
}
