using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;
using Engine.ViewModels;
using static WPFUI.MainWindow;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GameSession _gameSession;

        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
            // Data context is a built in property for the xaml window
            DataContext = _gameSession;

            //Startup(); 
        }

 


        private void XPButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.XPtillNextLvl = _gameSession.CurrentPlayer.XPtillNextLvl - 10;
        }

        private void OnClick_North(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_West(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_East(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_South(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
        private void OnClick_Up(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveUp();
        }
        private void OnClick_Down(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveDown();
        }

        private void FontSizeMethod(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "FontHigher")
            {
                _gameSession.FontSizeLabel += 1;
                //_gameSession.LeftSideGridSize += 2;
            }
            else
            {
                _gameSession.FontSizeLabel -= 1;
                //_gameSession.LeftSideGridSize -= 2;
            }
        }

        //private void Startup()
        //{
        //    TextBlock _LocationName = LocationName;
        //    _LocationName.Text = _gameSession.CurrentLocation.Name;
        //}

    }

}
