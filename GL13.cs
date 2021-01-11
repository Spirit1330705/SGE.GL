using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_TEXTURE0 = 0x84C0;
		public const int GL_TEXTURE1 = 0x84C1;
		public const int GL_TEXTURE2 = 0x84C2;
		public const int GL_TEXTURE3 = 0x84C3;
		public const int GL_TEXTURE4 = 0x84C4;
		public const int GL_TEXTURE5 = 0x84C5;
		public const int GL_TEXTURE6 = 0x84C6;
		public const int GL_TEXTURE7 = 0x84C7;
		public const int GL_TEXTURE8 = 0x84C8;
		public const int GL_TEXTURE9 = 0x84C9;
		public const int GL_TEXTURE10 = 0x84CA;
		public const int GL_TEXTURE11 = 0x84CB;
		public const int GL_TEXTURE12 = 0x84CC;
		public const int GL_TEXTURE13 = 0x84CD;
		public const int GL_TEXTURE14 = 0x84CE;
		public const int GL_TEXTURE15 = 0x84CF;
		public const int GL_TEXTURE16 = 0x84D0;
		public const int GL_TEXTURE17 = 0x84D1;
		public const int GL_TEXTURE18 = 0x84D2;
		public const int GL_TEXTURE19 = 0x84D3;
		public const int GL_TEXTURE20 = 0x84D4;
		public const int GL_TEXTURE21 = 0x84D5;
		public const int GL_TEXTURE22 = 0x84D6;
		public const int GL_TEXTURE23 = 0x84D7;
		public const int GL_TEXTURE24 = 0x84D8;
		public const int GL_TEXTURE25 = 0x84D9;
		public const int GL_TEXTURE26 = 0x84DA;
		public const int GL_TEXTURE27 = 0x84DB;
		public const int GL_TEXTURE28 = 0x84DC;
		public const int GL_TEXTURE29 = 0x84DD;
		public const int GL_TEXTURE30 = 0x84DE;
		public const int GL_TEXTURE31 = 0x84DF;
		public const int GL_ACTIVE_TEXTURE = 0x84E0;
		public const int GL_MULTISAMPLE = 0x809D;
		public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const int GL_SAMPLE_COVERAGE = 0x80A0;
		public const int GL_SAMPLE_BUFFERS = 0x80A8;
		public const int GL_SAMPLES = 0x80A9;
		public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const int GL_TEXTURE_CUBE_MAP = 0x8513;
		public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const int GL_COMPRESSED_RGB = 0x84ED;
		public const int GL_COMPRESSED_RGBA = 0x84EE;
		public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const int GL_TEXTURE_COMPRESSED = 0x86A1;
		public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const int GL_CLAMP_TO_BORDER = 0x812D;
		public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
		public const int GL_MAX_TEXTURE_UNITS = 0x84E2;
		public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
		public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
		public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
		public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
		public const int GL_MULTISAMPLE_BIT = 0x20000000;
		public const int GL_NORMAL_MAP = 0x8511;
		public const int GL_REFLECTION_MAP = 0x8512;
		public const int GL_COMPRESSED_ALPHA = 0x84E9;
		public const int GL_COMPRESSED_LUMINANCE = 0x84EA;
		public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
		public const int GL_COMPRESSED_INTENSITY = 0x84EC;
		public const int GL_COMBINE = 0x8570;
		public const int GL_COMBINE_RGB = 0x8571;
		public const int GL_COMBINE_ALPHA = 0x8572;
		public const int GL_SOURCE0_RGB = 0x8580;
		public const int GL_SOURCE1_RGB = 0x8581;
		public const int GL_SOURCE2_RGB = 0x8582;
		public const int GL_SOURCE0_ALPHA = 0x8588;
		public const int GL_SOURCE1_ALPHA = 0x8589;
		public const int GL_SOURCE2_ALPHA = 0x858A;
		public const int GL_OPERAND0_RGB = 0x8590;
		public const int GL_OPERAND1_RGB = 0x8591;
		public const int GL_OPERAND2_RGB = 0x8592;
		public const int GL_OPERAND0_ALPHA = 0x8598;
		public const int GL_OPERAND1_ALPHA = 0x8599;
		public const int GL_OPERAND2_ALPHA = 0x859A;
		public const int GL_RGB_SCALE = 0x8573;
		public const int GL_ADD_SIGNED = 0x8574;
		public const int GL_INTERPOLATE = 0x8575;
		public const int GL_SUBTRACT = 0x84E7;
		public const int GL_CONSTANT = 0x8576;
		public const int GL_PRIMARY_COLOR = 0x8577;
		public const int GL_PREVIOUS = 0x8578;
		public const int GL_DOT3_RGB = 0x86AE;
		public const int GL_DOT3_RGBA = 0x86AF;
		#endregion // Constants
		
		public static void glActiveTexture(int texture) =>
			Capabilities.nglActiveTexture(texture);
		
		public static void glSampleCoverage(float value, byte invert) =>
			Capabilities.nglSampleCoverage(value, invert);
		
		public static void glCompressedTexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTexImage1D(int target, int level, int internalformat, int width, int border, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTexSubImage1D(int target, int level, int xoffset, int width, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glGetCompressedTexImage(int target, int level, IntPtr img)
		{
			unsafe
			{
				Capabilities.nglGetCompressedTexImage(target, level, img.ToPointer());
			}
		}
		
		public static void glClientActiveTexture(int texture) =>
			Capabilities.nglClientActiveTexture(texture);
		
		public static void glMultiTexCoord1d(int target, double s) =>
			Capabilities.nglMultiTexCoord1d(target, s);
		
		public static void glMultiTexCoord1dv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord1dv(target, (double*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord1dv(int target, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord1dv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord1dv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord1dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord1dv(int target, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglMultiTexCoord1dv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord1f(int target, float s) =>
			Capabilities.nglMultiTexCoord1f(target, s);
		
		public static void glMultiTexCoord1fv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord1fv(target, (float*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord1fv(int target, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord1fv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord1fv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord1fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord1fv(int target, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglMultiTexCoord1fv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord1i(int target, int s) =>
			Capabilities.nglMultiTexCoord1i(target, s);
		
		public static void glMultiTexCoord1iv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord1iv(target, (int*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord1iv(int target, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord1iv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord1iv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord1iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord1iv(int target, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglMultiTexCoord1iv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord1s(int target, short s) =>
			Capabilities.nglMultiTexCoord1s(target, s);
		
		public static void glMultiTexCoord1sv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord1sv(target, (short*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord1sv(int target, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord1sv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord1sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord1sv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord1sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord1sv(int target, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglMultiTexCoord1sv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord2d(int target, double s, double t) =>
			Capabilities.nglMultiTexCoord2d(target, s, t);
		
		public static void glMultiTexCoord2dv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord2dv(target, (double*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord2dv(int target, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord2dv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord2dv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord2dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord2dv(int target, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglMultiTexCoord2dv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord2f(int target, float s, float t) =>
			Capabilities.nglMultiTexCoord2f(target, s, t);
		
		public static void glMultiTexCoord2fv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord2fv(target, (float*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord2fv(int target, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord2fv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord2fv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord2fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord2fv(int target, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglMultiTexCoord2fv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord2i(int target, int s, int t) =>
			Capabilities.nglMultiTexCoord2i(target, s, t);
		
		public static void glMultiTexCoord2iv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord2iv(target, (int*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord2iv(int target, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord2iv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord2iv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord2iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord2iv(int target, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglMultiTexCoord2iv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord2s(int target, short s, short t) =>
			Capabilities.nglMultiTexCoord2s(target, s, t);
		
		public static void glMultiTexCoord2sv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord2sv(target, (short*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord2sv(int target, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord2sv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord2sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord2sv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord2sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord2sv(int target, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglMultiTexCoord2sv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord3d(int target, double s, double t, double r) =>
			Capabilities.nglMultiTexCoord3d(target, s, t, r);
		
		public static void glMultiTexCoord3dv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord3dv(target, (double*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord3dv(int target, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord3dv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord3dv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord3dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord3dv(int target, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglMultiTexCoord3dv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord3f(int target, float s, float t, float r) =>
			Capabilities.nglMultiTexCoord3f(target, s, t, r);
		
		public static void glMultiTexCoord3fv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord3fv(target, (float*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord3fv(int target, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord3fv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord3fv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord3fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord3fv(int target, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglMultiTexCoord3fv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord3i(int target, int s, int t, int r) =>
			Capabilities.nglMultiTexCoord3i(target, s, t, r);
		
		public static void glMultiTexCoord3iv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord3iv(target, (int*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord3iv(int target, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord3iv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord3iv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord3iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord3iv(int target, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglMultiTexCoord3iv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord3s(int target, short s, short t, short r) =>
			Capabilities.nglMultiTexCoord3s(target, s, t, r);
		
		public static void glMultiTexCoord3sv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord3sv(target, (short*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord3sv(int target, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord3sv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord3sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord3sv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord3sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord3sv(int target, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglMultiTexCoord3sv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord4d(int target, double s, double t, double r, double q) =>
			Capabilities.nglMultiTexCoord4d(target, s, t, r, q);
		
		public static void glMultiTexCoord4dv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord4dv(target, (double*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord4dv(int target, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord4dv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord4dv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord4dv(target, (double*)ptr);
			}
		}
		
		public static void glMultiTexCoord4dv(int target, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglMultiTexCoord4dv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord4f(int target, float s, float t, float r, float q) =>
			Capabilities.nglMultiTexCoord4f(target, s, t, r, q);
		
		public static void glMultiTexCoord4fv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord4fv(target, (float*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord4fv(int target, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord4fv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord4fv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord4fv(target, (float*)ptr);
			}
		}
		
		public static void glMultiTexCoord4fv(int target, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglMultiTexCoord4fv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord4i(int target, int s, int t, int r, int q) =>
			Capabilities.nglMultiTexCoord4i(target, s, t, r, q);
		
		public static void glMultiTexCoord4iv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord4iv(target, (int*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord4iv(int target, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord4iv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord4iv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord4iv(target, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoord4iv(int target, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglMultiTexCoord4iv(target, vPtr);
				}
			}
		}
		
		public static void glMultiTexCoord4s(int target, short s, short t, short r, short q) =>
			Capabilities.nglMultiTexCoord4s(target, s, t, r, q);
		
		public static void glMultiTexCoord4sv(int target, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoord4sv(target, (short*)v.ToPointer());
			}
		}
		
		public static void glMultiTexCoord4sv(int target, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord4sv<T>(int target, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglMultiTexCoord4sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord4sv<T>(int target, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglMultiTexCoord4sv(target, (short*)ptr);
			}
		}
		
		public static void glMultiTexCoord4sv(int target, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglMultiTexCoord4sv(target, vPtr);
				}
			}
		}
		
		public static void glLoadTransposeMatrixf(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglLoadTransposeMatrixf((float*)m.ToPointer());
			}
		}
		
		public static void glLoadTransposeMatrixf(ref float m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixf<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixf<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglLoadTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixf(float[] m)
		{
			unsafe
			{
				fixed (float* mPtr = m)
				{
					Capabilities.nglLoadTransposeMatrixf(mPtr);
				}
			}
		}
		
		public static void glLoadTransposeMatrixd(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglLoadTransposeMatrixd((double*)m.ToPointer());
			}
		}
		
		public static void glLoadTransposeMatrixd(ref double m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixd<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixd<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglLoadTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadTransposeMatrixd(double[] m)
		{
			unsafe
			{
				fixed (double* mPtr = m)
				{
					Capabilities.nglLoadTransposeMatrixd(mPtr);
				}
			}
		}
		
		public static void glMultTransposeMatrixf(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglMultTransposeMatrixf((float*)m.ToPointer());
			}
		}
		
		public static void glMultTransposeMatrixf(ref float m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixf<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixf<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglMultTransposeMatrixf((float*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixf(float[] m)
		{
			unsafe
			{
				fixed (float* mPtr = m)
				{
					Capabilities.nglMultTransposeMatrixf(mPtr);
				}
			}
		}
		
		public static void glMultTransposeMatrixd(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglMultTransposeMatrixd((double*)m.ToPointer());
			}
		}
		
		public static void glMultTransposeMatrixd(ref double m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixd<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixd<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglMultTransposeMatrixd((double*)ptr);
			}
		}
		
		public static void glMultTransposeMatrixd(double[] m)
		{
			unsafe
			{
				fixed (double* mPtr = m)
				{
					Capabilities.nglMultTransposeMatrixd(mPtr);
				}
			}
		}
		
		
	}
}
