using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CsharpGUI_PSscriptrunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Run_Click(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            var ps1File = @"C:\Users\ryan3\OneDrive\Documents\GitHub\Code\cSharp\The_PSSR\CsharpGUI-PSscriptrunner\PSSCripts\testscript.ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy unrestricted -file \"{ps1File}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
