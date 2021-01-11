using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_BLEND_DST_RGB = 0x80C8;
		public const int GL_BLEND_SRC_RGB = 0x80C9;
		public const int GL_BLEND_DST_ALPHA = 0x80CA;
		public const int GL_BLEND_SRC_ALPHA = 0x80CB;
		public const int GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const int GL_DEPTH_COMPONENT16 = 0x81A5;
		public const int GL_DEPTH_COMPONENT24 = 0x81A6;
		public const int GL_DEPTH_COMPONENT32 = 0x81A7;
		public const int GL_MIRRORED_REPEAT = 0x8370;
		public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const int GL_TEXTURE_LOD_BIAS = 0x8501;
		public const int GL_INCR_WRAP = 0x8507;
		public const int GL_DECR_WRAP = 0x8508;
		public const int GL_TEXTURE_DEPTH_SIZE = 0x884A;
		public const int GL_TEXTURE_COMPARE_MODE = 0x884C;
		public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;
		public const int GL_POINT_SIZE_MIN = 0x8126;
		public const int GL_POINT_SIZE_MAX = 0x8127;
		public const int GL_POINT_DISTANCE_ATTENUATION = 0x8129;
		public const int GL_GENERATE_MIPMAP = 0x8191;
		public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
		public const int GL_FOG_COORDINATE_SOURCE = 0x8450;
		public const int GL_FOG_COORDINATE = 0x8451;
		public const int GL_FRAGMENT_DEPTH = 0x8452;
		public const int GL_CURRENT_FOG_COORDINATE = 0x8453;
		public const int GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
		public const int GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
		public const int GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
		public const int GL_FOG_COORDINATE_ARRAY = 0x8457;
		public const int GL_COLOR_SUM = 0x8458;
		public const int GL_CURRENT_SECONDARY_COLOR = 0x8459;
		public const int GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
		public const int GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
		public const int GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
		public const int GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
		public const int GL_SECONDARY_COLOR_ARRAY = 0x845E;
		public const int GL_TEXTURE_FILTER_CONTROL = 0x8500;
		public const int GL_DEPTH_TEXTURE_MODE = 0x884B;
		public const int GL_COMPARE_R_TO_TEXTURE = 0x884E;
		public const int GL_BLEND_COLOR = 0x8005;
		public const int GL_BLEND_EQUATION = 0x8009;
		public const int GL_CONSTANT_COLOR = 0x8001;
		public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const int GL_CONSTANT_ALPHA = 0x8003;
		public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const int GL_FUNC_ADD = 0x8006;
		public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const int GL_FUNC_SUBTRACT = 0x800A;
		public const int GL_MIN = 0x8007;
		public const int GL_MAX = 0x8008;
		#endregion // Constants
		
		public static void glBlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha) =>
			Capabilities.nglBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		
		public static void glMultiDrawArrays(int mode, IntPtr first, IntPtr count, int drawcount)
		{
			unsafe
			{
				Capabilities.nglMultiDrawArrays(mode, (int*)first.ToPointer(), (int*)count.ToPointer(), drawcount);
			}
		}
		
		public static void glMultiDrawArrays(int mode, int[] first, int[] count, int drawcount)
		{
			unsafe
			{
				fixed (int* firstPtr = first)
				{
					fixed (int* countPtr = count)
					{
						Capabilities.nglMultiDrawArrays(mode, firstPtr, countPtr, drawcount);
					}
				}
			}
		}
		
		public static void glMultiDrawElements(int mode, IntPtr count, int type, IntPtr indices, int drawcount)
		{
			unsafe
			{
				Capabilities.nglMultiDrawElements(mode, (int*)count.ToPointer(), type, (void**)indices.ToPointer(), drawcount);
			}
		}
		
		public static void glPointParameterf(int pname, float param) =>
			Capabilities.nglPointParameterf(pname, param);
		
		public static void glPointParameterfv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglPointParameterfv(pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glPointParameterfv(int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglPointParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPointParameterfv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglPointParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPointParameterfv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglPointParameterfv(pname, (float*)ptr);
			}
		}
		
		public static void glPointParameterfv(int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglPointParameterfv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glPointParameteri(int pname, int param) =>
			Capabilities.nglPointParameteri(pname, param);
		
		public static void glPointParameteriv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglPointParameteriv(pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glPointParameteriv(int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglPointParameteriv(pname, (int*)ptr);
			}
		}
		
		public static void glPointParameteriv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglPointParameteriv(pname, (int*)ptr);
			}
		}
		
		public static void glPointParameteriv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglPointParameteriv(pname, (int*)ptr);
			}
		}
		
		public static void glPointParameteriv(int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglPointParameteriv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glFogCoordf(float coord) =>
			Capabilities.nglFogCoordf(coord);
		
		public static void glFogCoordfv(IntPtr coord)
		{
			unsafe
			{
				Capabilities.nglFogCoordfv((float*)coord.ToPointer());
			}
		}
		
		public static void glFogCoordfv(ref float coord)
		{
			unsafe
			{
				fixed (void* ptr = &coord) Capabilities.nglFogCoordfv((float*)ptr);
			}
		}
		
		public static void glFogCoordfv<T>(ref T coord) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coord) Capabilities.nglFogCoordfv((float*)ptr);
			}
		}
		
		public static void glFogCoordfv<T>(T[] coord) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coord) Capabilities.nglFogCoordfv((float*)ptr);
			}
		}
		
		public static void glFogCoordfv(float[] coord)
		{
			unsafe
			{
				fixed (float* coordPtr = coord)
				{
					Capabilities.nglFogCoordfv(coordPtr);
				}
			}
		}
		
		public static void glFogCoordd(double coord) =>
			Capabilities.nglFogCoordd(coord);
		
		public static void glFogCoorddv(IntPtr coord)
		{
			unsafe
			{
				Capabilities.nglFogCoorddv((double*)coord.ToPointer());
			}
		}
		
		public static void glFogCoorddv(ref double coord)
		{
			unsafe
			{
				fixed (void* ptr = &coord) Capabilities.nglFogCoorddv((double*)ptr);
			}
		}
		
		public static void glFogCoorddv<T>(ref T coord) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coord) Capabilities.nglFogCoorddv((double*)ptr);
			}
		}
		
		public static void glFogCoorddv<T>(T[] coord) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coord) Capabilities.nglFogCoorddv((double*)ptr);
			}
		}
		
		public static void glFogCoorddv(double[] coord)
		{
			unsafe
			{
				fixed (double* coordPtr = coord)
				{
					Capabilities.nglFogCoorddv(coordPtr);
				}
			}
		}
		
		public static void glFogCoordPointer(int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglFogCoordPointer(type, stride, pointer.ToPointer());
			}
		}
		
		public static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) =>
			Capabilities.nglSecondaryColor3b(red, green, blue);
		
		public static void glSecondaryColor3bv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3bv((sbyte*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3bv(ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glSecondaryColor3bv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glSecondaryColor3bv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glSecondaryColor3bv(sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglSecondaryColor3bv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3d(double red, double green, double blue) =>
			Capabilities.nglSecondaryColor3d(red, green, blue);
		
		public static void glSecondaryColor3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3dv((double*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3dv((double*)ptr);
			}
		}
		
		public static void glSecondaryColor3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3dv((double*)ptr);
			}
		}
		
		public static void glSecondaryColor3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3dv((double*)ptr);
			}
		}
		
		public static void glSecondaryColor3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglSecondaryColor3dv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3f(float red, float green, float blue) =>
			Capabilities.nglSecondaryColor3f(red, green, blue);
		
		public static void glSecondaryColor3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3fv((float*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3fv((float*)ptr);
			}
		}
		
		public static void glSecondaryColor3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3fv((float*)ptr);
			}
		}
		
		public static void glSecondaryColor3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3fv((float*)ptr);
			}
		}
		
		public static void glSecondaryColor3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglSecondaryColor3fv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3i(int red, int green, int blue) =>
			Capabilities.nglSecondaryColor3i(red, green, blue);
		
		public static void glSecondaryColor3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3iv((int*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3iv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3iv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3iv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglSecondaryColor3iv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3s(short red, short green, short blue) =>
			Capabilities.nglSecondaryColor3s(red, green, blue);
		
		public static void glSecondaryColor3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3sv((short*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3sv((short*)ptr);
			}
		}
		
		public static void glSecondaryColor3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3sv((short*)ptr);
			}
		}
		
		public static void glSecondaryColor3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3sv((short*)ptr);
			}
		}
		
		public static void glSecondaryColor3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglSecondaryColor3sv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3ub(byte red, byte green, byte blue) =>
			Capabilities.nglSecondaryColor3ub(red, green, blue);
		
		public static void glSecondaryColor3ubv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3ubv((byte*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3ubv(ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3ubv((byte*)ptr);
			}
		}
		
		public static void glSecondaryColor3ubv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3ubv((byte*)ptr);
			}
		}
		
		public static void glSecondaryColor3ubv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3ubv((byte*)ptr);
			}
		}
		
		public static void glSecondaryColor3ubv(byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglSecondaryColor3ubv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3ui(int red, int green, int blue) =>
			Capabilities.nglSecondaryColor3ui(red, green, blue);
		
		public static void glSecondaryColor3uiv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3uiv((int*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3uiv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3uiv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3uiv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3uiv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3uiv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3uiv((int*)ptr);
			}
		}
		
		public static void glSecondaryColor3uiv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglSecondaryColor3uiv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColor3us(ushort red, ushort green, ushort blue) =>
			Capabilities.nglSecondaryColor3us(red, green, blue);
		
		public static void glSecondaryColor3usv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglSecondaryColor3usv((ushort*)v.ToPointer());
			}
		}
		
		public static void glSecondaryColor3usv(ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3usv((ushort*)ptr);
			}
		}
		
		public static void glSecondaryColor3usv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglSecondaryColor3usv((ushort*)ptr);
			}
		}
		
		public static void glSecondaryColor3usv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglSecondaryColor3usv((ushort*)ptr);
			}
		}
		
		public static void glSecondaryColor3usv(ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglSecondaryColor3usv(vPtr);
				}
			}
		}
		
		public static void glSecondaryColorPointer(int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglSecondaryColorPointer(size, type, stride, pointer.ToPointer());
			}
		}
		
		public static void glWindowPos2d(double x, double y) =>
			Capabilities.nglWindowPos2d(x, y);
		
		public static void glWindowPos2dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos2dv((double*)v.ToPointer());
			}
		}
		
		public static void glWindowPos2dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2dv((double*)ptr);
			}
		}
		
		public static void glWindowPos2dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2dv((double*)ptr);
			}
		}
		
		public static void glWindowPos2dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos2dv((double*)ptr);
			}
		}
		
		public static void glWindowPos2dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglWindowPos2dv(vPtr);
				}
			}
		}
		
		public static void glWindowPos2f(float x, float y) =>
			Capabilities.nglWindowPos2f(x, y);
		
		public static void glWindowPos2fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos2fv((float*)v.ToPointer());
			}
		}
		
		public static void glWindowPos2fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2fv((float*)ptr);
			}
		}
		
		public static void glWindowPos2fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2fv((float*)ptr);
			}
		}
		
		public static void glWindowPos2fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos2fv((float*)ptr);
			}
		}
		
		public static void glWindowPos2fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglWindowPos2fv(vPtr);
				}
			}
		}
		
		public static void glWindowPos2i(int x, int y) =>
			Capabilities.nglWindowPos2i(x, y);
		
		public static void glWindowPos2iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos2iv((int*)v.ToPointer());
			}
		}
		
		public static void glWindowPos2iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2iv((int*)ptr);
			}
		}
		
		public static void glWindowPos2iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2iv((int*)ptr);
			}
		}
		
		public static void glWindowPos2iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos2iv((int*)ptr);
			}
		}
		
		public static void glWindowPos2iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglWindowPos2iv(vPtr);
				}
			}
		}
		
		public static void glWindowPos2s(short x, short y) =>
			Capabilities.nglWindowPos2s(x, y);
		
		public static void glWindowPos2sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos2sv((short*)v.ToPointer());
			}
		}
		
		public static void glWindowPos2sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2sv((short*)ptr);
			}
		}
		
		public static void glWindowPos2sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos2sv((short*)ptr);
			}
		}
		
		public static void glWindowPos2sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos2sv((short*)ptr);
			}
		}
		
		public static void glWindowPos2sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglWindowPos2sv(vPtr);
				}
			}
		}
		
		public static void glWindowPos3d(double x, double y, double z) =>
			Capabilities.nglWindowPos3d(x, y, z);
		
		public static void glWindowPos3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos3dv((double*)v.ToPointer());
			}
		}
		
		public static void glWindowPos3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3dv((double*)ptr);
			}
		}
		
		public static void glWindowPos3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3dv((double*)ptr);
			}
		}
		
		public static void glWindowPos3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos3dv((double*)ptr);
			}
		}
		
		public static void glWindowPos3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglWindowPos3dv(vPtr);
				}
			}
		}
		
		public static void glWindowPos3f(float x, float y, float z) =>
			Capabilities.nglWindowPos3f(x, y, z);
		
		public static void glWindowPos3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos3fv((float*)v.ToPointer());
			}
		}
		
		public static void glWindowPos3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3fv((float*)ptr);
			}
		}
		
		public static void glWindowPos3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3fv((float*)ptr);
			}
		}
		
		public static void glWindowPos3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos3fv((float*)ptr);
			}
		}
		
		public static void glWindowPos3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglWindowPos3fv(vPtr);
				}
			}
		}
		
		public static void glWindowPos3i(int x, int y, int z) =>
			Capabilities.nglWindowPos3i(x, y, z);
		
		public static void glWindowPos3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos3iv((int*)v.ToPointer());
			}
		}
		
		public static void glWindowPos3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3iv((int*)ptr);
			}
		}
		
		public static void glWindowPos3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3iv((int*)ptr);
			}
		}
		
		public static void glWindowPos3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos3iv((int*)ptr);
			}
		}
		
		public static void glWindowPos3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglWindowPos3iv(vPtr);
				}
			}
		}
		
		public static void glWindowPos3s(short x, short y, short z) =>
			Capabilities.nglWindowPos3s(x, y, z);
		
		public static void glWindowPos3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglWindowPos3sv((short*)v.ToPointer());
			}
		}
		
		public static void glWindowPos3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3sv((short*)ptr);
			}
		}
		
		public static void glWindowPos3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglWindowPos3sv((short*)ptr);
			}
		}
		
		public static void glWindowPos3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglWindowPos3sv((short*)ptr);
			}
		}
		
		public static void glWindowPos3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglWindowPos3sv(vPtr);
				}
			}
		}
		
		public static void glBlendColor(float red, float green, float blue, float alpha) =>
			Capabilities.nglBlendColor(red, green, blue, alpha);
		
		public static void glBlendEquation(int mode) =>
			Capabilities.nglBlendEquation(mode);
		
		
	}
}
