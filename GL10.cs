using System;

namespace SGE.GL {
	public partial class OpenGL {
	
		#region Constants
		public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
		public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
		public const int GL_COLOR_BUFFER_BIT = 0x00004000;
		public const int GL_FALSE = 0;
		public const int GL_TRUE = 1;
		public const int GL_POINTS = 0x0000;
		public const int GL_LINES = 0x0001;
		public const int GL_LINE_LOOP = 0x0002;
		public const int GL_LINE_STRIP = 0x0003;
		public const int GL_TRIANGLES = 0x0004;
		public const int GL_TRIANGLE_STRIP = 0x0005;
		public const int GL_TRIANGLE_FAN = 0x0006;
		public const int GL_QUADS = 0x0007;
		public const int GL_NEVER = 0x0200;
		public const int GL_LESS = 0x0201;
		public const int GL_EQUAL = 0x0202;
		public const int GL_LEQUAL = 0x0203;
		public const int GL_GREATER = 0x0204;
		public const int GL_NOTEQUAL = 0x0205;
		public const int GL_GEQUAL = 0x0206;
		public const int GL_ALWAYS = 0x0207;
		public const int GL_ZERO = 0;
		public const int GL_ONE = 1;
		public const int GL_SRC_COLOR = 0x0300;
		public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const int GL_SRC_ALPHA = 0x0302;
		public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const int GL_DST_ALPHA = 0x0304;
		public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const int GL_DST_COLOR = 0x0306;
		public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const int GL_SRC_ALPHA_SATURATE = 0x0308;
		public const int GL_NONE = 0;
		public const int GL_FRONT_LEFT = 0x0400;
		public const int GL_FRONT_RIGHT = 0x0401;
		public const int GL_BACK_LEFT = 0x0402;
		public const int GL_BACK_RIGHT = 0x0403;
		public const int GL_FRONT = 0x0404;
		public const int GL_BACK = 0x0405;
		public const int GL_LEFT = 0x0406;
		public const int GL_RIGHT = 0x0407;
		public const int GL_FRONT_AND_BACK = 0x0408;
		public const int GL_NO_ERROR = 0;
		public const int GL_INVALID_ENUM = 0x0500;
		public const int GL_INVALID_VALUE = 0x0501;
		public const int GL_INVALID_OPERATION = 0x0502;
		public const int GL_OUT_OF_MEMORY = 0x0505;
		public const int GL_CW = 0x0900;
		public const int GL_CCW = 0x0901;
		public const int GL_POINT_SIZE = 0x0B11;
		public const int GL_POINT_SIZE_RANGE = 0x0B12;
		public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;
		public const int GL_LINE_SMOOTH = 0x0B20;
		public const int GL_LINE_WIDTH = 0x0B21;
		public const int GL_LINE_WIDTH_RANGE = 0x0B22;
		public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const int GL_POLYGON_MODE = 0x0B40;
		public const int GL_POLYGON_SMOOTH = 0x0B41;
		public const int GL_CULL_FACE = 0x0B44;
		public const int GL_CULL_FACE_MODE = 0x0B45;
		public const int GL_FRONT_FACE = 0x0B46;
		public const int GL_DEPTH_RANGE = 0x0B70;
		public const int GL_DEPTH_TEST = 0x0B71;
		public const int GL_DEPTH_WRITEMASK = 0x0B72;
		public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
		public const int GL_DEPTH_FUNC = 0x0B74;
		public const int GL_STENCIL_TEST = 0x0B90;
		public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
		public const int GL_STENCIL_FUNC = 0x0B92;
		public const int GL_STENCIL_VALUE_MASK = 0x0B93;
		public const int GL_STENCIL_FAIL = 0x0B94;
		public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const int GL_STENCIL_REF = 0x0B97;
		public const int GL_STENCIL_WRITEMASK = 0x0B98;
		public const int GL_VIEWPORT = 0x0BA2;
		public const int GL_DITHER = 0x0BD0;
		public const int GL_BLEND_DST = 0x0BE0;
		public const int GL_BLEND_SRC = 0x0BE1;
		public const int GL_BLEND = 0x0BE2;
		public const int GL_LOGIC_OP_MODE = 0x0BF0;
		public const int GL_DRAW_BUFFER = 0x0C01;
		public const int GL_READ_BUFFER = 0x0C02;
		public const int GL_SCISSOR_BOX = 0x0C10;
		public const int GL_SCISSOR_TEST = 0x0C11;
		public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
		public const int GL_COLOR_WRITEMASK = 0x0C23;
		public const int GL_DOUBLEBUFFER = 0x0C32;
		public const int GL_STEREO = 0x0C33;
		public const int GL_LINE_SMOOTH_HINT = 0x0C52;
		public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;
		public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;
		public const int GL_UNPACK_LSB_FIRST = 0x0CF1;
		public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;
		public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;
		public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;
		public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
		public const int GL_PACK_SWAP_BYTES = 0x0D00;
		public const int GL_PACK_LSB_FIRST = 0x0D01;
		public const int GL_PACK_ROW_LENGTH = 0x0D02;
		public const int GL_PACK_SKIP_ROWS = 0x0D03;
		public const int GL_PACK_SKIP_PIXELS = 0x0D04;
		public const int GL_PACK_ALIGNMENT = 0x0D05;
		public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
		public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
		public const int GL_SUBPIXEL_BITS = 0x0D50;
		public const int GL_TEXTURE_1D = 0x0DE0;
		public const int GL_TEXTURE_2D = 0x0DE1;
		public const int GL_TEXTURE_WIDTH = 0x1000;
		public const int GL_TEXTURE_HEIGHT = 0x1001;
		public const int GL_TEXTURE_BORDER_COLOR = 0x1004;
		public const int GL_DONT_CARE = 0x1100;
		public const int GL_FASTEST = 0x1101;
		public const int GL_NICEST = 0x1102;
		public const int GL_BYTE = 0x1400;
		public const int GL_UNSIGNED_BYTE = 0x1401;
		public const int GL_SHORT = 0x1402;
		public const int GL_UNSIGNED_SHORT = 0x1403;
		public const int GL_INT = 0x1404;
		public const int GL_UNSIGNED_INT = 0x1405;
		public const int GL_FLOAT = 0x1406;
		public const int GL_STACK_OVERFLOW = 0x0503;
		public const int GL_STACK_UNDERFLOW = 0x0504;
		public const int GL_CLEAR = 0x1500;
		public const int GL_AND = 0x1501;
		public const int GL_AND_REVERSE = 0x1502;
		public const int GL_COPY = 0x1503;
		public const int GL_AND_INVERTED = 0x1504;
		public const int GL_NOOP = 0x1505;
		public const int GL_XOR = 0x1506;
		public const int GL_OR = 0x1507;
		public const int GL_NOR = 0x1508;
		public const int GL_EQUIV = 0x1509;
		public const int GL_INVERT = 0x150A;
		public const int GL_OR_REVERSE = 0x150B;
		public const int GL_COPY_INVERTED = 0x150C;
		public const int GL_OR_INVERTED = 0x150D;
		public const int GL_NAND = 0x150E;
		public const int GL_SET = 0x150F;
		public const int GL_TEXTURE = 0x1702;
		public const int GL_COLOR = 0x1800;
		public const int GL_DEPTH = 0x1801;
		public const int GL_STENCIL = 0x1802;
		public const int GL_STENCIL_INDEX = 0x1901;
		public const int GL_DEPTH_COMPONENT = 0x1902;
		public const int GL_RED = 0x1903;
		public const int GL_GREEN = 0x1904;
		public const int GL_BLUE = 0x1905;
		public const int GL_ALPHA = 0x1906;
		public const int GL_RGB = 0x1907;
		public const int GL_RGBA = 0x1908;
		public const int GL_POINT = 0x1B00;
		public const int GL_LINE = 0x1B01;
		public const int GL_FILL = 0x1B02;
		public const int GL_KEEP = 0x1E00;
		public const int GL_REPLACE = 0x1E01;
		public const int GL_INCR = 0x1E02;
		public const int GL_DECR = 0x1E03;
		public const int GL_VENDOR = 0x1F00;
		public const int GL_RENDERER = 0x1F01;
		public const int GL_VERSION = 0x1F02;
		public const int GL_EXTENSIONS = 0x1F03;
		public const int GL_NEAREST = 0x2600;
		public const int GL_LINEAR = 0x2601;
		public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
		public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
		public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
		public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
		public const int GL_TEXTURE_MAG_FILTER = 0x2800;
		public const int GL_TEXTURE_MIN_FILTER = 0x2801;
		public const int GL_TEXTURE_WRAP_S = 0x2802;
		public const int GL_TEXTURE_WRAP_T = 0x2803;
		public const int GL_REPEAT = 0x2901;
		public const int GL_CURRENT_BIT = 0x00000001;
		public const int GL_POINT_BIT = 0x00000002;
		public const int GL_LINE_BIT = 0x00000004;
		public const int GL_POLYGON_BIT = 0x00000008;
		public const int GL_POLYGON_STIPPLE_BIT = 0x00000010;
		public const int GL_PIXEL_MODE_BIT = 0x00000020;
		public const int GL_LIGHTING_BIT = 0x00000040;
		public const int GL_FOG_BIT = 0x00000080;
		public const int GL_ACCUM_BUFFER_BIT = 0x00000200;
		public const int GL_VIEWPORT_BIT = 0x00000800;
		public const int GL_TRANSFORM_BIT = 0x00001000;
		public const int GL_ENABLE_BIT = 0x00002000;
		public const int GL_HINT_BIT = 0x00008000;
		public const int GL_EVAL_BIT = 0x00010000;
		public const int GL_LIST_BIT = 0x00020000;
		public const int GL_TEXTURE_BIT = 0x00040000;
		public const int GL_SCISSOR_BIT = 0x00080000;
		public const int GL_ALL_ATTRIB_BITS = -1;
		public const int GL_QUAD_STRIP = 0x0008;
		public const int GL_POLYGON = 0x0009;
		public const int GL_ACCUM = 0x0100;
		public const int GL_LOAD = 0x0101;
		public const int GL_RETURN = 0x0102;
		public const int GL_MULT = 0x0103;
		public const int GL_ADD = 0x0104;
		public const int GL_AUX0 = 0x0409;
		public const int GL_AUX1 = 0x040A;
		public const int GL_AUX2 = 0x040B;
		public const int GL_AUX3 = 0x040C;
		public const int GL_2D = 0x0600;
		public const int GL_3D = 0x0601;
		public const int GL_3D_COLOR = 0x0602;
		public const int GL_3D_COLOR_TEXTURE = 0x0603;
		public const int GL_4D_COLOR_TEXTURE = 0x0604;
		public const int GL_PASS_THROUGH_TOKEN = 0x0700;
		public const int GL_POINT_TOKEN = 0x0701;
		public const int GL_LINE_TOKEN = 0x0702;
		public const int GL_POLYGON_TOKEN = 0x0703;
		public const int GL_BITMAP_TOKEN = 0x0704;
		public const int GL_DRAW_PIXEL_TOKEN = 0x0705;
		public const int GL_COPY_PIXEL_TOKEN = 0x0706;
		public const int GL_LINE_RESET_TOKEN = 0x0707;
		public const int GL_EXP = 0x0800;
		public const int GL_EXP2 = 0x0801;
		public const int GL_COEFF = 0x0A00;
		public const int GL_ORDER = 0x0A01;
		public const int GL_DOMAIN = 0x0A02;
		public const int GL_PIXEL_MAP_I_TO_I = 0x0C70;
		public const int GL_PIXEL_MAP_S_TO_S = 0x0C71;
		public const int GL_PIXEL_MAP_I_TO_R = 0x0C72;
		public const int GL_PIXEL_MAP_I_TO_G = 0x0C73;
		public const int GL_PIXEL_MAP_I_TO_B = 0x0C74;
		public const int GL_PIXEL_MAP_I_TO_A = 0x0C75;
		public const int GL_PIXEL_MAP_R_TO_R = 0x0C76;
		public const int GL_PIXEL_MAP_G_TO_G = 0x0C77;
		public const int GL_PIXEL_MAP_B_TO_B = 0x0C78;
		public const int GL_PIXEL_MAP_A_TO_A = 0x0C79;
		public const int GL_CURRENT_COLOR = 0x0B00;
		public const int GL_CURRENT_INDEX = 0x0B01;
		public const int GL_CURRENT_NORMAL = 0x0B02;
		public const int GL_CURRENT_TEXTURE_COORDS = 0x0B03;
		public const int GL_CURRENT_RASTER_COLOR = 0x0B04;
		public const int GL_CURRENT_RASTER_INDEX = 0x0B05;
		public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
		public const int GL_CURRENT_RASTER_POSITION = 0x0B07;
		public const int GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
		public const int GL_CURRENT_RASTER_DISTANCE = 0x0B09;
		public const int GL_POINT_SMOOTH = 0x0B10;
		public const int GL_LINE_STIPPLE = 0x0B24;
		public const int GL_LINE_STIPPLE_PATTERN = 0x0B25;
		public const int GL_LINE_STIPPLE_REPEAT = 0x0B26;
		public const int GL_LIST_MODE = 0x0B30;
		public const int GL_MAX_LIST_NESTING = 0x0B31;
		public const int GL_LIST_BASE = 0x0B32;
		public const int GL_LIST_INDEX = 0x0B33;
		public const int GL_POLYGON_STIPPLE = 0x0B42;
		public const int GL_EDGE_FLAG = 0x0B43;
		public const int GL_LIGHTING = 0x0B50;
		public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
		public const int GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
		public const int GL_LIGHT_MODEL_AMBIENT = 0x0B53;
		public const int GL_SHADE_MODEL = 0x0B54;
		public const int GL_COLOR_MATERIAL_FACE = 0x0B55;
		public const int GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
		public const int GL_COLOR_MATERIAL = 0x0B57;
		public const int GL_FOG = 0x0B60;
		public const int GL_FOG_INDEX = 0x0B61;
		public const int GL_FOG_DENSITY = 0x0B62;
		public const int GL_FOG_START = 0x0B63;
		public const int GL_FOG_END = 0x0B64;
		public const int GL_FOG_MODE = 0x0B65;
		public const int GL_FOG_COLOR = 0x0B66;
		public const int GL_ACCUM_CLEAR_VALUE = 0x0B80;
		public const int GL_MATRIX_MODE = 0x0BA0;
		public const int GL_NORMALIZE = 0x0BA1;
		public const int GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
		public const int GL_PROJECTION_STACK_DEPTH = 0x0BA4;
		public const int GL_TEXTURE_STACK_DEPTH = 0x0BA5;
		public const int GL_MODELVIEW_MATRIX = 0x0BA6;
		public const int GL_PROJECTION_MATRIX = 0x0BA7;
		public const int GL_TEXTURE_MATRIX = 0x0BA8;
		public const int GL_ATTRIB_STACK_DEPTH = 0x0BB0;
		public const int GL_ALPHA_TEST = 0x0BC0;
		public const int GL_ALPHA_TEST_FUNC = 0x0BC1;
		public const int GL_ALPHA_TEST_REF = 0x0BC2;
		public const int GL_LOGIC_OP = 0x0BF1;
		public const int GL_AUX_BUFFERS = 0x0C00;
		public const int GL_INDEX_CLEAR_VALUE = 0x0C20;
		public const int GL_INDEX_WRITEMASK = 0x0C21;
		public const int GL_INDEX_MODE = 0x0C30;
		public const int GL_RGBA_MODE = 0x0C31;
		public const int GL_RENDER_MODE = 0x0C40;
		public const int GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
		public const int GL_POINT_SMOOTH_HINT = 0x0C51;
		public const int GL_FOG_HINT = 0x0C54;
		public const int GL_TEXTURE_GEN_S = 0x0C60;
		public const int GL_TEXTURE_GEN_T = 0x0C61;
		public const int GL_TEXTURE_GEN_R = 0x0C62;
		public const int GL_TEXTURE_GEN_Q = 0x0C63;
		public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
		public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
		public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
		public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
		public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
		public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
		public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
		public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
		public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
		public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
		public const int GL_MAP_COLOR = 0x0D10;
		public const int GL_MAP_STENCIL = 0x0D11;
		public const int GL_INDEX_SHIFT = 0x0D12;
		public const int GL_INDEX_OFFSET = 0x0D13;
		public const int GL_RED_SCALE = 0x0D14;
		public const int GL_RED_BIAS = 0x0D15;
		public const int GL_ZOOM_X = 0x0D16;
		public const int GL_ZOOM_Y = 0x0D17;
		public const int GL_GREEN_SCALE = 0x0D18;
		public const int GL_GREEN_BIAS = 0x0D19;
		public const int GL_BLUE_SCALE = 0x0D1A;
		public const int GL_BLUE_BIAS = 0x0D1B;
		public const int GL_ALPHA_SCALE = 0x0D1C;
		public const int GL_ALPHA_BIAS = 0x0D1D;
		public const int GL_DEPTH_SCALE = 0x0D1E;
		public const int GL_DEPTH_BIAS = 0x0D1F;
		public const int GL_MAX_EVAL_ORDER = 0x0D30;
		public const int GL_MAX_LIGHTS = 0x0D31;
		public const int GL_MAX_CLIP_PLANES = 0x0D32;
		public const int GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
		public const int GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
		public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
		public const int GL_MAX_NAME_STACK_DEPTH = 0x0D37;
		public const int GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
		public const int GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
		public const int GL_INDEX_BITS = 0x0D51;
		public const int GL_RED_BITS = 0x0D52;
		public const int GL_GREEN_BITS = 0x0D53;
		public const int GL_BLUE_BITS = 0x0D54;
		public const int GL_ALPHA_BITS = 0x0D55;
		public const int GL_DEPTH_BITS = 0x0D56;
		public const int GL_STENCIL_BITS = 0x0D57;
		public const int GL_ACCUM_RED_BITS = 0x0D58;
		public const int GL_ACCUM_GREEN_BITS = 0x0D59;
		public const int GL_ACCUM_BLUE_BITS = 0x0D5A;
		public const int GL_ACCUM_ALPHA_BITS = 0x0D5B;
		public const int GL_NAME_STACK_DEPTH = 0x0D70;
		public const int GL_AUTO_NORMAL = 0x0D80;
		public const int GL_MAP1_COLOR_4 = 0x0D90;
		public const int GL_MAP1_INDEX = 0x0D91;
		public const int GL_MAP1_NORMAL = 0x0D92;
		public const int GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
		public const int GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
		public const int GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
		public const int GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
		public const int GL_MAP1_VERTEX_3 = 0x0D97;
		public const int GL_MAP1_VERTEX_4 = 0x0D98;
		public const int GL_MAP2_COLOR_4 = 0x0DB0;
		public const int GL_MAP2_INDEX = 0x0DB1;
		public const int GL_MAP2_NORMAL = 0x0DB2;
		public const int GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
		public const int GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
		public const int GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
		public const int GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
		public const int GL_MAP2_VERTEX_3 = 0x0DB7;
		public const int GL_MAP2_VERTEX_4 = 0x0DB8;
		public const int GL_MAP1_GRID_DOMAIN = 0x0DD0;
		public const int GL_MAP1_GRID_SEGMENTS = 0x0DD1;
		public const int GL_MAP2_GRID_DOMAIN = 0x0DD2;
		public const int GL_MAP2_GRID_SEGMENTS = 0x0DD3;
		public const int GL_TEXTURE_COMPONENTS = 0x1003;
		public const int GL_TEXTURE_BORDER = 0x1005;
		public const int GL_AMBIENT = 0x1200;
		public const int GL_DIFFUSE = 0x1201;
		public const int GL_SPECULAR = 0x1202;
		public const int GL_POSITION = 0x1203;
		public const int GL_SPOT_DIRECTION = 0x1204;
		public const int GL_SPOT_EXPONENT = 0x1205;
		public const int GL_SPOT_CUTOFF = 0x1206;
		public const int GL_CONSTANT_ATTENUATION = 0x1207;
		public const int GL_LINEAR_ATTENUATION = 0x1208;
		public const int GL_QUADRATIC_ATTENUATION = 0x1209;
		public const int GL_COMPILE = 0x1300;
		public const int GL_COMPILE_AND_EXECUTE = 0x1301;
		public const int GL_2_BYTES = 0x1407;
		public const int GL_3_BYTES = 0x1408;
		public const int GL_4_BYTES = 0x1409;
		public const int GL_EMISSION = 0x1600;
		public const int GL_SHININESS = 0x1601;
		public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
		public const int GL_COLOR_INDEXES = 0x1603;
		public const int GL_MODELVIEW = 0x1700;
		public const int GL_PROJECTION = 0x1701;
		public const int GL_COLOR_INDEX = 0x1900;
		public const int GL_LUMINANCE = 0x1909;
		public const int GL_LUMINANCE_ALPHA = 0x190A;
		public const int GL_BITMAP = 0x1A00;
		public const int GL_RENDER = 0x1C00;
		public const int GL_FEEDBACK = 0x1C01;
		public const int GL_SELECT = 0x1C02;
		public const int GL_FLAT = 0x1D00;
		public const int GL_SMOOTH = 0x1D01;
		public const int GL_S = 0x2000;
		public const int GL_T = 0x2001;
		public const int GL_R = 0x2002;
		public const int GL_Q = 0x2003;
		public const int GL_MODULATE = 0x2100;
		public const int GL_DECAL = 0x2101;
		public const int GL_TEXTURE_ENV_MODE = 0x2200;
		public const int GL_TEXTURE_ENV_COLOR = 0x2201;
		public const int GL_TEXTURE_ENV = 0x2300;
		public const int GL_EYE_LINEAR = 0x2400;
		public const int GL_OBJECT_LINEAR = 0x2401;
		public const int GL_SPHERE_MAP = 0x2402;
		public const int GL_TEXTURE_GEN_MODE = 0x2500;
		public const int GL_OBJECT_PLANE = 0x2501;
		public const int GL_EYE_PLANE = 0x2502;
		public const int GL_CLAMP = 0x2900;
		public const int GL_CLIP_PLANE0 = 0x3000;
		public const int GL_CLIP_PLANE1 = 0x3001;
		public const int GL_CLIP_PLANE2 = 0x3002;
		public const int GL_CLIP_PLANE3 = 0x3003;
		public const int GL_CLIP_PLANE4 = 0x3004;
		public const int GL_CLIP_PLANE5 = 0x3005;
		public const int GL_LIGHT0 = 0x4000;
		public const int GL_LIGHT1 = 0x4001;
		public const int GL_LIGHT2 = 0x4002;
		public const int GL_LIGHT3 = 0x4003;
		public const int GL_LIGHT4 = 0x4004;
		public const int GL_LIGHT5 = 0x4005;
		public const int GL_LIGHT6 = 0x4006;
		public const int GL_LIGHT7 = 0x4007;
		#endregion // Constants
		
