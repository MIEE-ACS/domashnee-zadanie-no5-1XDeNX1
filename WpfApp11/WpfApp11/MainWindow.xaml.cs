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
using WpfApp11.SquereEqModel;
using static WpfApp11.SquereEqModel.Class1;
using static WpfApp11.SquereEqModel.Class1.SquereEquetion;

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SquereEquetion> m_eqs = new List<SquereEquetion>();
        public MainWindow()
        {
            InitializeComponent();
        }
        static bool CheckForDouble(String Num)
        {
            return Num.All(x => Int32.TryParse(x.ToString(), out Int32 result) || (x == ',') || (x == '-'));
        }
        private void TbA_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckForDouble(TbA.Text) || TbA.Text == "Введите a")
            {
                TbA.Text = "";
            }
        }

        private void TbA_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckForDouble(TbA.Text) || TbA.Text == "")
            {
                MessageBox.Show("Ошибка: Вы ввели не действительное число в поле A.");
                TbA.Text = "Введите a";
            }
        }


        private void TbB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckForDouble(TbB.Text) || TbB.Text == "Введите b")
            {
                TbB.Text = "";
            }
        }
        private void TbB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckForDouble(TbB.Text) || TbB.Text == "")
            {
                MessageBox.Show("Ошибка: Вы ввели не действительное число в поле B.");
                TbB.Text = "Введите b";
            }

        }

        private void TbC_GotFocus(object sender, RoutedEventArgs e)
        {
            if(!CheckForDouble(TbC.Text) || TbC.Text == "Введите c") 
            {
                TbC.Text = "";
            }
            
        }

        private void TbC_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckForDouble(TbC.Text) || TbC.Text == "") 
            {
                MessageBox.Show("Ошибка: Вы ввели не действительное число в поле C.");
                TbC.Text = "Введите c"; 
            }
        }
        private void BtCalcRoots_Click(object sender, RoutedEventArgs e)
        {
            if(CheckForDouble(TbA.Text) && CheckForDouble(TbB.Text) && CheckForDouble(TbC.Text)) 
            {
                m_eqs.Add(new SquereEquetion() { aX = Convert.ToDouble(TbA.Text), bX = Convert.ToDouble(TbB.Text), cX = Convert.ToDouble(TbC.Text), RootX="" });
                updateListBox(m_eqs);
            }
            else 
            {
                MessageBox.Show("Вы не ввели значение.");
            }
        }
        void updateListBox(List<SquereEquetion> equetions)
        {
            LbRoots.Items.Clear();

            foreach (var equetion in equetions)
            {
                LbRoots.Items.Add(equetion);
            }
        }

    }
}
