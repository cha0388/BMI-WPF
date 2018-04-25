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

namespace BMI_WPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {

        public class Global
        {
            public static string height, weight;
            public static float H, bmi, W;
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox1_TextInput(object sender, TextCompositionEventArgs e)
        {
            Global.height = Console.ReadLine();
            Global.H = (float)int.Parse(Global.height) / 100;
        }

        private void Delete1_Click(object sender, RoutedEventArgs e)
        {
            Box1.Clear();
        }

        private void TextBox2_TextInput(object sender, TextCompositionEventArgs e)
        {
            Global.weight = Console.ReadLine();
            Global.W =int.Parse(Global.weight);
        }

        private void Delete2_Click(object sender, RoutedEventArgs e)
        {
            Box2.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string height = Box1.Text;
            string weight = Box2.Text;
            float H = (float)int.Parse(height) / 100;
            float bmi = ( int.Parse(weight) / (H * H));
            Text1.Text = bmi.ToString() ;
        }
        
    }
}
