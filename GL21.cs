using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_PIXEL_PACK_BUFFER = 0x88EB;
		public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;
		public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const int GL_FLOAT_MAT2x3 = 0x8B65;
		public const int GL_FLOAT_MAT2x4 = 0x8B66;
		public const int GL_FLOAT_MAT3x2 = 0x8B67;
		public const int GL_FLOAT_MAT3x4 = 0x8B68;
		public const int GL_FLOAT_MAT4x2 = 0x8B69;
		public const int GL_FLOAT_MAT4x3 = 0x8B6A;
		public const int GL_SRGB = 0x8C40;
		public const int GL_SRGB8 = 0x8C41;
		public const int GL_SRGB_ALPHA = 0x8C42;
		public const int GL_SRGB8_ALPHA8 = 0x8C43;
		public const int GL_COMPRESSED_SRGB = 0x8C48;
		public const int GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const int GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
		public const int GL_SLUMINANCE_ALPHA = 0x8C44;
		public const int GL_SLUMINANCE8_ALPHA8 = 0x8C45;
		public const int GL_SLUMINANCE = 0x8C46;
		public const int GL_SLUMINANCE8 = 0x8C47;
		public const int GL_COMPRESSED_SLUMINANCE = 0x8C4A;
		public const int GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
		#endregion // Constants
		
		public static void glUniformMatrix2x3fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2x3fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2x3fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x3fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2x3fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3x2fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3x2fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3x2fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x2fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3x2fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix2x4fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2x4fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2x4fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2x4fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2x4fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4x2fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4x2fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4x2fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4x2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x2fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4x2fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3x4fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3x4fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3x4fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3x4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3x4fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3x4fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4x3fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4x3fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4x3fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4x3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4x3fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4x3fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		
	}
}
