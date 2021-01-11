# OpenGL bindings for C#

## Usage with SDL library:
    using SGE.GL;
    <.....>
    var window = SDL_CreateWindow(title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, width, height,
					SDL_WindowFlags.SDL_WINDOW_OPENGL);
    var context = SDL_GL_CreateContext(display.Handle);
    SDL_GL_MakeCurrent(window, context);
    // init functions for current context:
    var openGl = new OpenGL(SDL_GL_GetProcAddress);
    // set to current
    OpenGL.Capabilities = openGl;
    // here you can use opengl. for example:
    glClearColor(0.5f, 0.5f, 0.8f, 0.0f);
    glClear(GL_COLOR_BUFFER_BIT);

#### with multiple contexts just make current OpenGL instance:
    // set current
    SDL_GL_MakeCurrent(windowHandle, contextHandle);
    OpenGL.Capabilities = openGl;
    // unset
    SDL_GL_MakeCurrent(IntPtr.Zero, IntPtr.Zero);
    OpenGL.Capabilities = null;
    
