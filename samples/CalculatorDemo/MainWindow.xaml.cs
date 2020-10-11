using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CalculatorDemo
{
    public partial class MainWindow : Window
    {
        NewCalculator _calc = new NewCalculator();

        Control ctrl = null;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _calc;
        }

        private void OperandOne_Focus(object sender, RoutedEventArgs e)
        {
            ctrl = (Control)sender;
        }

        private void OperandTwo_Focus(object sender, RoutedEventArgs e)
        {
            ctrl = (Control)sender;
        }

        private void Div_Button_Click(object sender, RoutedEventArgs e)
        {
            _calc.Division();
        }

        private void Multi_Button_Click(object sender, RoutedEventArgs e)
        {
            _calc.Multiplication();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            _calc.Addition();
        }

        private void Sub_Button_Click(object sender, RoutedEventArgs e)
        {
            _calc.Subtraction();
        }

        private void Clr_Button_Click(object sender, RoutedEventArgs e)
        {
            _calc.Clear();
        }
       
        private void Sign_Change(object sender, RoutedEventArgs e)
        {
            TextBox tb = ctrl as TextBox;
            if(ctrl != null)
                _calc.changeSign(tb.Name);
        }

        private void Square_click(object sender, RoutedEventArgs e)
        {
            _calc.ShowSquare();
        }

        private void Sq_Root(object sender, RoutedEventArgs e)
        {
            _calc.FindSqRoot();
        }

        private void Mod_Click(object sender, RoutedEventArgs e)
        {
            _calc.ModOperation();
        }

        private void Inverse_click(object sender, RoutedEventArgs e)
        {
            TextBox tb = ctrl as TextBox;
            if (ctrl != null)
                _calc.InverseOperation(tb.Name);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //int i = 0;
            //OperandOne.Text += ((Button)sender).Content.ToString() ;
            TextBox tb = ctrl as TextBox;
            if (ctrl != null)
            {
                if(tb.Text == "0" && tb.Text.Length == 1)
                    tb.Text = null;

                tb.Text += ((Button)sender).Content.ToString();           
                
                if (tb.Name == "OperandOne")
                   _calc.Operand1 = double.Parse(tb.Text, System.Globalization.CultureInfo.InvariantCulture);
                else
                   _calc.Operand2 = double.Parse(tb.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
           
        }

        private void CE_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = ctrl as TextBox;
            if (ctrl != null)
            {
                tb.Text = null;
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = ctrl as TextBox;
            if (tb.Text != null)
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
        }
    }
}
