using System.Runtime.InteropServices;
namespace DemoWin32
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        static void Main2(string[] args)
        {
            int a = MessageBox(IntPtr.Zero, "MsgBox Text", "MsgBox Heading", 5);
            Console.WriteLine(a);
        }
    }
}