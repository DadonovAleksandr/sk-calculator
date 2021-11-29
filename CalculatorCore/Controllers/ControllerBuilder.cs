using CalculatorCore.Infrastructure;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace CalculatorCore.Controllers
{
    public class ControllerBuilder
    {
        private Controller _controller;

        public ControllerBuilder() => _controller = new();

        public ControllerBuilder SetModel(IModel model)
        {
            _controller.Model = model;
            return this;
        }
        
        public ControllerBuilder SetView(IView view)
        {
            _controller.View = view;
            return this;
        }

        public ControllerBuilder SetConvertor(INumberConvertor convertor)
        {
            _controller.Convertor = convertor;
            return this;
        }
        
        public Controller Build() => _controller;

    }
}