		public static void glCullFace(int mode) =>
			Capabilities.nglCullFace(mode);
		
		public static void glFrontFace(int mode) =>
			Capabilities.nglFrontFace(mode);
		
		public static void glHint(int target, int mode) =>
			Capabilities.nglHint(target, mode);
		
		public static void glLineWidth(float width) =>
			Capabilities.nglLineWidth(width);
		
		public static void glPointSize(float size) =>
			Capabilities.nglPointSize(size);
		
		public static void glPolygonMode(int face, int mode) =>
			Capabilities.nglPolygonMode(face, mode);
		
		public static void glScissor(int x, int y, int width, int height) =>
			Capabilities.nglScissor(x, y, width, height);
		
		public static void glTexParameterf(int target, int pname, float param) =>
			Capabilities.nglTexParameterf(target, pname, param);
		
		public static void glTexParameterfv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexParameterfv(target, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glTexParameterfv(int target, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexParameterfv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexParameterfv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexParameterfv(int target, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglTexParameterfv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexParameteri(int target, int pname, int param) =>
			Capabilities.nglTexParameteri(target, pname, param);
		
		public static void glTexParameteriv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexParameteriv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTexParameteriv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameteriv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameteriv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexParameteriv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTexParameteriv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexImage1D(int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTexImage1D(target, level, internalformat, width, border, format, type, pixels.ToPointer());
			}
		}
		
		public static void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglTexImage2D(target, level, internalformat, width, height, border, format, type, pixels.ToPointer());
			}
		}
		
		public static void glDrawBuffer(int buf) =>
			Capabilities.nglDrawBuffer(buf);
		
		public static void glClear(int mask) =>
			Capabilities.nglClear(mask);
		
		public static void glClearColor(float red, float green, float blue, float alpha) =>
			Capabilities.nglClearColor(red, green, blue, alpha);
		
		public static void glClearStencil(int s) =>
			Capabilities.nglClearStencil(s);
		
		public static void glClearDepth(double depth) =>
			Capabilities.nglClearDepth(depth);
		
		public static void glStencilMask(int mask) =>
			Capabilities.nglStencilMask(mask);
		
		public static void glColorMask(byte red, byte green, byte blue, byte alpha) =>
			Capabilities.nglColorMask(red, green, blue, alpha);
		
		public static void glDepthMask(byte flag) =>
			Capabilities.nglDepthMask(flag);
		
		public static void glDisable(int cap) =>
			Capabilities.nglDisable(cap);
		
		public static void glEnable(int cap) =>
			Capabilities.nglEnable(cap);
		
		public static void glFinish() =>
			Capabilities.nglFinish();
		
		public static void glFlush() =>
			Capabilities.nglFlush();
		
		public static void glBlendFunc(int sfactor, int dfactor) =>
			Capabilities.nglBlendFunc(sfactor, dfactor);
		
		public static void glLogicOp(int opcode) =>
			Capabilities.nglLogicOp(opcode);
		
		public static void glStencilFunc(int func, int _ref, int mask) =>
			Capabilities.nglStencilFunc(func, _ref, mask);
		
		public static void glStencilOp(int fail, int zfail, int zpass) =>
			Capabilities.nglStencilOp(fail, zfail, zpass);
		
		public static void glDepthFunc(int func) =>
			Capabilities.nglDepthFunc(func);
		
		public static void glPixelStoref(int pname, float param) =>
			Capabilities.nglPixelStoref(pname, param);
		
		public static void glPixelStorei(int pname, int param) =>
			Capabilities.nglPixelStorei(pname, param);
		
		public static void glReadBuffer(int src) =>
			Capabilities.nglReadBuffer(src);
		
