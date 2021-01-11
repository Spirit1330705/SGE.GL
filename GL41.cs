using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_FIXED = 0x140C;
		public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const int GL_LOW_FLOAT = 0x8DF0;
		public const int GL_MEDIUM_FLOAT = 0x8DF1;
		public const int GL_HIGH_FLOAT = 0x8DF2;
		public const int GL_LOW_INT = 0x8DF3;
		public const int GL_MEDIUM_INT = 0x8DF4;
		public const int GL_HIGH_INT = 0x8DF5;
		public const int GL_SHADER_COMPILER = 0x8DFA;
		public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const int GL_RGB565 = 0x8D62;
		public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
		public const int GL_VERTEX_SHADER_BIT = 0x00000001;
		public const int GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const int GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const int GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const int GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const int GL_ALL_SHADER_BITS = -1;
		public const int GL_PROGRAM_SEPARABLE = 0x8258;
		public const int GL_ACTIVE_PROGRAM = 0x8259;
		public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const int GL_MAX_VIEWPORTS = 0x825B;
		public const int GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const int GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const int GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const int GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const int GL_UNDEFINED_VERTEX = 0x8260;
		#endregion // Constants
		
		public static void glReleaseShaderCompiler() =>
			Capabilities.nglReleaseShaderCompiler();
		
		public static void glShaderBinary(int count, IntPtr shaders, int binaryFormat, IntPtr binary, int length)
		{
			unsafe
			{
				Capabilities.nglShaderBinary(count, (int*)shaders.ToPointer(), binaryFormat, binary.ToPointer(), length);
			}
		}
		
		public static void glGetShaderPrecisionFormat(int shadertype, int precisiontype, IntPtr range, IntPtr precision)
		{
			unsafe
			{
				Capabilities.nglGetShaderPrecisionFormat(shadertype, precisiontype, (int*)range.ToPointer(), (int*)precision.ToPointer());
			}
		}
		
		public static void glGetShaderPrecisionFormat(int shadertype, int precisiontype, int[] range, int[] precision)
		{
			unsafe
			{
				fixed (int* rangePtr = range)
				{
					fixed (int* precisionPtr = precision)
					{
						Capabilities.nglGetShaderPrecisionFormat(shadertype, precisiontype, rangePtr, precisionPtr);
					}
				}
			}
		}
		
		public static void glDepthRangef(float n, float f) =>
			Capabilities.nglDepthRangef(n, f);
		
		public static void glClearDepthf(float d) =>
			Capabilities.nglClearDepthf(d);
		
		public static void glGetProgramBinary(int program, int bufSize, IntPtr length, IntPtr binaryFormat, IntPtr binary)
		{
			unsafe
			{
				Capabilities.nglGetProgramBinary(program, bufSize, (int*)length.ToPointer(), (int*)binaryFormat.ToPointer(), binary.ToPointer());
			}
		}
		
		public static void glProgramBinary(int program, int binaryFormat, IntPtr binary, int length)
		{
			unsafe
			{
				Capabilities.nglProgramBinary(program, binaryFormat, binary.ToPointer(), length);
			}
		}
		
		public static void glProgramParameteri(int program, int pname, int value) =>
			Capabilities.nglProgramParameteri(program, pname, value);
		
		public static void glUseProgramStages(int pipeline, int stages, int program) =>
			Capabilities.nglUseProgramStages(pipeline, stages, program);
		
		public static void glActiveShaderProgram(int pipeline, int program) =>
			Capabilities.nglActiveShaderProgram(pipeline, program);
		
		public static int glCreateShaderProgramv(int type, int count, IntPtr strings)
		{
			unsafe
			{
				return Capabilities.nglCreateShaderProgramv(type, count, (byte**)strings.ToPointer());
			}
		}
		
		public static void glBindProgramPipeline(int pipeline) =>
			Capabilities.nglBindProgramPipeline(pipeline);
		
		public static void glDeleteProgramPipelines(int n, IntPtr pipelines)
		{
			unsafe
			{
				Capabilities.nglDeleteProgramPipelines(n, (int*)pipelines.ToPointer());
			}
		}
		
		public static void glDeleteProgramPipelines(int n, ref int pipelines)
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglDeleteProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glDeleteProgramPipelines<T>(int n, ref T pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglDeleteProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glDeleteProgramPipelines<T>(int n, T[] pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = pipelines) Capabilities.nglDeleteProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glDeleteProgramPipelines(int n, int[] pipelines)
		{
			unsafe
			{
				fixed (int* pipelinesPtr = pipelines)
				{
					Capabilities.nglDeleteProgramPipelines(n, pipelinesPtr);
				}
			}
		}
		
		public static void glDeleteProgramPipelines(int name)
		{
			unsafe
			{
				Capabilities.nglDeleteProgramPipelines(1, &name);
			}
		}
		
		public static void glDeleteProgramPipelines(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglDeleteProgramPipelines(names.Length, ptr);
			}
		}
		
		public static void glGenProgramPipelines(int n, IntPtr pipelines)
		{
			unsafe
			{
				Capabilities.nglGenProgramPipelines(n, (int*)pipelines.ToPointer());
			}
		}
		
		public static void glGenProgramPipelines(int n, ref int pipelines)
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglGenProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glGenProgramPipelines<T>(int n, ref T pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglGenProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glGenProgramPipelines<T>(int n, T[] pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = pipelines) Capabilities.nglGenProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glGenProgramPipelines(int n, int[] pipelines)
		{
			unsafe
			{
				fixed (int* pipelinesPtr = pipelines)
				{
					Capabilities.nglGenProgramPipelines(n, pipelinesPtr);
				}
			}
		}
		
		public static int glGenProgramPipelines()
		{
			unsafe
			{
				int val;
				Capabilities.nglGenProgramPipelines(1, &val);
				return val;
			}
		}
		
		public static void glGenProgramPipelines(int[] names)
		{
			unsafe
			{
				fixed (int* ptr = names) Capabilities.nglGenProgramPipelines(names.Length, ptr);
			}
		}
		
		public static byte glIsProgramPipeline(int pipeline) =>
			Capabilities.nglIsProgramPipeline(pipeline);
		
		public static void glGetProgramPipelineiv(int pipeline, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetProgramPipelineiv(pipeline, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetProgramPipelineiv(int pipeline, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramPipelineiv(pipeline, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramPipelineiv<T>(int pipeline, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramPipelineiv(pipeline, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramPipelineiv<T>(int pipeline, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetProgramPipelineiv(pipeline, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramPipelineiv(int pipeline, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetProgramPipelineiv(pipeline, pname, _paramsPtr);
				}
			}
		}
		
		public static void glProgramUniform1i(int program, int location, int v0) =>
			Capabilities.nglProgramUniform1i(program, location, v0);
		
		public static void glProgramUniform1iv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform1iv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform1iv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1iv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1iv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform1iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1iv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform1iv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform1f(int program, int location, float v0) =>
			Capabilities.nglProgramUniform1f(program, location, v0);
		
		public static void glProgramUniform1fv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform1fv(program, location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform1fv(int program, int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform1fv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform1fv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform1fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform1fv(int program, int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniform1fv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform1d(int program, int location, double v0) =>
			Capabilities.nglProgramUniform1d(program, location, v0);
		
		public static void glProgramUniform1dv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform1dv(program, location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform1dv(int program, int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform1dv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform1dv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform1dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform1dv(int program, int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniform1dv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform1ui(int program, int location, int v0) =>
			Capabilities.nglProgramUniform1ui(program, location, v0);
		
		public static void glProgramUniform1uiv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform1uiv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform1uiv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1uiv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform1uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1uiv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform1uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform1uiv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform1uiv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform2i(int program, int location, int v0, int v1) =>
			Capabilities.nglProgramUniform2i(program, location, v0, v1);
		
		public static void glProgramUniform2iv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform2iv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform2iv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2iv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2iv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform2iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2iv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform2iv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform2f(int program, int location, float v0, float v1) =>
			Capabilities.nglProgramUniform2f(program, location, v0, v1);
		
		public static void glProgramUniform2fv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform2fv(program, location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform2fv(int program, int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform2fv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform2fv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform2fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform2fv(int program, int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniform2fv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform2d(int program, int location, double v0, double v1) =>
			Capabilities.nglProgramUniform2d(program, location, v0, v1);
		
		public static void glProgramUniform2dv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform2dv(program, location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform2dv(int program, int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform2dv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform2dv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform2dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform2dv(int program, int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniform2dv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform2ui(int program, int location, int v0, int v1) =>
			Capabilities.nglProgramUniform2ui(program, location, v0, v1);
		
		public static void glProgramUniform2uiv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform2uiv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform2uiv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2uiv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform2uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2uiv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform2uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform2uiv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform2uiv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform3i(int program, int location, int v0, int v1, int v2) =>
			Capabilities.nglProgramUniform3i(program, location, v0, v1, v2);
		
		public static void glProgramUniform3iv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform3iv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform3iv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3iv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3iv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform3iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3iv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform3iv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform3f(int program, int location, float v0, float v1, float v2) =>
			Capabilities.nglProgramUniform3f(program, location, v0, v1, v2);
		
		public static void glProgramUniform3fv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform3fv(program, location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform3fv(int program, int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform3fv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform3fv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform3fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform3fv(int program, int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniform3fv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform3d(int program, int location, double v0, double v1, double v2) =>
			Capabilities.nglProgramUniform3d(program, location, v0, v1, v2);
		
		public static void glProgramUniform3dv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform3dv(program, location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform3dv(int program, int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform3dv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform3dv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform3dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform3dv(int program, int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniform3dv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform3ui(int program, int location, int v0, int v1, int v2) =>
			Capabilities.nglProgramUniform3ui(program, location, v0, v1, v2);
		
		public static void glProgramUniform3uiv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform3uiv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform3uiv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3uiv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform3uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3uiv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform3uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform3uiv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform3uiv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform4i(int program, int location, int v0, int v1, int v2, int v3) =>
			Capabilities.nglProgramUniform4i(program, location, v0, v1, v2, v3);
		
		public static void glProgramUniform4iv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform4iv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform4iv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4iv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4iv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform4iv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4iv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform4iv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform4f(int program, int location, float v0, float v1, float v2, float v3) =>
			Capabilities.nglProgramUniform4f(program, location, v0, v1, v2, v3);
		
		public static void glProgramUniform4fv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform4fv(program, location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform4fv(int program, int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform4fv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform4fv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform4fv(program, location, count, (float*)ptr);
			}
		}
		
		public static void glProgramUniform4fv(int program, int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniform4fv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform4d(int program, int location, double v0, double v1, double v2, double v3) =>
			Capabilities.nglProgramUniform4d(program, location, v0, v1, v2, v3);
		
		public static void glProgramUniform4dv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform4dv(program, location, count, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform4dv(int program, int location, int count, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform4dv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform4dv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform4dv(program, location, count, (double*)ptr);
			}
		}
		
		public static void glProgramUniform4dv(int program, int location, int count, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniform4dv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniform4ui(int program, int location, int v0, int v1, int v2, int v3) =>
			Capabilities.nglProgramUniform4ui(program, location, v0, v1, v2, v3);
		
		public static void glProgramUniform4uiv(int program, int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniform4uiv(program, location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glProgramUniform4uiv(int program, int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4uiv<T>(int program, int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniform4uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4uiv<T>(int program, int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniform4uiv(program, location, count, (int*)ptr);
			}
		}
		
		public static void glProgramUniform4uiv(int program, int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglProgramUniform4uiv(program, location, count, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2x3fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2x3fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2x3fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3x2fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3x2fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3x2fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2x4fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2x4fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2x4fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4x2fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4x2fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4x2fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4x2fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3x4fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3x4fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3x4fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3x4fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4x3fv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4x3fv(int program, int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3fv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3fv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4x3fv(program, location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3fv(int program, int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4x3fv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2x3dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2x3dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x3dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2x3dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3x2dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3x2dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x2dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3x2dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix2x4dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix2x4dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix2x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix2x4dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix2x4dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4x2dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4x2dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4x2dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x2dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4x2dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix3x4dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix3x4dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix3x4dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix3x4dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix3x4dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glProgramUniformMatrix4x3dv(int program, int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*)value.ToPointer());
			}
		}
		
		public static void glProgramUniformMatrix4x3dv(int program, int location, int count, byte transpose, ref double value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3dv<T>(int program, int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3dv<T>(int program, int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglProgramUniformMatrix4x3dv(program, location, count, transpose, (double*)ptr);
			}
		}
		
		public static void glProgramUniformMatrix4x3dv(int program, int location, int count, byte transpose, double[] value)
		{
			unsafe
			{
				fixed (double* valuePtr = value)
				{
					Capabilities.nglProgramUniformMatrix4x3dv(program, location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glValidateProgramPipeline(int pipeline) =>
			Capabilities.nglValidateProgramPipeline(pipeline);
		
		public static void glGetProgramPipelineInfoLog(int pipeline, int bufSize, IntPtr length, IntPtr infoLog)
		{
			unsafe
			{
				Capabilities.nglGetProgramPipelineInfoLog(pipeline, bufSize, (int*)length.ToPointer(), (byte*)infoLog.ToPointer());
			}
		}
		
		public static void glGetProgramPipelineInfoLog(int pipeline, int bufSize, int[] length, byte[] infoLog)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* infoLogPtr = infoLog)
					{
						Capabilities.nglGetProgramPipelineInfoLog(pipeline, bufSize, lengthPtr, infoLogPtr);
					}
				}
			}
		}
		
		public static void glVertexAttribL1d(int index, double x) =>
			Capabilities.nglVertexAttribL1d(index, x);
		
		public static void glVertexAttribL2d(int index, double x, double y) =>
			Capabilities.nglVertexAttribL2d(index, x, y);
		
		public static void glVertexAttribL3d(int index, double x, double y, double z) =>
			Capabilities.nglVertexAttribL3d(index, x, y, z);
		
		public static void glVertexAttribL4d(int index, double x, double y, double z, double w) =>
			Capabilities.nglVertexAttribL4d(index, x, y, z, w);
		
		public static void glVertexAttribL1dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribL1dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribL1dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL1dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL1dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribL1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL1dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttribL1dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribL2dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribL2dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribL2dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL2dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL2dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribL2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL2dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttribL2dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribL3dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribL3dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribL3dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL3dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL3dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribL3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL3dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttribL3dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribL4dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttribL4dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttribL4dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL4dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttribL4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL4dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttribL4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttribL4dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttribL4dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribLPointer(int index, int size, int type, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglVertexAttribLPointer(index, size, type, stride, pointer.ToPointer());
			}
		}
		
		public static void glGetVertexAttribLdv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribLdv(index, pname, (double*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribLdv(int index, int pname, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribLdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribLdv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribLdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribLdv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribLdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribLdv(int index, int pname, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribLdv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glViewportArrayv(int first, int count, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglViewportArrayv(first, count, (float*)v.ToPointer());
			}
		}
		
		public static void glViewportArrayv(int first, int count, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglViewportArrayv(first, count, (float*)ptr);
			}
		}
		
		public static void glViewportArrayv<T>(int first, int count, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglViewportArrayv(first, count, (float*)ptr);
			}
		}
		
		public static void glViewportArrayv<T>(int first, int count, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglViewportArrayv(first, count, (float*)ptr);
			}
		}
		
		public static void glViewportArrayv(int first, int count, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglViewportArrayv(first, count, vPtr);
				}
			}
		}
		
		public static void glViewportIndexedf(int index, float x, float y, float w, float h) =>
			Capabilities.nglViewportIndexedf(index, x, y, w, h);
		
		public static void glViewportIndexedfv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglViewportIndexedfv(index, (float*)v.ToPointer());
			}
		}
		
		public static void glViewportIndexedfv(int index, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglViewportIndexedfv(index, (float*)ptr);
			}
		}
		
		public static void glViewportIndexedfv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglViewportIndexedfv(index, (float*)ptr);
			}
		}
		
		public static void glViewportIndexedfv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglViewportIndexedfv(index, (float*)ptr);
			}
		}
		
		public static void glViewportIndexedfv(int index, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglViewportIndexedfv(index, vPtr);
				}
			}
		}
		
		public static void glScissorArrayv(int first, int count, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglScissorArrayv(first, count, (int*)v.ToPointer());
			}
		}
		
		public static void glScissorArrayv(int first, int count, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglScissorArrayv(first, count, (int*)ptr);
			}
		}
		
		public static void glScissorArrayv<T>(int first, int count, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglScissorArrayv(first, count, (int*)ptr);
			}
		}
		
		public static void glScissorArrayv<T>(int first, int count, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglScissorArrayv(first, count, (int*)ptr);
			}
		}
		
		public static void glScissorArrayv(int first, int count, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglScissorArrayv(first, count, vPtr);
				}
			}
		}
		
		public static void glScissorIndexed(int index, int left, int bottom, int width, int height) =>
			Capabilities.nglScissorIndexed(index, left, bottom, width, height);
		
		public static void glScissorIndexedv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglScissorIndexedv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glScissorIndexedv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglScissorIndexedv(index, (int*)ptr);
			}
		}
		
		public static void glScissorIndexedv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglScissorIndexedv(index, (int*)ptr);
			}
		}
		
		public static void glScissorIndexedv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglScissorIndexedv(index, (int*)ptr);
			}
		}
		
		public static void glScissorIndexedv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglScissorIndexedv(index, vPtr);
				}
			}
		}
		
		public static void glDepthRangeArrayv(int first, int count, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglDepthRangeArrayv(first, count, (double*)v.ToPointer());
			}
		}
		
		public static void glDepthRangeArrayv(int first, int count, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglDepthRangeArrayv(first, count, (double*)ptr);
			}
		}
		
		public static void glDepthRangeArrayv<T>(int first, int count, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglDepthRangeArrayv(first, count, (double*)ptr);
			}
		}
		
		public static void glDepthRangeArrayv<T>(int first, int count, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglDepthRangeArrayv(first, count, (double*)ptr);
			}
		}
		
		public static void glDepthRangeArrayv(int first, int count, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglDepthRangeArrayv(first, count, vPtr);
				}
			}
		}
		
		public static void glDepthRangeIndexed(int index, double n, double f) =>
			Capabilities.nglDepthRangeIndexed(index, n, f);
		
		public static void glGetFloati_v(int target, int index, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetFloati_v(target, index, (float*)data.ToPointer());
			}
		}
		
		public static void glGetFloati_v(int target, int index, ref float data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetFloati_v(target, index, (float*)ptr);
			}
		}
		
		public static void glGetFloati_v<T>(int target, int index, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetFloati_v(target, index, (float*)ptr);
			}
		}
		
		public static void glGetFloati_v<T>(int target, int index, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetFloati_v(target, index, (float*)ptr);
			}
		}
		
		public static void glGetFloati_v(int target, int index, float[] data)
		{
			unsafe
			{
				fixed (float* dataPtr = data)
				{
					Capabilities.nglGetFloati_v(target, index, dataPtr);
				}
			}
		}
		
		public static void glGetDoublei_v(int target, int index, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetDoublei_v(target, index, (double*)data.ToPointer());
			}
		}
		
		public static void glGetDoublei_v(int target, int index, ref double data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetDoublei_v(target, index, (double*)ptr);
			}
		}
		
		public static void glGetDoublei_v<T>(int target, int index, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetDoublei_v(target, index, (double*)ptr);
			}
		}
		
		public static void glGetDoublei_v<T>(int target, int index, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetDoublei_v(target, index, (double*)ptr);
			}
		}
		
		public static void glGetDoublei_v(int target, int index, double[] data)
		{
			unsafe
			{
				fixed (double* dataPtr = data)
				{
					Capabilities.nglGetDoublei_v(target, index, dataPtr);
				}
			}
		}
		
		
	}
}
