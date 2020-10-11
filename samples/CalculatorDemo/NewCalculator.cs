using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalculatorDemo
{
    public class NewCalculator : INotifyPropertyChanged
    {
        public double Operand1;
        public double Operand2;
        public double result;

        public double OperandOne 
        {
            get
            {
                return this.Operand1;
            }
            set { 
                this.Operand1 = value;   
            }  
             
        }
        public double OperandTwo { get { return this.Operand2; } set { this.Operand2 = value; } }

        public double Res { get { return this.result; } set { this.result = value; } }

        public void changeSign(string textBoxName)
        {
            double newValue;
            if(textBoxName == "OperandOne")
            {
                newValue = -1 * Operand1; //double.Parse(Operand1, System.Globalization.CultureInfo.InvariantCulture);
                Operand1 = newValue;
                OnPropertyChanged("Res");
                OnPropertyChanged("OperandOne");
            } 
            else
            {
                newValue = -1 * Operand2; 
                Operand2 = newValue;
                OnPropertyChanged("Res");
                OnPropertyChanged("OperandTwo");
            }            
        }

        public void InverseOperation(string textBoxName)
        {
            double newValue;
            if (textBoxName == "OperandOne")
            {
                newValue = 1 / Operand1; //double.Parse(Operand1, System.Globalization.CultureInfo.InvariantCulture);
                Operand1 = newValue;
                OnPropertyChanged("Res");
                OnPropertyChanged("OperandOne");
            }
            else
            {
                newValue = 1 / Operand2;
                Operand2 = newValue;
                OnPropertyChanged("Res");
                OnPropertyChanged("OperandTwo");
            }
        }
        public void Division()
        {
            result = Operand1 / Operand2;
            OnPropertyChanged("Res");    
        }
        public void Multiplication()
        {
            result = Operand1 * Operand2;
            OnPropertyChanged("Res");
        }
        public void Addition()
        {
            result = Operand1 + Operand2;
            OnPropertyChanged("Res");
        }
        public void Subtraction()
        {
            result = Operand1 - Operand2;
            OnPropertyChanged("Res");
        }

        public void ShowSquare()
        {
            result *= result;
            OnPropertyChanged("Res");
        }

        public void FindSqRoot()
        {
            result = Math.Sqrt(result);
            OnPropertyChanged("Res");
        }
        public void Clear()
        {
            Operand1=0;  Operand2 = 0; result = 0;
            OnPropertyChanged("OperandOne"); OnPropertyChanged("OperandTwo");
            OnPropertyChanged("Res");
        }

        public void ModOperation()
        {
            result = Operand1 % Operand2;
            OnPropertyChanged("Res");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
