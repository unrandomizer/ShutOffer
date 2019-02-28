using System.Runtime.InteropServices;

namespace ShutOffer
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(int window, int message, int param1, int param2);
        static void Main(string[] args)
        {
            SendMessage(0xFFFF, 0x0112, 0xF170, 0x0002);
        }
    }
}