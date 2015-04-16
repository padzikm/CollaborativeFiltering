using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Core
{
    public class DelegateAsyncCommand<T> : DelegateCommand<T> where T : class
    {
        public DelegateAsyncCommand(Action<T> execute, Predicate<T> canExecute)
            : base(execute, canExecute)
        {  }

        public DelegateAsyncCommand(Action<T> execute)
            : base(execute)
        {  }

        public bool IsExecuting { get; set; }

        public event EventHandler Started;
        public event EventHandler Ended;

        public override bool CanExecute(object parameter)
        {
            return (base.CanExecute(parameter)) && (!this.IsExecuting);
        }

        public override void Execute(object parameter)
        {
            try
            {
                this.IsExecuting = true;
                if (Started != null)
                    Started(this, EventArgs.Empty);

                Task task = Task.Factory.StartNew(() => _execute((T)parameter));
                task.ContinueWith(t => OnRunWorkerCompleted(EventArgs.Empty), TaskScheduler.FromCurrentSynchronizationContext());

            }
            catch(Exception e)
            {

            }
        }

        private void OnRunWorkerCompleted(EventArgs e)
        {
            IsExecuting = false;
            if (Ended != null)
                Ended(this, e);
        }
    }
}
