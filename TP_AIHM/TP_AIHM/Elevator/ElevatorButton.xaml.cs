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
using System.Windows.Controls.Primitives;

namespace TP_AIHM
{
    /// <summary>
    /// Interaction logic for ElevatorButton.xaml
    /// </summary>
    public partial class ElevatorButton : ToggleButton
    {

        public ElevatorButton()
        {
            InitializeComponent();
        }

        internal static readonly DependencyProperty EnabledUncheckedProperty = DependencyProperty.Register("EnabledUnchecked", typeof(BitmapImage), typeof(ElevatorButton));

        internal static readonly DependencyProperty DisabledUncheckedProperty = DependencyProperty.Register("DisabledUnchecked", typeof(BitmapImage), typeof(ElevatorButton));

        internal static readonly DependencyProperty EnabledCheckedProperty = DependencyProperty.Register("EnabledChecked", typeof(BitmapImage), typeof(ElevatorButton));

        public BitmapImage EnabledUnchecked
        {
            get { return (BitmapImage)GetValue(EnabledUncheckedProperty); }
            set { SetValue(EnabledUncheckedProperty, value); }
        }

        public BitmapImage DisabledUnchecked
        {
            get { return (BitmapImage)GetValue(DisabledUncheckedProperty); }
            set { SetValue(DisabledUncheckedProperty, value); }
        }

        public BitmapImage EnabledChecked
        {
            get { return (BitmapImage)GetValue(EnabledCheckedProperty); }
            set { SetValue(EnabledCheckedProperty, value); }
        }

        private void ToggleButton_CheckedChanged(object sender, RoutedEventArgs e)
        {
            ChangeImage();
        }

        private void ToggleButton_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ChangeImage();
        }

        private void ToggleButton_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeImage();
        }

        private void ChangeImage()
        {
            Console.WriteLine("Change");
            if (IsEnabled)
            {
                if (IsChecked == true)
                    ButtonImage.Source = EnabledChecked;
                else
                    ButtonImage.Source = EnabledUnchecked;
            }
            else
            {
                ButtonImage.Source = DisabledUnchecked;
            }
        }
    }
}
