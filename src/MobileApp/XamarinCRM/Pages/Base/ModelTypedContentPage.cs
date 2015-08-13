﻿using Xamarin.Forms;
using XamarinCRM.ViewModels.Base;

namespace XamarinCRM.Pages.Base
{
    public abstract class ModelTypedContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel
    {
        protected TViewModel ViewModel
        {
            get { return base.BindingContext as TViewModel; }
        }

        /// <summary>
        /// Sets the binding context.
        /// </summary>
        /// <value>The binding context.</value>
        /// <remarks>Enforces the proper binding context type at compile time.</remarks>
        public new TViewModel BindingContext
        {
            set 
            { 
                base.BindingContext = value; 
                base.OnPropertyChanged("BindingContext");
            }
        }
    }
}
