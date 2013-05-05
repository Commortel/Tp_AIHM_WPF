using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP_AIHM
{
    /// <summary>
    /// Interaction logic for ElevatorButton.xaml
    /// </summary>
    public partial class ElevatorButton : UserControl
    {
        public String name { get; set; }
        public String iconPath 
        {
            set
            {
                this.ButtonImage.Source = this.CreateImage(value);
            }
        }
        public String iconPathSelected 
        {
            set
            {
                this.ButtonImage.Source = this.CreateImage(value);
            }
        }
        public ElevetorControl control { get; set; }

        public ElevatorButton()
        {
            InitializeComponent();
        }

        private BitmapImage CreateImage(string path)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            image.UriSource = new Uri(@"" + path, UriKind.Relative);
            image.EndInit();
            return image;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.control.
        }
    }
}
