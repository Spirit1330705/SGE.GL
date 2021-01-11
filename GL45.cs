using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_CONTEXT_LOST = 0x0507;
		public const int GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const int GL_ZERO_TO_ONE = 0x935F;
		public const int GL_CLIP_ORIGIN = 0x935C;
		public const int GL_CLIP_DEPTH_MODE = 0x935D;
		public const int GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const int GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const int GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const int GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const int GL_MAX_CULL_DISTANCES = 0x82F9;
		public const int GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const int GL_TEXTURE_TARGET = 0x1006;
		public const int GL_QUERY_TARGET = 0x82EA;
		public const int GL_GUILTY_CONTEXT_RESET = 0x8253;
		public const int GL_INNOCENT_CONTEXT_RESET = 0x8254;
		public const int GL_UNKNOWN_CONTEXT_RESET = 0x8255;
		public const int GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const int GL_LOSE_CONTEXT_ON_RESET = 0x8252;
		public const int GL_NO_RESET_NOTIFICATION = 0x8261;
		public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const int GL_COLOR_TABLE = 0x80D0;
		public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
		public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
		public const int GL_PROXY_COLOR_TABLE = 0x80D3;
		public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
		public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
		public const int GL_CONVOLUTION_1D = 0x8010;
		public const int GL_CONVOLUTION_2D = 0x8011;
		public const int GL_SEPARABLE_2D = 0x8012;
		public const int GL_HISTOGRAM = 0x8024;
		public const int GL_PROXY_HISTOGRAM = 0x8025;
		public const int GL_MINMAX = 0x802E;
		public const int GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const int GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
		#endregion // Constants
		
		public static void glClipControl(int origin, int depth) =>
			Capabilities.nglClipControl(origin, depth);
		
		public static void glCreateTransformFeedbacks(int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglCreateTransformFeedbacks(n, (int*)ids.ToPointer());
			}
		}
		
		public static void glCreateTransformFeedbacks(int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglCreateTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glCreateTransformFeedbacks<T>(int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglCreateTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glCreateTransformFeedbacks<T>(int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglCreateTransformFeedbacks(n, (int*)ptr);
			}
		}
		
		public static void glCreateTransformFeedbacks(int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglCreateTransformFeedbacks(n, idsPtr);
				}
			}
		}
		
		public static void glTransformFeedbackBufferBase(int xfb, int index, int buffer) =>
			Capabilities.nglTransformFeedbackBufferBase(xfb, index, buffer);
		
		public static void glTransformFeedbackBufferRange(int xfb, int index, int buffer, IntPtr offset, IntPtr size) =>
			Capabilities.nglTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		
		public static void glGetTransformFeedbackiv(int xfb, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetTransformFeedbackiv(xfb, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glGetTransformFeedbackiv(int xfb, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbackiv(xfb, pname, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbackiv<T>(int xfb, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbackiv(xfb, pname, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbackiv<T>(int xfb, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetTransformFeedbackiv(xfb, pname, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbackiv(int xfb, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglGetTransformFeedbackiv(xfb, pname, paramPtr);
				}
			}
		}
		
		public static void glGetTransformFeedbacki_v(int xfb, int pname, int index, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetTransformFeedbacki_v(xfb, pname, index, (int*)param.ToPointer());
			}
		}
		
		public static void glGetTransformFeedbacki_v(int xfb, int pname, int index, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbacki_v(xfb, pname, index, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki_v<T>(int xfb, int pname, int index, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbacki_v(xfb, pname, index, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki_v<T>(int xfb, int pname, int index, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetTransformFeedbacki_v(xfb, pname, index, (int*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki_v(int xfb, int pname, int index, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglGetTransformFeedbacki_v(xfb, pname, index, paramPtr);
				}
			}
		}
		
		public static void glGetTransformFeedbacki64_v(int xfb, int pname, int index, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetTransformFeedbacki64_v(xfb, pname, index, (long*)param.ToPointer());
			}
		}
		
		public static void glGetTransformFeedbacki64_v(int xfb, int pname, int index, ref long param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbacki64_v(xfb, pname, index, (long*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki64_v<T>(int xfb, int pname, int index, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetTransformFeedbacki64_v(xfb, pname, index, (long*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki64_v<T>(int xfb, int pname, int index, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetTransformFeedbacki64_v(xfb, pname, index, (long*)ptr);
			}
		}
		
		public static void glGetTransformFeedbacki64_v(int xfb, int pname, int index, long[] param)
		{
			unsafe
			{
				fixed (long* paramPtr = param)
				{
					Capabilities.nglGetTransformFeedbacki64_v(xfb, pname, index, paramPtr);
				}
			}
		}
		
		public static void glCreateBuffers(int n, IntPtr buffers)
		{
			unsafe
			{
				Capabilities.nglCreateBuffers(n, (int*)buffers.ToPointer());
			}
		}
		
		public static void glCreateBuffers(int n, ref int buffers)
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglCreateBuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateBuffers<T>(int n, ref T buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffers) Capabilities.nglCreateBuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateBuffers<T>(int n, T[] buffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffers) Capabilities.nglCreateBuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateBuffers(int n, int[] buffers)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					Capabilities.nglCreateBuffers(n, buffersPtr);
				}
			}
		}
		
		public static void glNamedBufferStorage(int buffer, IntPtr size, IntPtr data, int flags)
		{
			unsafe
			{
				Capabilities.nglNamedBufferStorage(buffer, size, data.ToPointer(), flags);
			}
		}
		
		public static void glNamedBufferData(int buffer, IntPtr size, IntPtr data, int usage)
		{
			unsafe
			{
				Capabilities.nglNamedBufferData(buffer, size, data.ToPointer(), usage);
			}
		}
		
		public static void glNamedBufferSubData(int buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglNamedBufferSubData(buffer, offset, size, data.ToPointer());
			}
		}
		
		public static void glCopyNamedBufferSubData(int readBuffer, int writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size) =>
			Capabilities.nglCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		
		public static void glClearNamedBufferData(int buffer, int internalformat, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearNamedBufferData(buffer, internalformat, format, type, data.ToPointer());
			}
		}
		
		public static void glClearNamedBufferSubData(int buffer, int internalformat, IntPtr offset, IntPtr size, int format, int type, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data.ToPointer());
			}
		}
		
		public static IntPtr glMapNamedBuffer(int buffer, int access)
		{
			unsafe
			{
				return new IntPtr(Capabilities.nglMapNamedBuffer(buffer, access));
			}
		}
		
		public static IntPtr glMapNamedBufferRange(int buffer, IntPtr offset, IntPtr length, int access)
		{
			unsafe
			{
				return new IntPtr(Capabilities.nglMapNamedBufferRange(buffer, offset, length, access));
			}
		}
		
		public static byte glUnmapNamedBuffer(int buffer) =>
			Capabilities.nglUnmapNamedBuffer(buffer);
		
		public static void glFlushMappedNamedBufferRange(int buffer, IntPtr offset, IntPtr length) =>
			Capabilities.nglFlushMappedNamedBufferRange(buffer, offset, length);
		
		public static void glGetNamedBufferParameteriv(int buffer, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetNamedBufferParameteriv(buffer, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetNamedBufferParameteriv(int buffer, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedBufferParameteriv(buffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteriv<T>(int buffer, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedBufferParameteriv(buffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteriv<T>(int buffer, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetNamedBufferParameteriv(buffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteriv(int buffer, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetNamedBufferParameteriv(buffer, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetNamedBufferParameteri64v(int buffer, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetNamedBufferParameteri64v(buffer, pname, (long*)_params.ToPointer());
			}
		}
		
		public static void glGetNamedBufferParameteri64v(int buffer, int pname, ref long _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedBufferParameteri64v(buffer, pname, (long*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteri64v<T>(int buffer, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedBufferParameteri64v(buffer, pname, (long*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteri64v<T>(int buffer, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetNamedBufferParameteri64v(buffer, pname, (long*)ptr);
			}
		}
		
		public static void glGetNamedBufferParameteri64v(int buffer, int pname, long[] _params)
		{
			unsafe
			{
				fixed (long* _paramsPtr = _params)
				{
					Capabilities.nglGetNamedBufferParameteri64v(buffer, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetNamedBufferPointerv(int buffer, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetNamedBufferPointerv(buffer, pname, (void**)_params.ToPointer());
			}
		}
		
		public static void glGetNamedBufferSubData(int buffer, IntPtr offset, IntPtr size, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetNamedBufferSubData(buffer, offset, size, data.ToPointer());
			}
		}
		
		public static void glCreateFramebuffers(int n, IntPtr framebuffers)
		{
			unsafe
			{
				Capabilities.nglCreateFramebuffers(n, (int*)framebuffers.ToPointer());
			}
		}
		
		public static void glCreateFramebuffers(int n, ref int framebuffers)
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglCreateFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateFramebuffers<T>(int n, ref T framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &framebuffers) Capabilities.nglCreateFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateFramebuffers<T>(int n, T[] framebuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = framebuffers) Capabilities.nglCreateFramebuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateFramebuffers(int n, int[] framebuffers)
		{
			unsafe
			{
				fixed (int* framebuffersPtr = framebuffers)
				{
					Capabilities.nglCreateFramebuffers(n, framebuffersPtr);
				}
			}
		}
		
		public static void glNamedFramebufferRenderbuffer(int framebuffer, int attachment, int renderbuffertarget, int renderbuffer) =>
			Capabilities.nglNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		
		public static void glNamedFramebufferParameteri(int framebuffer, int pname, int param) =>
			Capabilities.nglNamedFramebufferParameteri(framebuffer, pname, param);
		
		public static void glNamedFramebufferTexture(int framebuffer, int attachment, int texture, int level) =>
			Capabilities.nglNamedFramebufferTexture(framebuffer, attachment, texture, level);
		
		public static void glNamedFramebufferTextureLayer(int framebuffer, int attachment, int texture, int level, int layer) =>
			Capabilities.nglNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		
		public static void glNamedFramebufferDrawBuffer(int framebuffer, int buf) =>
			Capabilities.nglNamedFramebufferDrawBuffer(framebuffer, buf);
		
		public static void glNamedFramebufferDrawBuffers(int framebuffer, int n, IntPtr bufs)
		{
			unsafe
			{
				Capabilities.nglNamedFramebufferDrawBuffers(framebuffer, n, (int*)bufs.ToPointer());
			}
		}
		
		public static void glNamedFramebufferDrawBuffers(int framebuffer, int n, ref int bufs)
		{
			unsafe
			{
				fixed (void* ptr = &bufs) Capabilities.nglNamedFramebufferDrawBuffers(framebuffer, n, (int*)ptr);
			}
		}
		
		public static void glNamedFramebufferDrawBuffers<T>(int framebuffer, int n, ref T bufs) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &bufs) Capabilities.nglNamedFramebufferDrawBuffers(framebuffer, n, (int*)ptr);
			}
		}
		
		public static void glNamedFramebufferDrawBuffers<T>(int framebuffer, int n, T[] bufs) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = bufs) Capabilities.nglNamedFramebufferDrawBuffers(framebuffer, n, (int*)ptr);
			}
		}
		
		public static void glNamedFramebufferDrawBuffers(int framebuffer, int n, int[] bufs)
		{
			unsafe
			{
				fixed (int* bufsPtr = bufs)
				{
					Capabilities.nglNamedFramebufferDrawBuffers(framebuffer, n, bufsPtr);
				}
			}
		}
		
		public static void glNamedFramebufferReadBuffer(int framebuffer, int src) =>
			Capabilities.nglNamedFramebufferReadBuffer(framebuffer, src);
		
		public static void glInvalidateNamedFramebufferData(int framebuffer, int numAttachments, IntPtr attachments)
		{
			unsafe
			{
				Capabilities.nglInvalidateNamedFramebufferData(framebuffer, numAttachments, (int*)attachments.ToPointer());
			}
		}
		
		public static void glInvalidateNamedFramebufferData(int framebuffer, int numAttachments, ref int attachments)
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateNamedFramebufferData(framebuffer, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateNamedFramebufferData<T>(int framebuffer, int numAttachments, ref T attachments) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateNamedFramebufferData(framebuffer, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateNamedFramebufferData<T>(int framebuffer, int numAttachments, T[] attachments) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = attachments) Capabilities.nglInvalidateNamedFramebufferData(framebuffer, numAttachments, (int*)ptr);
			}
		}
		
		public static void glInvalidateNamedFramebufferData(int framebuffer, int numAttachments, int[] attachments)
		{
			unsafe
			{
				fixed (int* attachmentsPtr = attachments)
				{
					Capabilities.nglInvalidateNamedFramebufferData(framebuffer, numAttachments, attachmentsPtr);
				}
			}
		}
		
		public static void glInvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, IntPtr attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				Capabilities.nglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, (int*)attachments.ToPointer(), x, y, width, height);
			}
		}
		
		public static void glInvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, ref int attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateNamedFramebufferSubData<T>(int framebuffer, int numAttachments, ref T attachments, int x, int y, int width, int height) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &attachments) Capabilities.nglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateNamedFramebufferSubData<T>(int framebuffer, int numAttachments, T[] attachments, int x, int y, int width, int height) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = attachments) Capabilities.nglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, (int*)ptr, x, y, width, height);
			}
		}
		
		public static void glInvalidateNamedFramebufferSubData(int framebuffer, int numAttachments, int[] attachments, int x, int y, int width, int height)
		{
			unsafe
			{
				fixed (int* attachmentsPtr = attachments)
				{
					Capabilities.nglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachmentsPtr, x, y, width, height);
				}
			}
		}
		
		public static void glClearNamedFramebufferiv(int framebuffer, int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, (int*)value.ToPointer());
			}
		}
		
		public static void glClearNamedFramebufferiv(int framebuffer, int buffer, int drawbuffer, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferiv<T>(int framebuffer, int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferiv<T>(int framebuffer, int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferiv(int framebuffer, int buffer, int drawbuffer, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearNamedFramebufferuiv(int framebuffer, int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, (int*)value.ToPointer());
			}
		}
		
		public static void glClearNamedFramebufferuiv(int framebuffer, int buffer, int drawbuffer, ref int value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferuiv<T>(int framebuffer, int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferuiv<T>(int framebuffer, int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, (int*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferuiv(int framebuffer, int buffer, int drawbuffer, int[] value)
		{
			unsafe
			{
				fixed (int* valuePtr = value)
				{
					Capabilities.nglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearNamedFramebufferfv(int framebuffer, int buffer, int drawbuffer, IntPtr value)
		{
			unsafe
			{
				Capabilities.nglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, (float*)value.ToPointer());
			}
		}
		
		public static void glClearNamedFramebufferfv(int framebuffer, int buffer, int drawbuffer, ref float value)
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferfv<T>(int framebuffer, int buffer, int drawbuffer, ref T value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &value) Capabilities.nglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferfv<T>(int framebuffer, int buffer, int drawbuffer, T[] value) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = value) Capabilities.nglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, (float*)ptr);
			}
		}
		
		public static void glClearNamedFramebufferfv(int framebuffer, int buffer, int drawbuffer, float[] value)
		{
			unsafe
			{
				fixed (float* valuePtr = value)
				{
					Capabilities.nglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, valuePtr);
				}
			}
		}
		
		public static void glClearNamedFramebufferfi(int framebuffer, int buffer, int drawbuffer, float depth, int stencil) =>
			Capabilities.nglClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		
		public static void glBlitNamedFramebuffer(int readFramebuffer, int drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter) =>
			Capabilities.nglBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		
		public static int glCheckNamedFramebufferStatus(int framebuffer, int target) =>
			Capabilities.nglCheckNamedFramebufferStatus(framebuffer, target);
		
		public static void glGetNamedFramebufferParameteriv(int framebuffer, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetNamedFramebufferParameteriv(framebuffer, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glGetNamedFramebufferParameteriv(int framebuffer, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetNamedFramebufferParameteriv(framebuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferParameteriv<T>(int framebuffer, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetNamedFramebufferParameteriv(framebuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferParameteriv<T>(int framebuffer, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetNamedFramebufferParameteriv(framebuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferParameteriv(int framebuffer, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglGetNamedFramebufferParameteriv(framebuffer, pname, paramPtr);
				}
			}
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(int framebuffer, int attachment, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(int framebuffer, int attachment, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv<T>(int framebuffer, int attachment, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv<T>(int framebuffer, int attachment, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(int framebuffer, int attachment, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, _paramsPtr);
				}
			}
		}
		
		public static void glCreateRenderbuffers(int n, IntPtr renderbuffers)
		{
			unsafe
			{
				Capabilities.nglCreateRenderbuffers(n, (int*)renderbuffers.ToPointer());
			}
		}
		
		public static void glCreateRenderbuffers(int n, ref int renderbuffers)
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglCreateRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateRenderbuffers<T>(int n, ref T renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &renderbuffers) Capabilities.nglCreateRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateRenderbuffers<T>(int n, T[] renderbuffers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = renderbuffers) Capabilities.nglCreateRenderbuffers(n, (int*)ptr);
			}
		}
		
		public static void glCreateRenderbuffers(int n, int[] renderbuffers)
		{
			unsafe
			{
				fixed (int* renderbuffersPtr = renderbuffers)
				{
					Capabilities.nglCreateRenderbuffers(n, renderbuffersPtr);
				}
			}
		}
		
		public static void glNamedRenderbufferStorage(int renderbuffer, int internalformat, int width, int height) =>
			Capabilities.nglNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		
		public static void glNamedRenderbufferStorageMultisample(int renderbuffer, int samples, int internalformat, int width, int height) =>
			Capabilities.nglNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		
		public static void glGetNamedRenderbufferParameteriv(int renderbuffer, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetNamedRenderbufferParameteriv(renderbuffer, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetNamedRenderbufferParameteriv(int renderbuffer, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedRenderbufferParameteriv(renderbuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedRenderbufferParameteriv<T>(int renderbuffer, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetNamedRenderbufferParameteriv(renderbuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedRenderbufferParameteriv<T>(int renderbuffer, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetNamedRenderbufferParameteriv(renderbuffer, pname, (int*)ptr);
			}
		}
		
		public static void glGetNamedRenderbufferParameteriv(int renderbuffer, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetNamedRenderbufferParameteriv(renderbuffer, pname, _paramsPtr);
				}
			}
		}
		
		public static void glCreateTextures(int target, int n, IntPtr textures)
		{
			unsafe
			{
				Capabilities.nglCreateTextures(target, n, (int*)textures.ToPointer());
			}
		}
		
		public static void glCreateTextures(int target, int n, ref int textures)
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglCreateTextures(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateTextures<T>(int target, int n, ref T textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &textures) Capabilities.nglCreateTextures(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateTextures<T>(int target, int n, T[] textures) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = textures) Capabilities.nglCreateTextures(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateTextures(int target, int n, int[] textures)
		{
			unsafe
			{
				fixed (int* texturesPtr = textures)
				{
					Capabilities.nglCreateTextures(target, n, texturesPtr);
				}
			}
		}
		
		public static void glTextureBuffer(int texture, int internalformat, int buffer) =>
			Capabilities.nglTextureBuffer(texture, internalformat, buffer);
		
		public static void glTextureBufferRange(int texture, int internalformat, int buffer, IntPtr offset, IntPtr size) =>
			Capabilities.nglTextureBufferRange(texture, internalformat, buffer, offset, size);
		
		public static void glTextureStorage1D(int texture, int levels, int internalformat, int width) =>
			Capabilities.nglTextureStorage1D(texture, levels, internalformat, width);
		
		public static void glTextureStorage2D(int texture, int levels, int internalformat, int width, int height) =>
			Capabilities.nglTextureStorage2D(texture, levels, internalformat, width, height);
		
		public static void glTextureStorage3D(int texture, int levels, int internalformat, int width, int height, int depth) =>
			Capabilities.nglTextureStorage3D(texture, levels, internalformat, width, height, depth);
		
		public static void glTextureStorage2DMultisample(int texture, int samples, int internalformat, int width, int height, byte fixedsamplelocations) =>
			Capabilities.nglTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		
		public static void glTextureStorage3DMultisample(int texture, int samples, int internalformat, int width, int height, int depth, byte fixedsamplelocations) =>
			Capabilities.nglTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		
		public static void glTextureSubImage1D(int texture, int level, int xoffset, int width, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTextureSubImage1D(texture, level, xoffset, width, format, type, pixels.ToPointer());
			}
		}
		
		public static void glTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
			}
		}
		
		public static void glTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
			}
		}
		
		public static void glCompressedTextureSubImage1D(int texture, int level, int xoffset, int width, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glCompressedTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToPointer());
			}
		}
		
		public static void glCopyTextureSubImage1D(int texture, int level, int xoffset, int x, int y, int width) =>
			Capabilities.nglCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		
		public static void glCopyTextureSubImage2D(int texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) =>
			Capabilities.nglCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		
		public static void glCopyTextureSubImage3D(int texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) =>
			Capabilities.nglCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		
		public static void glTextureParameterf(int texture, int pname, float param) =>
			Capabilities.nglTextureParameterf(texture, pname, param);
		
		public static void glTextureParameterfv(int texture, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglTextureParameterfv(texture, pname, (float*)param.ToPointer());
			}
		}
		
		public static void glTextureParameterfv(int texture, int pname, ref float param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glTextureParameterfv<T>(int texture, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glTextureParameterfv<T>(int texture, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glTextureParameterfv(int texture, int pname, float[] param)
		{
			unsafe
			{
				fixed (float* paramPtr = param)
				{
					Capabilities.nglTextureParameterfv(texture, pname, paramPtr);
				}
			}
		}
		
		public static void glTextureParameteri(int texture, int pname, int param) =>
			Capabilities.nglTextureParameteri(texture, pname, param);
		
		public static void glTextureParameterIiv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTextureParameterIiv(texture, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTextureParameterIiv(int texture, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIiv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIiv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIiv(int texture, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTextureParameterIiv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTextureParameterIuiv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTextureParameterIuiv(texture, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTextureParameterIuiv(int texture, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIuiv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIuiv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameterIuiv(int texture, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTextureParameterIuiv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTextureParameteriv(int texture, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglTextureParameteriv(texture, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glTextureParameteriv(int texture, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameteriv<T>(int texture, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameteriv<T>(int texture, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glTextureParameteriv(int texture, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglTextureParameteriv(texture, pname, paramPtr);
				}
			}
		}
		
		public static void glGenerateTextureMipmap(int texture) =>
			Capabilities.nglGenerateTextureMipmap(texture);
		
		public static void glBindTextureUnit(int unit, int texture) =>
			Capabilities.nglBindTextureUnit(unit, texture);
		
		public static void glGetTextureImage(int texture, int level, int format, int type, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetTextureImage(texture, level, format, type, bufSize, pixels.ToPointer());
			}
		}
		
		public static void glGetCompressedTextureImage(int texture, int level, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetCompressedTextureImage(texture, level, bufSize, pixels.ToPointer());
			}
		}
		
		public static void glGetTextureLevelParameterfv(int texture, int level, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureLevelParameterfv(texture, level, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureLevelParameterfv(int texture, int level, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureLevelParameterfv(texture, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameterfv<T>(int texture, int level, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureLevelParameterfv(texture, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameterfv<T>(int texture, int level, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureLevelParameterfv(texture, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameterfv(int texture, int level, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureLevelParameterfv(texture, level, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTextureLevelParameteriv(int texture, int level, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureLevelParameteriv(texture, level, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureLevelParameteriv(int texture, int level, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureLevelParameteriv(texture, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameteriv<T>(int texture, int level, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureLevelParameteriv(texture, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameteriv<T>(int texture, int level, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureLevelParameteriv(texture, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureLevelParameteriv(int texture, int level, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureLevelParameteriv(texture, level, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTextureParameterfv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureParameterfv(texture, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureParameterfv(int texture, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureParameterfv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureParameterfv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureParameterfv(texture, pname, (float*)ptr);
			}
		}
		
		public static void glGetTextureParameterfv(int texture, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureParameterfv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTextureParameterIiv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureParameterIiv(texture, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureParameterIiv(int texture, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIiv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIiv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureParameterIiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIiv(int texture, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureParameterIiv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTextureParameterIuiv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureParameterIuiv(texture, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureParameterIuiv(int texture, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIuiv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIuiv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureParameterIuiv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameterIuiv(int texture, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureParameterIuiv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTextureParameteriv(int texture, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTextureParameteriv(texture, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTextureParameteriv(int texture, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameteriv<T>(int texture, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameteriv<T>(int texture, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTextureParameteriv(texture, pname, (int*)ptr);
			}
		}
		
		public static void glGetTextureParameteriv(int texture, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTextureParameteriv(texture, pname, _paramsPtr);
				}
			}
		}
		
		public static void glCreateVertexArrays(int n, IntPtr arrays)
		{
			unsafe
			{
				Capabilities.nglCreateVertexArrays(n, (int*)arrays.ToPointer());
			}
		}
		
		public static void glCreateVertexArrays(int n, ref int arrays)
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglCreateVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glCreateVertexArrays<T>(int n, ref T arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &arrays) Capabilities.nglCreateVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glCreateVertexArrays<T>(int n, T[] arrays) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = arrays) Capabilities.nglCreateVertexArrays(n, (int*)ptr);
			}
		}
		
		public static void glCreateVertexArrays(int n, int[] arrays)
		{
			unsafe
			{
				fixed (int* arraysPtr = arrays)
				{
					Capabilities.nglCreateVertexArrays(n, arraysPtr);
				}
			}
		}
		
		public static void glDisableVertexArrayAttrib(int vaobj, int index) =>
			Capabilities.nglDisableVertexArrayAttrib(vaobj, index);
		
		public static void glEnableVertexArrayAttrib(int vaobj, int index) =>
			Capabilities.nglEnableVertexArrayAttrib(vaobj, index);
		
		public static void glVertexArrayElementBuffer(int vaobj, int buffer) =>
			Capabilities.nglVertexArrayElementBuffer(vaobj, buffer);
		
		public static void glVertexArrayVertexBuffer(int vaobj, int bindingindex, int buffer, IntPtr offset, int stride) =>
			Capabilities.nglVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		
		public static void glVertexArrayVertexBuffers(int vaobj, int first, int count, IntPtr buffers, IntPtr offsets, IntPtr strides)
		{
			unsafe
			{
				Capabilities.nglVertexArrayVertexBuffers(vaobj, first, count, (int*)buffers.ToPointer(), (IntPtr*)offsets.ToPointer(), (int*)strides.ToPointer());
			}
		}
		
		public static void glVertexArrayVertexBuffers(int vaobj, int first, int count, int[] buffers, IntPtr[] offsets, int[] strides)
		{
			unsafe
			{
				fixed (int* buffersPtr = buffers)
				{
					fixed (IntPtr* offsetsPtr = offsets)
					{
						fixed (int* stridesPtr = strides)
						{
							Capabilities.nglVertexArrayVertexBuffers(vaobj, first, count, buffersPtr, offsetsPtr, stridesPtr);
						}
					}
				}
			}
		}
		
		public static void glVertexArrayAttribBinding(int vaobj, int attribindex, int bindingindex) =>
			Capabilities.nglVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		
		public static void glVertexArrayAttribFormat(int vaobj, int attribindex, int size, int type, byte normalized, int relativeoffset) =>
			Capabilities.nglVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		
		public static void glVertexArrayAttribIFormat(int vaobj, int attribindex, int size, int type, int relativeoffset) =>
			Capabilities.nglVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		
		public static void glVertexArrayAttribLFormat(int vaobj, int attribindex, int size, int type, int relativeoffset) =>
			Capabilities.nglVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		
		public static void glVertexArrayBindingDivisor(int vaobj, int bindingindex, int divisor) =>
			Capabilities.nglVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		
		public static void glGetVertexArrayiv(int vaobj, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetVertexArrayiv(vaobj, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glGetVertexArrayiv(int vaobj, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayiv(vaobj, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayiv<T>(int vaobj, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayiv(vaobj, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayiv<T>(int vaobj, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetVertexArrayiv(vaobj, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayiv(int vaobj, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglGetVertexArrayiv(vaobj, pname, paramPtr);
				}
			}
		}
		
		public static void glGetVertexArrayIndexediv(int vaobj, int index, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetVertexArrayIndexediv(vaobj, index, pname, (int*)param.ToPointer());
			}
		}
		
		public static void glGetVertexArrayIndexediv(int vaobj, int index, int pname, ref int param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayIndexediv(vaobj, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexediv<T>(int vaobj, int index, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayIndexediv(vaobj, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexediv<T>(int vaobj, int index, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetVertexArrayIndexediv(vaobj, index, pname, (int*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexediv(int vaobj, int index, int pname, int[] param)
		{
			unsafe
			{
				fixed (int* paramPtr = param)
				{
					Capabilities.nglGetVertexArrayIndexediv(vaobj, index, pname, paramPtr);
				}
			}
		}
		
		public static void glGetVertexArrayIndexed64iv(int vaobj, int index, int pname, IntPtr param)
		{
			unsafe
			{
				Capabilities.nglGetVertexArrayIndexed64iv(vaobj, index, pname, (long*)param.ToPointer());
			}
		}
		
		public static void glGetVertexArrayIndexed64iv(int vaobj, int index, int pname, ref long param)
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayIndexed64iv(vaobj, index, pname, (long*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexed64iv<T>(int vaobj, int index, int pname, ref T param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &param) Capabilities.nglGetVertexArrayIndexed64iv(vaobj, index, pname, (long*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexed64iv<T>(int vaobj, int index, int pname, T[] param) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = param) Capabilities.nglGetVertexArrayIndexed64iv(vaobj, index, pname, (long*)ptr);
			}
		}
		
		public static void glGetVertexArrayIndexed64iv(int vaobj, int index, int pname, long[] param)
		{
			unsafe
			{
				fixed (long* paramPtr = param)
				{
					Capabilities.nglGetVertexArrayIndexed64iv(vaobj, index, pname, paramPtr);
				}
			}
		}
		
		public static void glCreateSamplers(int n, IntPtr samplers)
		{
			unsafe
			{
				Capabilities.nglCreateSamplers(n, (int*)samplers.ToPointer());
			}
		}
		
		public static void glCreateSamplers(int n, ref int samplers)
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglCreateSamplers(n, (int*)ptr);
			}
		}
		
		public static void glCreateSamplers<T>(int n, ref T samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &samplers) Capabilities.nglCreateSamplers(n, (int*)ptr);
			}
		}
		
		public static void glCreateSamplers<T>(int n, T[] samplers) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = samplers) Capabilities.nglCreateSamplers(n, (int*)ptr);
			}
		}
		
		public static void glCreateSamplers(int n, int[] samplers)
		{
			unsafe
			{
				fixed (int* samplersPtr = samplers)
				{
					Capabilities.nglCreateSamplers(n, samplersPtr);
				}
			}
		}
		
		public static void glCreateProgramPipelines(int n, IntPtr pipelines)
		{
			unsafe
			{
				Capabilities.nglCreateProgramPipelines(n, (int*)pipelines.ToPointer());
			}
		}
		
		public static void glCreateProgramPipelines(int n, ref int pipelines)
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglCreateProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glCreateProgramPipelines<T>(int n, ref T pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &pipelines) Capabilities.nglCreateProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glCreateProgramPipelines<T>(int n, T[] pipelines) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = pipelines) Capabilities.nglCreateProgramPipelines(n, (int*)ptr);
			}
		}
		
		public static void glCreateProgramPipelines(int n, int[] pipelines)
		{
			unsafe
			{
				fixed (int* pipelinesPtr = pipelines)
				{
					Capabilities.nglCreateProgramPipelines(n, pipelinesPtr);
				}
			}
		}
		
		public static void glCreateQueries(int target, int n, IntPtr ids)
		{
			unsafe
			{
				Capabilities.nglCreateQueries(target, n, (int*)ids.ToPointer());
			}
		}
		
		public static void glCreateQueries(int target, int n, ref int ids)
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglCreateQueries(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateQueries<T>(int target, int n, ref T ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &ids) Capabilities.nglCreateQueries(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateQueries<T>(int target, int n, T[] ids) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = ids) Capabilities.nglCreateQueries(target, n, (int*)ptr);
			}
		}
		
		public static void glCreateQueries(int target, int n, int[] ids)
		{
			unsafe
			{
				fixed (int* idsPtr = ids)
				{
					Capabilities.nglCreateQueries(target, n, idsPtr);
				}
			}
		}
		
		public static void glGetQueryBufferObjecti64v(int id, int buffer, int pname, IntPtr offset) =>
			Capabilities.nglGetQueryBufferObjecti64v(id, buffer, pname, offset);
		
		public static void glGetQueryBufferObjectiv(int id, int buffer, int pname, IntPtr offset) =>
			Capabilities.nglGetQueryBufferObjectiv(id, buffer, pname, offset);
		
		public static void glGetQueryBufferObjectui64v(int id, int buffer, int pname, IntPtr offset) =>
			Capabilities.nglGetQueryBufferObjectui64v(id, buffer, pname, offset);
		
		public static void glGetQueryBufferObjectuiv(int id, int buffer, int pname, IntPtr offset) =>
			Capabilities.nglGetQueryBufferObjectuiv(id, buffer, pname, offset);
		
		public static void glMemoryBarrierByRegion(int barriers) =>
			Capabilities.nglMemoryBarrierByRegion(barriers);
		
		public static void glGetTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels.ToPointer());
			}
		}
		
		public static void glGetCompressedTextureSubImage(int texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels.ToPointer());
			}
		}
		
		public static int glGetGraphicsResetStatus() =>
			Capabilities.nglGetGraphicsResetStatus();
		
		public static void glGetnCompressedTexImage(int target, int lod, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetnCompressedTexImage(target, lod, bufSize, pixels.ToPointer());
			}
		}
		
		public static void glGetnTexImage(int target, int level, int format, int type, int bufSize, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetnTexImage(target, level, format, type, bufSize, pixels.ToPointer());
			}
		}
		
		public static void glGetnUniformdv(int program, int location, int bufSize, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetnUniformdv(program, location, bufSize, (double*)_params.ToPointer());
			}
		}
		
		public static void glGetnUniformdv(int program, int location, int bufSize, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformdv(program, location, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnUniformdv<T>(int program, int location, int bufSize, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformdv(program, location, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnUniformdv<T>(int program, int location, int bufSize, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetnUniformdv(program, location, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnUniformdv(int program, int location, int bufSize, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglGetnUniformdv(program, location, bufSize, _paramsPtr);
				}
			}
		}
		
		public static void glGetnUniformfv(int program, int location, int bufSize, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetnUniformfv(program, location, bufSize, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetnUniformfv(int program, int location, int bufSize, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformfv(program, location, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnUniformfv<T>(int program, int location, int bufSize, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformfv(program, location, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnUniformfv<T>(int program, int location, int bufSize, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetnUniformfv(program, location, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnUniformfv(int program, int location, int bufSize, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetnUniformfv(program, location, bufSize, _paramsPtr);
				}
			}
		}
		
		public static void glGetnUniformiv(int program, int location, int bufSize, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetnUniformiv(program, location, bufSize, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetnUniformiv(int program, int location, int bufSize, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformiv<T>(int program, int location, int bufSize, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformiv<T>(int program, int location, int bufSize, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetnUniformiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformiv(int program, int location, int bufSize, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetnUniformiv(program, location, bufSize, _paramsPtr);
				}
			}
		}
		
		public static void glGetnUniformuiv(int program, int location, int bufSize, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetnUniformuiv(program, location, bufSize, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetnUniformuiv(int program, int location, int bufSize, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformuiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformuiv<T>(int program, int location, int bufSize, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetnUniformuiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformuiv<T>(int program, int location, int bufSize, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetnUniformuiv(program, location, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnUniformuiv(int program, int location, int bufSize, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetnUniformuiv(program, location, bufSize, _paramsPtr);
				}
			}
		}
		
		public static void glReadnPixels(int x, int y, int width, int height, int format, int type, int bufSize, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglReadnPixels(x, y, width, height, format, type, bufSize, data.ToPointer());
			}
		}
		
		public static void glGetnMapdv(int target, int query, int bufSize, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetnMapdv(target, query, bufSize, (double*)v.ToPointer());
			}
		}
		
		public static void glGetnMapdv(int target, int query, int bufSize, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapdv(target, query, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnMapdv<T>(int target, int query, int bufSize, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapdv(target, query, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnMapdv<T>(int target, int query, int bufSize, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetnMapdv(target, query, bufSize, (double*)ptr);
			}
		}
		
		public static void glGetnMapdv(int target, int query, int bufSize, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglGetnMapdv(target, query, bufSize, vPtr);
				}
			}
		}
		
		public static void glGetnMapfv(int target, int query, int bufSize, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetnMapfv(target, query, bufSize, (float*)v.ToPointer());
			}
		}
		
		public static void glGetnMapfv(int target, int query, int bufSize, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapfv(target, query, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnMapfv<T>(int target, int query, int bufSize, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapfv(target, query, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnMapfv<T>(int target, int query, int bufSize, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetnMapfv(target, query, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnMapfv(int target, int query, int bufSize, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglGetnMapfv(target, query, bufSize, vPtr);
				}
			}
		}
		
		public static void glGetnMapiv(int target, int query, int bufSize, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetnMapiv(target, query, bufSize, (int*)v.ToPointer());
			}
		}
		
		public static void glGetnMapiv(int target, int query, int bufSize, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapiv(target, query, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnMapiv<T>(int target, int query, int bufSize, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetnMapiv(target, query, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnMapiv<T>(int target, int query, int bufSize, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetnMapiv(target, query, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnMapiv(int target, int query, int bufSize, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglGetnMapiv(target, query, bufSize, vPtr);
				}
			}
		}
		
		public static void glGetnPixelMapfv(int map, int bufSize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetnPixelMapfv(map, bufSize, (float*)values.ToPointer());
			}
		}
		
		public static void glGetnPixelMapfv(int map, int bufSize, ref float values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapfv(map, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnPixelMapfv<T>(int map, int bufSize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapfv(map, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnPixelMapfv<T>(int map, int bufSize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetnPixelMapfv(map, bufSize, (float*)ptr);
			}
		}
		
		public static void glGetnPixelMapfv(int map, int bufSize, float[] values)
		{
			unsafe
			{
				fixed (float* valuesPtr = values)
				{
					Capabilities.nglGetnPixelMapfv(map, bufSize, valuesPtr);
				}
			}
		}
		
		public static void glGetnPixelMapuiv(int map, int bufSize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetnPixelMapuiv(map, bufSize, (int*)values.ToPointer());
			}
		}
		
		public static void glGetnPixelMapuiv(int map, int bufSize, ref int values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapuiv(map, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnPixelMapuiv<T>(int map, int bufSize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapuiv(map, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnPixelMapuiv<T>(int map, int bufSize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetnPixelMapuiv(map, bufSize, (int*)ptr);
			}
		}
		
		public static void glGetnPixelMapuiv(int map, int bufSize, int[] values)
		{
			unsafe
			{
				fixed (int* valuesPtr = values)
				{
					Capabilities.nglGetnPixelMapuiv(map, bufSize, valuesPtr);
				}
			}
		}
		
		public static void glGetnPixelMapusv(int map, int bufSize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetnPixelMapusv(map, bufSize, (ushort*)values.ToPointer());
			}
		}
		
		public static void glGetnPixelMapusv(int map, int bufSize, ref ushort values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapusv(map, bufSize, (ushort*)ptr);
			}
		}
		
		public static void glGetnPixelMapusv<T>(int map, int bufSize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetnPixelMapusv(map, bufSize, (ushort*)ptr);
			}
		}
		
		public static void glGetnPixelMapusv<T>(int map, int bufSize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetnPixelMapusv(map, bufSize, (ushort*)ptr);
			}
		}
		
		public static void glGetnPixelMapusv(int map, int bufSize, ushort[] values)
		{
			unsafe
			{
				fixed (ushort* valuesPtr = values)
				{
					Capabilities.nglGetnPixelMapusv(map, bufSize, valuesPtr);
				}
			}
		}
		
		public static void glGetnPolygonStipple(int bufSize, IntPtr pattern)
		{
			unsafe
			{
				Capabilities.nglGetnPolygonStipple(bufSize, (byte*)pattern.ToPointer());
			}
		}
		
		public static void glGetnPolygonStipple(int bufSize, ref byte pattern)
		{
			unsafe
			{
				fixed (void* ptr = &pattern) Capabilities.nglGetnPolygonStipple(bufSize, (byte*)ptr);
			}
		}
		
		public static void glGetnPolygonStipple<T>(int bufSize, ref T pattern) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &pattern) Capabilities.nglGetnPolygonStipple(bufSize, (byte*)ptr);
			}
		}
		
		public static void glGetnPolygonStipple<T>(int bufSize, T[] pattern) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = pattern) Capabilities.nglGetnPolygonStipple(bufSize, (byte*)ptr);
			}
		}
		
		public static void glGetnPolygonStipple(int bufSize, byte[] pattern)
		{
			unsafe
			{
				fixed (byte* patternPtr = pattern)
				{
					Capabilities.nglGetnPolygonStipple(bufSize, patternPtr);
				}
			}
		}
		
		public static void glGetnColorTable(int target, int format, int type, int bufSize, IntPtr table)
		{
			unsafe
			{
				Capabilities.nglGetnColorTable(target, format, type, bufSize, table.ToPointer());
			}
		}
		
		public static void glGetnConvolutionFilter(int target, int format, int type, int bufSize, IntPtr image)
		{
			unsafe
			{
				Capabilities.nglGetnConvolutionFilter(target, format, type, bufSize, image.ToPointer());
			}
		}
		
		public static void glGetnSeparableFilter(int target, int format, int type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span)
		{
			unsafe
			{
				Capabilities.nglGetnSeparableFilter(target, format, type, rowBufSize, row.ToPointer(), columnBufSize, column.ToPointer(), span.ToPointer());
			}
		}
		
		public static void glGetnHistogram(int target, byte reset, int format, int type, int bufSize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetnHistogram(target, reset, format, type, bufSize, values.ToPointer());
			}
		}
		
		public static void glGetnMinmax(int target, byte reset, int format, int type, int bufSize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetnMinmax(target, reset, format, type, bufSize, values.ToPointer());
			}
		}
		
		public static void glTextureBarrier() =>
			Capabilities.nglTextureBarrier();
		
		
	}
}
