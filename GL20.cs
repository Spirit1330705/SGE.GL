using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_BLEND_EQUATION_RGB = 0x8009;
		public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const int GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const int GL_STENCIL_BACK_FUNC = 0x8800;
		public const int GL_STENCIL_BACK_FAIL = 0x8801;
		public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const int GL_MAX_DRAW_BUFFERS = 0x8824;
		public const int GL_DRAW_BUFFER0 = 0x8825;
		public const int GL_DRAW_BUFFER1 = 0x8826;
		public const int GL_DRAW_BUFFER2 = 0x8827;
		public const int GL_DRAW_BUFFER3 = 0x8828;
		public const int GL_DRAW_BUFFER4 = 0x8829;
		public const int GL_DRAW_BUFFER5 = 0x882A;
		public const int GL_DRAW_BUFFER6 = 0x882B;
		public const int GL_DRAW_BUFFER7 = 0x882C;
		public const int GL_DRAW_BUFFER8 = 0x882D;
		public const int GL_DRAW_BUFFER9 = 0x882E;
		public const int GL_DRAW_BUFFER10 = 0x882F;
		public const int GL_DRAW_BUFFER11 = 0x8830;
		public const int GL_DRAW_BUFFER12 = 0x8831;
		public const int GL_DRAW_BUFFER13 = 0x8832;
		public const int GL_DRAW_BUFFER14 = 0x8833;
		public const int GL_DRAW_BUFFER15 = 0x8834;
		public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const int GL_FRAGMENT_SHADER = 0x8B30;
		public const int GL_VERTEX_SHADER = 0x8B31;
		public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const int GL_MAX_VARYING_FLOATS = 0x8B4B;
		public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const int GL_SHADER_TYPE = 0x8B4F;
		public const int GL_FLOAT_VEC2 = 0x8B50;
		public const int GL_FLOAT_VEC3 = 0x8B51;
		public const int GL_FLOAT_VEC4 = 0x8B52;
		public const int GL_INT_VEC2 = 0x8B53;
		public const int GL_INT_VEC3 = 0x8B54;
		public const int GL_INT_VEC4 = 0x8B55;
		public const int GL_BOOL = 0x8B56;
		public const int GL_BOOL_VEC2 = 0x8B57;
		public const int GL_BOOL_VEC3 = 0x8B58;
		public const int GL_BOOL_VEC4 = 0x8B59;
		public const int GL_FLOAT_MAT2 = 0x8B5A;
		public const int GL_FLOAT_MAT3 = 0x8B5B;
		public const int GL_FLOAT_MAT4 = 0x8B5C;
		public const int GL_SAMPLER_1D = 0x8B5D;
		public const int GL_SAMPLER_2D = 0x8B5E;
		public const int GL_SAMPLER_3D = 0x8B5F;
		public const int GL_SAMPLER_CUBE = 0x8B60;
		public const int GL_SAMPLER_1D_SHADOW = 0x8B61;
		public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
		public const int GL_DELETE_STATUS = 0x8B80;
		public const int GL_COMPILE_STATUS = 0x8B81;
		public const int GL_LINK_STATUS = 0x8B82;
		public const int GL_VALIDATE_STATUS = 0x8B83;
		public const int GL_INFO_LOG_LENGTH = 0x8B84;
		public const int GL_ATTACHED_SHADERS = 0x8B85;
		public const int GL_ACTIVE_UNIFORMS = 0x8B86;
		public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const int GL_CURRENT_PROGRAM = 0x8B8D;
		public const int GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const int GL_LOWER_LEFT = 0x8CA1;
		public const int GL_UPPER_LEFT = 0x8CA2;
		public const int GL_STENCIL_BACK_REF = 0x8CA3;
		public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const int GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
		public const int GL_POINT_SPRITE = 0x8861;
		public const int GL_COORD_REPLACE = 0x8862;
		public const int GL_MAX_TEXTURE_COORDS = 0x8871;
		#endregion // Constants
		
		public static void glBlendEquationSeparate(int modeRGB, int modeAlpha) =>
			Capabilities.nglBlendEquationSeparate(modeRGB, modeAlpha);
		
		public static void glDrawBuffers(int n, IntPtr bufs)
		{
			unsafe
			{
				Capabilities.nglDrawBuffers(n, (int*)bufs.ToPointer());
			}
		}
		
		public static void glDrawBuffers(int n, ref int bufs)
		{
			unsafe
			{
				fixed (void* ptr = &bufs) Capabilities.nglDrawBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDrawBuffers<T>(int n, ref T bufs) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &bufs) Capabilities.nglDrawBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDrawBuffers<T>(int n, T[] bufs) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = bufs) Capabilities.nglDrawBuffers(n, (int*)ptr);
			}
		}
		
		public static void glDrawBuffers(int n, int[] bufs)
		{
			unsafe
			{
				fixed (int* bufsPtr = bufs)
				{
					Capabilities.nglDrawBuffers(n, bufsPtr);
				}
			}
		}
		
		public static void glStencilOpSeparate(int face, int sfail, int dpfail, int dppass) =>
			Capabilities.nglStencilOpSeparate(face, sfail, dpfail, dppass);
		
		public static void glStencilFuncSeparate(int face, int func, int _ref, int mask) =>
			Capabilities.nglStencilFuncSeparate(face, func, _ref, mask);
		
		public static void glStencilMaskSeparate(int face, int mask) =>
			Capabilities.nglStencilMaskSeparate(face, mask);
		
		public static void glAttachShader(int program, int shader) =>
			Capabilities.nglAttachShader(program, shader);
		
		public static void glBindAttribLocation(int program, int index, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglBindAttribLocation(program, index, (byte*)name.ToPointer());
			}
		}
		
		public static void glBindAttribLocation(int program, int index, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindAttribLocation(program, index, (byte*)ptr);
			}
		}
		
		public static void glBindAttribLocation<T>(int program, int index, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglBindAttribLocation(program, index, (byte*)ptr);
			}
		}
		
		public static void glBindAttribLocation<T>(int program, int index, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglBindAttribLocation(program, index, (byte*)ptr);
			}
		}
		
		public static void glBindAttribLocation(int program, int index, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglBindAttribLocation(program, index, namePtr);
				}
			}
		}
		
		public static void glCompileShader(int shader) =>
			Capabilities.nglCompileShader(shader);
		
		public static int glCreateProgram() =>
			Capabilities.nglCreateProgram();
		
		public static int glCreateShader(int type) =>
			Capabilities.nglCreateShader(type);
		
		public static void glDeleteProgram(int program) =>
			Capabilities.nglDeleteProgram(program);
		
		public static void glDeleteShader(int shader) =>
			Capabilities.nglDeleteShader(shader);
		
		public static void glDetachShader(int program, int shader) =>
			Capabilities.nglDetachShader(program, shader);
		
		public static void glDisableVertexAttribArray(int index) =>
			Capabilities.nglDisableVertexAttribArray(index);
		
		public static void glEnableVertexAttribArray(int index) =>
			Capabilities.nglEnableVertexAttribArray(index);
		
		public static void glGetActiveAttrib(int program, int index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetActiveAttrib(program, index, bufSize, (int*)length.ToPointer(), (int*)size.ToPointer(), (int*)type.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetActiveAttrib(int program, int index, int bufSize, int[] length, int[] size, int[] type, byte[] name)
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
								Capabilities.nglGetActiveAttrib(program, index, bufSize, lengthPtr, sizePtr, typePtr, namePtr);
							}
						}
					}
				}
			}
		}
		
		public static void glGetActiveUniform(int program, int index, int bufSize, IntPtr length, IntPtr size, IntPtr type, IntPtr name)
		{
			unsafe
			{
				Capabilities.nglGetActiveUniform(program, index, bufSize, (int*)length.ToPointer(), (int*)size.ToPointer(), (int*)type.ToPointer(), (byte*)name.ToPointer());
			}
		}
		
		public static void glGetActiveUniform(int program, int index, int bufSize, int[] length, int[] size, int[] type, byte[] name)
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
								Capabilities.nglGetActiveUniform(program, index, bufSize, lengthPtr, sizePtr, typePtr, namePtr);
							}
						}
					}
				}
			}
		}
		
		public static void glGetAttachedShaders(int program, int maxCount, IntPtr count, IntPtr shaders)
		{
			unsafe
			{
				Capabilities.nglGetAttachedShaders(program, maxCount, (int*)count.ToPointer(), (int*)shaders.ToPointer());
			}
		}
		
		public static void glGetAttachedShaders(int program, int maxCount, int[] count, int[] shaders)
		{
			unsafe
			{
				fixed (int* countPtr = count)
				{
					fixed (int* shadersPtr = shaders)
					{
						Capabilities.nglGetAttachedShaders(program, maxCount, countPtr, shadersPtr);
					}
				}
			}
		}
		
		public static int glGetAttribLocation(int program, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetAttribLocation(program, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetAttribLocation(int program, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetAttribLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetAttribLocation<T>(int program, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetAttribLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetAttribLocation<T>(int program, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetAttribLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetAttribLocation(int program, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetAttribLocation(program, namePtr);
				}
			}
		}
		
		public static void glGetProgramiv(int program, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetProgramiv(program, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetProgramiv(int program, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramiv(program, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramiv<T>(int program, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetProgramiv(program, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramiv<T>(int program, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetProgramiv(program, pname, (int*)ptr);
			}
		}
		
		public static void glGetProgramiv(int program, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetProgramiv(program, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetProgramInfoLog(int program, int bufSize, IntPtr length, IntPtr infoLog)
		{
			unsafe
			{
				Capabilities.nglGetProgramInfoLog(program, bufSize, (int*)length.ToPointer(), (byte*)infoLog.ToPointer());
			}
		}
		
		public static void glGetProgramInfoLog(int program, int bufSize, int[] length, byte[] infoLog)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* infoLogPtr = infoLog)
					{
						Capabilities.nglGetProgramInfoLog(program, bufSize, lengthPtr, infoLogPtr);
					}
				}
			}
		}
		
		public static void glGetShaderiv(int shader, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetShaderiv(shader, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetShaderiv(int shader, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetShaderiv(shader, pname, (int*)ptr);
			}
		}
		
		public static void glGetShaderiv<T>(int shader, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetShaderiv(shader, pname, (int*)ptr);
			}
		}
		
		public static void glGetShaderiv<T>(int shader, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetShaderiv(shader, pname, (int*)ptr);
			}
		}
		
		public static void glGetShaderiv(int shader, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetShaderiv(shader, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetShaderInfoLog(int shader, int bufSize, IntPtr length, IntPtr infoLog)
		{
			unsafe
			{
				Capabilities.nglGetShaderInfoLog(shader, bufSize, (int*)length.ToPointer(), (byte*)infoLog.ToPointer());
			}
		}
		
		public static void glGetShaderInfoLog(int shader, int bufSize, int[] length, byte[] infoLog)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* infoLogPtr = infoLog)
					{
						Capabilities.nglGetShaderInfoLog(shader, bufSize, lengthPtr, infoLogPtr);
					}
				}
			}
		}
		
		public static void glGetShaderSource(int shader, int bufSize, IntPtr length, IntPtr source)
		{
			unsafe
			{
				Capabilities.nglGetShaderSource(shader, bufSize, (int*)length.ToPointer(), (byte*)source.ToPointer());
			}
		}
		
		public static void glGetShaderSource(int shader, int bufSize, int[] length, byte[] source)
		{
			unsafe
			{
				fixed (int* lengthPtr = length)
				{
					fixed (byte* sourcePtr = source)
					{
						Capabilities.nglGetShaderSource(shader, bufSize, lengthPtr, sourcePtr);
					}
				}
			}
		}
		
		public static int glGetUniformLocation(int program, IntPtr name)
		{
			unsafe
			{
				return Capabilities.nglGetUniformLocation(program, (byte*)name.ToPointer());
			}
		}
		
		public static void glGetUniformLocation(int program, ref byte name)
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetUniformLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformLocation<T>(int program, ref T name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &name) Capabilities.nglGetUniformLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformLocation<T>(int program, T[] name) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = name) Capabilities.nglGetUniformLocation(program, (byte*)ptr);
			}
		}
		
		public static void glGetUniformLocation(int program, byte[] name)
		{
			unsafe
			{
				fixed (byte* namePtr = name)
				{
					Capabilities.nglGetUniformLocation(program, namePtr);
				}
			}
		}
		
		public static void glGetUniformfv(int program, int location, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetUniformfv(program, location, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetUniformfv(int program, int location, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformfv(program, location, (float*)ptr);
			}
		}
		
		public static void glGetUniformfv<T>(int program, int location, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformfv(program, location, (float*)ptr);
			}
		}
		
		public static void glGetUniformfv<T>(int program, int location, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetUniformfv(program, location, (float*)ptr);
			}
		}
		
		public static void glGetUniformfv(int program, int location, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetUniformfv(program, location, _paramsPtr);
				}
			}
		}
		
		public static void glGetUniformiv(int program, int location, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetUniformiv(program, location, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetUniformiv(int program, int location, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformiv<T>(int program, int location, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetUniformiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformiv<T>(int program, int location, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetUniformiv(program, location, (int*)ptr);
			}
		}
		
		public static void glGetUniformiv(int program, int location, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetUniformiv(program, location, _paramsPtr);
				}
			}
		}
		
		public static void glGetVertexAttribdv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribdv(index, pname, (double*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribdv(int index, int pname, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribdv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribdv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribdv(index, pname, (double*)ptr);
			}
		}
		
		public static void glGetVertexAttribdv(int index, int pname, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribdv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetVertexAttribfv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribfv(index, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribfv(int index, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribfv(index, pname, (float*)ptr);
			}
		}
		
		public static void glGetVertexAttribfv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribfv(index, pname, (float*)ptr);
			}
		}
		
		public static void glGetVertexAttribfv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribfv(index, pname, (float*)ptr);
			}
		}
		
		public static void glGetVertexAttribfv(int index, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribfv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetVertexAttribiv(int index, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribiv(index, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetVertexAttribiv(int index, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribiv<T>(int index, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetVertexAttribiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribiv<T>(int index, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetVertexAttribiv(index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexAttribiv(int index, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetVertexAttribiv(index, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetVertexAttribPointerv(int index, int pname, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglGetVertexAttribPointerv(index, pname, (void**)pointer.ToPointer());
			}
		}
		
		public static byte glIsProgram(int program) =>
			Capabilities.nglIsProgram(program);
		
		public static byte glIsShader(int shader) =>
			Capabilities.nglIsShader(shader);
		
		public static void glLinkProgram(int program) =>
			Capabilities.nglLinkProgram(program);
		
		public static void glShaderSource(int shader, int count, IntPtr _string, IntPtr length)
		{
			unsafe
			{
				Capabilities.nglShaderSource(shader, count, (byte**)_string.ToPointer(), (int*)length.ToPointer());
			}
		}
		
		public static void glUseProgram(int program) =>
			Capabilities.nglUseProgram(program);
		
		public static void glUniform1f(int location, float v0) =>
			Capabilities.nglUniform1f(location, v0);
		
		public static void glUniform2f(int location, float v0, float v1) =>
			Capabilities.nglUniform2f(location, v0, v1);
		
		public static void glUniform3f(int location, float v0, float v1, float v2) =>
			Capabilities.nglUniform3f(location, v0, v1, v2);
		
		public static void glUniform4f(int location, float v0, float v1, float v2, float v3) =>
			Capabilities.nglUniform4f(location, v0, v1, v2, v3);
		
		public static void glUniform1i(int location, int v0) =>
			Capabilities.nglUniform1i(location, v0);
		
		public static void glUniform2i(int location, int v0, int v1) =>
			Capabilities.nglUniform2i(location, v0, v1);
		
		public static void glUniform3i(int location, int v0, int v1, int v2) =>
			Capabilities.nglUniform3i(location, v0, v1, v2);
		
		public static void glUniform4i(int location, int v0, int v1, int v2, int v3) =>
			Capabilities.nglUniform4i(location, v0, v1, v2, v3);
		
		public static void glUniform1fv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform1fv(location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glUniform1fv(int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform1fv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform1fv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform1fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform1fv(int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniform1fv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform2fv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform2fv(location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glUniform2fv(int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform2fv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform2fv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform2fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform2fv(int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniform2fv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform3fv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform3fv(location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glUniform3fv(int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform3fv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform3fv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform3fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform3fv(int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniform3fv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform4fv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform4fv(location, count, (float*)value.ToPointer());
			}
		}
		
		public static void glUniform4fv(int location, int count, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform4fv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform4fv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform4fv(location, count, (float*)ptr);
			}
		}
		
		public static void glUniform4fv(int location, int count, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniform4fv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform1iv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform1iv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform1iv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1iv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform1iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1iv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform1iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform1iv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform1iv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform2iv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform2iv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform2iv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2iv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform2iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2iv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform2iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform2iv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform2iv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform3iv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform3iv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform3iv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3iv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform3iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3iv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform3iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform3iv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform3iv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniform4iv(int location, int count, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniform4iv(location, count, (int*)value.ToPointer());
			}
		}
		
		public static void glUniform4iv(int location, int count, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4iv<T>(int location, int count, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniform4iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4iv<T>(int location, int count, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniform4iv(location, count, (int*)ptr);
			}
		}
		
		public static void glUniform4iv(int location, int count, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglUniform4iv(location, count, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix2fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix2fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix2fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix2fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix2fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix2fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix3fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix3fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix3fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix3fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix3fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix3fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glUniformMatrix4fv(int location, int count, byte transpose, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglUniformMatrix4fv(location, count, transpose, (float*)value.ToPointer());
			}
		}
		
		public static void glUniformMatrix4fv(int location, int count, byte transpose, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4fv<T>(int location, int count, byte transpose, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglUniformMatrix4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4fv<T>(int location, int count, byte transpose, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglUniformMatrix4fv(location, count, transpose, (float*)ptr);
			}
		}
		
		public static void glUniformMatrix4fv(int location, int count, byte transpose, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglUniformMatrix4fv(location, count, transpose, valuePtr);
				}
			}
		}
		
		public static void glValidateProgram(int program) =>
			Capabilities.nglValidateProgram(program);
		
		public static void glVertexAttrib1d(int index, double x) =>
			Capabilities.nglVertexAttrib1d(index, x);
		
		public static void glVertexAttrib1dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib1dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib1dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib1dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib1dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib1dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib1dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttrib1dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib1f(int index, float x) =>
			Capabilities.nglVertexAttrib1f(index, x);
		
		public static void glVertexAttrib1fv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib1fv(index, (float*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib1fv(int index, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib1fv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib1fv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib1fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib1fv(int index, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertexAttrib1fv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib1s(int index, short x) =>
			Capabilities.nglVertexAttrib1s(index, x);
		
		public static void glVertexAttrib1sv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib1sv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib1sv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib1sv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib1sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib1sv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib1sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib1sv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttrib1sv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib2d(int index, double x, double y) =>
			Capabilities.nglVertexAttrib2d(index, x, y);
		
		public static void glVertexAttrib2dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib2dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib2dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib2dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib2dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib2dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib2dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttrib2dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib2f(int index, float x, float y) =>
			Capabilities.nglVertexAttrib2f(index, x, y);
		
		public static void glVertexAttrib2fv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib2fv(index, (float*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib2fv(int index, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib2fv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib2fv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib2fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib2fv(int index, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertexAttrib2fv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib2s(int index, short x, short y) =>
			Capabilities.nglVertexAttrib2s(index, x, y);
		
		public static void glVertexAttrib2sv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib2sv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib2sv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib2sv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib2sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib2sv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib2sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib2sv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttrib2sv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib3d(int index, double x, double y, double z) =>
			Capabilities.nglVertexAttrib3d(index, x, y, z);
		
		public static void glVertexAttrib3dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib3dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib3dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib3dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib3dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib3dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib3dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttrib3dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib3f(int index, float x, float y, float z) =>
			Capabilities.nglVertexAttrib3f(index, x, y, z);
		
		public static void glVertexAttrib3fv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib3fv(index, (float*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib3fv(int index, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib3fv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib3fv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib3fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib3fv(int index, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertexAttrib3fv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib3s(int index, short x, short y, short z) =>
			Capabilities.nglVertexAttrib3s(index, x, y, z);
		
		public static void glVertexAttrib3sv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib3sv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib3sv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib3sv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib3sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib3sv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib3sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib3sv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttrib3sv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Nbv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Nbv(index, (sbyte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Nbv(int index, ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nbv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nbv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nbv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nbv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Nbv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nbv(int index, sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Nbv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Niv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Niv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Niv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Niv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Niv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Niv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Niv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Niv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Niv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Niv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Nsv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Nsv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Nsv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nsv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nsv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nsv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nsv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Nsv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nsv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Nsv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Nub(int index, byte x, byte y, byte z, byte w) =>
			Capabilities.nglVertexAttrib4Nub(index, x, y, z, w);
		
		public static void glVertexAttrib4Nubv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Nubv(index, (byte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Nubv(int index, ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nubv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nubv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Nubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nubv(int index, byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Nubv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Nuiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Nuiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Nuiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nuiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nuiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nuiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nuiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Nuiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nuiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Nuiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4Nusv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4Nusv(index, (ushort*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4Nusv(int index, ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nusv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nusv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4Nusv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nusv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4Nusv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4Nusv(int index, ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglVertexAttrib4Nusv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4bv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4bv(index, (sbyte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4bv(int index, ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4bv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4bv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4bv(index, (sbyte*)ptr);
			}
		}
		
		public static void glVertexAttrib4bv(int index, sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglVertexAttrib4bv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4d(int index, double x, double y, double z, double w) =>
			Capabilities.nglVertexAttrib4d(index, x, y, z, w);
		
		public static void glVertexAttrib4dv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4dv(index, (double*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4dv(int index, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib4dv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib4dv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4dv(index, (double*)ptr);
			}
		}
		
		public static void glVertexAttrib4dv(int index, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertexAttrib4dv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4f(int index, float x, float y, float z, float w) =>
			Capabilities.nglVertexAttrib4f(index, x, y, z, w);
		
		public static void glVertexAttrib4fv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4fv(index, (float*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4fv(int index, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib4fv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib4fv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4fv(index, (float*)ptr);
			}
		}
		
		public static void glVertexAttrib4fv(int index, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertexAttrib4fv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4iv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4iv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4iv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4iv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4iv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4iv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4iv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttrib4iv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4s(int index, short x, short y, short z, short w) =>
			Capabilities.nglVertexAttrib4s(index, x, y, z, w);
		
		public static void glVertexAttrib4sv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4sv(index, (short*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4sv(int index, ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4sv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4sv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4sv(index, (short*)ptr);
			}
		}
		
		public static void glVertexAttrib4sv(int index, short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertexAttrib4sv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4ubv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4ubv(index, (byte*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4ubv(int index, ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4ubv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4ubv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4ubv(index, (byte*)ptr);
			}
		}
		
		public static void glVertexAttrib4ubv(int index, byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglVertexAttrib4ubv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4uiv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4uiv(index, (int*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4uiv(int index, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4uiv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4uiv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4uiv(index, (int*)ptr);
			}
		}
		
		public static void glVertexAttrib4uiv(int index, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertexAttrib4uiv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttrib4usv(int index, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertexAttrib4usv(index, (ushort*)v.ToPointer());
			}
		}
		
		public static void glVertexAttrib4usv(int index, ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4usv<T>(int index, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertexAttrib4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4usv<T>(int index, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertexAttrib4usv(index, (ushort*)ptr);
			}
		}
		
		public static void glVertexAttrib4usv(int index, ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglVertexAttrib4usv(index, vPtr);
				}
			}
		}
		
		public static void glVertexAttribPointer(int index, int size, int type, byte normalized, int stride, IntPtr pointer)
		{
			unsafe
			{
				Capabilities.nglVertexAttribPointer(index, size, type, normalized, stride, pointer.ToPointer());
			}
		}
		
		
	}
}
