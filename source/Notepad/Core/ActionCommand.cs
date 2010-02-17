using System;
using System.Windows.Input;

namespace Notepad.Core
{
    public class ActionCommand : ICommand
    {
        private readonly Action _commandDelegate;

        public ActionCommand(Action commandDelegate)
        {
            _commandDelegate = commandDelegate;
        }

        public void Execute(object parameter)
        {
            _commandDelegate();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}