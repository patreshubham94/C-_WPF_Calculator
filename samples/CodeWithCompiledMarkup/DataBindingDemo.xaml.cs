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
using System.Windows.Shapes;

namespace CodeWithCompiledMarkup
{
    /// <summary>
    /// Interaction logic for DataBindingDemo.xaml
    /// </summary>
    public partial class DataBindingDemo : Window
    {
        public DataBindingDemo()
        {
            InitializeComponent();

            //Binding sliderValueToRectangleWidthConnector = new Binding();

            //sliderValueToRectangleWidthConnector.Source = this.zoomControl;
            //sliderValueToRectangleWidthConnector.Path = new PropertyPath("value");

            //this.canvasArea.SetBinding(Rectangle.WidthProperty, sliderValueToRectangleWidthConnector);
            //this.canvasArea.SetBinding(Rectangle.HeightProperty, sliderValueToRectangleWidthConnector);

        }

        private void zoomControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
