using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfUIError.ViewModels
{


    public class MainWindowViewModel : Caliburn.Micro.Screen
    {
        private readonly IWindowManager _iWindowManager;
        public MainWindowViewModel()
        {
            _iWindowManager = IoC.Get<IWindowManager>();
        }

        private int timeBindingNumber = 10;

        public int TimeBindingNumber
        {
            get { return timeBindingNumber; }
            set
            {
                timeBindingNumber = value;
                NotifyOfPropertyChange(() => TimeBindingNumber);
            }
        }

        public void TextBlockChangedViewModelShow()
        {
            if (TimeBindingNumber > 0)
            {
                for (int i = 0; i < TimeBindingNumber; i++)
                {
                    TextBlockChangedViewModel onRenderViewModel = new TextBlockChangedViewModel();
                    _iWindowManager.ShowWindowAsync(onRenderViewModel);
                }
            }
            else
            {
                TextBlockChangedViewModel onRenderViewModel = new TextBlockChangedViewModel();
                _iWindowManager.ShowWindowAsync(onRenderViewModel);
            }

        }
    }
}
