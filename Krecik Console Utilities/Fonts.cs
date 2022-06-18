using System;
using System.Runtime.InteropServices;
namespace KCU
{
    public class Fonts
    {
        [DllImport("gdi32.dll", EntryPoint= "AddFontResourceW", SetLastError= true)]
        static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        public static string InstallFont(string fontPath)
        {
            int result = AddFontResource(fontPath);
            int error = Marshal.GetLastWin32Error();

            if (error != 0)
            {
                return new System.ComponentModel.Win32Exception(error).Message;
            }
            else
            {
               return (result == 0) ? "Font is already installed." : "Font installed successfully.";
            }
        }


        // straight from msdn
        // https://docs.microsoft.com/en-us/dotnet/api/system.console?redirectedfrom=MSDN&view=net-6.0

        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {
            internal short X;
            internal short Y;

            internal COORD(short x, short y)
            {
                X = x;
                Y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal unsafe struct CONSOLE_FONT_INFO_EX
        {
            internal uint cbSize;
            internal uint nFont;
            internal COORD dwFontSize;
            internal int FontFamily;
            internal int FontWeight;
            internal fixed char FaceName[LF_FACESIZE];
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool GetCurrentConsoleFontEx(
               IntPtr consoleOutput,
               bool maximumWindow,
               ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetCurrentConsoleFontEx(
               IntPtr consoleOutput,
               bool maximumWindow,
               ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);

        private const int STD_OUTPUT_HANDLE = -11;
        private const int TMPF_TRUETYPE = 4;
        private const int FONT_FAMILY = 54;
        private const int LF_FACESIZE = 32;
        private static IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
        

        public static unsafe string? GetFontName()
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hnd != INVALID_HANDLE_VALUE)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                if (GetCurrentConsoleFontEx(hnd, false, ref info))
                {
                    return new string(info.FaceName);
                }
            }
                return null;
        }

        public static unsafe void ChangeFont(string fontName = "Lucida Console")
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hnd != INVALID_HANDLE_VALUE)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                bool tt = false;
                // First determine whether there's already a TrueType font.
                if (GetCurrentConsoleFontEx(hnd, false, ref info))
                {
                    CONSOLE_FONT_INFO_EX newInfo = new CONSOLE_FONT_INFO_EX();
                    newInfo.cbSize = (uint)Marshal.SizeOf(newInfo);
                    newInfo.FontFamily = TMPF_TRUETYPE;
                    IntPtr ptr = new IntPtr(newInfo.FaceName);
                    Marshal.Copy(fontName.ToCharArray(), 0, ptr, fontName.Length);
                    // Get some settings from current font.
                    newInfo.dwFontSize = new COORD(info.dwFontSize.X, info.dwFontSize.Y);
                    newInfo.FontWeight = info.FontWeight;
                    SetCurrentConsoleFontEx(hnd, false, ref newInfo);
                }
            }
        }

        public static unsafe void SetFontSize(short width, short height)
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hnd != INVALID_HANDLE_VALUE)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                if (GetCurrentConsoleFontEx(hnd, false, ref info))
                {
                    CONSOLE_FONT_INFO_EX newInfo = info;
                    newInfo.dwFontSize = new COORD(width, height);
                    SetCurrentConsoleFontEx(hnd, false, ref newInfo);
                }
            }
        }

        public static unsafe short? GetFontSize(bool x = true)
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hnd != INVALID_HANDLE_VALUE)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                if (GetCurrentConsoleFontEx(hnd, false, ref info))
                {
                    return (x)? info.dwFontSize.X : info.dwFontSize.Y;
                }
            }
            return null;
        }
    }
}
