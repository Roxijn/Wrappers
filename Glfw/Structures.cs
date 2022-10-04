using System.Runtime.InteropServices;

public static partial class Glfw
{
    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWmonitor
    {
        public static readonly GLFWmonitor Zero;
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWwindow
    {
        public static readonly GLFWwindow Zero;
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWcursor
    {
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWvidmode
    {
        public int width, height;
        public int redBits, greenBits, blueBits;
        public int refreshRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWgammaramp
    {
        public nint red, green, blue;
        public int size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWimage
    {
        public int width, height;
        public nint pixels;
    }

    [StructLayout(LayoutKind.Sequential)]
    public record struct GLFWgamepadstate
    {
        public nint states;
        public nint axes;
    }
}
