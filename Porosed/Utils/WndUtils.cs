using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Porosed.Utils
{
    internal class WndUtils
    {
        private static readonly string hotaWindowCaption = 
            "Heroes of Might and Magic III: Horn of the Abyss";

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroPtr, string lpWindowName);

        public static Task<IntPtr> FindHotaWnd()
        {
            Task<IntPtr> hotaWndTask = Task.Factory.StartNew(() =>
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, hotaWindowCaption);

                while (hWnd.Equals(IntPtr.Zero))
                {
                    hWnd = FindWindowByCaption(IntPtr.Zero, hotaWindowCaption);
                    Thread.Yield();
                }

                return hWnd;
            });

            return hotaWndTask;
        }
    }
}
