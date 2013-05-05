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
    /// Interaction logic for ElevatorView.xaml
    /// </summary>
    public partial class ElevatorView : UserControl
    {
        public ElevatorView()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            this.ZeroButton.iconPath = "images/Call.png";
            this.FirstButton.iconPath = "images/Call.png";
            this.SecondButton.iconPath = "images/Call.png";
            this.ThirdButton.iconPath = "images/Call.png";
        }
    }
}
