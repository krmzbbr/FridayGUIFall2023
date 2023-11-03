using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace FridayGUIFall2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //myNewFancyButton.Opacity = 0.5;

        }

        private void myNewFancyButton_Click(object sender, RoutedEventArgs e)
        {
            //myLabel.Content = myCheckBox.IsChecked.ToString();
        }

        private void myOtherButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello Class";

        }

        private void myLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            myOtherLabel.Content = "Mouse is over me";
        }

        private void myLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            myOtherLabel.Content = "Mouse left me";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string result = $"Hello {userNameTextBox.Text}";

            if (Convert.ToBoolean(isItSunnyCheckBox.IsChecked))
            {
                result += "\n It is sunny today";
            }
            else
            {
                result += "\n It is NOT sunny today";

            }


            if (Convert.ToBoolean(twentyThirtyRadioButton.IsChecked))
            {
                result += "\n You are 20-30 years old";
            }

            if (Convert.ToBoolean(twentyThirtyRadioButton.IsChecked))
            {
                result += "\n You are 20-30 years old";
            }

            if (Convert.ToBoolean(thirtyFortyRadioButton.IsChecked))
            {
                result += "\n You are 30-40 years old";
            }

            if (Convert.ToBoolean(fortyFiftyRadioButton.IsChecked))
            {
                result += "\n You are 40-50 years old";
            }
            
            myTextBlock.Text = result;
        }
    }
}
