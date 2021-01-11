using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const int GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const int GL_COMPRESSED_RGB8_ETC2 = 0x9274;
		public const int GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const int GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const int GL_COMPRESSED_R11_EAC = 0x9270;
		public const int GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const int GL_COMPRESSED_RG11_EAC = 0x9272;
		public const int GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const int GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const int GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const int GL_MAX_ELEMENT_INDEX = 0x8D6B;
		public const int GL_COMPUTE_SHADER = 0x91B9;
		public const int GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const int GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const int GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const int GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const int GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const int GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const int GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const int GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const int GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const int GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const int GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const int GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const int GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const int GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const int GL_DEBUG_SOURCE_API = 0x8246;
		public const int GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const int GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const int GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const int GL_DEBUG_SOURCE_APPLICATION = 0x824A;
		public const int GL_DEBUG_SOURCE_OTHER = 0x824B;
		public const int GL_DEBUG_TYPE_ERROR = 0x824C;
		public const int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const int GL_DEBUG_TYPE_PORTABILITY = 0x824F;
		public const int GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const int GL_DEBUG_TYPE_OTHER = 0x8251;
		public const int GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const int GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const int GL_DEBUG_LOGGED_MESSAGES = 0x9145;
		public const int GL_DEBUG_SEVERITY_HIGH = 0x9146;
		public const int GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const int GL_DEBUG_SEVERITY_LOW = 0x9148;
		public const int GL_DEBUG_TYPE_MARKER = 0x8268;
		public const int GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const int GL_DEBUG_TYPE_POP_GROUP = 0x826A;
		public const int GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const int GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const int GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const int GL_BUFFER = 0x82E0;
		public const int GL_SHADER = 0x82E1;
		public const int GL_PROGRAM = 0x82E2;
		public const int GL_QUERY = 0x82E3;
		public const int GL_PROGRAM_PIPELINE = 0x82E4;
		public const int GL_SAMPLER = 0x82E6;
		public const int GL_MAX_LABEL_LENGTH = 0x82E8;
		public const int GL_DEBUG_OUTPUT = 0x92E0;
		public const int GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const int GL_MAX_UNIFORM_LOCATIONS = 0x826E;
		public const int GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const int GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const int GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const int GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const int GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const int GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const int GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const int GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const int GL_INTERNALFORMAT_SUPPORTED = 0x826F;
		public const int GL_INTERNALFORMAT_PREFERRED = 0x8270;
		public const int GL_INTERNALFORMAT_RED_SIZE = 0x8271;
		public const int GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const int GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const int GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const int GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const int GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const int GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const int GL_INTERNALFORMAT_RED_TYPE = 0x8278;
		public const int GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const int GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const int GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const int GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const int GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const int GL_MAX_WIDTH = 0x827E;
		public const int GL_MAX_HEIGHT = 0x827F;
		public const int GL_MAX_DEPTH = 0x8280;
		public const int GL_MAX_LAYERS = 0x8281;
		public const int GL_MAX_COMBINED_DIMENSIONS = 0x8282;
		public const int GL_COLOR_COMPONENTS = 0x8283;
		public const int GL_DEPTH_COMPONENTS = 0x8284;
		public const int GL_STENCIL_COMPONENTS = 0x8285;
		public const int GL_COLOR_RENDERABLE = 0x8286;
		public const int GL_DEPTH_RENDERABLE = 0x8287;
		public const int GL_STENCIL_RENDERABLE = 0x8288;
		public const int GL_FRAMEBUFFER_RENDERABLE = 0x8289;
		public const int GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const int GL_FRAMEBUFFER_BLEND = 0x828B;
		public const int GL_READ_PIXELS = 0x828C;
		public const int GL_READ_PIXELS_FORMAT = 0x828D;
		public const int GL_READ_PIXELS_TYPE = 0x828E;
		public const int GL_TEXTURE_IMAGE_FORMAT = 0x828F;
		public const int GL_TEXTURE_IMAGE_TYPE = 0x8290;
		public const int GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const int GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const int GL_MIPMAP = 0x8293;
		public const int GL_MANUAL_GENERATE_MIPMAP = 0x8294;
		public const int GL_AUTO_GENERATE_MIPMAP = 0x8295;
		public const int GL_COLOR_ENCODING = 0x8296;
		public const int GL_SRGB_READ = 0x8297;
		public const int GL_SRGB_WRITE = 0x8298;
		public const int GL_FILTER = 0x829A;
		public const int GL_VERTEX_TEXTURE = 0x829B;
		public const int GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const int GL_TESS_EVALUATION_TEXTURE = 0x829D;
		public const int GL_GEOMETRY_TEXTURE = 0x829E;
		public const int GL_FRAGMENT_TEXTURE = 0x829F;
		public const int GL_COMPUTE_TEXTURE = 0x82A0;
		public const int GL_TEXTURE_SHADOW = 0x82A1;
		public const int GL_TEXTURE_GATHER = 0x82A2;
		public const int GL_TEXTURE_GATHER_SHADOW = 0x82A3;
		public const int GL_SHADER_IMAGE_LOAD = 0x82A4;
		public const int GL_SHADER_IMAGE_STORE = 0x82A5;
		public const int GL_SHADER_IMAGE_ATOMIC = 0x82A6;
		public const int GL_IMAGE_TEXEL_SIZE = 0x82A7;
		public const int GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const int GL_IMAGE_PIXEL_FORMAT = 0x82A9;
		public const int GL_IMAGE_PIXEL_TYPE = 0x82AA;
		public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const int GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const int GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const int GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const int GL_CLEAR_BUFFER = 0x82B4;
		public const int GL_TEXTURE_VIEW = 0x82B5;
		public const int GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const int GL_FULL_SUPPORT = 0x82B7;
		public const int GL_CAVEAT_SUPPORT = 0x82B8;
		public const int GL_IMAGE_CLASS_4_X_32 = 0x82B9;
		public const int GL_IMAGE_CLASS_2_X_32 = 0x82BA;
		public const int GL_IMAGE_CLASS_1_X_32 = 0x82BB;
		public const int GL_IMAGE_CLASS_4_X_16 = 0x82BC;
		public const int GL_IMAGE_CLASS_2_X_16 = 0x82BD;
		public const int GL_IMAGE_CLASS_1_X_16 = 0x82BE;
		public const int GL_IMAGE_CLASS_4_X_8 = 0x82BF;
		public const int GL_IMAGE_CLASS_2_X_8 = 0x82C0;
		public const int GL_IMAGE_CLASS_1_X_8 = 0x82C1;
		public const int GL_IMAGE_CLASS_11_11_10 = 0x82C2;
		public const int GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const int GL_VIEW_CLASS_128_BITS = 0x82C4;
		public const int GL_VIEW_CLASS_96_BITS = 0x82C5;
		public const int GL_VIEW_CLASS_64_BITS = 0x82C6;
		public const int GL_VIEW_CLASS_48_BITS = 0x82C7;
		public const int GL_VIEW_CLASS_32_BITS = 0x82C8;
		public const int GL_VIEW_CLASS_24_BITS = 0x82C9;
		public const int GL_VIEW_CLASS_16_BITS = 0x82CA;
		public const int GL_VIEW_CLASS_8_BITS = 0x82CB;
		public const int GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const int GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const int GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const int GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const int GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const int GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const int GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const int GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const int GL_UNIFORM = 0x92E1;
		public const int GL_UNIFORM_BLOCK = 0x92E2;
		public const int GL_PROGRAM_INPUT = 0x92E3;
		public const int GL_PROGRAM_OUTPUT = 0x92E4;
		public const int GL_BUFFER_VARIABLE = 0x92E5;
		public const int GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const int GL_VERTEX_SUBROUTINE = 0x92E8;
		public const int GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const int GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const int GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const int GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const int GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const int GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const int GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const int GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const int GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const int GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const int GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const int GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const int GL_ACTIVE_RESOURCES = 0x92F5;
		public const int GL_MAX_NAME_LENGTH = 0x92F6;
		public const int GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const int GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const int GL_NAME_LENGTH = 0x92F9;
		public const int GL_TYPE = 0x92FA;
		public const int GL_ARRAY_SIZE = 0x92FB;
		public const int GL_OFFSET = 0x92FC;
		public const int GL_BLOCK_INDEX = 0x92FD;
		public const int GL_ARRAY_STRIDE = 0x92FE;
		public const int GL_MATRIX_STRIDE = 0x92FF;
		public const int GL_IS_ROW_MAJOR = 0x9300;
		public const int GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const int GL_BUFFER_BINDING = 0x9302;
		public const int GL_BUFFER_DATA_SIZE = 0x9303;
		public const int GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const int GL_ACTIVE_VARIABLES = 0x9305;
		public const int GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const int GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const int GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const int GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const int GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const int GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const int GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const int GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const int GL_LOCATION = 0x930E;
		public const int GL_LOCATION_INDEX = 0x930F;
		public const int GL_IS_PER_PATCH = 0x92E7;
		public const int GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const int GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const int GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const int GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const int GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const int GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const int GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const int GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const int GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const int GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const int GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const int GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const int GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const int GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const int GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const int GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const int GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const int GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const int GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const int GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const int GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const int GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const int GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const int GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const int GL_VERTEX_BINDING_BUFFER = 0x8F4F;
		public const int GL_DISPLAY_LIST = 0x82E7;
		#endregion // Constants
		
		public static void glClearBufferData(int target, int internalformat, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearBufferData(target, internalformat, format, type, data.ToPointer());
			}
		}
		
		public static void glClearBufferSubData(int target, int internalformat, IntPtr offset, IntPtr size, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearBufferSubData(target, internalformat, offset, size, format, type, data.ToPointer());
			}
		}
		
		public static void glDispatchCompute(int num_groups_x, int num_groups_y, int num_groups_z) =>
			Capabilities.nglDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		
		public static void glDispatchComputeIndirect(IntPtr indirect) =>
			Capabilities.nglDispatchComputeIndirect(indirect);
		
		public static void glCopyImageSubData(int srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, int dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) =>
			Capabilities.nglCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		
		public static void glFramebufferParameteri(int target, int pname, int param) =>
			Capabilities.nglFramebufferParameteri(target, pname, param);
		
		public static void glGetFramebufferParameteriv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetFramebufferParameteriv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetFramebufferParameteriv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetFramebufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferParameteriv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetFramebufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferParameteriv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetFramebufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetFramebufferParameteriv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetFramebufferParameteriv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetInternalformati64v(int target, int internalformat, int pname, int count, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetInternalformati64v(target, internalformat, pname, count, (long*)_params.ToPointer());
			}
		}
		
		public static void glGetInternalformati64v(int target, int internalformat, int pname, int count, ref long _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetInternalformati64v(target, internalformat, pname, count, (long*)ptr);
			}
		}
		
		public static void glGetInternalformati64v<T>(int target, int internalformat, int pname, int count, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetInternalformati64v(target, internalformat, pname, count, (long*)ptr);
			}
		}
		
		public static void glGetInternalformati64v<T>(int target, int internalformat, int pname, int count, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetInternalformati64v(target, internalformat, pname, count, (long*)ptr);
			}
		}
		
		public static void glGetInternalformati64v(int target, int internalformat, int pname, int count, long[] _params)
		{
			unsafe
			{
				fixed (long* _paramsPtr = _params)
				{
					Capabilities.nglGetInternalformati64v(target, internalformat, pname, count, _paramsPtr);
				}
			}
		}
		
		public static void glInvalidateTexSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) =>
			Capabilities.nglInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		
		public static void glInvalidateTexImage(int texture, int level) =>
			Capabilities.nglInvalidateTexImage(texture, level);
		
		public static void glInvalidateBufferSubData(int buffer, IntPtr offset, IntPtr length) =>
			Capabilities.nglInvalidateBufferSubData(buffer, offset, length);
		
		public static void glInvalidateBufferData(int buffer) =>
			Capabilities.nglInvalidateBufferData(buffer);
		
		public static void glInvalidateFramebuffer(int target, int numAttachments, IntPtr attachments)
		{
			unsafe
			{
				Capabilities.nglInvalidateFramebuffer(target, numAttachments, (int*)attachments.ToPointer());
			}
		}
		
		public static void glInvalidateFramebuffer(int target, int numAttachments, ref int attachments)
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateFramebuffer(target, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateFramebuffer<T>(int target, int numAttachments, ref T attachments) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateFramebuffer(target, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateFramebuffer<T>(int target, int numAttachments, T[] attachments) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = attachments) Capabilities.nglInvalidateFramebuffer(target, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateFramebuffer(int target, int numAttachments, int[] attachments)
		{
			unsafe
			{
				fixed (int* attachmentsPtr = attachments)
				{
					Capabilities.nglInvalidateFramebuffer(target, numAttachments, attachmentsPtr);
				}
			}
		}
		
		public static void glInvalidateSubFramebuffer(int target, int numAttachments, IntPtr attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				Capabilities.nglInvalidateSubFramebuffer(target, numAttachments, (int*)attachments.ToPointer(), x, y, width, height);
			}
		}
		
		public static void glInvalidateSubFramebuffer(int target, int numAttachments, ref int attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateSubFramebuffer(target, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateSubFramebuffer<T>(int target, int numAttachments, ref T attachments, int x, int y, int width, int height) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateSubFramebuffer(target, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateSubFramebuffer<T>(int target, int numAttachments, T[] attachments, int x, int y, int width, int height) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = attachments) Capabilities.nglInvalidateSubFramebuffer(target, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateSubFramebuffer(int target, int numAttachments, int[] attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				fixed (int* attachmentsPtr = attachments)
				{
					Capabilities.nglInvalidateSubFramebuffer(target, numAttachments, attachmentsPtr, x, y, width, height);
				}
			}
		}
		
		public static void glMultiDrawArraysIndirect(int mode, IntPtr indirect, int drawcount, int stride)
		{
			unsafe
			{
				Capabilities.nglMultiDrawArraysIndirect(mode, indirect.ToPointer(), drawcount, stride);
			}
		}
		
		public static void glMultiDrawElementsIndirect(int mode, int type, IntPtr indirect, int drawcount, int stride)
		{
			unsafe
			{
				Capabilities.nglMultiDrawElementsIndirect(mode, type, indirect.ToPointer(), drawcount, stride);
			}
		}
		
		public static void glGetProgramInterfaceiv(int program, int programInterface, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetProgramInterfaceiv(program, programInterface, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetProgramInterfaceiv(int program, int programInterface, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramInterfaceiv(program, programInterface, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramInterfaceiv<T>(int program, int programInterface, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramInterfaceiv(program, programInterface, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramInterfaceiv<T>(int program, int programInterface, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetProgramInterfaceiv(program, programInterface, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramInterfaceiv(int program, int programInterface, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetProgramInterfaceiv(program, programInterface, pname, _paramsPtr);
				}
			}
		}
		
		public static int glGetProgramResourceIndex(int program, int programInterface, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetProgramResourceIndex(program, programInterface, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetProgramResourceIndex(int program, int programInterface, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceIndex<T>(int program, int programInterface, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceIndex<T>(int program, int programInterface, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetProgramResourceIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceIndex(int program, int programInterface, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetProgramResourceIndex(program, programInterface, namePtr);
				}
			}
		}
		
		public static void glGetProgramResourceName(int program, int programInterface, int index, int bufSize, IntPtr length, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetProgramResourceName(program, programInterface, index, bufSize, (int*)length.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetProgramResourceName(int program, int programInterface, int index, int bufSize, int[] length, byte[] name)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* namePtr = name)
					{
						Capabilities.nglGetProgramResourceName(program, programInterface, index, bufSize, lengthPtr, namePtr);
					}
				}
			}
		}
		
		public static void glGetProgramResourceiv(int program, int programInterface, int index, int propCount, IntPtr props, int count, IntPtr length, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetProgramResourceiv(program, programInterface, index, propCount, (int*)props.ToPointer(), count, (int*)length.ToPointer(), (int*)_params.ToPointer());
			}
		}
		
		public static void glGetProgramResourceiv(int program, int programInterface, int index, int propCount, int[] props, int count, int[] length, int[] _params)
		{
			unsafe
			{
				fixed (int* propsPtr = props)
				{
					fixed (int* lengthPtr = length)
					{
						fixed (int* _paramsPtr = _params)
						{
							Capabilities.nglGetProgramResourceiv(program, programInterface, index, propCount, propsPtr, count, lengthPtr, _paramsPtr);
						}
					}
				}
			}
		}
		
		public static int glGetProgramResourceLocation(int program, int programInterface, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetProgramResourceLocation(program, programInterface, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetProgramResourceLocation(int program, int programInterface, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceLocation(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocation<T>(int program, int programInterface, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceLocation(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocation<T>(int program, int programInterface, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetProgramResourceLocation(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocation(int program, int programInterface, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetProgramResourceLocation(program, programInterface, namePtr);
				}
			}
		}
		
		public static int glGetProgramResourceLocationIndex(int program, int programInterface, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetProgramResourceLocationIndex(program, programInterface, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetProgramResourceLocationIndex(int program, int programInterface, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceLocationIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocationIndex<T>(int program, int programInterface, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetProgramResourceLocationIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocationIndex<T>(int program, int programInterface, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetProgramResourceLocationIndex(program, programInterface, (byte*)ptr);
			}
		}
		
		public static void glGetProgramResourceLocationIndex(int program, int programInterface, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetProgramResourceLocationIndex(program, programInterface, namePtr);
				}
			}
		}
		
		public static void glShaderStorageBlockBinding(int program, int storageBlockIndex, int storageBlockBinding) =>
			Capabilities.nglShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		
		public static void glTexBufferRange(int target, int internalformat, int buffer, IntPtr offset, IntPtr size) =>
			Capabilities.nglTexBufferRange(target, internalformat, buffer, offset, size);
		
		public static void glTexStorage2DMultisample(int target, int samples, int internalformat, int width, int height, byte fixedsamplelocations) =>
			Capabilities.nglTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		
		public static void glTexStorage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, byte fixedsamplelocations) =>
			Capabilities.nglTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		
		public static void glTextureView(int texture, int target, int origtexture, int internalformat, int minlevel, int numlevels, int minlayer, int numlayers) =>
			Capabilities.nglTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		
		public static void glBindVertexBuffer(int bindingindex, int buffer, IntPtr offset, int stride) =>
			Capabilities.nglBindVertexBuffer(bindingindex, buffer, offset, stride);
		
		public static void glVertexAttribFormat(int attribindex, int size, int type, byte normalized, int relativeoffset) =>
			Capabilities.nglVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		
		public static void glVertexAttribIFormat(int attribindex, int size, int type, int relativeoffset) =>
			Capabilities.nglVertexAttribIFormat(attribindex, size, type, relativeoffset);
		
		public static void glVertexAttribLFormat(int attribindex, int size, int type, int relativeoffset) =>
			Capabilities.nglVertexAttribLFormat(attribindex, size, type, relativeoffset);
		
		public static void glVertexAttribBinding(int attribindex, int bindingindex) =>
			Capabilities.nglVertexAttribBinding(attribindex, bindingindex);
		
		public static void glVertexBindingDivisor(int bindingindex, int divisor) =>
			Capabilities.nglVertexBindingDivisor(bindingindex, divisor);
		
		public static void glDebugMessageControl(int source, int type, int severity, int count, IntPtr ids, byte enabled)
		{
			unsafe
			{
				Capabilities.nglDebugMessageControl(source, type, severity, count, (int*)ids.ToPointer(), enabled);
			}
		}
		
		public static void glDebugMessageControl(int source, int type, int severity, int count, ref int ids, byte enabled)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDebugMessageControl(source, type, severity, count, (int*)ptr, enabled);
			}
		}
		
		public static void glDebugMessageControl<T>(int source, int type, int severity, int count, ref T ids, byte enabled) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDebugMessageControl(source, type, severity, count, (int*)ptr, enabled);
			}
		}
		
		public static void glDebugMessageControl<T>(int source, int type, int severity, int count, T[] ids, byte enabled) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglDebugMessageControl(source, type, severity, count, (int*)ptr, enabled);
			}
		}
		
		public static void glDebugMessageControl(int source, int type, int severity, int count, int[] ids, byte enabled)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglDebugMessageControl(source, type, severity, count, idsPtr, enabled);
				}
			}
		}
		
		public static void glDebugMessageInsert(int source, int type, int id, int severity, int length, IntPtr buf)
		{
			unsafe
			{
				Capabilities.nglDebugMessageInsert(source, type, id, severity, length, (byte*)buf.ToPointer());
			}
		}
		
		public static void glDebugMessageInsert(int source, int type, int id, int severity, int length, ref byte buf)
		{
			unsafe
			{
				fixed (void* ptr = &buf) Capabilities.nglDebugMessageInsert(source, type, id, severity, length, (byte*)ptr);
			}
		}
		
		public static void glDebugMessageInsert<T>(int source, int type, int id, int severity, int length, ref T buf) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buf) Capabilities.nglDebugMessageInsert(source, type, id, severity, length, (byte*)ptr);
			}
		}
		
		public static void glDebugMessageInsert<T>(int source, int type, int id, int severity, int length, T[] buf) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buf) Capabilities.nglDebugMessageInsert(source, type, id, severity, length, (byte*)ptr);
			}
		}
		
		public static void glDebugMessageInsert(int source, int type, int id, int severity, int length, byte[] buf)
		{
			unsafe
			{
				fixed (byte* bufPtr = buf)
				{
					Capabilities.nglDebugMessageInsert(source, type, id, severity, length, bufPtr);
				}
			}
		}
		
		public static void glDebugMessageCallback(IntPtr callback, IntPtr userParam)
		{
			unsafe
			{
				Capabilities.nglDebugMessageCallback(callback, userParam.ToPointer());
			}
		}
		
		public static int glGetDebugMessageLog(int count, int bufSize, IntPtr sources, IntPtr types, IntPtr ids, IntPtr severities, IntPtr lengths, IntPtr messageLog)
		{
			unsafe
			{
				return Capabilities.nglGetDebugMessageLog(count, bufSize, (int*)sources.ToPointer(), (int*)types.ToPointer(), (int*)ids.ToPointer(), (int*)severities.ToPointer(), (int*)lengths.ToPointer(), (byte*)messageLog.ToPointer());
			}
		}
		
		public static void glGetDebugMessageLog(int count, int bufSize, int[] sources, int[] types, int[] ids, int[] severities, int[] lengths, byte[] messageLog)
		{
			unsafe
			{
				fixed (int* sourcesPtr = sources)
				{
					fixed (int* typesPtr = types)
					{
						fixed (int* idsPtr = ids)
						{
							fixed (int* severitiesPtr = severities)
							{
								fixed (int* lengthsPtr = lengths)
								{
									fixed (byte* messageLogPtr = messageLog)
									{
										Capabilities.nglGetDebugMessageLog(count, bufSize, sourcesPtr, typesPtr, idsPtr, severitiesPtr, lengthsPtr, messageLogPtr);
									}
								}
							}
						}
					}
				}
			}
		}
		
		public static void glPushDebugGroup(int source, int id, int length, IntPtr message)
		{
			unsafe
			{
				Capabilities.nglPushDebugGroup(source, id, length, (byte*)message.ToPointer());
			}
		}
		
		public static void glPushDebugGroup(int source, int id, int length, ref byte message)
		{
			unsafe
			{
				fixed (void* ptr = &message) Capabilities.nglPushDebugGroup(source, id, length, (byte*)ptr);
			}
		}
		
		public static void glPushDebugGroup<T>(int source, int id, int length, ref T message) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &message) Capabilities.nglPushDebugGroup(source, id, length, (byte*)ptr);
			}
		}
		
		public static void glPushDebugGroup<T>(int source, int id, int length, T[] message) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = message) Capabilities.nglPushDebugGroup(source, id, length, (byte*)ptr);
			}
		}
		
		public static void glPushDebugGroup(int source, int id, int length, byte[] message)
		{
			unsafe
			{
				fixed (byte* messagePtr = message)
				{
					Capabilities.nglPushDebugGroup(source, id, length, messagePtr);
				}
			}
		}
		
		public static void glPopDebugGroup() =>
			Capabilities.nglPopDebugGroup();
		
		public static void glObjectLabel(int identifier, int name, int length, IntPtr label)
		{
			unsafe
			{
				Capabilities.nglObjectLabel(identifier, name, length, (byte*)label.ToPointer());
			}
		}
		
		public static void glObjectLabel(int identifier, int name, int length, ref byte label)
		{
			unsafe
			{
				fixed (void* ptr = &label) Capabilities.nglObjectLabel(identifier, name, length, (byte*)ptr);
			}
		}
		
		public static void glObjectLabel<T>(int identifier, int name, int length, ref T label) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &label) Capabilities.nglObjectLabel(identifier, name, length, (byte*)ptr);
			}
		}
		
		public static void glObjectLabel<T>(int identifier, int name, int length, T[] label) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = label) Capabilities.nglObjectLabel(identifier, name, length, (byte*)ptr);
			}
		}
		
		public static void glObjectLabel(int identifier, int name, int length, byte[] label)
		{
			unsafe
			{
				fixed (byte* labelPtr = label)
				{
					Capabilities.nglObjectLabel(identifier, name, length, labelPtr);
				}
			}
		}
		
		public static void glGetObjectLabel(int identifier, int name, int bufSize, IntPtr length, IntPtr label)
		{
			unsafe
			{
				Capabilities.nglGetObjectLabel(identifier, name, bufSize, (int*)length.ToPointer(), (byte*)label.ToPointer());
			}
		}
		
		public static void glGetObjectLabel(int identifier, int name, int bufSize, int[] length, byte[] label)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* labelPtr = label)
					{
						Capabilities.nglGetObjectLabel(identifier, name, bufSize, lengthPtr, labelPtr);
					}
				}
			}
		}
		
		public static void glObjectPtrLabel(IntPtr ptr, int length, IntPtr label)
		{
			unsafe
			{
				Capabilities.nglObjectPtrLabel(ptr.ToPointer(), length, (byte*)label.ToPointer());
			}
		}
		
		public static void glGetObjectPtrLabel(IntPtr ptr, int bufSize, IntPtr length, IntPtr label)
		{
			unsafe
			{
				Capabilities.nglGetObjectPtrLabel(ptr.ToPointer(), bufSize, (int*)length.ToPointer(), (byte*)label.ToPointer());
			}
		}
		
		
	}
}
