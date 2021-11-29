namespace CalculatorCore.Views
{
    public interface IView
    {
        string FirstNumber { get; }
        string SecondNumber { get; }
        string Result { set; }
    }

    public interface IConsoleView : IView
    { void WelcomeAction(string msg); }

    public interface IWpfView : IView
    { void ToDoAction(string msg); }
    
}