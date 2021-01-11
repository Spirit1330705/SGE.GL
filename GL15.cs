using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_BUFFER_SIZE = 0x8764;
		public const int GL_BUFFER_USAGE = 0x8765;
		public const int GL_QUERY_COUNTER_BITS = 0x8864;
		public const int GL_CURRENT_QUERY = 0x8865;
		public const int GL_QUERY_RESULT = 0x8866;
		public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;
		public const int GL_ARRAY_BUFFER = 0x8892;
		public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const int GL_READ_ONLY = 0x88B8;
		public const int GL_WRITE_ONLY = 0x88B9;
		public const int GL_READ_WRITE = 0x88BA;
		public const int GL_BUFFER_ACCESS = 0x88BB;
		public const int GL_BUFFER_MAPPED = 0x88BC;
		public const int GL_BUFFER_MAP_POINTER = 0x88BD;
		public const int GL_STREAM_DRAW = 0x88E0;
		public const int GL_STREAM_READ = 0x88E1;
		public const int GL_STREAM_COPY = 0x88E2;
		public const int GL_STATIC_DRAW = 0x88E4;
		public const int GL_STATIC_READ = 0x88E5;
		public const int GL_STATIC_COPY = 0x88E6;
		public const int GL_DYNAMIC_DRAW = 0x88E8;
		public const int GL_DYNAMIC_READ = 0x88E9;
		public const int GL_DYNAMIC_COPY = 0x88EA;
		public const int GL_SAMPLES_PASSED = 0x8914;
		public const int GL_SRC1_ALPHA = 0x8589;
		public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
		public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
		public const int GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
		public const int GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
		public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
		public const int GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
		public const int GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
		public const int GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
		public const int GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
		public const int GL_FOG_COORD_SRC = 0x8450;
		public const int GL_FOG_COORD = 0x8451;
		public const int GL_CURRENT_FOG_COORD = 0x8453;
		public const int GL_FOG_COORD_ARRAY_TYPE = 0x8454;
		public const int GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
		public const int GL_FOG_COORD_ARRAY_POINTER = 0x8456;
		public const int GL_FOG_COORD_ARRAY = 0x8457;
		public const int GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
		public const int GL_SRC0_RGB = 0x8580;
		public const int GL_SRC1_RGB = 0x8581;
		public const int GL_SRC2_RGB = 0x8582;
		public const int GL_SRC0_ALPHA = 0x8588;
		public const int GL_SRC2_ALPHA = 0x858A;
		#endregion // Constants
		
		public static void glGenQueries(int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglGenQueries(n, (int*)ids.ToPointer());
			}
		}
		
		public static void glGenQueries(int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglGenQueries(n, (int*)ptr);
			}
		}
		
		public static void glGenQueries<T>(int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglGenQueries(n, (int*)ptr);
			}
		}
		
		public static void glGenQueries<T>(int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglGenQueries(n, (int*)ptr);
			}
		}
		
		public static void glGenQueries(int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglGenQueries(n, idsPtr);
				}
			}
		}
		
		public static int glGenQueries()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenQueries(1, &val);
				return val;
			}
		}
		
		public static void glGenQueries(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenQueries(names.Length, ptr);
			}
		}
		
		public static void glDeleteQueries(int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglDeleteQueries(n, (int*)ids.ToPointer());
			}
		}
		
		public static void glDeleteQueries(int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDeleteQueries(n, (int*)ptr);
			}
		}
		
		public static void glDeleteQueries<T>(int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglDeleteQueries(n, (int*)ptr);
			}
		}
		
		public static void glDeleteQueries<T>(int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglDeleteQueries(n, (int*)ptr);
			}
		}
		
		public static void glDeleteQueries(int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglDeleteQueries(n, idsPtr);
				}
			}
		}
		
		public static void glDeleteQueries(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteQueries(1, &name);
			}
		}
		
		public static void glDeleteQueries(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteQueries(names.Length, ptr);
			}
		}
		
		public static byte glIsQuery(int id) =>
			Capabilities.nglIsQuery(id);
		
		public static void glBeginQuery(int target, int id) =>
			Capabilities.nglBeginQuery(target, id);
		
		public static void glEndQuery(int target) =>
			Capabilities.nglEndQuery(target);
		
		public static void glGetQueryiv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryiv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryiv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryiv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryiv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryiv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryiv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryiv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetQueryObjectiv(int id, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryObjectiv(id, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryObjectiv(int id, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectiv<T>(int id, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectiv<T>(int id, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryObjectiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectiv(int id, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryObjectiv(id, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetQueryObjectuiv(int id, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetQueryObjectuiv(id, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetQueryObjectuiv(int id, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectuiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectuiv<T>(int id, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetQueryObjectuiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectuiv<T>(int id, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetQueryObjectuiv(id, pname, (int*)ptr);
			}
		}
		
		public static void glGetQueryObjectuiv(int id, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetQueryObjectuiv(id, pname, _paramsPtr);
				}
			}
		}
		
		public static void glBindBuffer(int target, int buffer) =>
			Capabilities.nglBindBuffer(target, buffer);
		
		public static void glDeleteBuffers(int n, IntPtr buffers)
		{
			unsafe
			{
				Capabilities.nglDeleteBuffers(n, (int*)buffers.ToPointer());
			}
		}
		
		public static void glDeleteBuffers(int n, ref int buffers)
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglDeleteBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteBuffers<T>(int n, ref T buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglDeleteBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteBuffers<T>(int n, T[] buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffers) Capabilities.nglDeleteBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDeleteBuffers(int n, int[] buffers)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					Capabilities.nglDeleteBuffers(n, buffersPtr);
				}
			}
		}
		
		public static void glDeleteBuffers(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteBuffers(1, &name);
			}
		}
		
		public static void glDeleteBuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteBuffers(names.Length, ptr);
			}
		}
		
		public static void glGenBuffers(int n, IntPtr buffers)
		{
			unsafe
			{
				Capabilities.nglGenBuffers(n, (int*)buffers.ToPointer());
			}
		}
		
		public static void glGenBuffers(int n, ref int buffers)
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglGenBuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenBuffers<T>(int n, ref T buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglGenBuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenBuffers<T>(int n, T[] buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffers) Capabilities.nglGenBuffers(n, (int*)ptr);
			}
		}
		
		public static void glGenBuffers(int n, int[] buffers)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					Capabilities.nglGenBuffers(n, buffersPtr);
				}
			}
		}
		
		public static int glGenBuffers()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenBuffers(1, &val);
				return val;
			}
		}
		
		public static void glGenBuffers(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenBuffers(names.Length, ptr);
			}
		}
		
		public static byte glIsBuffer(int buffer) =>
			Capabilities.nglIsBuffer(buffer);
		
		public static void glBufferData(int target, IntPtr size, IntPtr data, int usage)
		{
			unsafe
			{
				Capabilities.nglBufferData(target, size, data.ToPointer(), usage);
			}
		}
		
		public static void glBufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglBufferSubData(target, offset, size, data.ToPointer());
			}
		}
		
		public static void glGetBufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetBufferSubData(target, offset, size, data.ToPointer());
			}
		}
		
		public static IntPtr glMapBuffer(int target, int access)
		{
			unsafe
			{
				return new IntPtr(Capabilities.nglMapBuffer(target, access));
			}
		}
		
		public static byte glUnmapBuffer(int target) =>
			Capabilities.nglUnmapBuffer(target);
		
		public static void glGetBufferParameteriv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetBufferParameteriv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetBufferParameteriv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetBufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetBufferParameteriv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetBufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetBufferParameteriv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetBufferParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetBufferParameteriv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetBufferParameteriv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetBufferPointerv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetBufferPointerv(target, pname, (void**)_params.ToPointer());
			}
		}
		
		
	}
}
