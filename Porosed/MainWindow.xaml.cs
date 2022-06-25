using Porosed.Utils;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Porosed
{
    public partial class MainWindow : Window
    {
        public IntPtr hotaWnd;
        public MainWindow()
        {
            InitializeComponent();
            Task<IntPtr> hotaWnd = WndUtils.FindHotaWnd();
            hotaWnd.ContinueWith((t) =>
            {
                var res = t.Result;
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("wsdasdas");
                });
            });
        }
    }
}
