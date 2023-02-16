using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PianoAlpha3
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

        // C = Teal
        // G = blue
        // A = green
        // B = Orange
        // D = yellow
        // E = red
        // F = purps
        
        private void C_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            C.Fill = new SolidColorBrush(Colors.Gray);
            /*Stream cNote = (Stream)Properties.Resources.ResourceManager.GetObject("C");*/
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.C);
            playNote.Play();
        }

        private void C_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            C.Fill = new SolidColorBrush(Colors.Teal);
        }
                
        private void F_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.F);
            playNote.Play();
        }

        private void F_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            F.Fill = new SolidColorBrush(Colors.Purple);
        }

        private void G_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            G.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.G);
            playNote.Play();
        }

        private void G_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            G.Fill = new SolidColorBrush(Colors.Blue);
        }
        private void A_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            A.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.A);
            playNote.Play();
        }

        private void A_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            A.Fill = new SolidColorBrush(Colors.Green);
        }

        private void D_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            D.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.D);
            playNote.Play();
        }

        private void D_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            D.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void E_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            E.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.E);
            playNote.Play();
        }

        private void E_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            E.Fill = new SolidColorBrush(Colors.Red);
        }

        // private void F_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        // {
        // F.Fill = new SolidColorBrush(Colors.Purple);
        // }

        private void B_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            B.Fill = new SolidColorBrush(Colors.Gray);
            SoundPlayer playNote = new SoundPlayer(Properties.Resources.B);
            playNote.Play();
        }

        private void B_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            B.Fill = new SolidColorBrush(Colors.Orange);
        }

        /*private void highlightCircle(Ellipse circ, bool isClicked)
        {
            if (!isClicked)
                circ.Fill = new SolidColorBrush(Colors.Yellow);
            else
                circ.Fill = new SolidColorBrush(Colors.Orange);
        }

        private void unHighlightCircle(Ellipse circ, bool isUnClicked)
        {
            if (!isUnClicked)
                circ.Fill = new SolidColorBrush(Colors.Orange);
            else
                circ.Fill = new SolidColorBrush(Colors.Yellow);
        }*/
    }
}
