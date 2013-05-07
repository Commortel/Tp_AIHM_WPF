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
    /// Interaction logic for CabinView.xaml
    /// </summary>
    public partial class CabinView : UserControl
    {
        public CabinView()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {      
            this.ThirdButton.EnabledChecked = this.CreateImage("images/ThreeSelected.png");
            this.ThirdButton.EnabledUnchecked = this.CreateImage("images/Three.png");
            this.ThirdButton.DisabledUnchecked = this.CreateImage("images/Three.png");

            this.SecondButton.EnabledChecked = this.CreateImage("images/TwoSelected.png");
            this.SecondButton.EnabledUnchecked = this.CreateImage("images/Two.png");
            this.SecondButton.DisabledUnchecked = this.CreateImage("images/Two.png");

            this.FirstButton.EnabledChecked = this.CreateImage("images/OneSelected.png");
            this.FirstButton.EnabledUnchecked = this.CreateImage("images/One.png");
            this.FirstButton.DisabledUnchecked = this.CreateImage("images/One.png");

            this.ZeroButton.EnabledChecked = this.CreateImage("images/ZeroSelected.png");
            this.ZeroButton.EnabledUnchecked = this.CreateImage("images/Zero.png");
            this.ZeroButton.DisabledUnchecked = this.CreateImage("images/Zero.png");
        }

        internal void init(ElevatorControl elevatorControl)
        {
            throw new NotImplementedException();
        }

        internal ElevatorButton getButton(string name)
        {
            throw new NotImplementedException();
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
    }
}
