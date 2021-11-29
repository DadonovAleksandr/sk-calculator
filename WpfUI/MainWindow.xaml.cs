using System.Windows;
using CalculatorCore.Controllers;
using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWpfView
    {
        public MainWindow()
        {
            InitializeComponent();

            var controller = new LoggerController(new ControllerBuilder()
                .SetView(this)
                .SetModel(new Model(new Sum()))
                .SetConvertor(new NumberConverter())
                .Build(),
                new DebugLog()
            );
            btResult.Click += delegate { controller.ButtonClick(); };
        }

        public string FirstNumber { get { return tbFirstNumber.Text; }}
        public string SecondNumber { get { return tbSecondNumber.Text; }}
        public string Result { set { tbResult.Text = value; }}
        public void ToDoAction(string msg)
        {
            MessageBox.Show("Wuf");
        }
    }
}