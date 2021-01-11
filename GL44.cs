using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const int GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const int GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const int GL_MAP_PERSISTENT_BIT = 0x0040;
		public const int GL_MAP_COHERENT_BIT = 0x0080;
		public const int GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const int GL_CLIENT_STORAGE_BIT = 0x0200;
		public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const int GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const int GL_BUFFER_STORAGE_FLAGS = 0x8220;
		public const int GL_CLEAR_TEXTURE = 0x9365;
		public const int GL_LOCATION_COMPONENT = 0x934A;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const int GL_QUERY_BUFFER = 0x9192;
		public const int GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const int GL_QUERY_BUFFER_BINDING = 0x9193;
		public const int GL_QUERY_RESULT_NO_WAIT = 0x9194;
		public const int GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
		#endregion // Constants
		
		public static void glBufferStorage(int target, IntPtr size, IntPtr data, int flags)
		{
			unsafe
			{
				Capabilities.nglBufferStorage(target, size, data.ToPointer(), flags);
			}
		}
		
		public static void glClearTexImage(int texture, int level, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearTexImage(texture, level, format, type, data.ToPointer());
			}
		}
		
		public static void glClearTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data.ToPointer());
			}
		}
		
		public static void glBindBuffersBase(int target, int first, int count, IntPtr buffers)
		{
			unsafe
			{
				Capabilities.nglBindBuffersBase(target, first, count, (int*)buffers.ToPointer());
			}
		}
		
		public static void glBindBuffersBase(int target, int first, int count, ref int buffers)
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglBindBuffersBase(target, first, count, (int*)ptr);
			}
		}
		
		public static void glBindBuffersBase<T>(int target, int first, int count, ref T buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglBindBuffersBase(target, first, count, (int*)ptr);
			}
		}
		
		public static void glBindBuffersBase<T>(int target, int first, int count, T[] buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffers) Capabilities.nglBindBuffersBase(target, first, count, (int*)ptr);
			}
		}
		
		public static void glBindBuffersBase(int target, int first, int count, int[] buffers)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					Capabilities.nglBindBuffersBase(target, first, count, buffersPtr);
				}
			}
		}
		
		public static void glBindBuffersRange(int target, int first, int count, IntPtr buffers, IntPtr offsets, IntPtr sizes)
		{
			unsafe
			{
				Capabilities.nglBindBuffersRange(target, first, count, (int*)buffers.ToPointer(), (IntPtr*)offsets.ToPointer(), (IntPtr*)sizes.ToPointer());
			}
		}
		
		public static void glBindBuffersRange(int target, int first, int count, int[] buffers, IntPtr[] offsets, IntPtr[] sizes)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					fixed (IntPtr* offsetsPtr = offsets)
					{
						fixed (IntPtr* sizesPtr = sizes)
						{
							Capabilities.nglBindBuffersRange(target, first, count, buffersPtr, offsetsPtr, sizesPtr);
						}
					}
				}
			}
		}
		
		public static void glBindTextures(int first, int count, IntPtr textures)
		{
			unsafe
			{
				Capabilities.nglBindTextures(first, count, (int*)textures.ToPointer());
			}
		}
		
		public static void glBindTextures(int first, int count, ref int textures)
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglBindTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindTextures<T>(int first, int count, ref T textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglBindTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindTextures<T>(int first, int count, T[] textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = textures) Capabilities.nglBindTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindTextures(int first, int count, int[] textures)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					Capabilities.nglBindTextures(first, count, texturesPtr);
				}
			}
		}
		
		public static void glBindSamplers(int first, int count, IntPtr samplers)
		{
			unsafe
			{
				Capabilities.nglBindSamplers(first, count, (int*)samplers.ToPointer());
			}
		}
		
		public static void glBindSamplers(int first, int count, ref int samplers)
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglBindSamplers(first, count, (int*)ptr);
			}
		}
		
		public static void glBindSamplers<T>(int first, int count, ref T samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglBindSamplers(first, count, (int*)ptr);
			}
		}
		
		public static void glBindSamplers<T>(int first, int count, T[] samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = samplers) Capabilities.nglBindSamplers(first, count, (int*)ptr);
			}
		}
		
		public static void glBindSamplers(int first, int count, int[] samplers)
		{
			unsafe
			{
				fixed (int* samplersPtr = samplers)
				{
					Capabilities.nglBindSamplers(first, count, samplersPtr);
				}
			}
		}
		
		public static void glBindImageTextures(int first, int count, IntPtr textures)
		{
			unsafe
			{
				Capabilities.nglBindImageTextures(first, count, (int*)textures.ToPointer());
			}
		}
		
		public static void glBindImageTextures(int first, int count, ref int textures)
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglBindImageTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindImageTextures<T>(int first, int count, ref T textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglBindImageTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindImageTextures<T>(int first, int count, T[] textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = textures) Capabilities.nglBindImageTextures(first, count, (int*)ptr);
			}
		}
		
		public static void glBindImageTextures(int first, int count, int[] textures)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					Capabilities.nglBindImageTextures(first, count, texturesPtr);
				}
			}
		}
		
		public static void glBindVertexBuffers(int first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides)
		{
			unsafe
			{
				Capabilities.nglBindVertexBuffers(first, count, (int*)buffers.ToPointer(), (IntPtr*)offsets.ToPointer(), (int*)strides.ToPointer());
			}
		}
		
		public static void glBindVertexBuffers(int first, int count, int[] buffers, IntPtr[] offsets, int[] strides)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					fixed (IntPtr* offsetsPtr = offsets)
					{
						fixed (int* stridesPtr = strides)
						{
							Capabilities.nglBindVertexBuffers(first, count, buffersPtr, offsetsPtr, stridesPtr);
						}
					}
				}
			}
		}
		
		
	}
}
