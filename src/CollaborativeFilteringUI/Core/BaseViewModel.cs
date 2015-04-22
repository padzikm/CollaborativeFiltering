﻿using StructureMap;
using System;

namespace CollaborativeFilteringUI.Core
{
    public class BaseViewModel : BaseNotification, IViewModel
    {
        

        public BaseViewModel(IView view, IContainer container)
        {
            View = view;
            view.DataContext = this;
            Container = container;
            IsResponsive = true;
        }

        public IView View { get; set; }

        public IContainer Container { get; set; }

        public bool IsResponsive { get; set; }

        public event EventHandler OnWindowUpdated;
        public event EventHandler OnWindowResponsivnesLost;
        public event EventHandler OnWindowResponsivnesGained;

        protected void OnResponsivnesLost(object sender, EventArgs e)
        {
            IsResponsive = false;
            OnWindowResponsivnesLost(sender, e);
        }

        protected void OnResponsivnesGained(object sender, EventArgs e)
        {
            IsResponsive = true;
            OnWindowResponsivnesGained(sender, e);
        }

        protected void RaiseOnWindowUpdated(object sender, EventArgs e)
        {
            OnWindowUpdated(sender, e);
        }
    }
}
