/*Ethan Ross
 * February 7,2018
 * u1_02_EthanROuput
 * Greeting program w/ Name and Age Inputs*/
using System;
using System.Collections.Generic;
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

namespace u1_02_EthanROutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Age = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void sliderAge_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double sliderValue = Convert.ToInt32(sliderAge.Value);
            LblSlider.Content = "Age = "+sliderValue.ToString();
            Age = sliderValue;
        }
        private void btnShowGreeting_Click(object sender, RoutedEventArgs e)
        {
            string LastName = entryLastName.Text;
            string FirstName = entryFirstName.Text;
            lblOutput.Content = "Hello," + FirstName +" "+LastName + "!" +"\n"+"So, I see that you are "+Age+" Years Old";
        }
        private void entryFirstName_Click(object sender, EventArgs e)
        {
            entryFirstName.Clear();
        }
        private void entryLastName_Click(object sender, EventArgs e)
        {
            entryLastName.Clear();
        }
    }
}
