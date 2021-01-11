using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_SAMPLER_2D_RECT = 0x8B63;
		public const int GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const int GL_SAMPLER_BUFFER = 0x8DC2;
		public const int GL_INT_SAMPLER_2D_RECT = 0x8DCD;
		public const int GL_INT_SAMPLER_BUFFER = 0x8DD0;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const int GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const int GL_TEXTURE_BUFFER = 0x8C2A;
		public const int GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const int GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const int GL_TEXTURE_RECTANGLE = 0x84F5;
		public const int GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const int GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const int GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const int GL_R8_SNORM = 0x8F94;
		public const int GL_RG8_SNORM = 0x8F95;
		public const int GL_RGB8_SNORM = 0x8F96;
		public const int GL_RGBA8_SNORM = 0x8F97;
		public const int GL_R16_SNORM = 0x8F98;
		public const int GL_RG16_SNORM = 0x8F99;
		public const int GL_RGB16_SNORM = 0x8F9A;
		public const int GL_RGBA16_SNORM = 0x8F9B;
		public const int GL_SIGNED_NORMALIZED = 0x8F9C;
		public const int GL_PRIMITIVE_RESTART = 0x8F9D;
		public const int GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const int GL_COPY_READ_BUFFER = 0x8F36;
		public const int GL_COPY_WRITE_BUFFER = 0x8F37;
		public const int GL_UNIFORM_BUFFER = 0x8A11;
		public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const int GL_UNIFORM_BUFFER_START = 0x8A29;
		public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const int GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const int GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const int GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const int GL_UNIFORM_TYPE = 0x8A37;
		public const int GL_UNIFORM_SIZE = 0x8A38;
		public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const int GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const int GL_UNIFORM_OFFSET = 0x8A3B;
		public const int GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const int GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const int GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const int GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const int GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const int GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const int GL_INVALID_INDEX = -1;
		#endregion // Constants
		
		public static void glDrawArraysInstanced(int mode, int first, int count, int instancecount) =>
			Capabilities.nglDrawArraysInstanced(mode, first, count, instancecount);
		
		public static void glDrawElementsInstanced(int mode, int count, int type, IntPtr indices, int instancecount)
		{
			unsafe
			{
				Capabilities.nglDrawElementsInstanced(mode, count, type, indices.ToPointer(), instancecount);
			}
		}
		
		public static void glTexBuffer(int target, int internalformat, int buffer) =>
			Capabilities.nglTexBuffer(target, internalformat, buffer);
		
		public static void glPrimitiveRestartIndex(int index) =>
			Capabilities.nglPrimitiveRestartIndex(index);
		
		public static void glCopyBufferSubData(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size) =>
			Capabilities.nglCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		
		public static void glGetUniformIndices(int program, int uniformCount, IntPtr uniformNames, IntPtr uniformIndices)
		{
			unsafe
			{
				Capabilities.nglGetUniformIndices(program, uniformCount, (byte**)uniformNames.ToPointer(), (int*)uniformIndices.ToPointer());
			}
		}
		
		public static void glGetActiveUniformsiv(int program, int uniformCount, IntPtr uniformIndices, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetActiveUniformsiv(program, uniformCount, (int*)uniformIndices.ToPointer(), pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetActiveUniformsiv(int program, int uniformCount, int[] uniformIndices, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* uniformIndicesPtr = uniformIndices)
				{
					fixed (int* _paramsPtr = _params)
					{
						Capabilities.nglGetActiveUniformsiv(program, uniformCount, uniformIndicesPtr, pname, _paramsPtr);
					}
				}
			}
		}
		
		public static void glGetActiveUniformName(int program, int uniformIndex, int bufSize, IntPtr length, IntPtr uniformName)
		{
			unsafe
			{
				Capabilities.nglGetActiveUniformName(program, uniformIndex, bufSize, (int*)length.ToPointer(), (byte*)uniformName.ToPointer());
			}
		}
		
		public static void glGetActiveUniformName(int program, int uniformIndex, int bufSize, int[] length, byte[] uniformName)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* uniformNamePtr = uniformName)
					{
						Capabilities.nglGetActiveUniformName(program, uniformIndex, bufSize, lengthPtr, uniformNamePtr);
					}
				}
			}
		}
		
		public static int glGetUniformBlockIndex(int program, IntPtr uniformBlockName)
		{
			unsafe
			{
				return Capabilities.nglGetUniformBlockIndex(program, (byte*)uniformBlockName.ToPointer());
			}
		}
		
		public static void glGetUniformBlockIndex(int program, ref byte uniformBlockName)
		{
			unsafe
			{
				fixed (void* ptr = &uniformBlockName) Capabilities.nglGetUniformBlockIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformBlockIndex<T>(int program, ref T uniformBlockName) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &uniformBlockName) Capabilities.nglGetUniformBlockIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformBlockIndex<T>(int program, T[] uniformBlockName) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = uniformBlockName) Capabilities.nglGetUniformBlockIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformBlockIndex(int program, byte[] uniformBlockName)
		{
			unsafe
			{
				fixed (byte* uniformBlockNamePtr = uniformBlockName)
				{
					Capabilities.nglGetUniformBlockIndex(program, uniformBlockNamePtr);
				}
			}
		}
		
		public static void glGetActiveUniformBlockiv(int program, int uniformBlockIndex, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetActiveUniformBlockiv(int program, int uniformBlockIndex, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveUniformBlockiv<T>(int program, int uniformBlockIndex, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveUniformBlockiv<T>(int program, int uniformBlockIndex, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, (int*)ptr);
			}
		}
		
		public static void glGetActiveUniformBlockiv(int program, int uniformBlockIndex, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetActiveUniformBlockName(int program, int uniformBlockIndex, int bufSize, IntPtr length, IntPtr uniformBlockName)
		{
			unsafe
			{
				Capabilities.nglGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, (int*)length.ToPointer(), (byte*)uniformBlockName.ToPointer());
			}
		}
		
		public static void glGetActiveUniformBlockName(int program, int uniformBlockIndex, int bufSize, int[] length, byte[] uniformBlockName)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* uniformBlockNamePtr = uniformBlockName)
					{
						Capabilities.nglGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, lengthPtr, uniformBlockNamePtr);
					}
				}
			}
		}
		
		public static void glUniformBlockBinding(int program, int uniformBlockIndex, int uniformBlockBinding) =>
			Capabilities.nglUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		
		
	}
}
