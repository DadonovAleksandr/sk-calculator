using System;
using CalculatorCore.Infrastructure;
using CalculatorCore.Log;
using CalculatorCore.Models;
using CalculatorCore.Views;

namespace CalculatorCore.Controllers
{
    public abstract class BaseController
    {
        public virtual IView View { get; set; }
        public virtual IModel Model { get; set; }
        public virtual INumberConvertor Convertor { get; set; }
        public abstract void ButtonClick();
    }

    public class Controller : BaseController
    {
        public override void ButtonClick()
        {
            var a = Convertor.Convert(View.FirstNumber);
            var b = Convertor.Convert(View.SecondNumber);
            View.Result = Convertor.ConvertBack(Model.Execute(a,b));
        }
    }

    public class LoggerController : BaseController
    {
        private BaseController bc;
        private ILog log;

        public LoggerController(BaseController controller, ILog log = null)
        {
            bc = controller;
            this.log = new VoluntaryLog(log);
        }
        public override void ButtonClick()
        {
            bc.ButtonClick();
            log.Log($"Button pressed at {DateTime.Now}");
        }
    }
}