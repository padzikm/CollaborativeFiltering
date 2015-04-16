using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollaborativeFilteringUI.Core
{
    public class DelegateCommand<T> : BaseNotification, ICommand where T : class
    {
        protected readonly Predicate<T> _canExecute;
        protected readonly Action<T> _execute;
        protected bool _isEnabled = true;

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute ?? (t => _isEnabled);
        }

        public virtual bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public virtual void Execute(object parameter)
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
