using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Core
{
    public class DelegateCommand<T> : ICommand where T : class
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;
        protected bool _isEnabled = true;

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute ?? (t => _isEnabled);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            OnCanExecuteChanged();
        }

        protected virtual void OnCanExecuteChanged()
        {
            EventHandler handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
