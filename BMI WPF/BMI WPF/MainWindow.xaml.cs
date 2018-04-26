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
        //把身高、體重、bmi等會用到的數值設為全域變數
        public class Global
        {
            public static string height, weight;
            public static float H, bmi, W;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        //點擊Del1會觸發以下事件
        private void Delete1_Click(object sender, RoutedEventArgs e)
        {
            //Del1背景色變色
            Del1.Background = Brushes.LemonChiffon;

            //清除TextBox1的內容
            Box1.Clear();
        }

        //點擊Del2會觸發以下事件
        private void Delete2_Click(object sender, RoutedEventArgs e)
        {
            //Del2背景色變色
            Del2.Background = Brushes.LemonChiffon;
            //清除TextBox2的內容
            Box2.Clear();
        }

        //點擊B會觸發以下事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //導入Box1、Box2的文字並轉為數值，設為height跟weight
            string height = Box1.Text;
            string weight = Box2.Text;

            //計算bmi
            float H = (float)int.Parse(height) / 100;
            float bmi = (int.Parse(weight) / (H * H));

            //寫出bmi並取到小數點後第二位
            Text1.Text = bmi.ToString("0.00") ;
        }
        
    }
}
