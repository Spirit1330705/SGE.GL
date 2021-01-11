using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const int GL_SRC1_COLOR = 0x88F9;
		public const int GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const int GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const int GL_ANY_SAMPLES_PASSED = 0x8C2F;
		public const int GL_SAMPLER_BINDING = 0x8919;
		public const int GL_RGB10_A2UI = 0x906F;
		public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const int GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const int GL_TIME_ELAPSED = 0x88BF;
		public const int GL_TIMESTAMP = 0x8E28;
		public const int GL_INT_2_10_10_10_REV = 0x8D9F;
		#endregion // Constants
		
		public static void glBindFragDataLocationIndexed(int program, int colorNumber, int index, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglBindFragDataLocationIndexed(program, colorNumber, index, (byte*)name.ToPointer());
			}
		}
		
		public static void glBindFragDataLocationIndexed(int program, int colorNumber, int index, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindFragDataLocationIndexed(program, colorNumber, index, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocationIndexed<T>(int program, int colorNumber, int index, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindFragDataLocationIndexed(program, colorNumber, index, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocationIndexed<T>(int program, int colorNumber, int index, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglBindFragDataLocationIndexed(program, colorNumber, index, (byte*)ptr);
			}
		}
		
		public static void glBindFragDataLocationIndexed(int program, int colorNumber, int index, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglBindFragDataLocationIndexed(program, colorNumber, index, namePtr);
				}
			}
		}
		
		public static int glGetFragDataIndex(int program, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetFragDataIndex(program, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetFragDataIndex(int program, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetFragDataIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataIndex<T>(int program, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetFragDataIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataIndex<T>(int program, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetFragDataIndex(program, (byte*)ptr);
			}
		}
		
		public static void glGetFragDataIndex(int program, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetFragDataIndex(program, namePtr);
				}
			}
		}
		
		public static void glGenSamplers(int count, IntPtr samplers)
		{
			unsafe
			{
				Capabilities.nglGenSamplers(count, (int*)samplers.ToPointer());
			}
		}
		
		public static void glGenSamplers(int count, ref int samplers)
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglGenSamplers(count, (int*)ptr);
			}
		}
		
		public static void glGenSamplers<T>(int count, ref T samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglGenSamplers(count, (int*)ptr);
			}
		}
		
		public static void glGenSamplers<T>(int count, T[] samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = samplers) Capabilities.nglGenSamplers(count, (int*)ptr);
			}
		}
		
		public static void glGenSamplers(int count, int[] samplers)
		{
			unsafe
			{
				fixed (int* samplersPtr = samplers)
				{
					Capabilities.nglGenSamplers(count, samplersPtr);
				}
			}
		}
		
		public static int glGenSamplers()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenSamplers(1, &val);
				return val;
			}
		}
		
		public static void glGenSamplers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenSamplers(names.Length, ptr);
			}
		}
		
		public static void glDeleteSamplers(int count, IntPtr samplers)
		{
			unsafe
			{
				Capabilities.nglDeleteSamplers(count, (int*)samplers.ToPointer());
			}
		}
		
		public static void glDeleteSamplers(int count, ref int samplers)
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglDeleteSamplers(count, (int*)ptr);
			}
		}
		
		public static void glDeleteSamplers<T>(int count, ref T samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglDeleteSamplers(count, (int*)ptr);
			}
		}
		
		public static void glDeleteSamplers<T>(int count, T[] samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = samplers) Capabilities.nglDeleteSamplers(count, (int*)ptr);
			}
		}
		
		public static void glDeleteSamplers(int count, int[] samplers)
		{
			unsafe
			{
				fixed (int* samplersPtr = samplers)
				{
					Capabilities.nglDeleteSamplers(count, samplersPtr);
				}
			}
		}
		
		public static void glDeleteSamplers(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteSamplers(1, &name);
			}
		}
		
		public static void glDeleteSamplers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteSamplers(names.Length, ptr);
			}
		}
		
		public static byte glIsSampler(int sampler) =>
			Capabilities.nglIsSampler(sampler);
		
		public static void glBindSampler(int unit, int sampler) =>
			Capabilities.nglBindSampler(unit, sampler);
		
		public static void glSamplerParameteri(int sampler, int pname, int param) =>
			Capabilities.nglSamplerParameteri(sampler, pname, param);
		
		public static void glSamplerParameteriv(int sampler, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglSamplerParameteriv(sampler, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glSamplerParameteriv(int sampler, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameteriv<T>(int sampler, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameteriv<T>(int sampler, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameteriv(int sampler, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglSamplerParameteriv(sampler, pname, paramPtr);
				}
			}
		}
		
		public static void glSamplerParameterf(int sampler, int pname, float param) =>
			Capabilities.nglSamplerParameterf(sampler, pname, param);
		
		public static void glSamplerParameterfv(int sampler, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglSamplerParameterfv(sampler, pname, (float*)param.ToPointer());
			}
		}
		
		public static void glSamplerParameterfv(int sampler, int pname, ref float param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glSamplerParameterfv<T>(int sampler, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glSamplerParameterfv<T>(int sampler, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glSamplerParameterfv(int sampler, int pname, float[] param)
		{
			unsafe
			{
				fixed (float* paramPtr = param)
				{
					Capabilities.nglSamplerParameterfv(sampler, pname, paramPtr);
				}
			}
		}
		
		public static void glSamplerParameterIiv(int sampler, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglSamplerParameterIiv(sampler, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glSamplerParameterIiv(int sampler, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIiv<T>(int sampler, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIiv<T>(int sampler, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIiv(int sampler, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglSamplerParameterIiv(sampler, pname, paramPtr);
				}
			}
		}
		
		public static void glSamplerParameterIuiv(int sampler, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglSamplerParameterIuiv(sampler, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glSamplerParameterIuiv(int sampler, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIuiv<T>(int sampler, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIuiv<T>(int sampler, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glSamplerParameterIuiv(int sampler, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglSamplerParameterIuiv(sampler, pname, paramPtr);
				}
			}
		}
		
		public static void glGetSamplerParameteriv(int sampler, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetSamplerParameteriv(sampler, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetSamplerParameteriv(int sampler, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameteriv<T>(int sampler, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameteriv<T>(int sampler, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetSamplerParameteriv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameteriv(int sampler, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetSamplerParameteriv(sampler, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetSamplerParameterIiv(int sampler, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetSamplerParameterIiv(sampler, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetSamplerParameterIiv(int sampler, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIiv<T>(int sampler, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIiv<T>(int sampler, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetSamplerParameterIiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIiv(int sampler, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetSamplerParameterIiv(sampler, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetSamplerParameterfv(int sampler, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetSamplerParameterfv(sampler, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetSamplerParameterfv(int sampler, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glGetSamplerParameterfv<T>(int sampler, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glGetSamplerParameterfv<T>(int sampler, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetSamplerParameterfv(sampler, pname, (float*)ptr);
			}
		}
		
		public static void glGetSamplerParameterfv(int sampler, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetSamplerParameterfv(sampler, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetSamplerParameterIuiv(int sampler, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetSamplerParameterIuiv(sampler, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetSamplerParameterIuiv(int sampler, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIuiv<T>(int sampler, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIuiv<T>(int sampler, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetSamplerParameterIuiv(sampler, pname, (int*)ptr);
			}
		}
		
		public static void glGetSamplerParameterIuiv(int sampler, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetSamplerParameterIuiv(sampler, pname, _paramsPtr);
				}
			}
		}
		
		public static void glQueryCounter(int id, int target) =>
			Capabilities.nglQueryCounter(id, target);
		
		public static void glGetQueryObjecti64v(int id, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryObjecti64v(id, pname, (long*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryObjecti64v(int id, int pname, ref long _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjecti64v(id, pname, (long*)ptr);
			}
		}
		
		public static void glGetQueryObjecti64v<T>(int id, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjecti64v(id, pname, (long*)ptr);
			}
		}
		
		public static void glGetQueryObjecti64v<T>(int id, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryObjecti64v(id, pname, (long*)ptr);
			}
		}
		
		public static void glGetQueryObjecti64v(int id, int pname, long[] _params)
		{
			unsafe
			{
				fixed (long* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryObjecti64v(id, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetQueryObjectui64v(int id, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryObjectui64v(id, pname, (ulong*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryObjectui64v(int id, int pname, ref ulong _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectui64v(id, pname, (ulong*)ptr);
			}
		}
		
		public static void glGetQueryObjectui64v<T>(int id, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectui64v(id, pname, (ulong*)ptr);
			}
		}
		
		public static void glGetQueryObjectui64v<T>(int id, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryObjectui64v(id, pname, (ulong*)ptr);
			}
		}
		
		public static void glGetQueryObjectui64v(int id, int pname, ulong[] _params)
		{
			unsafe
			{
				fixed (ulong* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryObjectui64v(id, pname, _paramsPtr);
				}
			}
		}
		
		public static void glVertexAttribDivisor(int index, int divisor) =>
			Capabilities.nglVertexAttribDivisor(index, divisor);
		
		public static void glVertexAttribP1ui(int index, int type, byte normalized, int value) =>
			Capabilities.nglVertexAttribP1ui(index, type, normalized, value);
		
		public static void glVertexAttribP1uiv(int index, int type, byte normalized, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexAttribP1uiv(index, type, normalized, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexAttribP1uiv(int index, int type, byte normalized, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP1uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP1uiv<T>(int index, int type, byte normalized, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP1uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP1uiv<T>(int index, int type, byte normalized, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexAttribP1uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP1uiv(int index, int type, byte normalized, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexAttribP1uiv(index, type, normalized, valuePtr);
				}
			}
		}
		
		public static void glVertexAttribP2ui(int index, int type, byte normalized, int value) =>
			Capabilities.nglVertexAttribP2ui(index, type, normalized, value);
		
		public static void glVertexAttribP2uiv(int index, int type, byte normalized, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexAttribP2uiv(index, type, normalized, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexAttribP2uiv(int index, int type, byte normalized, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP2uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP2uiv<T>(int index, int type, byte normalized, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP2uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP2uiv<T>(int index, int type, byte normalized, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexAttribP2uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP2uiv(int index, int type, byte normalized, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexAttribP2uiv(index, type, normalized, valuePtr);
				}
			}
		}
		
		public static void glVertexAttribP3ui(int index, int type, byte normalized, int value) =>
			Capabilities.nglVertexAttribP3ui(index, type, normalized, value);
		
		public static void glVertexAttribP3uiv(int index, int type, byte normalized, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexAttribP3uiv(index, type, normalized, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexAttribP3uiv(int index, int type, byte normalized, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP3uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP3uiv<T>(int index, int type, byte normalized, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP3uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP3uiv<T>(int index, int type, byte normalized, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexAttribP3uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP3uiv(int index, int type, byte normalized, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexAttribP3uiv(index, type, normalized, valuePtr);
				}
			}
		}
		
		public static void glVertexAttribP4ui(int index, int type, byte normalized, int value) =>
			Capabilities.nglVertexAttribP4ui(index, type, normalized, value);
		
		public static void glVertexAttribP4uiv(int index, int type, byte normalized, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexAttribP4uiv(index, type, normalized, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexAttribP4uiv(int index, int type, byte normalized, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP4uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP4uiv<T>(int index, int type, byte normalized, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexAttribP4uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP4uiv<T>(int index, int type, byte normalized, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexAttribP4uiv(index, type, normalized, (int*)ptr);
			}
		}
		
		public static void glVertexAttribP4uiv(int index, int type, byte normalized, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexAttribP4uiv(index, type, normalized, valuePtr);
				}
			}
		}
		
		public static void glVertexP2ui(int type, int value) =>
			Capabilities.nglVertexP2ui(type, value);
		
		public static void glVertexP2uiv(int type, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexP2uiv(type, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexP2uiv(int type, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP2uiv<T>(int type, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP2uiv<T>(int type, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP2uiv(int type, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexP2uiv(type, valuePtr);
				}
			}
		}
		
		public static void glVertexP3ui(int type, int value) =>
			Capabilities.nglVertexP3ui(type, value);
		
		public static void glVertexP3uiv(int type, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexP3uiv(type, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexP3uiv(int type, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP3uiv<T>(int type, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP3uiv<T>(int type, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP3uiv(int type, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexP3uiv(type, valuePtr);
				}
			}
		}
		
		public static void glVertexP4ui(int type, int value) =>
			Capabilities.nglVertexP4ui(type, value);
		
		public static void glVertexP4uiv(int type, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglVertexP4uiv(type, (int*)value.ToPointer());
			}
		}
		
		public static void glVertexP4uiv(int type, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP4uiv<T>(int type, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglVertexP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP4uiv<T>(int type, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglVertexP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glVertexP4uiv(int type, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglVertexP4uiv(type, valuePtr);
				}
			}
		}
		
		public static void glTexCoordP1ui(int type, int coords) =>
			Capabilities.nglTexCoordP1ui(type, coords);
		
		public static void glTexCoordP1uiv(int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglTexCoordP1uiv(type, (int*)coords.ToPointer());
			}
		}
		
		public static void glTexCoordP1uiv(int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP1uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP1uiv<T>(int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP1uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP1uiv<T>(int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglTexCoordP1uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP1uiv(int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglTexCoordP1uiv(type, coordsPtr);
				}
			}
		}
		
		public static void glTexCoordP2ui(int type, int coords) =>
			Capabilities.nglTexCoordP2ui(type, coords);
		
		public static void glTexCoordP2uiv(int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglTexCoordP2uiv(type, (int*)coords.ToPointer());
			}
		}
		
		public static void glTexCoordP2uiv(int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP2uiv<T>(int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP2uiv<T>(int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglTexCoordP2uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP2uiv(int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglTexCoordP2uiv(type, coordsPtr);
				}
			}
		}
		
		public static void glTexCoordP3ui(int type, int coords) =>
			Capabilities.nglTexCoordP3ui(type, coords);
		
		public static void glTexCoordP3uiv(int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglTexCoordP3uiv(type, (int*)coords.ToPointer());
			}
		}
		
		public static void glTexCoordP3uiv(int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP3uiv<T>(int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP3uiv<T>(int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglTexCoordP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP3uiv(int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglTexCoordP3uiv(type, coordsPtr);
				}
			}
		}
		
		public static void glTexCoordP4ui(int type, int coords) =>
			Capabilities.nglTexCoordP4ui(type, coords);
		
		public static void glTexCoordP4uiv(int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglTexCoordP4uiv(type, (int*)coords.ToPointer());
			}
		}
		
		public static void glTexCoordP4uiv(int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP4uiv<T>(int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglTexCoordP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP4uiv<T>(int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglTexCoordP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glTexCoordP4uiv(int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglTexCoordP4uiv(type, coordsPtr);
				}
			}
		}
		
		public static void glMultiTexCoordP1ui(int texture, int type, int coords) =>
			Capabilities.nglMultiTexCoordP1ui(texture, type, coords);
		
		public static void glMultiTexCoordP1uiv(int texture, int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoordP1uiv(texture, type, (int*)coords.ToPointer());
			}
		}
		
		public static void glMultiTexCoordP1uiv(int texture, int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP1uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP1uiv<T>(int texture, int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP1uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP1uiv<T>(int texture, int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglMultiTexCoordP1uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP1uiv(int texture, int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglMultiTexCoordP1uiv(texture, type, coordsPtr);
				}
			}
		}
		
		public static void glMultiTexCoordP2ui(int texture, int type, int coords) =>
			Capabilities.nglMultiTexCoordP2ui(texture, type, coords);
		
		public static void glMultiTexCoordP2uiv(int texture, int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoordP2uiv(texture, type, (int*)coords.ToPointer());
			}
		}
		
		public static void glMultiTexCoordP2uiv(int texture, int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP2uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP2uiv<T>(int texture, int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP2uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP2uiv<T>(int texture, int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglMultiTexCoordP2uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP2uiv(int texture, int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglMultiTexCoordP2uiv(texture, type, coordsPtr);
				}
			}
		}
		
		public static void glMultiTexCoordP3ui(int texture, int type, int coords) =>
			Capabilities.nglMultiTexCoordP3ui(texture, type, coords);
		
		public static void glMultiTexCoordP3uiv(int texture, int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoordP3uiv(texture, type, (int*)coords.ToPointer());
			}
		}
		
		public static void glMultiTexCoordP3uiv(int texture, int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP3uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP3uiv<T>(int texture, int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP3uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP3uiv<T>(int texture, int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglMultiTexCoordP3uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP3uiv(int texture, int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglMultiTexCoordP3uiv(texture, type, coordsPtr);
				}
			}
		}
		
		public static void glMultiTexCoordP4ui(int texture, int type, int coords) =>
			Capabilities.nglMultiTexCoordP4ui(texture, type, coords);
		
		public static void glMultiTexCoordP4uiv(int texture, int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglMultiTexCoordP4uiv(texture, type, (int*)coords.ToPointer());
			}
		}
		
		public static void glMultiTexCoordP4uiv(int texture, int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP4uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP4uiv<T>(int texture, int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglMultiTexCoordP4uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP4uiv<T>(int texture, int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglMultiTexCoordP4uiv(texture, type, (int*)ptr);
			}
		}
		
		public static void glMultiTexCoordP4uiv(int texture, int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglMultiTexCoordP4uiv(texture, type, coordsPtr);
				}
			}
		}
		
		public static void glNormalP3ui(int type, int coords) =>
			Capabilities.nglNormalP3ui(type, coords);
		
		public static void glNormalP3uiv(int type, IntPtr coords)
		{
			unsafe
			{
				Capabilities.nglNormalP3uiv(type, (int*)coords.ToPointer());
			}
		}
		
		public static void glNormalP3uiv(int type, ref int coords)
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglNormalP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glNormalP3uiv<T>(int type, ref T coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &coords) Capabilities.nglNormalP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glNormalP3uiv<T>(int type, T[] coords) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = coords) Capabilities.nglNormalP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glNormalP3uiv(int type, int[] coords)
		{
			unsafe
			{
				fixed (int* coordsPtr = coords)
				{
					Capabilities.nglNormalP3uiv(type, coordsPtr);
				}
			}
		}
		
		public static void glColorP3ui(int type, int color) =>
			Capabilities.nglColorP3ui(type, color);
		
		public static void glColorP3uiv(int type, IntPtr color)
		{
			unsafe
			{
				Capabilities.nglColorP3uiv(type, (int*)color.ToPointer());
			}
		}
		
		public static void glColorP3uiv(int type, ref int color)
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP3uiv<T>(int type, ref T color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP3uiv<T>(int type, T[] color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = color) Capabilities.nglColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP3uiv(int type, int[] color)
		{
			unsafe
			{
				fixed (int* colorPtr = color)
				{
					Capabilities.nglColorP3uiv(type, colorPtr);
				}
			}
		}
		
		public static void glColorP4ui(int type, int color) =>
			Capabilities.nglColorP4ui(type, color);
		
		public static void glColorP4uiv(int type, IntPtr color)
		{
			unsafe
			{
				Capabilities.nglColorP4uiv(type, (int*)color.ToPointer());
			}
		}
		
		public static void glColorP4uiv(int type, ref int color)
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglColorP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP4uiv<T>(int type, ref T color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglColorP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP4uiv<T>(int type, T[] color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = color) Capabilities.nglColorP4uiv(type, (int*)ptr);
			}
		}
		
		public static void glColorP4uiv(int type, int[] color)
		{
			unsafe
			{
				fixed (int* colorPtr = color)
				{
					Capabilities.nglColorP4uiv(type, colorPtr);
				}
			}
		}
		
		public static void glSecondaryColorP3ui(int type, int color) =>
			Capabilities.nglSecondaryColorP3ui(type, color);
		
		public static void glSecondaryColorP3uiv(int type, IntPtr color)
		{
			unsafe
			{
				Capabilities.nglSecondaryColorP3uiv(type, (int*)color.ToPointer());
			}
		}
		
		public static void glSecondaryColorP3uiv(int type, ref int color)
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglSecondaryColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glSecondaryColorP3uiv<T>(int type, ref T color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &color) Capabilities.nglSecondaryColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glSecondaryColorP3uiv<T>(int type, T[] color) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = color) Capabilities.nglSecondaryColorP3uiv(type, (int*)ptr);
			}
		}
		
		public static void glSecondaryColorP3uiv(int type, int[] color)
		{
			unsafe
			{
				fixed (int* colorPtr = color)
				{
					Capabilities.nglSecondaryColorP3uiv(type, colorPtr);
				}
			}
		}
		
		
	}
}
