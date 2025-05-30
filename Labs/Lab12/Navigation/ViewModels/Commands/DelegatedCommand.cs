using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation.ViewModels.Commands
{
    public class DelegatedCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Predicate<object?> _canExecute;

        public DelegatedCommand(Action<object?> execute, Predicate<object?> canExecute = null!)
        {
            _execute = execute;
            _canExecute = canExecute ?? ((_) => true);
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter) => _canExecute.Invoke(parameter);

        public void Execute(object? parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
