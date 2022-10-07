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

namespace Enter
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string EnterText = TextBox1.Text;
            string[] EnterNums = EnterText.Split(' ');
            
            int[] Nums = new int[10];

            int temp;

            for (int i = 0; i < EnterNums.Length; i++) 
            { 
                Nums[i] = Convert.ToInt32(EnterNums[i]); 

            }

            for (int j = 0; j < Nums.Length - 1; j++)
            {
                for (int k = 0; k < Nums.Length; k++)
                {
                    if (Nums[k] > Nums[j])
                    {
                        temp = Nums[j];
                        Nums[j] = Nums[k];
                        Nums[k] = temp;
                    }
                }
            }

            Label1.Content = Convert.ToString(Nums[0]);
        }
    }
}