		public static void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglReadPixels(x, y, width, height, format, type, pixels.ToPointer());
			}
		}
		
		public static void glGetBooleanv(int pname, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetBooleanv(pname, (byte*)data.ToPointer());
			}
		}
		
		public static void glGetBooleanv(int pname, ref byte data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetBooleanv(pname, (byte*)ptr);
			}
		}
		
		public static void glGetBooleanv<T>(int pname, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetBooleanv(pname, (byte*)ptr);
			}
		}
		
		public static void glGetBooleanv<T>(int pname, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetBooleanv(pname, (byte*)ptr);
			}
		}
		
		public static void glGetBooleanv(int pname, byte[] data)
		{
			unsafe
			{
				fixed (byte* dataPtr = data)
				{
					Capabilities.nglGetBooleanv(pname, dataPtr);
				}
			}
		}
		
		public static void glGetDoublev(int pname, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetDoublev(pname, (double*)data.ToPointer());
			}
		}
		
		public static void glGetDoublev(int pname, ref double data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetDoublev(pname, (double*)ptr);
			}
		}
		
		public static void glGetDoublev<T>(int pname, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetDoublev(pname, (double*)ptr);
			}
		}
		
		public static void glGetDoublev<T>(int pname, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetDoublev(pname, (double*)ptr);
			}
		}
		
		public static void glGetDoublev(int pname, double[] data)
		{
			unsafe
			{
				fixed (double* dataPtr = data)
				{
					Capabilities.nglGetDoublev(pname, dataPtr);
				}
			}
		}
		
		public static int glGetError() =>
			Capabilities.nglGetError();
		
		public static void glGetFloatv(int pname, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetFloatv(pname, (float*)data.ToPointer());
			}
		}
		
		public static void glGetFloatv(int pname, ref float data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetFloatv(pname, (float*)ptr);
			}
		}
		
		public static void glGetFloatv<T>(int pname, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetFloatv(pname, (float*)ptr);
			}
		}
		
		public static void glGetFloatv<T>(int pname, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetFloatv(pname, (float*)ptr);
			}
		}
		
		public static void glGetFloatv(int pname, float[] data)
		{
			unsafe
			{
				fixed (float* dataPtr = data)
				{
					Capabilities.nglGetFloatv(pname, dataPtr);
				}
			}
		}
		
		public static void glGetIntegerv(int pname, IntPtr data)
		{
			unsafe
			{
				Capabilities.nglGetIntegerv(pname, (int*)data.ToPointer());
			}
		}
		
		public static void glGetIntegerv(int pname, ref int data)
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetIntegerv(pname, (int*)ptr);
			}
		}
		
		public static void glGetIntegerv<T>(int pname, ref T data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &data) Capabilities.nglGetIntegerv(pname, (int*)ptr);
			}
		}
		
		public static void glGetIntegerv<T>(int pname, T[] data) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = data) Capabilities.nglGetIntegerv(pname, (int*)ptr);
			}
		}
		
		public static void glGetIntegerv(int pname, int[] data)
		{
			unsafe
			{
				fixed (int* dataPtr = data)
				{
					Capabilities.nglGetIntegerv(pname, dataPtr);
				}
			}
		}
		
		public static string glGetString(int name)
		{
			unsafe
			{
				byte* data = Capabilities.nglGetString(name);
				int count = 0;
				while (data[count] != 0) count++;
				return System.Text.Encoding.UTF8.GetString(data, count);
			}
		}
		
		public static void glGetTexImage(int target, int level, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglGetTexImage(target, level, format, type, pixels.ToPointer());
			}
		}
		
		public static void glGetTexParameterfv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexParameterfv(target, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTexParameterfv(int target, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexParameterfv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexParameterfv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexParameterfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexParameterfv(int target, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTexParameterfv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexParameteriv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexParameteriv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexParameteriv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameteriv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameteriv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexParameteriv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexParameteriv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexParameteriv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexLevelParameterfv(int target, int level, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexLevelParameterfv(target, level, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTexLevelParameterfv(int target, int level, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexLevelParameterfv(target, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexLevelParameterfv<T>(int target, int level, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexLevelParameterfv(target, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexLevelParameterfv<T>(int target, int level, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexLevelParameterfv(target, level, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexLevelParameterfv(int target, int level, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTexLevelParameterfv(target, level, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexLevelParameteriv(int target, int level, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexLevelParameteriv(target, level, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexLevelParameteriv(int target, int level, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexLevelParameteriv(target, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexLevelParameteriv<T>(int target, int level, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexLevelParameteriv(target, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexLevelParameteriv<T>(int target, int level, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexLevelParameteriv(target, level, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexLevelParameteriv(int target, int level, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexLevelParameteriv(target, level, pname, _paramsPtr);
				}
			}
		}
		
		public static byte glIsEnabled(int cap) =>
			Capabilities.nglIsEnabled(cap);
		
		public static void glDepthRange(double n, double f) =>
			Capabilities.nglDepthRange(n, f);
		
		public static void glViewport(int x, int y, int width, int height) =>
			Capabilities.nglViewport(x, y, width, height);
		
		public static void glNewList(int list, int mode) =>
			Capabilities.nglNewList(list, mode);
		
		public static void glEndList() =>
			Capabilities.nglEndList();
		
		public static void glCallList(int list) =>
			Capabilities.nglCallList(list);
		
		public static void glCallLists(int n, int type, IntPtr lists)
		{
			unsafe
			{
				Capabilities.nglCallLists(n, type, lists.ToPointer());
			}
		}
		
		public static void glDeleteLists(int list, int range) =>
			Capabilities.nglDeleteLists(list, range);
		
		public static int glGenLists(int range) =>
			Capabilities.nglGenLists(range);
		
		public static void glListBase(int _base) =>
			Capabilities.nglListBase(_base);
		
		public static void glBegin(int mode) =>
			Capabilities.nglBegin(mode);
		
		public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, IntPtr bitmap)
		{
			unsafe
			{
				Capabilities.nglBitmap(width, height, xorig, yorig, xmove, ymove, (byte*)bitmap.ToPointer());
			}
		}
		
		public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, ref byte bitmap)
		{
			unsafe
			{
				fixed (void* ptr = &bitmap) Capabilities.nglBitmap(width, height, xorig, yorig, xmove, ymove, (byte*)ptr);
			}
		}
		
		public static void glBitmap<T>(int width, int height, float xorig, float yorig, float xmove, float ymove, ref T bitmap) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &bitmap) Capabilities.nglBitmap(width, height, xorig, yorig, xmove, ymove, (byte*)ptr);
			}
		}
		
		public static void glBitmap<T>(int width, int height, float xorig, float yorig, float xmove, float ymove, T[] bitmap) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = bitmap) Capabilities.nglBitmap(width, height, xorig, yorig, xmove, ymove, (byte*)ptr);
			}
		}
		
		public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
		{
			unsafe
			{
				fixed (byte* bitmapPtr = bitmap)
				{
					Capabilities.nglBitmap(width, height, xorig, yorig, xmove, ymove, bitmapPtr);
				}
			}
		}
		
		public static void glColor3b(sbyte red, sbyte green, sbyte blue) =>
			Capabilities.nglColor3b(red, green, blue);
		
		public static void glColor3bv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3bv((sbyte*)v.ToPointer());
			}
		}
		
		public static void glColor3bv(ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glColor3bv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glColor3bv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3bv((sbyte*)ptr);
			}
		}
		
		public static void glColor3bv(sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglColor3bv(vPtr);
				}
			}
		}
		
		public static void glColor3d(double red, double green, double blue) =>
			Capabilities.nglColor3d(red, green, blue);
		
		public static void glColor3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3dv((double*)v.ToPointer());
			}
		}
		
		public static void glColor3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3dv((double*)ptr);
			}
		}
		
		public static void glColor3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3dv((double*)ptr);
			}
		}
		
		public static void glColor3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3dv((double*)ptr);
			}
		}
		
		public static void glColor3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglColor3dv(vPtr);
				}
			}
		}
		
		public static void glColor3f(float red, float green, float blue) =>
			Capabilities.nglColor3f(red, green, blue);
		
		public static void glColor3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3fv((float*)v.ToPointer());
			}
		}
		
		public static void glColor3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3fv((float*)ptr);
			}
		}
		
		public static void glColor3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3fv((float*)ptr);
			}
		}
		
		public static void glColor3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3fv((float*)ptr);
			}
		}
		
		public static void glColor3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglColor3fv(vPtr);
				}
			}
		}
		
		public static void glColor3i(int red, int green, int blue) =>
			Capabilities.nglColor3i(red, green, blue);
		
		public static void glColor3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3iv((int*)v.ToPointer());
			}
		}
		
		public static void glColor3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3iv((int*)ptr);
			}
		}
		
		public static void glColor3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3iv((int*)ptr);
			}
		}
		
		public static void glColor3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3iv((int*)ptr);
			}
		}
		
		public static void glColor3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglColor3iv(vPtr);
				}
			}
		}
		
		public static void glColor3s(short red, short green, short blue) =>
			Capabilities.nglColor3s(red, green, blue);
		
		public static void glColor3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3sv((short*)v.ToPointer());
			}
		}
		
		public static void glColor3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3sv((short*)ptr);
			}
		}
		
		public static void glColor3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3sv((short*)ptr);
			}
		}
		
		public static void glColor3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3sv((short*)ptr);
			}
		}
		
		public static void glColor3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglColor3sv(vPtr);
				}
			}
		}
		
		public static void glColor3ub(byte red, byte green, byte blue) =>
			Capabilities.nglColor3ub(red, green, blue);
		
		public static void glColor3ubv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3ubv((byte*)v.ToPointer());
			}
		}
		
		public static void glColor3ubv(ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3ubv((byte*)ptr);
			}
		}
		
		public static void glColor3ubv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3ubv((byte*)ptr);
			}
		}
		
		public static void glColor3ubv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3ubv((byte*)ptr);
			}
		}
		
		public static void glColor3ubv(byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglColor3ubv(vPtr);
				}
			}
		}
		
		public static void glColor3ui(int red, int green, int blue) =>
			Capabilities.nglColor3ui(red, green, blue);
		
		public static void glColor3uiv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3uiv((int*)v.ToPointer());
			}
		}
		
		public static void glColor3uiv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3uiv((int*)ptr);
			}
		}
		
		public static void glColor3uiv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3uiv((int*)ptr);
			}
		}
		
		public static void glColor3uiv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3uiv((int*)ptr);
			}
		}
		
		public static void glColor3uiv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglColor3uiv(vPtr);
				}
			}
		}
		
		public static void glColor3us(ushort red, ushort green, ushort blue) =>
			Capabilities.nglColor3us(red, green, blue);
		
		public static void glColor3usv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor3usv((ushort*)v.ToPointer());
			}
		}
		
		public static void glColor3usv(ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3usv((ushort*)ptr);
			}
		}
		
		public static void glColor3usv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor3usv((ushort*)ptr);
			}
		}
		
		public static void glColor3usv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor3usv((ushort*)ptr);
			}
		}
		
		public static void glColor3usv(ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglColor3usv(vPtr);
				}
			}
		}
		
		public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) =>
			Capabilities.nglColor4b(red, green, blue, alpha);
		
		public static void glColor4bv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4bv((sbyte*)v.ToPointer());
			}
		}
		
		public static void glColor4bv(ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4bv((sbyte*)ptr);
			}
		}
		
		public static void glColor4bv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4bv((sbyte*)ptr);
			}
		}
		
		public static void glColor4bv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4bv((sbyte*)ptr);
			}
		}
		
		public static void glColor4bv(sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglColor4bv(vPtr);
				}
			}
		}
		
		public static void glColor4d(double red, double green, double blue, double alpha) =>
			Capabilities.nglColor4d(red, green, blue, alpha);
		
		public static void glColor4dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4dv((double*)v.ToPointer());
			}
		}
		
		public static void glColor4dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4dv((double*)ptr);
			}
		}
		
		public static void glColor4dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4dv((double*)ptr);
			}
		}
		
		public static void glColor4dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4dv((double*)ptr);
			}
		}
		
		public static void glColor4dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglColor4dv(vPtr);
				}
			}
		}
		
		public static void glColor4f(float red, float green, float blue, float alpha) =>
			Capabilities.nglColor4f(red, green, blue, alpha);
		
		public static void glColor4fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4fv((float*)v.ToPointer());
			}
		}
		
		public static void glColor4fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4fv((float*)ptr);
			}
		}
		
		public static void glColor4fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4fv((float*)ptr);
			}
		}
		
		public static void glColor4fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4fv((float*)ptr);
			}
		}
		
		public static void glColor4fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglColor4fv(vPtr);
				}
			}
		}
		
		public static void glColor4i(int red, int green, int blue, int alpha) =>
			Capabilities.nglColor4i(red, green, blue, alpha);
		
		public static void glColor4iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4iv((int*)v.ToPointer());
			}
		}
		
		public static void glColor4iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4iv((int*)ptr);
			}
		}
		
		public static void glColor4iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4iv((int*)ptr);
			}
		}
		
		public static void glColor4iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4iv((int*)ptr);
			}
		}
		
		public static void glColor4iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglColor4iv(vPtr);
				}
			}
		}
		
		public static void glColor4s(short red, short green, short blue, short alpha) =>
			Capabilities.nglColor4s(red, green, blue, alpha);
		
		public static void glColor4sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4sv((short*)v.ToPointer());
			}
		}
		
		public static void glColor4sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4sv((short*)ptr);
			}
		}
		
		public static void glColor4sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4sv((short*)ptr);
			}
		}
		
		public static void glColor4sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4sv((short*)ptr);
			}
		}
		
		public static void glColor4sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglColor4sv(vPtr);
				}
			}
		}
		
		public static void glColor4ub(byte red, byte green, byte blue, byte alpha) =>
			Capabilities.nglColor4ub(red, green, blue, alpha);
		
		public static void glColor4ubv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4ubv((byte*)v.ToPointer());
			}
		}
		
		public static void glColor4ubv(ref byte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4ubv((byte*)ptr);
			}
		}
		
		public static void glColor4ubv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4ubv((byte*)ptr);
			}
		}
		
		public static void glColor4ubv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4ubv((byte*)ptr);
			}
		}
		
		public static void glColor4ubv(byte[] v)
		{
			unsafe
			{
				fixed (byte* vPtr = v)
				{
					Capabilities.nglColor4ubv(vPtr);
				}
			}
		}
		
		public static void glColor4ui(int red, int green, int blue, int alpha) =>
			Capabilities.nglColor4ui(red, green, blue, alpha);
		
		public static void glColor4uiv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4uiv((int*)v.ToPointer());
			}
		}
		
		public static void glColor4uiv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4uiv((int*)ptr);
			}
		}
		
		public static void glColor4uiv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4uiv((int*)ptr);
			}
		}
		
		public static void glColor4uiv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4uiv((int*)ptr);
			}
		}
		
		public static void glColor4uiv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglColor4uiv(vPtr);
				}
			}
		}
		
		public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) =>
			Capabilities.nglColor4us(red, green, blue, alpha);
		
		public static void glColor4usv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglColor4usv((ushort*)v.ToPointer());
			}
		}
		
		public static void glColor4usv(ref ushort v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4usv((ushort*)ptr);
			}
		}
		
		public static void glColor4usv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglColor4usv((ushort*)ptr);
			}
		}
		
		public static void glColor4usv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglColor4usv((ushort*)ptr);
			}
		}
		
		public static void glColor4usv(ushort[] v)
		{
			unsafe
			{
				fixed (ushort* vPtr = v)
				{
					Capabilities.nglColor4usv(vPtr);
				}
			}
		}
		
		public static void glEdgeFlag(byte flag) =>
			Capabilities.nglEdgeFlag(flag);
		
		public static void glEdgeFlagv(IntPtr flag)
		{
			unsafe
			{
				Capabilities.nglEdgeFlagv((byte*)flag.ToPointer());
			}
		}
		
		public static void glEdgeFlagv(ref byte flag)
		{
			unsafe
			{
				fixed (void* ptr = &flag) Capabilities.nglEdgeFlagv((byte*)ptr);
			}
		}
		
		public static void glEdgeFlagv<T>(ref T flag) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &flag) Capabilities.nglEdgeFlagv((byte*)ptr);
			}
		}
		
		public static void glEdgeFlagv<T>(T[] flag) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = flag) Capabilities.nglEdgeFlagv((byte*)ptr);
			}
		}
		
		public static void glEdgeFlagv(byte[] flag)
		{
			unsafe
			{
				fixed (byte* flagPtr = flag)
				{
					Capabilities.nglEdgeFlagv(flagPtr);
				}
			}
		}
		
		public static void glEnd() =>
			Capabilities.nglEnd();
		
		public static void glIndexd(double c) =>
			Capabilities.nglIndexd(c);
		
		public static void glIndexdv(IntPtr c)
		{
			unsafe
			{
				Capabilities.nglIndexdv((double*)c.ToPointer());
			}
		}
		
		public static void glIndexdv(ref double c)
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexdv((double*)ptr);
			}
		}
		
		public static void glIndexdv<T>(ref T c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexdv((double*)ptr);
			}
		}
		
		public static void glIndexdv<T>(T[] c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = c) Capabilities.nglIndexdv((double*)ptr);
			}
		}
		
		public static void glIndexdv(double[] c)
		{
			unsafe
			{
				fixed (double* cPtr = c)
				{
					Capabilities.nglIndexdv(cPtr);
				}
			}
		}
		
		public static void glIndexf(float c) =>
			Capabilities.nglIndexf(c);
		
		public static void glIndexfv(IntPtr c)
		{
			unsafe
			{
				Capabilities.nglIndexfv((float*)c.ToPointer());
			}
		}
		
		public static void glIndexfv(ref float c)
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexfv((float*)ptr);
			}
		}
		
		public static void glIndexfv<T>(ref T c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexfv((float*)ptr);
			}
		}
		
		public static void glIndexfv<T>(T[] c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = c) Capabilities.nglIndexfv((float*)ptr);
			}
		}
		
		public static void glIndexfv(float[] c)
		{
			unsafe
			{
				fixed (float* cPtr = c)
				{
					Capabilities.nglIndexfv(cPtr);
				}
			}
		}
		
		public static void glIndexi(int c) =>
			Capabilities.nglIndexi(c);
		
		public static void glIndexiv(IntPtr c)
		{
			unsafe
			{
				Capabilities.nglIndexiv((int*)c.ToPointer());
			}
		}
		
		public static void glIndexiv(ref int c)
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexiv((int*)ptr);
			}
		}
		
		public static void glIndexiv<T>(ref T c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexiv((int*)ptr);
			}
		}
		
		public static void glIndexiv<T>(T[] c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = c) Capabilities.nglIndexiv((int*)ptr);
			}
		}
		
		public static void glIndexiv(int[] c)
		{
			unsafe
			{
				fixed (int* cPtr = c)
				{
					Capabilities.nglIndexiv(cPtr);
				}
			}
		}
		
		public static void glIndexs(short c) =>
			Capabilities.nglIndexs(c);
		
		public static void glIndexsv(IntPtr c)
		{
			unsafe
			{
				Capabilities.nglIndexsv((short*)c.ToPointer());
			}
		}
		
		public static void glIndexsv(ref short c)
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexsv((short*)ptr);
			}
		}
		
		public static void glIndexsv<T>(ref T c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &c) Capabilities.nglIndexsv((short*)ptr);
			}
		}
		
		public static void glIndexsv<T>(T[] c) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = c) Capabilities.nglIndexsv((short*)ptr);
			}
		}
		
		public static void glIndexsv(short[] c)
		{
			unsafe
			{
				fixed (short* cPtr = c)
				{
					Capabilities.nglIndexsv(cPtr);
				}
			}
		}
		
		public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz) =>
			Capabilities.nglNormal3b(nx, ny, nz);
		
		public static void glNormal3bv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglNormal3bv((sbyte*)v.ToPointer());
			}
		}
		
		public static void glNormal3bv(ref sbyte v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3bv((sbyte*)ptr);
			}
		}
		
		public static void glNormal3bv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3bv((sbyte*)ptr);
			}
		}
		
		public static void glNormal3bv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglNormal3bv((sbyte*)ptr);
			}
		}
		
		public static void glNormal3bv(sbyte[] v)
		{
			unsafe
			{
				fixed (sbyte* vPtr = v)
				{
					Capabilities.nglNormal3bv(vPtr);
				}
			}
		}
		
		public static void glNormal3d(double nx, double ny, double nz) =>
			Capabilities.nglNormal3d(nx, ny, nz);
		
		public static void glNormal3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglNormal3dv((double*)v.ToPointer());
			}
		}
		
		public static void glNormal3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3dv((double*)ptr);
			}
		}
		
		public static void glNormal3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3dv((double*)ptr);
			}
		}
		
		public static void glNormal3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglNormal3dv((double*)ptr);
			}
		}
		
		public static void glNormal3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglNormal3dv(vPtr);
				}
			}
		}
		
		public static void glNormal3f(float nx, float ny, float nz) =>
			Capabilities.nglNormal3f(nx, ny, nz);
		
		public static void glNormal3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglNormal3fv((float*)v.ToPointer());
			}
		}
		
		public static void glNormal3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3fv((float*)ptr);
			}
		}
		
		public static void glNormal3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3fv((float*)ptr);
			}
		}
		
		public static void glNormal3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglNormal3fv((float*)ptr);
			}
		}
		
		public static void glNormal3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglNormal3fv(vPtr);
				}
			}
		}
		
		public static void glNormal3i(int nx, int ny, int nz) =>
			Capabilities.nglNormal3i(nx, ny, nz);
		
		public static void glNormal3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglNormal3iv((int*)v.ToPointer());
			}
		}
		
		public static void glNormal3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3iv((int*)ptr);
			}
		}
		
		public static void glNormal3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3iv((int*)ptr);
			}
		}
		
		public static void glNormal3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglNormal3iv((int*)ptr);
			}
		}
		
		public static void glNormal3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglNormal3iv(vPtr);
				}
			}
		}
		
		public static void glNormal3s(short nx, short ny, short nz) =>
			Capabilities.nglNormal3s(nx, ny, nz);
		
		public static void glNormal3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglNormal3sv((short*)v.ToPointer());
			}
		}
		
		public static void glNormal3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3sv((short*)ptr);
			}
		}
		
		public static void glNormal3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglNormal3sv((short*)ptr);
			}
		}
		
		public static void glNormal3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglNormal3sv((short*)ptr);
			}
		}
		
		public static void glNormal3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglNormal3sv(vPtr);
				}
			}
		}
		
		public static void glRasterPos2d(double x, double y) =>
			Capabilities.nglRasterPos2d(x, y);
		
		public static void glRasterPos2dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos2dv((double*)v.ToPointer());
			}
		}
		
		public static void glRasterPos2dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2dv((double*)ptr);
			}
		}
		
		public static void glRasterPos2dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2dv((double*)ptr);
			}
		}
		
		public static void glRasterPos2dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos2dv((double*)ptr);
			}
		}
		
		public static void glRasterPos2dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglRasterPos2dv(vPtr);
				}
			}
		}
		
		public static void glRasterPos2f(float x, float y) =>
			Capabilities.nglRasterPos2f(x, y);
		
		public static void glRasterPos2fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos2fv((float*)v.ToPointer());
			}
		}
		
		public static void glRasterPos2fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2fv((float*)ptr);
			}
		}
		
		public static void glRasterPos2fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2fv((float*)ptr);
			}
		}
		
		public static void glRasterPos2fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos2fv((float*)ptr);
			}
		}
		
		public static void glRasterPos2fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglRasterPos2fv(vPtr);
				}
			}
		}
		
		public static void glRasterPos2i(int x, int y) =>
			Capabilities.nglRasterPos2i(x, y);
		
		public static void glRasterPos2iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos2iv((int*)v.ToPointer());
			}
		}
		
		public static void glRasterPos2iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2iv((int*)ptr);
			}
		}
		
		public static void glRasterPos2iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2iv((int*)ptr);
			}
		}
		
		public static void glRasterPos2iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos2iv((int*)ptr);
			}
		}
		
		public static void glRasterPos2iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglRasterPos2iv(vPtr);
				}
			}
		}
		
		public static void glRasterPos2s(short x, short y) =>
			Capabilities.nglRasterPos2s(x, y);
		
		public static void glRasterPos2sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos2sv((short*)v.ToPointer());
			}
		}
		
		public static void glRasterPos2sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2sv((short*)ptr);
			}
		}
		
		public static void glRasterPos2sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos2sv((short*)ptr);
			}
		}
		
		public static void glRasterPos2sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos2sv((short*)ptr);
			}
		}
		
		public static void glRasterPos2sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglRasterPos2sv(vPtr);
				}
			}
		}
		
		public static void glRasterPos3d(double x, double y, double z) =>
			Capabilities.nglRasterPos3d(x, y, z);
		
		public static void glRasterPos3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos3dv((double*)v.ToPointer());
			}
		}
		
		public static void glRasterPos3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3dv((double*)ptr);
			}
		}
		
		public static void glRasterPos3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3dv((double*)ptr);
			}
		}
		
		public static void glRasterPos3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos3dv((double*)ptr);
			}
		}
		
		public static void glRasterPos3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglRasterPos3dv(vPtr);
				}
			}
		}
		
		public static void glRasterPos3f(float x, float y, float z) =>
			Capabilities.nglRasterPos3f(x, y, z);
		
		public static void glRasterPos3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos3fv((float*)v.ToPointer());
			}
		}
		
		public static void glRasterPos3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3fv((float*)ptr);
			}
		}
		
		public static void glRasterPos3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3fv((float*)ptr);
			}
		}
		
		public static void glRasterPos3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos3fv((float*)ptr);
			}
		}
		
		public static void glRasterPos3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglRasterPos3fv(vPtr);
				}
			}
		}
		
		public static void glRasterPos3i(int x, int y, int z) =>
			Capabilities.nglRasterPos3i(x, y, z);
		
		public static void glRasterPos3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos3iv((int*)v.ToPointer());
			}
		}
		
		public static void glRasterPos3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3iv((int*)ptr);
			}
		}
		
		public static void glRasterPos3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3iv((int*)ptr);
			}
		}
		
		public static void glRasterPos3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos3iv((int*)ptr);
			}
		}
		
		public static void glRasterPos3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglRasterPos3iv(vPtr);
				}
			}
		}
		
		public static void glRasterPos3s(short x, short y, short z) =>
			Capabilities.nglRasterPos3s(x, y, z);
		
		public static void glRasterPos3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos3sv((short*)v.ToPointer());
			}
		}
		
		public static void glRasterPos3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3sv((short*)ptr);
			}
		}
		
		public static void glRasterPos3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos3sv((short*)ptr);
			}
		}
		
		public static void glRasterPos3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos3sv((short*)ptr);
			}
		}
		
		public static void glRasterPos3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglRasterPos3sv(vPtr);
				}
			}
		}
		
		public static void glRasterPos4d(double x, double y, double z, double w) =>
			Capabilities.nglRasterPos4d(x, y, z, w);
		
		public static void glRasterPos4dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos4dv((double*)v.ToPointer());
			}
		}
		
		public static void glRasterPos4dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4dv((double*)ptr);
			}
		}
		
		public static void glRasterPos4dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4dv((double*)ptr);
			}
		}
		
		public static void glRasterPos4dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos4dv((double*)ptr);
			}
		}
		
		public static void glRasterPos4dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglRasterPos4dv(vPtr);
				}
			}
		}
		
		public static void glRasterPos4f(float x, float y, float z, float w) =>
			Capabilities.nglRasterPos4f(x, y, z, w);
		
		public static void glRasterPos4fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos4fv((float*)v.ToPointer());
			}
		}
		
		public static void glRasterPos4fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4fv((float*)ptr);
			}
		}
		
		public static void glRasterPos4fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4fv((float*)ptr);
			}
		}
		
		public static void glRasterPos4fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos4fv((float*)ptr);
			}
		}
		
		public static void glRasterPos4fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglRasterPos4fv(vPtr);
				}
			}
		}
		
		public static void glRasterPos4i(int x, int y, int z, int w) =>
			Capabilities.nglRasterPos4i(x, y, z, w);
		
		public static void glRasterPos4iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos4iv((int*)v.ToPointer());
			}
		}
		
		public static void glRasterPos4iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4iv((int*)ptr);
			}
		}
		
		public static void glRasterPos4iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4iv((int*)ptr);
			}
		}
		
		public static void glRasterPos4iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos4iv((int*)ptr);
			}
		}
		
		public static void glRasterPos4iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglRasterPos4iv(vPtr);
				}
			}
		}
		
		public static void glRasterPos4s(short x, short y, short z, short w) =>
			Capabilities.nglRasterPos4s(x, y, z, w);
		
		public static void glRasterPos4sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglRasterPos4sv((short*)v.ToPointer());
			}
		}
		
		public static void glRasterPos4sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4sv((short*)ptr);
			}
		}
		
		public static void glRasterPos4sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglRasterPos4sv((short*)ptr);
			}
		}
		
		public static void glRasterPos4sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglRasterPos4sv((short*)ptr);
			}
		}
		
		public static void glRasterPos4sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglRasterPos4sv(vPtr);
				}
			}
		}
		
		public static void glRectd(double x1, double y1, double x2, double y2) =>
			Capabilities.nglRectd(x1, y1, x2, y2);
		
		public static void glRectdv(IntPtr v1, IntPtr v2)
		{
			unsafe
			{
				Capabilities.nglRectdv((double*)v1.ToPointer(), (double*)v2.ToPointer());
			}
		}
		
		public static void glRectdv(double[] v1, double[] v2)
		{
			unsafe
			{
				fixed (double* v1Ptr = v1)
				{
					fixed (double* v2Ptr = v2)
					{
						Capabilities.nglRectdv(v1Ptr, v2Ptr);
					}
				}
			}
		}
		
		public static void glRectf(float x1, float y1, float x2, float y2) =>
			Capabilities.nglRectf(x1, y1, x2, y2);
		
		public static void glRectfv(IntPtr v1, IntPtr v2)
		{
			unsafe
			{
				Capabilities.nglRectfv((float*)v1.ToPointer(), (float*)v2.ToPointer());
			}
		}
		
		public static void glRectfv(float[] v1, float[] v2)
		{
			unsafe
			{
				fixed (float* v1Ptr = v1)
				{
					fixed (float* v2Ptr = v2)
					{
						Capabilities.nglRectfv(v1Ptr, v2Ptr);
					}
				}
			}
		}
		
		public static void glRecti(int x1, int y1, int x2, int y2) =>
			Capabilities.nglRecti(x1, y1, x2, y2);
		
		public static void glRectiv(IntPtr v1, IntPtr v2)
		{
			unsafe
			{
				Capabilities.nglRectiv((int*)v1.ToPointer(), (int*)v2.ToPointer());
			}
		}
		
		public static void glRectiv(int[] v1, int[] v2)
		{
			unsafe
			{
				fixed (int* v1Ptr = v1)
				{
					fixed (int* v2Ptr = v2)
					{
						Capabilities.nglRectiv(v1Ptr, v2Ptr);
					}
				}
			}
		}
		
		public static void glRects(short x1, short y1, short x2, short y2) =>
			Capabilities.nglRects(x1, y1, x2, y2);
		
		public static void glRectsv(IntPtr v1, IntPtr v2)
		{
			unsafe
			{
				Capabilities.nglRectsv((short*)v1.ToPointer(), (short*)v2.ToPointer());
			}
		}
		
		public static void glRectsv(short[] v1, short[] v2)
		{
			unsafe
			{
				fixed (short* v1Ptr = v1)
				{
					fixed (short* v2Ptr = v2)
					{
						Capabilities.nglRectsv(v1Ptr, v2Ptr);
					}
				}
			}
		}
		
		public static void glTexCoord1d(double s) =>
			Capabilities.nglTexCoord1d(s);
		
		public static void glTexCoord1dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord1dv((double*)v.ToPointer());
			}
		}
		
		public static void glTexCoord1dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1dv((double*)ptr);
			}
		}
		
		public static void glTexCoord1dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1dv((double*)ptr);
			}
		}
		
		public static void glTexCoord1dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord1dv((double*)ptr);
			}
		}
		
		public static void glTexCoord1dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglTexCoord1dv(vPtr);
				}
			}
		}
		
		public static void glTexCoord1f(float s) =>
			Capabilities.nglTexCoord1f(s);
		
		public static void glTexCoord1fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord1fv((float*)v.ToPointer());
			}
		}
		
		public static void glTexCoord1fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1fv((float*)ptr);
			}
		}
		
		public static void glTexCoord1fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1fv((float*)ptr);
			}
		}
		
		public static void glTexCoord1fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord1fv((float*)ptr);
			}
		}
		
		public static void glTexCoord1fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglTexCoord1fv(vPtr);
				}
			}
		}
		
		public static void glTexCoord1i(int s) =>
			Capabilities.nglTexCoord1i(s);
		
		public static void glTexCoord1iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord1iv((int*)v.ToPointer());
			}
		}
		
		public static void glTexCoord1iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1iv((int*)ptr);
			}
		}
		
		public static void glTexCoord1iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1iv((int*)ptr);
			}
		}
		
		public static void glTexCoord1iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord1iv((int*)ptr);
			}
		}
		
		public static void glTexCoord1iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglTexCoord1iv(vPtr);
				}
			}
		}
		
		public static void glTexCoord1s(short s) =>
			Capabilities.nglTexCoord1s(s);
		
		public static void glTexCoord1sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord1sv((short*)v.ToPointer());
			}
		}
		
		public static void glTexCoord1sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1sv((short*)ptr);
			}
		}
		
		public static void glTexCoord1sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord1sv((short*)ptr);
			}
		}
		
		public static void glTexCoord1sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord1sv((short*)ptr);
			}
		}
		
		public static void glTexCoord1sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglTexCoord1sv(vPtr);
				}
			}
		}
		
		public static void glTexCoord2d(double s, double t) =>
			Capabilities.nglTexCoord2d(s, t);
		
		public static void glTexCoord2dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord2dv((double*)v.ToPointer());
			}
		}
		
		public static void glTexCoord2dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2dv((double*)ptr);
			}
		}
		
		public static void glTexCoord2dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2dv((double*)ptr);
			}
		}
		
		public static void glTexCoord2dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord2dv((double*)ptr);
			}
		}
		
		public static void glTexCoord2dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglTexCoord2dv(vPtr);
				}
			}
		}
		
		public static void glTexCoord2f(float s, float t) =>
			Capabilities.nglTexCoord2f(s, t);
		
		public static void glTexCoord2fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord2fv((float*)v.ToPointer());
			}
		}
		
		public static void glTexCoord2fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2fv((float*)ptr);
			}
		}
		
		public static void glTexCoord2fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2fv((float*)ptr);
			}
		}
		
		public static void glTexCoord2fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord2fv((float*)ptr);
			}
		}
		
		public static void glTexCoord2fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglTexCoord2fv(vPtr);
				}
			}
		}
		
		public static void glTexCoord2i(int s, int t) =>
			Capabilities.nglTexCoord2i(s, t);
		
		public static void glTexCoord2iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord2iv((int*)v.ToPointer());
			}
		}
		
		public static void glTexCoord2iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2iv((int*)ptr);
			}
		}
		
		public static void glTexCoord2iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2iv((int*)ptr);
			}
		}
		
		public static void glTexCoord2iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord2iv((int*)ptr);
			}
		}
		
		public static void glTexCoord2iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglTexCoord2iv(vPtr);
				}
			}
		}
		
		public static void glTexCoord2s(short s, short t) =>
			Capabilities.nglTexCoord2s(s, t);
		
		public static void glTexCoord2sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord2sv((short*)v.ToPointer());
			}
		}
		
		public static void glTexCoord2sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2sv((short*)ptr);
			}
		}
		
		public static void glTexCoord2sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord2sv((short*)ptr);
			}
		}
		
		public static void glTexCoord2sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord2sv((short*)ptr);
			}
		}
		
		public static void glTexCoord2sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglTexCoord2sv(vPtr);
				}
			}
		}
		
		public static void glTexCoord3d(double s, double t, double r) =>
			Capabilities.nglTexCoord3d(s, t, r);
		
		public static void glTexCoord3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord3dv((double*)v.ToPointer());
			}
		}
		
		public static void glTexCoord3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3dv((double*)ptr);
			}
		}
		
		public static void glTexCoord3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3dv((double*)ptr);
			}
		}
		
		public static void glTexCoord3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord3dv((double*)ptr);
			}
		}
		
		public static void glTexCoord3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglTexCoord3dv(vPtr);
				}
			}
		}
		
		public static void glTexCoord3f(float s, float t, float r) =>
			Capabilities.nglTexCoord3f(s, t, r);
		
		public static void glTexCoord3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord3fv((float*)v.ToPointer());
			}
		}
		
		public static void glTexCoord3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3fv((float*)ptr);
			}
		}
		
		public static void glTexCoord3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3fv((float*)ptr);
			}
		}
		
		public static void glTexCoord3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord3fv((float*)ptr);
			}
		}
		
		public static void glTexCoord3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglTexCoord3fv(vPtr);
				}
			}
		}
		
		public static void glTexCoord3i(int s, int t, int r) =>
			Capabilities.nglTexCoord3i(s, t, r);
		
		public static void glTexCoord3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord3iv((int*)v.ToPointer());
			}
		}
		
		public static void glTexCoord3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3iv((int*)ptr);
			}
		}
		
		public static void glTexCoord3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3iv((int*)ptr);
			}
		}
		
		public static void glTexCoord3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord3iv((int*)ptr);
			}
		}
		
		public static void glTexCoord3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglTexCoord3iv(vPtr);
				}
			}
		}
		
		public static void glTexCoord3s(short s, short t, short r) =>
			Capabilities.nglTexCoord3s(s, t, r);
		
		public static void glTexCoord3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord3sv((short*)v.ToPointer());
			}
		}
		
		public static void glTexCoord3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3sv((short*)ptr);
			}
		}
		
		public static void glTexCoord3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord3sv((short*)ptr);
			}
		}
		
		public static void glTexCoord3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord3sv((short*)ptr);
			}
		}
		
		public static void glTexCoord3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglTexCoord3sv(vPtr);
				}
			}
		}
		
		public static void glTexCoord4d(double s, double t, double r, double q) =>
			Capabilities.nglTexCoord4d(s, t, r, q);
		
		public static void glTexCoord4dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord4dv((double*)v.ToPointer());
			}
		}
		
		public static void glTexCoord4dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4dv((double*)ptr);
			}
		}
		
		public static void glTexCoord4dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4dv((double*)ptr);
			}
		}
		
		public static void glTexCoord4dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord4dv((double*)ptr);
			}
		}
		
		public static void glTexCoord4dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglTexCoord4dv(vPtr);
				}
			}
		}
		
		public static void glTexCoord4f(float s, float t, float r, float q) =>
			Capabilities.nglTexCoord4f(s, t, r, q);
		
		public static void glTexCoord4fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord4fv((float*)v.ToPointer());
			}
		}
		
		public static void glTexCoord4fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4fv((float*)ptr);
			}
		}
		
		public static void glTexCoord4fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4fv((float*)ptr);
			}
		}
		
		public static void glTexCoord4fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord4fv((float*)ptr);
			}
		}
		
		public static void glTexCoord4fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglTexCoord4fv(vPtr);
				}
			}
		}
		
		public static void glTexCoord4i(int s, int t, int r, int q) =>
			Capabilities.nglTexCoord4i(s, t, r, q);
		
		public static void glTexCoord4iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord4iv((int*)v.ToPointer());
			}
		}
		
		public static void glTexCoord4iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4iv((int*)ptr);
			}
		}
		
		public static void glTexCoord4iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4iv((int*)ptr);
			}
		}
		
		public static void glTexCoord4iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord4iv((int*)ptr);
			}
		}
		
		public static void glTexCoord4iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglTexCoord4iv(vPtr);
				}
			}
		}
		
		public static void glTexCoord4s(short s, short t, short r, short q) =>
			Capabilities.nglTexCoord4s(s, t, r, q);
		
		public static void glTexCoord4sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglTexCoord4sv((short*)v.ToPointer());
			}
		}
		
		public static void glTexCoord4sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4sv((short*)ptr);
			}
		}
		
		public static void glTexCoord4sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglTexCoord4sv((short*)ptr);
			}
		}
		
		public static void glTexCoord4sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglTexCoord4sv((short*)ptr);
			}
		}
		
		public static void glTexCoord4sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglTexCoord4sv(vPtr);
				}
			}
		}
		
		public static void glVertex2d(double x, double y) =>
			Capabilities.nglVertex2d(x, y);
		
		public static void glVertex2dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex2dv((double*)v.ToPointer());
			}
		}
		
		public static void glVertex2dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2dv((double*)ptr);
			}
		}
		
		public static void glVertex2dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2dv((double*)ptr);
			}
		}
		
		public static void glVertex2dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex2dv((double*)ptr);
			}
		}
		
		public static void glVertex2dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertex2dv(vPtr);
				}
			}
		}
		
		public static void glVertex2f(float x, float y) =>
			Capabilities.nglVertex2f(x, y);
		
		public static void glVertex2fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex2fv((float*)v.ToPointer());
			}
		}
		
		public static void glVertex2fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2fv((float*)ptr);
			}
		}
		
		public static void glVertex2fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2fv((float*)ptr);
			}
		}
		
		public static void glVertex2fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex2fv((float*)ptr);
			}
		}
		
		public static void glVertex2fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertex2fv(vPtr);
				}
			}
		}
		
		public static void glVertex2i(int x, int y) =>
			Capabilities.nglVertex2i(x, y);
		
		public static void glVertex2iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex2iv((int*)v.ToPointer());
			}
		}
		
		public static void glVertex2iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2iv((int*)ptr);
			}
		}
		
		public static void glVertex2iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2iv((int*)ptr);
			}
		}
		
		public static void glVertex2iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex2iv((int*)ptr);
			}
		}
		
		public static void glVertex2iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertex2iv(vPtr);
				}
			}
		}
		
		public static void glVertex2s(short x, short y) =>
			Capabilities.nglVertex2s(x, y);
		
		public static void glVertex2sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex2sv((short*)v.ToPointer());
			}
		}
		
		public static void glVertex2sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2sv((short*)ptr);
			}
		}
		
		public static void glVertex2sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex2sv((short*)ptr);
			}
		}
		
		public static void glVertex2sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex2sv((short*)ptr);
			}
		}
		
		public static void glVertex2sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertex2sv(vPtr);
				}
			}
		}
		
		public static void glVertex3d(double x, double y, double z) =>
			Capabilities.nglVertex3d(x, y, z);
		
		public static void glVertex3dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex3dv((double*)v.ToPointer());
			}
		}
		
		public static void glVertex3dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3dv((double*)ptr);
			}
		}
		
		public static void glVertex3dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3dv((double*)ptr);
			}
		}
		
		public static void glVertex3dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex3dv((double*)ptr);
			}
		}
		
		public static void glVertex3dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertex3dv(vPtr);
				}
			}
		}
		
		public static void glVertex3f(float x, float y, float z) =>
			Capabilities.nglVertex3f(x, y, z);
		
		public static void glVertex3fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex3fv((float*)v.ToPointer());
			}
		}
		
		public static void glVertex3fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3fv((float*)ptr);
			}
		}
		
		public static void glVertex3fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3fv((float*)ptr);
			}
		}
		
		public static void glVertex3fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex3fv((float*)ptr);
			}
		}
		
		public static void glVertex3fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertex3fv(vPtr);
				}
			}
		}
		
		public static void glVertex3i(int x, int y, int z) =>
			Capabilities.nglVertex3i(x, y, z);
		
		public static void glVertex3iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex3iv((int*)v.ToPointer());
			}
		}
		
		public static void glVertex3iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3iv((int*)ptr);
			}
		}
		
		public static void glVertex3iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3iv((int*)ptr);
			}
		}
		
		public static void glVertex3iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex3iv((int*)ptr);
			}
		}
		
		public static void glVertex3iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertex3iv(vPtr);
				}
			}
		}
		
		public static void glVertex3s(short x, short y, short z) =>
			Capabilities.nglVertex3s(x, y, z);
		
		public static void glVertex3sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex3sv((short*)v.ToPointer());
			}
		}
		
		public static void glVertex3sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3sv((short*)ptr);
			}
		}
		
		public static void glVertex3sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex3sv((short*)ptr);
			}
		}
		
		public static void glVertex3sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex3sv((short*)ptr);
			}
		}
		
		public static void glVertex3sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertex3sv(vPtr);
				}
			}
		}
		
		public static void glVertex4d(double x, double y, double z, double w) =>
			Capabilities.nglVertex4d(x, y, z, w);
		
		public static void glVertex4dv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex4dv((double*)v.ToPointer());
			}
		}
		
		public static void glVertex4dv(ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4dv((double*)ptr);
			}
		}
		
		public static void glVertex4dv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4dv((double*)ptr);
			}
		}
		
		public static void glVertex4dv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex4dv((double*)ptr);
			}
		}
		
		public static void glVertex4dv(double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglVertex4dv(vPtr);
				}
			}
		}
		
		public static void glVertex4f(float x, float y, float z, float w) =>
			Capabilities.nglVertex4f(x, y, z, w);
		
		public static void glVertex4fv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex4fv((float*)v.ToPointer());
			}
		}
		
		public static void glVertex4fv(ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4fv((float*)ptr);
			}
		}
		
		public static void glVertex4fv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4fv((float*)ptr);
			}
		}
		
		public static void glVertex4fv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex4fv((float*)ptr);
			}
		}
		
		public static void glVertex4fv(float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglVertex4fv(vPtr);
				}
			}
		}
		
		public static void glVertex4i(int x, int y, int z, int w) =>
			Capabilities.nglVertex4i(x, y, z, w);
		
		public static void glVertex4iv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex4iv((int*)v.ToPointer());
			}
		}
		
		public static void glVertex4iv(ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4iv((int*)ptr);
			}
		}
		
		public static void glVertex4iv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4iv((int*)ptr);
			}
		}
		
		public static void glVertex4iv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex4iv((int*)ptr);
			}
		}
		
		public static void glVertex4iv(int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglVertex4iv(vPtr);
				}
			}
		}
		
		public static void glVertex4s(short x, short y, short z, short w) =>
			Capabilities.nglVertex4s(x, y, z, w);
		
		public static void glVertex4sv(IntPtr v)
		{
			unsafe
			{
				Capabilities.nglVertex4sv((short*)v.ToPointer());
			}
		}
		
		public static void glVertex4sv(ref short v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4sv((short*)ptr);
			}
		}
		
		public static void glVertex4sv<T>(ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglVertex4sv((short*)ptr);
			}
		}
		
		public static void glVertex4sv<T>(T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglVertex4sv((short*)ptr);
			}
		}
		
		public static void glVertex4sv(short[] v)
		{
			unsafe
			{
				fixed (short* vPtr = v)
				{
					Capabilities.nglVertex4sv(vPtr);
				}
			}
		}
		
		public static void glClipPlane(int plane, IntPtr equation)
		{
			unsafe
			{
				Capabilities.nglClipPlane(plane, (double*)equation.ToPointer());
			}
		}
		
		public static void glClipPlane(int plane, ref double equation)
		{
			unsafe
			{
				fixed (void* ptr = &equation) Capabilities.nglClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glClipPlane<T>(int plane, ref T equation) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &equation) Capabilities.nglClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glClipPlane<T>(int plane, T[] equation) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = equation) Capabilities.nglClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glClipPlane(int plane, double[] equation)
		{
			unsafe
			{
				fixed (double* equationPtr = equation)
				{
					Capabilities.nglClipPlane(plane, equationPtr);
				}
			}
		}
		
		public static void glColorMaterial(int face, int mode) =>
			Capabilities.nglColorMaterial(face, mode);
		
		public static void glFogf(int pname, float param) =>
			Capabilities.nglFogf(pname, param);
		
		public static void glFogfv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglFogfv(pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glFogfv(int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglFogfv(pname, (float*)ptr);
			}
		}
		
		public static void glFogfv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglFogfv(pname, (float*)ptr);
			}
		}
		
		public static void glFogfv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglFogfv(pname, (float*)ptr);
			}
		}
		
		public static void glFogfv(int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglFogfv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glFogi(int pname, int param) =>
			Capabilities.nglFogi(pname, param);
		
		public static void glFogiv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglFogiv(pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glFogiv(int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglFogiv(pname, (int*)ptr);
			}
		}
		
		public static void glFogiv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglFogiv(pname, (int*)ptr);
			}
		}
		
		public static void glFogiv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglFogiv(pname, (int*)ptr);
			}
		}
		
		public static void glFogiv(int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglFogiv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glLightf(int light, int pname, float param) =>
			Capabilities.nglLightf(light, pname, param);
		
		public static void glLightfv(int light, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglLightfv(light, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glLightfv(int light, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glLightfv<T>(int light, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glLightfv<T>(int light, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glLightfv(int light, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglLightfv(light, pname, _paramsPtr);
				}
			}
		}
		
		public static void glLighti(int light, int pname, int param) =>
			Capabilities.nglLighti(light, pname, param);
		
		public static void glLightiv(int light, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglLightiv(light, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glLightiv(int light, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glLightiv<T>(int light, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glLightiv<T>(int light, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glLightiv(int light, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglLightiv(light, pname, _paramsPtr);
				}
			}
		}
		
		public static void glLightModelf(int pname, float param) =>
			Capabilities.nglLightModelf(pname, param);
		
		public static void glLightModelfv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglLightModelfv(pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glLightModelfv(int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightModelfv(pname, (float*)ptr);
			}
		}
		
		public static void glLightModelfv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightModelfv(pname, (float*)ptr);
			}
		}
		
		public static void glLightModelfv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglLightModelfv(pname, (float*)ptr);
			}
		}
		
		public static void glLightModelfv(int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglLightModelfv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glLightModeli(int pname, int param) =>
			Capabilities.nglLightModeli(pname, param);
		
		public static void glLightModeliv(int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglLightModeliv(pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glLightModeliv(int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightModeliv(pname, (int*)ptr);
			}
		}
		
		public static void glLightModeliv<T>(int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglLightModeliv(pname, (int*)ptr);
			}
		}
		
		public static void glLightModeliv<T>(int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglLightModeliv(pname, (int*)ptr);
			}
		}
		
		public static void glLightModeliv(int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglLightModeliv(pname, _paramsPtr);
				}
			}
		}
		
		public static void glLineStipple(int factor, ushort pattern) =>
			Capabilities.nglLineStipple(factor, pattern);
		
		public static void glMaterialf(int face, int pname, float param) =>
			Capabilities.nglMaterialf(face, pname, param);
		
		public static void glMaterialfv(int face, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglMaterialfv(face, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glMaterialfv(int face, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glMaterialfv<T>(int face, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glMaterialfv<T>(int face, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glMaterialfv(int face, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglMaterialfv(face, pname, _paramsPtr);
				}
			}
		}
		
		public static void glMateriali(int face, int pname, int param) =>
			Capabilities.nglMateriali(face, pname, param);
		
		public static void glMaterialiv(int face, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglMaterialiv(face, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glMaterialiv(int face, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glMaterialiv<T>(int face, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glMaterialiv<T>(int face, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glMaterialiv(int face, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglMaterialiv(face, pname, _paramsPtr);
				}
			}
		}
		
		public static void glPolygonStipple(IntPtr mask)
		{
			unsafe
			{
				Capabilities.nglPolygonStipple((byte*)mask.ToPointer());
			}
		}
		
		public static void glPolygonStipple(ref byte mask)
		{
			unsafe
			{
				fixed (void* ptr = &mask) Capabilities.nglPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glPolygonStipple<T>(ref T mask) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &mask) Capabilities.nglPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glPolygonStipple<T>(T[] mask) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = mask) Capabilities.nglPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glPolygonStipple(byte[] mask)
		{
			unsafe
			{
				fixed (byte* maskPtr = mask)
				{
					Capabilities.nglPolygonStipple(maskPtr);
				}
			}
		}
		
		public static void glShadeModel(int mode) =>
			Capabilities.nglShadeModel(mode);
		
		public static void glTexEnvf(int target, int pname, float param) =>
			Capabilities.nglTexEnvf(target, pname, param);
		
		public static void glTexEnvfv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexEnvfv(target, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glTexEnvfv(int target, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexEnvfv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexEnvfv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glTexEnvfv(int target, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglTexEnvfv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexEnvi(int target, int pname, int param) =>
			Capabilities.nglTexEnvi(target, pname, param);
		
		public static void glTexEnviv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexEnviv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTexEnviv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexEnviv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexEnviv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glTexEnviv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTexEnviv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexGend(int coord, int pname, double param) =>
			Capabilities.nglTexGend(coord, pname, param);
		
		public static void glTexGendv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexGendv(coord, pname, (double*)_params.ToPointer());
			}
		}
		
		public static void glTexGendv(int coord, int pname, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glTexGendv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glTexGendv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glTexGendv(int coord, int pname, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglTexGendv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexGenf(int coord, int pname, float param) =>
			Capabilities.nglTexGenf(coord, pname, param);
		
		public static void glTexGenfv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexGenfv(coord, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glTexGenfv(int coord, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glTexGenfv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glTexGenfv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glTexGenfv(int coord, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglTexGenfv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static void glTexGeni(int coord, int pname, int param) =>
			Capabilities.nglTexGeni(coord, pname, param);
		
		public static void glTexGeniv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglTexGeniv(coord, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glTexGeniv(int coord, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glTexGeniv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glTexGeniv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glTexGeniv(int coord, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglTexGeniv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static void glFeedbackBuffer(int size, int type, IntPtr buffer)
		{
			unsafe
			{
				Capabilities.nglFeedbackBuffer(size, type, (float*)buffer.ToPointer());
			}
		}
		
		public static void glFeedbackBuffer(int size, int type, ref float buffer)
		{
			unsafe
			{
				fixed (void* ptr = &buffer) Capabilities.nglFeedbackBuffer(size, type, (float*)ptr);
			}
		}
		
		public static void glFeedbackBuffer<T>(int size, int type, ref T buffer) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffer) Capabilities.nglFeedbackBuffer(size, type, (float*)ptr);
			}
		}
		
		public static void glFeedbackBuffer<T>(int size, int type, T[] buffer) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffer) Capabilities.nglFeedbackBuffer(size, type, (float*)ptr);
			}
		}
		
		public static void glFeedbackBuffer(int size, int type, float[] buffer)
		{
			unsafe
			{
				fixed (float* bufferPtr = buffer)
				{
					Capabilities.nglFeedbackBuffer(size, type, bufferPtr);
				}
			}
		}
		
		public static void glSelectBuffer(int size, IntPtr buffer)
		{
			unsafe
			{
				Capabilities.nglSelectBuffer(size, (int*)buffer.ToPointer());
			}
		}
		
		public static void glSelectBuffer(int size, ref int buffer)
		{
			unsafe
			{
				fixed (void* ptr = &buffer) Capabilities.nglSelectBuffer(size, (int*)ptr);
			}
		}
		
		public static void glSelectBuffer<T>(int size, ref T buffer) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &buffer) Capabilities.nglSelectBuffer(size, (int*)ptr);
			}
		}
		
		public static void glSelectBuffer<T>(int size, T[] buffer) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = buffer) Capabilities.nglSelectBuffer(size, (int*)ptr);
			}
		}
		
		public static void glSelectBuffer(int size, int[] buffer)
		{
			unsafe
			{
				fixed (int* bufferPtr = buffer)
				{
					Capabilities.nglSelectBuffer(size, bufferPtr);
				}
			}
		}
		
		public static int glRenderMode(int mode) =>
			Capabilities.nglRenderMode(mode);
		
		public static void glInitNames() =>
			Capabilities.nglInitNames();
		
		public static void glLoadName(int name) =>
			Capabilities.nglLoadName(name);
		
		public static void glPassThrough(float token) =>
			Capabilities.nglPassThrough(token);
		
		public static void glPopName() =>
			Capabilities.nglPopName();
		
		public static void glPushName(int name) =>
			Capabilities.nglPushName(name);
		
		public static void glClearAccum(float red, float green, float blue, float alpha) =>
			Capabilities.nglClearAccum(red, green, blue, alpha);
		
		public static void glClearIndex(float c) =>
			Capabilities.nglClearIndex(c);
		
		public static void glIndexMask(int mask) =>
			Capabilities.nglIndexMask(mask);
		
		public static void glAccum(int op, float value) =>
			Capabilities.nglAccum(op, value);
		
		public static void glPopAttrib() =>
			Capabilities.nglPopAttrib();
		
		public static void glPushAttrib(int mask) =>
			Capabilities.nglPushAttrib(mask);
		
		public static void glMap1d(int target, double u1, double u2, int stride, int order, IntPtr points)
		{
			unsafe
			{
				Capabilities.nglMap1d(target, u1, u2, stride, order, (double*)points.ToPointer());
			}
		}
		
		public static void glMap1d(int target, double u1, double u2, int stride, int order, ref double points)
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap1d(target, u1, u2, stride, order, (double*)ptr);
			}
		}
		
		public static void glMap1d<T>(int target, double u1, double u2, int stride, int order, ref T points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap1d(target, u1, u2, stride, order, (double*)ptr);
			}
		}
		
		public static void glMap1d<T>(int target, double u1, double u2, int stride, int order, T[] points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = points) Capabilities.nglMap1d(target, u1, u2, stride, order, (double*)ptr);
			}
		}
		
		public static void glMap1d(int target, double u1, double u2, int stride, int order, double[] points)
		{
			unsafe
			{
				fixed (double* pointsPtr = points)
				{
					Capabilities.nglMap1d(target, u1, u2, stride, order, pointsPtr);
				}
			}
		}
		
		public static void glMap1f(int target, float u1, float u2, int stride, int order, IntPtr points)
		{
			unsafe
			{
				Capabilities.nglMap1f(target, u1, u2, stride, order, (float*)points.ToPointer());
			}
		}
		
		public static void glMap1f(int target, float u1, float u2, int stride, int order, ref float points)
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap1f(target, u1, u2, stride, order, (float*)ptr);
			}
		}
		
		public static void glMap1f<T>(int target, float u1, float u2, int stride, int order, ref T points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap1f(target, u1, u2, stride, order, (float*)ptr);
			}
		}
		
		public static void glMap1f<T>(int target, float u1, float u2, int stride, int order, T[] points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = points) Capabilities.nglMap1f(target, u1, u2, stride, order, (float*)ptr);
			}
		}
		
		public static void glMap1f(int target, float u1, float u2, int stride, int order, float[] points)
		{
			unsafe
			{
				fixed (float* pointsPtr = points)
				{
					Capabilities.nglMap1f(target, u1, u2, stride, order, pointsPtr);
				}
			}
		}
		
		public static void glMap2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, IntPtr points)
		{
			unsafe
			{
				Capabilities.nglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (double*)points.ToPointer());
			}
		}
		
		public static void glMap2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, ref double points)
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (double*)ptr);
			}
		}
		
		public static void glMap2d<T>(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, ref T points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (double*)ptr);
			}
		}
		
		public static void glMap2d<T>(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, T[] points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = points) Capabilities.nglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (double*)ptr);
			}
		}
		
		public static void glMap2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
		{
			unsafe
			{
				fixed (double* pointsPtr = points)
				{
					Capabilities.nglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
				}
			}
		}
		
		public static void glMap2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, IntPtr points)
		{
			unsafe
			{
				Capabilities.nglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (float*)points.ToPointer());
			}
		}
		
		public static void glMap2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, ref float points)
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (float*)ptr);
			}
		}
		
		public static void glMap2f<T>(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, ref T points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &points) Capabilities.nglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (float*)ptr);
			}
		}
		
		public static void glMap2f<T>(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, T[] points) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = points) Capabilities.nglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, (float*)ptr);
			}
		}
		
		public static void glMap2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
		{
			unsafe
			{
				fixed (float* pointsPtr = points)
				{
					Capabilities.nglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, pointsPtr);
				}
			}
		}
		
		public static void glMapGrid1d(int un, double u1, double u2) =>
			Capabilities.nglMapGrid1d(un, u1, u2);
		
		public static void glMapGrid1f(int un, float u1, float u2) =>
			Capabilities.nglMapGrid1f(un, u1, u2);
		
		public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) =>
			Capabilities.nglMapGrid2d(un, u1, u2, vn, v1, v2);
		
		public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) =>
			Capabilities.nglMapGrid2f(un, u1, u2, vn, v1, v2);
		
		public static void glEvalCoord1d(double u) =>
			Capabilities.nglEvalCoord1d(u);
		
		public static void glEvalCoord1dv(IntPtr u)
		{
			unsafe
			{
				Capabilities.nglEvalCoord1dv((double*)u.ToPointer());
			}
		}
		
		public static void glEvalCoord1dv(ref double u)
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord1dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord1dv<T>(ref T u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord1dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord1dv<T>(T[] u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = u) Capabilities.nglEvalCoord1dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord1dv(double[] u)
		{
			unsafe
			{
				fixed (double* uPtr = u)
				{
					Capabilities.nglEvalCoord1dv(uPtr);
				}
			}
		}
		
		public static void glEvalCoord1f(float u) =>
			Capabilities.nglEvalCoord1f(u);
		
		public static void glEvalCoord1fv(IntPtr u)
		{
			unsafe
			{
				Capabilities.nglEvalCoord1fv((float*)u.ToPointer());
			}
		}
		
		public static void glEvalCoord1fv(ref float u)
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord1fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord1fv<T>(ref T u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord1fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord1fv<T>(T[] u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = u) Capabilities.nglEvalCoord1fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord1fv(float[] u)
		{
			unsafe
			{
				fixed (float* uPtr = u)
				{
					Capabilities.nglEvalCoord1fv(uPtr);
				}
			}
		}
		
		public static void glEvalCoord2d(double u, double v) =>
			Capabilities.nglEvalCoord2d(u, v);
		
		public static void glEvalCoord2dv(IntPtr u)
		{
			unsafe
			{
				Capabilities.nglEvalCoord2dv((double*)u.ToPointer());
			}
		}
		
		public static void glEvalCoord2dv(ref double u)
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord2dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord2dv<T>(ref T u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord2dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord2dv<T>(T[] u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = u) Capabilities.nglEvalCoord2dv((double*)ptr);
			}
		}
		
		public static void glEvalCoord2dv(double[] u)
		{
			unsafe
			{
				fixed (double* uPtr = u)
				{
					Capabilities.nglEvalCoord2dv(uPtr);
				}
			}
		}
		
		public static void glEvalCoord2f(float u, float v) =>
			Capabilities.nglEvalCoord2f(u, v);
		
		public static void glEvalCoord2fv(IntPtr u)
		{
			unsafe
			{
				Capabilities.nglEvalCoord2fv((float*)u.ToPointer());
			}
		}
		
		public static void glEvalCoord2fv(ref float u)
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord2fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord2fv<T>(ref T u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &u) Capabilities.nglEvalCoord2fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord2fv<T>(T[] u) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = u) Capabilities.nglEvalCoord2fv((float*)ptr);
			}
		}
		
		public static void glEvalCoord2fv(float[] u)
		{
			unsafe
			{
				fixed (float* uPtr = u)
				{
					Capabilities.nglEvalCoord2fv(uPtr);
				}
			}
		}
		
		public static void glEvalMesh1(int mode, int i1, int i2) =>
			Capabilities.nglEvalMesh1(mode, i1, i2);
		
		public static void glEvalPoint1(int i) =>
			Capabilities.nglEvalPoint1(i);
		
		public static void glEvalMesh2(int mode, int i1, int i2, int j1, int j2) =>
			Capabilities.nglEvalMesh2(mode, i1, i2, j1, j2);
		
		public static void glEvalPoint2(int i, int j) =>
			Capabilities.nglEvalPoint2(i, j);
		
		public static void glAlphaFunc(int func, float _ref) =>
			Capabilities.nglAlphaFunc(func, _ref);
		
		public static void glPixelZoom(float xfactor, float yfactor) =>
			Capabilities.nglPixelZoom(xfactor, yfactor);
		
		public static void glPixelTransferf(int pname, float param) =>
			Capabilities.nglPixelTransferf(pname, param);
		
		public static void glPixelTransferi(int pname, int param) =>
			Capabilities.nglPixelTransferi(pname, param);
		
		public static void glPixelMapfv(int map, int mapsize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglPixelMapfv(map, mapsize, (float*)values.ToPointer());
			}
		}
		
		public static void glPixelMapfv(int map, int mapsize, ref float values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapfv(map, mapsize, (float*)ptr);
			}
		}
		
		public static void glPixelMapfv<T>(int map, int mapsize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapfv(map, mapsize, (float*)ptr);
			}
		}
		
		public static void glPixelMapfv<T>(int map, int mapsize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglPixelMapfv(map, mapsize, (float*)ptr);
			}
		}
		
		public static void glPixelMapfv(int map, int mapsize, float[] values)
		{
			unsafe
			{
				fixed (float* valuesPtr = values)
				{
					Capabilities.nglPixelMapfv(map, mapsize, valuesPtr);
				}
			}
		}
		
		public static void glPixelMapuiv(int map, int mapsize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglPixelMapuiv(map, mapsize, (int*)values.ToPointer());
			}
		}
		
		public static void glPixelMapuiv(int map, int mapsize, ref int values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapuiv(map, mapsize, (int*)ptr);
			}
		}
		
		public static void glPixelMapuiv<T>(int map, int mapsize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapuiv(map, mapsize, (int*)ptr);
			}
		}
		
		public static void glPixelMapuiv<T>(int map, int mapsize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglPixelMapuiv(map, mapsize, (int*)ptr);
			}
		}
		
		public static void glPixelMapuiv(int map, int mapsize, int[] values)
		{
			unsafe
			{
				fixed (int* valuesPtr = values)
				{
					Capabilities.nglPixelMapuiv(map, mapsize, valuesPtr);
				}
			}
		}
		
		public static void glPixelMapusv(int map, int mapsize, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglPixelMapusv(map, mapsize, (ushort*)values.ToPointer());
			}
		}
		
		public static void glPixelMapusv(int map, int mapsize, ref ushort values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapusv(map, mapsize, (ushort*)ptr);
			}
		}
		
		public static void glPixelMapusv<T>(int map, int mapsize, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglPixelMapusv(map, mapsize, (ushort*)ptr);
			}
		}
		
		public static void glPixelMapusv<T>(int map, int mapsize, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglPixelMapusv(map, mapsize, (ushort*)ptr);
			}
		}
		
		public static void glPixelMapusv(int map, int mapsize, ushort[] values)
		{
			unsafe
			{
				fixed (ushort* valuesPtr = values)
				{
					Capabilities.nglPixelMapusv(map, mapsize, valuesPtr);
				}
			}
		}
		
		public static void glCopyPixels(int x, int y, int width, int height, int type) =>
			Capabilities.nglCopyPixels(x, y, width, height, type);
		
		public static void glDrawPixels(int width, int height, int format, int type, IntPtr pixels)
		{
			unsafe
			{
				Capabilities.nglDrawPixels(width, height, format, type, pixels.ToPointer());
			}
		}
		
		public static void glGetClipPlane(int plane, IntPtr equation)
		{
			unsafe
			{
				Capabilities.nglGetClipPlane(plane, (double*)equation.ToPointer());
			}
		}
		
		public static void glGetClipPlane(int plane, ref double equation)
		{
			unsafe
			{
				fixed (void* ptr = &equation) Capabilities.nglGetClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glGetClipPlane<T>(int plane, ref T equation) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &equation) Capabilities.nglGetClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glGetClipPlane<T>(int plane, T[] equation) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = equation) Capabilities.nglGetClipPlane(plane, (double*)ptr);
			}
		}
		
		public static void glGetClipPlane(int plane, double[] equation)
		{
			unsafe
			{
				fixed (double* equationPtr = equation)
				{
					Capabilities.nglGetClipPlane(plane, equationPtr);
				}
			}
		}
		
		public static void glGetLightfv(int light, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetLightfv(light, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetLightfv(int light, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glGetLightfv<T>(int light, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glGetLightfv<T>(int light, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetLightfv(light, pname, (float*)ptr);
			}
		}
		
		public static void glGetLightfv(int light, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetLightfv(light, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetLightiv(int light, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetLightiv(light, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetLightiv(int light, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glGetLightiv<T>(int light, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glGetLightiv<T>(int light, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetLightiv(light, pname, (int*)ptr);
			}
		}
		
		public static void glGetLightiv(int light, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetLightiv(light, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetMapdv(int target, int query, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetMapdv(target, query, (double*)v.ToPointer());
			}
		}
		
		public static void glGetMapdv(int target, int query, ref double v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapdv(target, query, (double*)ptr);
			}
		}
		
		public static void glGetMapdv<T>(int target, int query, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapdv(target, query, (double*)ptr);
			}
		}
		
		public static void glGetMapdv<T>(int target, int query, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetMapdv(target, query, (double*)ptr);
			}
		}
		
		public static void glGetMapdv(int target, int query, double[] v)
		{
			unsafe
			{
				fixed (double* vPtr = v)
				{
					Capabilities.nglGetMapdv(target, query, vPtr);
				}
			}
		}
		
		public static void glGetMapfv(int target, int query, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetMapfv(target, query, (float*)v.ToPointer());
			}
		}
		
		public static void glGetMapfv(int target, int query, ref float v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapfv(target, query, (float*)ptr);
			}
		}
		
		public static void glGetMapfv<T>(int target, int query, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapfv(target, query, (float*)ptr);
			}
		}
		
		public static void glGetMapfv<T>(int target, int query, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetMapfv(target, query, (float*)ptr);
			}
		}
		
		public static void glGetMapfv(int target, int query, float[] v)
		{
			unsafe
			{
				fixed (float* vPtr = v)
				{
					Capabilities.nglGetMapfv(target, query, vPtr);
				}
			}
		}
		
		public static void glGetMapiv(int target, int query, IntPtr v)
		{
			unsafe
			{
				Capabilities.nglGetMapiv(target, query, (int*)v.ToPointer());
			}
		}
		
		public static void glGetMapiv(int target, int query, ref int v)
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapiv(target, query, (int*)ptr);
			}
		}
		
		public static void glGetMapiv<T>(int target, int query, ref T v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &v) Capabilities.nglGetMapiv(target, query, (int*)ptr);
			}
		}
		
		public static void glGetMapiv<T>(int target, int query, T[] v) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = v) Capabilities.nglGetMapiv(target, query, (int*)ptr);
			}
		}
		
		public static void glGetMapiv(int target, int query, int[] v)
		{
			unsafe
			{
				fixed (int* vPtr = v)
				{
					Capabilities.nglGetMapiv(target, query, vPtr);
				}
			}
		}
		
		public static void glGetMaterialfv(int face, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetMaterialfv(face, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetMaterialfv(int face, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glGetMaterialfv<T>(int face, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glGetMaterialfv<T>(int face, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetMaterialfv(face, pname, (float*)ptr);
			}
		}
		
		public static void glGetMaterialfv(int face, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetMaterialfv(face, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetMaterialiv(int face, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetMaterialiv(face, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetMaterialiv(int face, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glGetMaterialiv<T>(int face, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glGetMaterialiv<T>(int face, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetMaterialiv(face, pname, (int*)ptr);
			}
		}
		
		public static void glGetMaterialiv(int face, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetMaterialiv(face, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetPixelMapfv(int map, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetPixelMapfv(map, (float*)values.ToPointer());
			}
		}
		
		public static void glGetPixelMapfv(int map, ref float values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapfv(map, (float*)ptr);
			}
		}
		
		public static void glGetPixelMapfv<T>(int map, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapfv(map, (float*)ptr);
			}
		}
		
		public static void glGetPixelMapfv<T>(int map, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetPixelMapfv(map, (float*)ptr);
			}
		}
		
		public static void glGetPixelMapfv(int map, float[] values)
		{
			unsafe
			{
				fixed (float* valuesPtr = values)
				{
					Capabilities.nglGetPixelMapfv(map, valuesPtr);
				}
			}
		}
		
		public static void glGetPixelMapuiv(int map, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetPixelMapuiv(map, (int*)values.ToPointer());
			}
		}
		
		public static void glGetPixelMapuiv(int map, ref int values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapuiv(map, (int*)ptr);
			}
		}
		
		public static void glGetPixelMapuiv<T>(int map, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapuiv(map, (int*)ptr);
			}
		}
		
		public static void glGetPixelMapuiv<T>(int map, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetPixelMapuiv(map, (int*)ptr);
			}
		}
		
		public static void glGetPixelMapuiv(int map, int[] values)
		{
			unsafe
			{
				fixed (int* valuesPtr = values)
				{
					Capabilities.nglGetPixelMapuiv(map, valuesPtr);
				}
			}
		}
		
		public static void glGetPixelMapusv(int map, IntPtr values)
		{
			unsafe
			{
				Capabilities.nglGetPixelMapusv(map, (ushort*)values.ToPointer());
			}
		}
		
		public static void glGetPixelMapusv(int map, ref ushort values)
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapusv(map, (ushort*)ptr);
			}
		}
		
		public static void glGetPixelMapusv<T>(int map, ref T values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &values) Capabilities.nglGetPixelMapusv(map, (ushort*)ptr);
			}
		}
		
		public static void glGetPixelMapusv<T>(int map, T[] values) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = values) Capabilities.nglGetPixelMapusv(map, (ushort*)ptr);
			}
		}
		
		public static void glGetPixelMapusv(int map, ushort[] values)
		{
			unsafe
			{
				fixed (ushort* valuesPtr = values)
				{
					Capabilities.nglGetPixelMapusv(map, valuesPtr);
				}
			}
		}
		
		public static void glGetPolygonStipple(IntPtr mask)
		{
			unsafe
			{
				Capabilities.nglGetPolygonStipple((byte*)mask.ToPointer());
			}
		}
		
		public static void glGetPolygonStipple(ref byte mask)
		{
			unsafe
			{
				fixed (void* ptr = &mask) Capabilities.nglGetPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glGetPolygonStipple<T>(ref T mask) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &mask) Capabilities.nglGetPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glGetPolygonStipple<T>(T[] mask) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = mask) Capabilities.nglGetPolygonStipple((byte*)ptr);
			}
		}
		
		public static void glGetPolygonStipple(byte[] mask)
		{
			unsafe
			{
				fixed (byte* maskPtr = mask)
				{
					Capabilities.nglGetPolygonStipple(maskPtr);
				}
			}
		}
		
		public static void glGetTexEnvfv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexEnvfv(target, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTexEnvfv(int target, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexEnvfv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexEnvfv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexEnvfv(target, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexEnvfv(int target, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTexEnvfv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexEnviv(int target, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexEnviv(target, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexEnviv(int target, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexEnviv<T>(int target, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexEnviv<T>(int target, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexEnviv(target, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexEnviv(int target, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexEnviv(target, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexGendv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexGendv(coord, pname, (double*)_params.ToPointer());
			}
		}
		
		public static void glGetTexGendv(int coord, int pname, ref double _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glGetTexGendv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glGetTexGendv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexGendv(coord, pname, (double*)ptr);
			}
		}
		
		public static void glGetTexGendv(int coord, int pname, double[] _params)
		{
			unsafe
			{
				fixed (double* _paramsPtr = _params)
				{
					Capabilities.nglGetTexGendv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexGenfv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexGenfv(coord, pname, (float*)_params.ToPointer());
			}
		}
		
		public static void glGetTexGenfv(int coord, int pname, ref float _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexGenfv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexGenfv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexGenfv(coord, pname, (float*)ptr);
			}
		}
		
		public static void glGetTexGenfv(int coord, int pname, float[] _params)
		{
			unsafe
			{
				fixed (float* _paramsPtr = _params)
				{
					Capabilities.nglGetTexGenfv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static void glGetTexGeniv(int coord, int pname, IntPtr _params)
		{
			unsafe
			{
				Capabilities.nglGetTexGeniv(coord, pname, (int*)_params.ToPointer());
			}
		}
		
		public static void glGetTexGeniv(int coord, int pname, ref int _params)
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexGeniv<T>(int coord, int pname, ref T _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &_params) Capabilities.nglGetTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexGeniv<T>(int coord, int pname, T[] _params) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = _params) Capabilities.nglGetTexGeniv(coord, pname, (int*)ptr);
			}
		}
		
		public static void glGetTexGeniv(int coord, int pname, int[] _params)
		{
			unsafe
			{
				fixed (int* _paramsPtr = _params)
				{
					Capabilities.nglGetTexGeniv(coord, pname, _paramsPtr);
				}
			}
		}
		
		public static byte glIsList(int list) =>
			Capabilities.nglIsList(list);
		
		public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) =>
			Capabilities.nglFrustum(left, right, bottom, top, zNear, zFar);
		
		public static void glLoadIdentity() =>
			Capabilities.nglLoadIdentity();
		
		public static void glLoadMatrixf(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglLoadMatrixf((float*)m.ToPointer());
			}
		}
		
		public static void glLoadMatrixf(ref float m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadMatrixf<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadMatrixf<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglLoadMatrixf((float*)ptr);
			}
		}
		
		public static void glLoadMatrixf(float[] m)
		{
			unsafe
			{
				fixed (float* mPtr = m)
				{
					Capabilities.nglLoadMatrixf(mPtr);
				}
			}
		}
		
		public static void glLoadMatrixd(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglLoadMatrixd((double*)m.ToPointer());
			}
		}
		
		public static void glLoadMatrixd(ref double m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadMatrixd<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglLoadMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadMatrixd<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglLoadMatrixd((double*)ptr);
			}
		}
		
		public static void glLoadMatrixd(double[] m)
		{
			unsafe
			{
				fixed (double* mPtr = m)
				{
					Capabilities.nglLoadMatrixd(mPtr);
				}
			}
		}
		
		public static void glMatrixMode(int mode) =>
			Capabilities.nglMatrixMode(mode);
		
		public static void glMultMatrixf(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglMultMatrixf((float*)m.ToPointer());
			}
		}
		
		public static void glMultMatrixf(ref float m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultMatrixf((float*)ptr);
			}
		}
		
		public static void glMultMatrixf<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultMatrixf((float*)ptr);
			}
		}
		
		public static void glMultMatrixf<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglMultMatrixf((float*)ptr);
			}
		}
		
		public static void glMultMatrixf(float[] m)
		{
			unsafe
			{
				fixed (float* mPtr = m)
				{
					Capabilities.nglMultMatrixf(mPtr);
				}
			}
		}
		
		public static void glMultMatrixd(IntPtr m)
		{
			unsafe
			{
				Capabilities.nglMultMatrixd((double*)m.ToPointer());
			}
		}
		
		public static void glMultMatrixd(ref double m)
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultMatrixd((double*)ptr);
			}
		}
		
		public static void glMultMatrixd<T>(ref T m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = &m) Capabilities.nglMultMatrixd((double*)ptr);
			}
		}
		
		public static void glMultMatrixd<T>(T[] m) where T : unmanaged
		{
			unsafe
			{
				fixed (void* ptr = m) Capabilities.nglMultMatrixd((double*)ptr);
			}
		}
		
		public static void glMultMatrixd(double[] m)
		{
			unsafe
			{
				fixed (double* mPtr = m)
				{
					Capabilities.nglMultMatrixd(mPtr);
				}
			}
		}
		
		public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) =>
			Capabilities.nglOrtho(left, right, bottom, top, zNear, zFar);
		
		public static void glPopMatrix() =>
			Capabilities.nglPopMatrix();
		
		public static void glPushMatrix() =>
			Capabilities.nglPushMatrix();
		
		public static void glRotated(double angle, double x, double y, double z) =>
			Capabilities.nglRotated(angle, x, y, z);
		
		public static void glRotatef(float angle, float x, float y, float z) =>
			Capabilities.nglRotatef(angle, x, y, z);
		
		public static void glScaled(double x, double y, double z) =>
			Capabilities.nglScaled(x, y, z);
		
		public static void glScalef(float x, float y, float z) =>
			Capabilities.nglScalef(x, y, z);
		
		public static void glTranslated(double x, double y, double z) =>
			Capabilities.nglTranslated(x, y, z);
		
		public static void glTranslatef(float x, float y, float z) =>
			Capabilities.nglTranslatef(x, y, z);
		
		
	}
}
