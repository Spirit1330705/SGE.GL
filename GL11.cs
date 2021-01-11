using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_COLOR_LOGIC_OP = 0x0BF2;
		public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
		public const int GL_POLYGON_OFFSET_POINT = 0x2A01;
		public const int GL_POLYGON_OFFSET_LINE = 0x2A02;
		public const int GL_POLYGON_OFFSET_FILL = 0x8037;
		public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
		public const int GL_TEXTURE_BINDING_1D = 0x8068;
		public const int GL_TEXTURE_BINDING_2D = 0x8069;
		public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const int GL_TEXTURE_RED_SIZE = 0x805C;
		public const int GL_TEXTURE_GREEN_SIZE = 0x805D;
		public const int GL_TEXTURE_BLUE_SIZE = 0x805E;
		public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;
		public const int GL_DOUBLE = 0x140A;
		public const int GL_PROXY_TEXTURE_1D = 0x8063;
		public const int GL_PROXY_TEXTURE_2D = 0x8064;
		public const int GL_R3_G3_B2 = 0x2A10;
		public const int GL_RGB4 = 0x804F;
		public const int GL_RGB5 = 0x8050;
		public const int GL_RGB8 = 0x8051;
		public const int GL_RGB10 = 0x8052;
		public const int GL_RGB12 = 0x8053;
		public const int GL_RGB16 = 0x8054;
		public const int GL_RGBA2 = 0x8055;
		public const int GL_RGBA4 = 0x8056;
		public const int GL_RGB5_A1 = 0x8057;
		public const int GL_RGBA8 = 0x8058;
		public const int GL_RGB10_A2 = 0x8059;
		public const int GL_RGBA12 = 0x805A;
		public const int GL_RGBA16 = 0x805B;
		public const int GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
		public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
		public const int GL_CLIENT_ALL_ATTRIB_BITS = -1;
		public const int GL_VERTEX_ARRAY_POINTER = 0x808E;
		public const int GL_NORMAL_ARRAY_POINTER = 0x808F;
		public const int GL_COLOR_ARRAY_POINTER = 0x8090;
		public const int GL_INDEX_ARRAY_POINTER = 0x8091;
		public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
		public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
		public const int GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
		public const int GL_SELECTION_BUFFER_POINTER = 0x0DF3;
		public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
		public const int GL_INDEX_LOGIC_OP = 0x0BF1;
		public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
		public const int GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
		public const int GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
		public const int GL_SELECTION_BUFFER_SIZE = 0x0DF4;
		public const int GL_VERTEX_ARRAY = 0x8074;
		public const int GL_NORMAL_ARRAY = 0x8075;
		public const int GL_COLOR_ARRAY = 0x8076;
		public const int GL_INDEX_ARRAY = 0x8077;
		public const int GL_TEXTURE_COORD_ARRAY = 0x8078;
		public const int GL_EDGE_FLAG_ARRAY = 0x8079;
		public const int GL_VERTEX_ARRAY_SIZE = 0x807A;
		public const int GL_VERTEX_ARRAY_TYPE = 0x807B;
		public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;
		public const int GL_NORMAL_ARRAY_TYPE = 0x807E;
		public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;
		public const int GL_COLOR_ARRAY_SIZE = 0x8081;
		public const int GL_COLOR_ARRAY_TYPE = 0x8082;
		public const int GL_COLOR_ARRAY_STRIDE = 0x8083;
		public const int GL_INDEX_ARRAY_TYPE = 0x8085;
		public const int GL_INDEX_ARRAY_STRIDE = 0x8086;
		public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
		public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
		public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
		public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
		public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
		public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;
		public const int GL_TEXTURE_PRIORITY = 0x8066;
		public const int GL_TEXTURE_RESIDENT = 0x8067;
		public const int GL_ALPHA4 = 0x803B;
		public const int GL_ALPHA8 = 0x803C;
		public const int GL_ALPHA12 = 0x803D;
		public const int GL_ALPHA16 = 0x803E;
		public const int GL_LUMINANCE4 = 0x803F;
		public const int GL_LUMINANCE8 = 0x8040;
		public const int GL_LUMINANCE12 = 0x8041;
		public const int GL_LUMINANCE16 = 0x8042;
		public const int GL_LUMINANCE4_ALPHA4 = 0x8043;
		public const int GL_LUMINANCE6_ALPHA2 = 0x8044;
		public const int GL_LUMINANCE8_ALPHA8 = 0x8045;
		public const int GL_LUMINANCE12_ALPHA4 = 0x8046;
		public const int GL_LUMINANCE12_ALPHA12 = 0x8047;
		public const int GL_LUMINANCE16_ALPHA16 = 0x8048;
		public const int GL_INTENSITY = 0x8049;
		public const int GL_INTENSITY4 = 0x804A;
		public const int GL_INTENSITY8 = 0x804B;
		public const int GL_INTENSITY12 = 0x804C;
		public const int GL_INTENSITY16 = 0x804D;
		public const int GL_V2F = 0x2A20;
		public const int GL_V3F = 0x2A21;
		public const int GL_C4UB_V2F = 0x2A22;
		public const int GL_C4UB_V3F = 0x2A23;
		public const int GL_C3F_V3F = 0x2A24;
		public const int GL_N3F_V3F = 0x2A25;
		public const int GL_C4F_N3F_V3F = 0x2A26;
		public const int GL_T2F_V3F = 0x2A27;
		public const int GL_T4F_V4F = 0x2A28;
		public const int GL_T2F_C4UB_V3F = 0x2A29;
		public const int GL_T2F_C3F_V3F = 0x2A2A;
		public const int GL_T2F_N3F_V3F = 0x2A2B;
		public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;
		public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;
		#endregion // Constants
		
		public static void glDrawArrays(int mode, int first, int count) =>
			Capabilities.nglDrawArrays(mode, first, count);
		
		public static void glDrawElements(int mode, int count, int type, IntPtr indices)
		{
			unsafe
			{
				Capabilities.nglDrawElements(mode, count, type, indices.ToPointer());
			}
		}
		
		public static void glGetPointerv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetPointerv(pname, (void**)_params.ToPointer());
			}
		}
		
		public static void glPolygonOffset(float factor, float units) =>
			Capabilities.nglPolygonOffset(factor, units);
		
		public static void glCopyTexImage1D(int target, int level, int internalformat, int x, int y, int width, int border) =>
			Capabilities.nglCopyTexImage1D(target, level, internalformat, x, y, width, border);
		
		public static void glCopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) =>
			Capabilities.nglCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		
		public static void glCopyTexSubImage1D(int target, int level, int xoffset, int x, int y, int width) =>
			Capabilities.nglCopyTexSubImage1D(target, level, xoffset, x, y, width);
		
		public static void glCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height) =>
			Capabilities.nglCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		
		public static void glTexSubImage1D(int target, int level, int xoffset, int width, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTexSubImage1D(target, level, xoffset, width, format, type, pixels.ToPointer());
			}
		}
		
		public static void glTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
			}
		}
		
		public static void glBindTexture(int target, int texture) =>
			Capabilities.nglBindTexture(target, texture);
		
		public static void glDeleteTextures(int n, IntPtr textures)
		{
			unsafe
			{
				Capabilities.nglDeleteTextures(n, (int*)textures.ToPointer());
			}
		}
		
		public static void glDeleteTextures(int n, ref int textures)
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglDeleteTextures(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTextures<T>(int n, ref T textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglDeleteTextures(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTextures<T>(int n, T[] textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = textures) Capabilities.nglDeleteTextures(n, (int*)ptr);
			}
		}
		
		public static void glDeleteTextures(int n, int[] textures)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					Capabilities.nglDeleteTextures(n, texturesPtr);
				}
			}
		}
		
		public static void glDeleteTextures(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteTextures(1, &name);
			}
		}
		
		public static void glDeleteTextures(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteTextures(names.Length, ptr);
			}
		}
		
		public static void glGenTextures(int n, IntPtr textures)
		{
			unsafe
			{
				Capabilities.nglGenTextures(n, (int*)textures.ToPointer());
			}
		}
		
		public static void glGenTextures(int n, ref int textures)
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglGenTextures(n, (int*)ptr);
			}
		}
		
		public static void glGenTextures<T>(int n, ref T textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglGenTextures(n, (int*)ptr);
			}
		}
		
		public static void glGenTextures<T>(int n, T[] textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = textures) Capabilities.nglGenTextures(n, (int*)ptr);
			}
		}
		
		public static void glGenTextures(int n, int[] textures)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					Capabilities.nglGenTextures(n, texturesPtr);
				}
			}
		}
		
		public static int glGenTextures()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenTextures(1, &val);
				return val;
			}
		}
		
		public static void glGenTextures(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenTextures(names.Length, ptr);
			}
		}
		
		public static byte glIsTexture(int texture) =>
			Capabilities.nglIsTexture(texture);
		
		public static void glArrayElement(int i) =>
			Capabilities.nglArrayElement(i);
		
		public static void glColorPointer(int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglColorPointer(size, type, stride, pointer.ToPointer());
			}
		}
		
		public static void glDisableClientState(int array) =>
			Capabilities.nglDisableClientState(array);
		
		public static void glEdgeFlagPointer(int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglEdgeFlagPointer(stride, pointer.ToPointer());
			}
		}
		
		public static void glEnableClientState(int array) =>
			Capabilities.nglEnableClientState(array);
		
		public static void glIndexPointer(int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglIndexPointer(type, stride, pointer.ToPointer());
			}
		}
		
		public static void glInterleavedArrays(int format, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglInterleavedArrays(format, stride, pointer.ToPointer());
			}
		}
		
		public static void glNormalPointer(int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglNormalPointer(type, stride, pointer.ToPointer());
			}
		}
		
		public static void glTexCoordPointer(int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglTexCoordPointer(size, type, stride, pointer.ToPointer());
			}
		}
		
		public static void glVertexPointer(int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglVertexPointer(size, type, stride, pointer.ToPointer());
			}
		}
		
		public static byte glAreTexturesResident(int n, IntPtr textures, IntPtr residences)
		{
			unsafe
			{
				return Capabilities.nglAreTexturesResident(n, (int*)textures.ToPointer(), (byte*)residences.ToPointer());
			}
		}
		
		public static void glAreTexturesResident(int n, int[] textures, byte[] residences)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					fixed (byte* residencesPtr = residences)
					{
						Capabilities.nglAreTexturesResident(n, texturesPtr, residencesPtr);
					}
				}
			}
		}
		
		public static void glPrioritizeTextures(int n, IntPtr textures, IntPtr priorities)
		{
			unsafe
			{
				Capabilities.nglPrioritizeTextures(n, (int*)textures.ToPointer(), (float*)priorities.ToPointer());
			}
		}
		
		public static void glPrioritizeTextures(int n, int[] textures, float[] priorities)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					fixed (float* prioritiesPtr = priorities)
					{
						Capabilities.nglPrioritizeTextures(n, texturesPtr, prioritiesPtr);
					}
				}
			}
		}
		
		public static void glIndexub(byte c) =>
			Capabilities.nglIndexub(c);
		
		public static void glIndexubv(IntPtr c)
		{
			unsafe
			{
				Capabilities.nglIndexubv((byte*)c.ToPointer());
			}
		}
		
		public static void glIndexubv(ref byte c)
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexubv((byte*)ptr);
			}
		}
		
		public static void glIndexubv<T>(ref T c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexubv((byte*)ptr);
			}
		}
		
		public static void glIndexubv<T>(T[] c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = c) Capabilities.nglIndexubv((byte*)ptr);
			}
		}
		
		public static void glIndexubv(byte[] c)
		{
			unsafe
			{
				fixed (byte* cPtr = c)
				{
					Capabilities.nglIndexubv(cPtr);
				}
			}
		}
		
		public static void glPopClientAttrib() =>
			Capabilities.nglPopClientAttrib();
		
		public static void glPushClientAttrib(int mask) =>
			Capabilities.nglPushClientAttrib(mask);
		
		
	}
}
