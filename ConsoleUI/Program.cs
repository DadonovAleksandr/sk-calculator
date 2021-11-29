using System;
using System.Threading.Channels;
using CalculatorCore.Controllers;
using CalculatorCore.Infrastructure;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace ConsoleUI
{
    class Program
    {
        class UI : IConsoleView
        {
            public string FirstNumber { get { Console.WriteLine("First number: "); return Console.ReadLine(); }} 
            public string SecondNumber { get { Console.WriteLine("Second number: "); return Console.ReadLine(); } }
            public string Result { set { Console.WriteLine($"Result: {value}"); } }
            public void WelcomeAction(string msg) => Console.WriteLine("Hi");
        }
        static void Main(string[] args)
        {
            var controller = new ControllerBuilder()
                .SetView(new UI())
                .SetModel(new Model(new Mult()))
                .SetConvertor(new NumberConverter())
                .Build();
            controller.ButtonClick();
            Console.ReadLine();
        }
    }
}