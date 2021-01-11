using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;
		public const int GL_CLIP_DISTANCE0 = 0x3000;
		public const int GL_CLIP_DISTANCE1 = 0x3001;
		public const int GL_CLIP_DISTANCE2 = 0x3002;
		public const int GL_CLIP_DISTANCE3 = 0x3003;
		public const int GL_CLIP_DISTANCE4 = 0x3004;
		public const int GL_CLIP_DISTANCE5 = 0x3005;
		public const int GL_CLIP_DISTANCE6 = 0x3006;
		public const int GL_CLIP_DISTANCE7 = 0x3007;
		public const int GL_MAX_CLIP_DISTANCES = 0x0D32;
		public const int GL_MAJOR_VERSION = 0x821B;
		public const int GL_MINOR_VERSION = 0x821C;
		public const int GL_NUM_EXTENSIONS = 0x821D;
		public const int GL_CONTEXT_FLAGS = 0x821E;
		public const int GL_COMPRESSED_RED = 0x8225;
		public const int GL_COMPRESSED_RG = 0x8226;
		public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const int GL_RGBA32F = 0x8814;
		public const int GL_RGB32F = 0x8815;
		public const int GL_RGBA16F = 0x881A;
		public const int GL_RGB16F = 0x881B;
		public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const int GL_CLAMP_READ_COLOR = 0x891C;
		public const int GL_FIXED_ONLY = 0x891D;
		public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const int GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const int GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const int GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const int GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const int GL_R11F_G11F_B10F = 0x8C3A;
		public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const int GL_RGB9_E5 = 0x8C3D;
		public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const int GL_TEXTURE_SHARED_SIZE = 0x8C3F;
		public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const int GL_PRIMITIVES_GENERATED = 0x8C87;
		public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const int GL_RASTERIZER_DISCARD = 0x8C89;
		public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const int GL_INTERLEAVED_ATTRIBS = 0x8C8C;
		public const int GL_SEPARATE_ATTRIBS = 0x8C8D;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const int GL_RGBA32UI = 0x8D70;
		public const int GL_RGB32UI = 0x8D71;
		public const int GL_RGBA16UI = 0x8D76;
		public const int GL_RGB16UI = 0x8D77;
		public const int GL_RGBA8UI = 0x8D7C;
		public const int GL_RGB8UI = 0x8D7D;
		public const int GL_RGBA32I = 0x8D82;
		public const int GL_RGB32I = 0x8D83;
		public const int GL_RGBA16I = 0x8D88;
		public const int GL_RGB16I = 0x8D89;
		public const int GL_RGBA8I = 0x8D8E;
		public const int GL_RGB8I = 0x8D8F;
		public const int GL_RED_INTEGER = 0x8D94;
		public const int GL_GREEN_INTEGER = 0x8D95;
		public const int GL_BLUE_INTEGER = 0x8D96;
		public const int GL_RGB_INTEGER = 0x8D98;
		public const int GL_RGBA_INTEGER = 0x8D99;
		public const int GL_BGR_INTEGER = 0x8D9A;
		public const int GL_BGRA_INTEGER = 0x8D9B;
		public const int GL_SAMPLER_1D_ARRAY = 0x8DC0;
		public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;
		public const int GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;
		public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;
		public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;
		public const int GL_INT_SAMPLER_1D = 0x8DC9;
		public const int GL_INT_SAMPLER_2D = 0x8DCA;
		public const int GL_INT_SAMPLER_3D = 0x8DCB;
		public const int GL_INT_SAMPLER_CUBE = 0x8DCC;
		public const int GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const int GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const int GL_QUERY_WAIT = 0x8E13;
		public const int GL_QUERY_NO_WAIT = 0x8E14;
		public const int GL_QUERY_BY_REGION_WAIT = 0x8E15;
		public const int GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;
		public const int GL_BUFFER_MAP_LENGTH = 0x9120;
		public const int GL_BUFFER_MAP_OFFSET = 0x9121;
		public const int GL_DEPTH_COMPONENT32F = 0x8CAC;
		public const int GL_DEPTH32F_STENCIL8 = 0x8CAD;
		public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const int GL_DEPTH_STENCIL = 0x84F9;
		public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const int GL_DEPTH24_STENCIL8 = 0x88F0;
		public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const int GL_TEXTURE_RED_TYPE = 0x8C10;
		public const int GL_TEXTURE_GREEN_TYPE = 0x8C11;
		public const int GL_TEXTURE_BLUE_TYPE = 0x8C12;
		public const int GL_TEXTURE_ALPHA_TYPE = 0x8C13;
		public const int GL_TEXTURE_DEPTH_TYPE = 0x8C16;
		public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const int GL_READ_FRAMEBUFFER = 0x8CA8;
		public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const int GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const int GL_COLOR_ATTACHMENT16 = 0x8CF0;
		public const int GL_COLOR_ATTACHMENT17 = 0x8CF1;
		public const int GL_COLOR_ATTACHMENT18 = 0x8CF2;
		public const int GL_COLOR_ATTACHMENT19 = 0x8CF3;
		public const int GL_COLOR_ATTACHMENT20 = 0x8CF4;
		public const int GL_COLOR_ATTACHMENT21 = 0x8CF5;
		public const int GL_COLOR_ATTACHMENT22 = 0x8CF6;
		public const int GL_COLOR_ATTACHMENT23 = 0x8CF7;
		public const int GL_COLOR_ATTACHMENT24 = 0x8CF8;
		public const int GL_COLOR_ATTACHMENT25 = 0x8CF9;
		public const int GL_COLOR_ATTACHMENT26 = 0x8CFA;
		public const int GL_COLOR_ATTACHMENT27 = 0x8CFB;
		public const int GL_COLOR_ATTACHMENT28 = 0x8CFC;
		public const int GL_COLOR_ATTACHMENT29 = 0x8CFD;
		public const int GL_COLOR_ATTACHMENT30 = 0x8CFE;
		public const int GL_COLOR_ATTACHMENT31 = 0x8CFF;
		public const int GL_DEPTH_ATTACHMENT = 0x8D00;
		public const int GL_STENCIL_ATTACHMENT = 0x8D20;
		public const int GL_FRAMEBUFFER = 0x8D40;
		public const int GL_RENDERBUFFER = 0x8D41;
		public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const int GL_STENCIL_INDEX1 = 0x8D46;
		public const int GL_STENCIL_INDEX4 = 0x8D47;
		public const int GL_STENCIL_INDEX8 = 0x8D48;
		public const int GL_STENCIL_INDEX16 = 0x8D49;
		public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const int GL_MAX_SAMPLES = 0x8D57;
		public const int GL_INDEX = 0x8222;
		public const int GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
		public const int GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
		public const int GL_FRAMEBUFFER_SRGB = 0x8DB9;
		public const int GL_HALF_FLOAT = 0x140B;
		public const int GL_MAP_READ_BIT = 0x0001;
		public const int GL_MAP_WRITE_BIT = 0x0002;
		public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const int GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const int GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const int GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const int GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const int GL_RG = 0x8227;
		public const int GL_RG_INTEGER = 0x8228;
		public const int GL_R8 = 0x8229;
		public const int GL_R16 = 0x822A;
		public const int GL_RG8 = 0x822B;
		public const int GL_RG16 = 0x822C;
		public const int GL_R16F = 0x822D;
		public const int GL_R32F = 0x822E;
		public const int GL_RG16F = 0x822F;
		public const int GL_RG32F = 0x8230;
		public const int GL_R8I = 0x8231;
		public const int GL_R8UI = 0x8232;
		public const int GL_R16I = 0x8233;
		public const int GL_R16UI = 0x8234;
		public const int GL_R32I = 0x8235;
		public const int GL_R32UI = 0x8236;
		public const int GL_RG8I = 0x8237;
		public const int GL_RG8UI = 0x8238;
		public const int GL_RG16I = 0x8239;
		public const int GL_RG16UI = 0x823A;
		public const int GL_RG32I = 0x823B;
		public const int GL_RG32UI = 0x823C;
		public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;
		public const int GL_CLAMP_VERTEX_COLOR = 0x891A;
		public const int GL_CLAMP_FRAGMENT_COLOR = 0x891B;
		public const int GL_ALPHA_INTEGER = 0x8D97;
		#endregion // Constants
		
		public static void glColorMaski(int index, byte r, byte g, byte b, byte a) =>
			Capabilities.nglColorMaski(index, r, g, b, a);
		
		public static void glGetBooleani_v(int target, int index, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetBooleani_v(target, index, (byte*)data.ToPointer());
			}
		}
		
		public static void glGetBooleani_v(int target, int index, ref byte data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetBooleani_v(target, index, (byte*)ptr);
			}
		}
		
		public static void glGetBooleani_v<T>(int target, int index, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetBooleani_v(target, index, (byte*)ptr);
			}
		}
		
		public static void glGetBooleani_v<T>(int target, int index, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetBooleani_v(target, index, (byte*)ptr);
			}
		}
		
		public static void glGetBooleani_v(int target, int index, byte[] data)
		{
			unsafe
			{
				fixed (byte* dataPtr = data)
				{
					Capabilities.nglGetBooleani_v(target, index, dataPtr);
				}
			}
		}
		
		public static void glGetIntegeri_v(int target, int index, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetIntegeri_v(target, index, (int*)data.ToPointer());
			}
		}
		
		public static void glGetIntegeri_v(int target, int index, ref int data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetIntegeri_v(target, index, (int*)ptr);
			}
		}
		
		public static void glGetIntegeri_v<T>(int target, int index, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetIntegeri_v(target, index, (int*)ptr);
			}
		}
		
		public static void glGetIntegeri_v<T>(int target, int index, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetIntegeri_v(target, index, (int*)ptr);
			}
		}
		
		public static void glGetIntegeri_v(int target, int index, int[] data)
		{
			unsafe
			{
				fixed (int* dataPtr = data)
				{
					Capabilities.nglGetIntegeri_v(target, index, dataPtr);
				}
			}
		}
		
		public static void glEnablei(int target, int index) =>
			Capabilities.nglEnablei(target, index);
		
		public static void glDisablei(int target, int index) =>
			Capabilities.nglDisablei(target, index);
		
		public static byte glIsEnabledi(int target, int index) =>
			Capabilities.nglIsEnabledi(target, index);
		
		public static void glBeginTransformFeedback(int primitiveMode) =>
			Capabilities.nglBeginTransformFeedback(primitiveMode);
		
		public static void glEndTransformFeedback() =>
			Capabilities.nglEndTransformFeedback();
		
		public static void glBindBufferRange(int target, int index, int buffer, IntPtr offset, IntPtr size) =>
			Capabilities.nglBindBufferRange(target, index, buffer, offset, size);
		
		public static void glBindBufferBase(int target, int index, int buffer) =>
			Capabilities.nglBindBufferBase(target, index, buffer);
		
		public static void glTransformFeedbackVaryings(int program, int count, IntPtr varyings, int bufferMode)
		{
			unsafe
			{
				Capabilities.nglTransformFeedbackVaryings(program, count, (byte**)varyings.ToPointer(), bufferMode);
			}
		}
		
		public static void glGetTransformFeedbackVarying(int program, int index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetTransformFeedbackVarying(program, index, bufSize, (int*)length.ToPointer(), (int*)size.ToPointer(), (int*)type.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetTransformFeedbackVarying(int program, int index, int bufSize, int[] length, int[] size, int[] type, byte[] name)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (int* sizePtr = size)
					{
						fixed (int* typePtr = type)
						{
							fixed (byte* namePtr = name)
							{
								Capabilities.nglGetTransformFeedbackVarying(program, index, bufSize, lengthPtr, sizePtr, typePtr, namePtr);
							}
						}
					}
				}
			}
		}
		
		public static void glClampColor(int target, int clamp) =>
			Capabilities.nglClampColor(target, clamp);
		
		public static void glBeginConditionalRender(int id, int mode) =>
			Capabilities.nglBeginConditionalRender(id, mode);
		
		public static void glEndConditionalRender() =>
			Capabilities.nglEndConditionalRender();
		
		public static void glVertexAttribIPointer(int index, int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglVertexAttribIPointer(index, size, type, stride, pointer.ToPointer());
			}
		}
		
		public static void glGetVertexAttribIiv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribIiv(index, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribIiv(int index, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribIiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIiv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribIiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIiv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribIiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIiv(int index, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribIiv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetVertexAttribIuiv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribIuiv(index, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribIuiv(int index, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribIuiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIuiv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribIuiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIuiv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribIuiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribIuiv(int index, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribIuiv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glVertexAttribI1i(int index, int x) =>
			Capabilities.nglVertexAttribI1i(index, x);
		
		public static void glVertexAttribI2i(int index, int x, int y) =>
			Capabilities.nglVertexAttribI2i(index, x, y);
		
		public static void glVertexAttribI3i(int index, int x, int y, int z) =>
			Capabilities.nglVertexAttribI3i(index, x, y, z);
		
		public static void glVertexAttribI4i(int index, int x, int y, int z, int w) =>
			Capabilities.nglVertexAttribI4i(index, x, y, z, w);
		
		public static void glVertexAttribI1ui(int index, int x) =>
			Capabilities.nglVertexAttribI1ui(index, x);
		
		public static void glVertexAttribI2ui(int index, int x, int y) =>
			Capabilities.nglVertexAttribI2ui(index, x, y);
		
		public static void glVertexAttribI3ui(int index, int x, int y, int z) =>
			Capabilities.nglVertexAttribI3ui(index, x, y, z);
		
		public static void glVertexAttribI4ui(int index, int x, int y, int z, int w) =>
			Capabilities.nglVertexAttribI4ui(index, x, y, z, w);
		
		public static void glVertexAttribI1iv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI1iv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI1iv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI1iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1iv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI1iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1iv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI1iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1iv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI1iv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI2iv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI2iv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI2iv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI2iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2iv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI2iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2iv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI2iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2iv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI2iv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI3iv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI3iv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI3iv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI3iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3iv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI3iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3iv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI3iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3iv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI3iv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4iv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4iv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4iv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4iv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4iv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4iv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI4iv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI1uiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI1uiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI1uiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI1uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1uiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI1uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1uiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI1uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI1uiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI1uiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI2uiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI2uiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI2uiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI2uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2uiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI2uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2uiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI2uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI2uiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI2uiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI3uiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI3uiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI3uiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI3uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3uiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI3uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3uiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI3uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI3uiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI3uiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4uiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4uiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4uiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4uiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4uiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttribI4uiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttribI4uiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4bv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4bv(index, (sbyte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4bv(int index, ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttribI4bv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttribI4bv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttribI4bv(int index, sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglVertexAttribI4bv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4sv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4sv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4sv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttribI4sv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttribI4sv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttribI4sv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttribI4sv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4ubv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4ubv(index, (byte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4ubv(int index, ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttribI4ubv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttribI4ubv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttribI4ubv(int index, byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglVertexAttribI4ubv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribI4usv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribI4usv(index, (ushort*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribI4usv(int index, ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttribI4usv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribI4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttribI4usv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribI4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttribI4usv(int index, ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglVertexAttribI4usv(index, vPtr);
				}
			}
		}
		
		public static void glGetUniformuiv(int program, int location, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetUniformuiv(program, location, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetUniformuiv(int program, int location, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformuiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformuiv<T>(int program, int location, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformuiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformuiv<T>(int program, int location, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetUniformuiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformuiv(int program, int location, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetUniformuiv(program, location, _paramsPtr);
				}
			}
		}
		
		public static void glBindFragDataLocation(int program, int color, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglBindFragDataLocation(program, color, (byte*)name.ToPointer());
			}
		}
		
		public static void glBindFragDataLocation(int program, int color, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindFragDataLocation(program, color, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocation<T>(int program, int color, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindFragDataLocation(program, color, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocation<T>(int program, int color, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglBindFragDataLocation(program, color, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocation(int program, int color, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglBindFragDataLocation(program, color, namePtr);
				}
			}
		}
		
		public static int glGetFragDataLocation(int program, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetFragDataLocation(program, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetFragDataLocation(int program, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetFragDataLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataLocation<T>(int program, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetFragDataLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataLocation<T>(int program, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetFragDataLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataLocation(int program, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetFragDataLocation(program, namePtr);
				}
			}
		}
		
		public static void glUniform1ui(int location, int v0) =>
			Capabilities.nglUniform1ui(location, v0);
		
		public static void glUniform2ui(int location, int v0, int v1) =>
			Capabilities.nglUniform2ui(location, v0, v1);
		
		public static void glUniform3ui(int location, int v0, int v1, int v2) =>
			Capabilities.nglUniform3ui(location, v0, v1, v2);
		
		public static void glUniform4ui(int location, int v0, int v1, int v2, int v3) =>
			Capabilities.nglUniform4ui(location, v0, v1, v2, v3);
		
		public static void glUniform1uiv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform1uiv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform1uiv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1uiv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1uiv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform1uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1uiv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform1uiv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform2uiv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform2uiv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform2uiv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2uiv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2uiv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform2uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2uiv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform2uiv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform3uiv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform3uiv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform3uiv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3uiv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3uiv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform3uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3uiv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform3uiv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform4uiv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform4uiv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform4uiv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4uiv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4uiv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform4uiv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4uiv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform4uiv(location, count, valuePtr);
				}
			}
		}
		
		public static void glTexParameterIiv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexParameterIiv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTexParameterIiv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIiv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIiv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIiv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTexParameterIiv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexParameterIuiv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexParameterIuiv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTexParameterIuiv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIuiv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIuiv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameterIuiv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTexParameterIuiv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexParameterIiv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexParameterIiv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexParameterIiv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIiv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIiv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexParameterIiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIiv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexParameterIiv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexParameterIuiv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexParameterIuiv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexParameterIuiv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIuiv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIuiv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexParameterIuiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameterIuiv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexParameterIuiv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glClearBufferiv(int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearBufferiv(buffer, drawbuffer, (int*)value.ToPointer());
			}
		}
		
		public static void glClearBufferiv(int buffer, int drawbuffer, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferiv<T>(int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferiv<T>(int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearBufferiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferiv(int buffer, int drawbuffer, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglClearBufferiv(buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearBufferuiv(int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearBufferuiv(buffer, drawbuffer, (int*)value.ToPointer());
			}
		}
		
		public static void glClearBufferuiv(int buffer, int drawbuffer, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferuiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferuiv<T>(int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferuiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferuiv<T>(int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearBufferuiv(buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearBufferuiv(int buffer, int drawbuffer, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglClearBufferuiv(buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearBufferfv(int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearBufferfv(buffer, drawbuffer, (float*)value.ToPointer());
			}
		}
		
		public static void glClearBufferfv(int buffer, int drawbuffer, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferfv(buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearBufferfv<T>(int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearBufferfv(buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearBufferfv<T>(int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearBufferfv(buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearBufferfv(int buffer, int drawbuffer, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglClearBufferfv(buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearBufferfi(int buffer, int drawbuffer, float depth, int stencil) =>
			Capabilities.nglClearBufferfi(buffer, drawbuffer, depth, stencil);
		
		public static string glGetStringi(int name, int index)
		{
			unsafe
			{
				byte* data = Capabilities.nglGetStringi(name, index);
				int count = 0;
				while (data[count] != 0) count++;
				return System.Text.Encoding.UTF8.GetString(data, count);
			}
		}
		
		public static byte glIsRenderbuffer(int renderbuffer) =>
			Capabilities.nglIsRenderbuffer(renderbuffer);
		
		public static void glBindRenderbuffer(int target, int renderbuffer) =>
			Capabilities.nglBindRenderbuffer(target, renderbuffer);
		
		public static void glDeleteRenderbuffers(int n, IntPtr renderbuffers)
		{
			unsafe
			{
				Capabilities.nglDeleteRenderbuffers(n, (int*)renderbuffers.ToPointer());
			}
		}
		
		public static void glDeleteRenderbuffers(int n, ref int renderbuffers)
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglDeleteRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteRenderbuffers<T>(int n, ref T renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglDeleteRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteRenderbuffers<T>(int n, T[] renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = renderbuffers) Capabilities.nglDeleteRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteRenderbuffers(int n, int[] renderbuffers)
		{
			unsafe
			{
				fixed (int* renderbuffersPtr = renderbuffers)
				{
					Capabilities.nglDeleteRenderbuffers(n, renderbuffersPtr);
				}
			}
		}
		
		public static void glDeleteRenderbuffers(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteRenderbuffers(1, &name);
			}
		}
		
		public static void glDeleteRenderbuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteRenderbuffers(names.Length, ptr);
			}
		}
		
		public static void glGenRenderbuffers(int n, IntPtr renderbuffers)
		{
			unsafe
			{
				Capabilities.nglGenRenderbuffers(n, (int*)renderbuffers.ToPointer());
			}
		}
		
		public static void glGenRenderbuffers(int n, ref int renderbuffers)
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglGenRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenRenderbuffers<T>(int n, ref T renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglGenRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenRenderbuffers<T>(int n, T[] renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = renderbuffers) Capabilities.nglGenRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenRenderbuffers(int n, int[] renderbuffers)
		{
			unsafe
			{
				fixed (int* renderbuffersPtr = renderbuffers)
				{
					Capabilities.nglGenRenderbuffers(n, renderbuffersPtr);
				}
			}
		}
		
		public static int glGenRenderbuffers()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenRenderbuffers(1, &val);
				return val;
			}
		}
		
		public static void glGenRenderbuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenRenderbuffers(names.Length, ptr);
			}
		}
		
		public static void glRenderbufferStorage(int target, int internalformat, int width, int height) =>
			Capabilities.nglRenderbufferStorage(target, internalformat, width, height);
		
		public static void glGetRenderbufferParameteriv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetRenderbufferParameteriv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetRenderbufferParameteriv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetRenderbufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetRenderbufferParameteriv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetRenderbufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetRenderbufferParameteriv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetRenderbufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetRenderbufferParameteriv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetRenderbufferParameteriv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static byte glIsFramebuffer(int framebuffer) =>
			Capabilities.nglIsFramebuffer(framebuffer);
		
		public static void glBindFramebuffer(int target, int framebuffer) =>
			Capabilities.nglBindFramebuffer(target, framebuffer);
		
		public static void glDeleteFramebuffers(int n, IntPtr framebuffers)
		{
			unsafe
			{
				Capabilities.nglDeleteFramebuffers(n, (int*)framebuffers.ToPointer());
			}
		}
		
		public static void glDeleteFramebuffers(int n, ref int framebuffers)
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglDeleteFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteFramebuffers<T>(int n, ref T framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglDeleteFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteFramebuffers<T>(int n, T[] framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = framebuffers) Capabilities.nglDeleteFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteFramebuffers(int n, int[] framebuffers)
		{
			unsafe
			{
				fixed (int* framebuffersPtr = framebuffers)
				{
					Capabilities.nglDeleteFramebuffers(n, framebuffersPtr);
				}
			}
		}
		
		public static void glDeleteFramebuffers(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteFramebuffers(1, &name);
			}
		}
		
		public static void glDeleteFramebuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteFramebuffers(names.Length, ptr);
			}
		}
		
		public static void glGenFramebuffers(int n, IntPtr framebuffers)
		{
			unsafe
			{
				Capabilities.nglGenFramebuffers(n, (int*)framebuffers.ToPointer());
			}
		}
		
		public static void glGenFramebuffers(int n, ref int framebuffers)
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglGenFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenFramebuffers<T>(int n, ref T framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglGenFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenFramebuffers<T>(int n, T[] framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = framebuffers) Capabilities.nglGenFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenFramebuffers(int n, int[] framebuffers)
		{
			unsafe
			{
				fixed (int* framebuffersPtr = framebuffers)
				{
					Capabilities.nglGenFramebuffers(n, framebuffersPtr);
				}
			}
		}
		
		public static int glGenFramebuffers()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenFramebuffers(1, &val);
				return val;
			}
		}
		
		public static void glGenFramebuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenFramebuffers(names.Length, ptr);
			}
		}
		
		public static int glCheckFramebufferStatus(int target) =>
			Capabilities.nglCheckFramebufferStatus(target);
		
		public static void glFramebufferTexture1D(int target, int attachment, int textarget, int texture, int level) =>
			Capabilities.nglFramebufferTexture1D(target, attachment, textarget, texture, level);
		
		public static void glFramebufferTexture2D(int target, int attachment, int textarget, int texture, int level) =>
			Capabilities.nglFramebufferTexture2D(target, attachment, textarget, texture, level);
		
		public static void glFramebufferTexture3D(int target, int attachment, int textarget, int texture, int level, int zoffset) =>
			Capabilities.nglFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		
		public static void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, int renderbuffer) =>
			Capabilities.nglFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		
		public static void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetFramebufferAttachmentParameteriv(target, attachment, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetFramebufferAttachmentParameteriv(target, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferAttachmentParameteriv<T>(int target, int attachment, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetFramebufferAttachmentParameteriv(target, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferAttachmentParameteriv<T>(int target, int attachment, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetFramebufferAttachmentParameteriv(target, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetFramebufferAttachmentParameteriv(target, attachment, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGenerateMipmap(int target) =>
			Capabilities.nglGenerateMipmap(target);
		
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter) =>
			Capabilities.nglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		
		public static void glRenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height) =>
			Capabilities.nglRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		
		public static void glFramebufferTextureLayer(int target, int attachment, int texture, int level, int layer) =>
			Capabilities.nglFramebufferTextureLayer(target, attachment, texture, level, layer);
		
		public static IntPtr glMapBufferRange(int target, IntPtr offset, IntPtr length, int access)
		{
			unsafe
			{
				return new IntPtr(Capabilities.nglMapBufferRange(target, offset, length, access));
			}
		}
		
		public static void glFlushMappedBufferRange(int target, IntPtr offset, IntPtr length) =>
			Capabilities.nglFlushMappedBufferRange(target, offset, length);
		
		public static void glBindVertexArray(int array) =>
			Capabilities.nglBindVertexArray(array);
		
		public static void glDeleteVertexArrays(int n, IntPtr arrays)
		{
			unsafe
			{
				Capabilities.nglDeleteVertexArrays(n, (int*)arrays.ToPointer());
			}
		}
		
		public static void glDeleteVertexArrays(int n, ref int arrays)
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglDeleteVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glDeleteVertexArrays<T>(int n, ref T arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglDeleteVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glDeleteVertexArrays<T>(int n, T[] arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = arrays) Capabilities.nglDeleteVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glDeleteVertexArrays(int n, int[] arrays)
		{
			unsafe
			{
				fixed (int* arraysPtr = arrays)
				{
					Capabilities.nglDeleteVertexArrays(n, arraysPtr);
				}
			}
		}
		
		public static void glDeleteVertexArrays(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteVertexArrays(1, &name);
			}
		}
		
		public static void glDeleteVertexArrays(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteVertexArrays(names.Length, ptr);
			}
		}
		
		public static void glGenVertexArrays(int n, IntPtr arrays)
		{
			unsafe
			{
				Capabilities.nglGenVertexArrays(n, (int*)arrays.ToPointer());
			}
		}
		
		public static void glGenVertexArrays(int n, ref int arrays)
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglGenVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glGenVertexArrays<T>(int n, ref T arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglGenVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glGenVertexArrays<T>(int n, T[] arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = arrays) Capabilities.nglGenVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glGenVertexArrays(int n, int[] arrays)
		{
			unsafe
			{
				fixed (int* arraysPtr = arrays)
				{
					Capabilities.nglGenVertexArrays(n, arraysPtr);
				}
			}
		}
		
		public static int glGenVertexArrays()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenVertexArrays(1, &val);
				return val;
			}
		}
		
		public static void glGenVertexArrays(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenVertexArrays(names.Length, ptr);
			}
		}
		
		public static byte glIsVertexArray(int array) =>
			Capabilities.nglIsVertexArray(array);
		
		
	}
}
