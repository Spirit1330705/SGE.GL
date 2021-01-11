using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const int GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const int GL_LINES_ADJACENCY = 0x000A;
		public const int GL_LINE_STRIP_ADJACENCY = 0x000B;
		public const int GL_TRIANGLES_ADJACENCY = 0x000C;
		public const int GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const int GL_PROGRAM_POINT_SIZE = 0x8642;
		public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const int GL_GEOMETRY_SHADER = 0x8DD9;
		public const int GL_GEOMETRY_VERTICES_OUT = 0x8916;
		public const int GL_GEOMETRY_INPUT_TYPE = 0x8917;
		public const int GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const int GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const int GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const int GL_CONTEXT_PROFILE_MASK = 0x9126;
		public const int GL_DEPTH_CLAMP = 0x864F;
		public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const int GL_PROVOKING_VERTEX = 0x8E4F;
		public const int GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const int GL_OBJECT_TYPE = 0x9112;
		public const int GL_SYNC_CONDITION = 0x9113;
		public const int GL_SYNC_STATUS = 0x9114;
		public const int GL_SYNC_FLAGS = 0x9115;
		public const int GL_SYNC_FENCE = 0x9116;
		public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const int GL_UNSIGNALED = 0x9118;
		public const int GL_SIGNALED = 0x9119;
		public const int GL_ALREADY_SIGNALED = 0x911A;
		public const int GL_TIMEOUT_EXPIRED = 0x911B;
		public const int GL_CONDITION_SATISFIED = 0x911C;
		public const int GL_WAIT_FAILED = 0x911D;
		public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const int GL_SAMPLE_POSITION = 0x8E50;
		public const int GL_SAMPLE_MASK = 0x8E51;
		public const int GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const int GL_TEXTURE_SAMPLES = 0x9106;
		public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const int GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const int GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const int GL_MAX_INTEGER_SAMPLES = 0x9110;
		#endregion // Constants
		
		public static void glDrawElementsBaseVertex(int mode, int count, int type, IntPtr indices, int basevertex)
		{
			unsafe
			{
				Capabilities.nglDrawElementsBaseVertex(mode, count, type, indices.ToPointer(), basevertex);
			}
		}
		
		public static void glDrawRangeElementsBaseVertex(int mode, int start, int end, int count, int type, IntPtr indices, int basevertex)
		{
			unsafe
			{
				Capabilities.nglDrawRangeElementsBaseVertex(mode, start, end, count, type, indices.ToPointer(), basevertex);
			}
		}
		
		public static void glDrawElementsInstancedBaseVertex(int mode, int count, int type, IntPtr indices, int instancecount, int basevertex)
		{
			unsafe
			{
				Capabilities.nglDrawElementsInstancedBaseVertex(mode, count, type, indices.ToPointer(), instancecount, basevertex);
			}
		}
		
		public static void glMultiDrawElementsBaseVertex(int mode, IntPtr count, int type, IntPtr indices, int drawcount, IntPtr basevertex)
		{
			unsafe
			{
				Capabilities.nglMultiDrawElementsBaseVertex(mode, (int*)count.ToPointer(), type, (void**)indices.ToPointer(), drawcount, (int*)basevertex.ToPointer());
			}
		}
		
		public static void glProvokingVertex(int mode) =>
			Capabilities.nglProvokingVertex(mode);
		
		public static IntPtr glFenceSync(int condition, int flags) =>
			Capabilities.nglFenceSync(condition, flags);
		
		public static byte glIsSync(IntPtr sync) =>
			Capabilities.nglIsSync(sync);
		
		public static void glDeleteSync(IntPtr sync) =>
			Capabilities.nglDeleteSync(sync);
		
		public static int glClientWaitSync(IntPtr sync, int flags, ulong timeout) =>
			Capabilities.nglClientWaitSync(sync, flags, timeout);
		
		public static void glWaitSync(IntPtr sync, int flags, ulong timeout) =>
			Capabilities.nglWaitSync(sync, flags, timeout);
		
		public static void glGetInteger64v(int pname, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetInteger64v(pname, (long*)data.ToPointer());
			}
		}
		
		public static void glGetInteger64v(int pname, ref long data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetInteger64v(pname, (long*)ptr);
			}
		}
		
		public static void glGetInteger64v<T>(int pname, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetInteger64v(pname, (long*)ptr);
			}
		}
		
		public static void glGetInteger64v<T>(int pname, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetInteger64v(pname, (long*)ptr);
			}
		}
		
		public static void glGetInteger64v(int pname, long[] data)
		{
			unsafe
			{
				fixed (long* dataPtr = data)
				{
					Capabilities.nglGetInteger64v(pname, dataPtr);
				}
			}
		}
		
		public static void glGetSynciv(IntPtr sync, int pname, int count, IntPtr length, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetSynciv(sync, pname, count, (int*)length.ToPointer(), (int*)values.ToPointer());
			}
		}
		
		public static void glGetSynciv(IntPtr sync, int pname, int count, int[] length, int[] values)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (int* valuesPtr = values)
					{
						Capabilities.nglGetSynciv(sync, pname, count, lengthPtr, valuesPtr);
					}
				}
			}
		}
		
		public static void glGetInteger64i_v(int target, int index, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetInteger64i_v(target, index, (long*)data.ToPointer());
			}
		}
		
		public static void glGetInteger64i_v(int target, int index, ref long data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetInteger64i_v(target, index, (long*)ptr);
			}
		}
		
		public static void glGetInteger64i_v<T>(int target, int index, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetInteger64i_v(target, index, (long*)ptr);
			}
		}
		
		public static void glGetInteger64i_v<T>(int target, int index, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetInteger64i_v(target, index, (long*)ptr);
			}
		}
		
		public static void glGetInteger64i_v(int target, int index, long[] data)
		{
			unsafe
			{
				fixed (long* dataPtr = data)
				{
					Capabilities.nglGetInteger64i_v(target, index, dataPtr);
				}
			}
		}
		
		public static void glGetBufferParameteri64v(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetBufferParameteri64v(target, pname, (long*)_params.ToPointer());
			}
		}
		
		public static void glGetBufferParameteri64v(int target, int pname, ref long _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetBufferParameteri64v(target, pname, (long*)ptr);
			}
		}
		
		public static void glGetBufferParameteri64v<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetBufferParameteri64v(target, pname, (long*)ptr);
			}
		}
		
		public static void glGetBufferParameteri64v<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetBufferParameteri64v(target, pname, (long*)ptr);
			}
		}
		
		public static void glGetBufferParameteri64v(int target, int pname, long[] _params)
		{
			unsafe
			{
				fixed (long* _paramsPtr = _params)
				{
					Capabilities.nglGetBufferParameteri64v(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glFramebufferTexture(int target, int attachment, int texture, int level) =>
			Capabilities.nglFramebufferTexture(target, attachment, texture, level);
		
		public static void glTexImage2DMultisample(int target, int samples, int internalformat, int width, int height, byte fixedsamplelocations) =>
			Capabilities.nglTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		
		public static void glTexImage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, byte fixedsamplelocations) =>
			Capabilities.nglTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		
		public static void glGetMultisamplefv(int pname, int index, IntPtr val)
		{
			unsafe
			{
				Capabilities.nglGetMultisamplefv(pname, index, (float*)val.ToPointer());
			}
		}
		
		public static void glGetMultisamplefv(int pname, int index, ref float val)
		{
			unsafe
			{
				fixed (void* ptr = &val) Capabilities.nglGetMultisamplefv(pname, index, (float*)ptr);
			}
		}
		
		public static void glGetMultisamplefv<T>(int pname, int index, ref T val) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &val) Capabilities.nglGetMultisamplefv(pname, index, (float*)ptr);
			}
		}
		
		public static void glGetMultisamplefv<T>(int pname, int index, T[] val) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = val) Capabilities.nglGetMultisamplefv(pname, index, (float*)ptr);
			}
		}
		
		public static void glGetMultisamplefv(int pname, int index, float[] val)
		{
			unsafe
			{
				fixed (float* valPtr = val)
				{
					Capabilities.nglGetMultisamplefv(pname, index, valPtr);
				}
			}
		}
		
		public static void glSampleMaski(int maskNumber, int mask) =>
			Capabilities.nglSampleMaski(maskNumber, mask);
		
		
	}
}
