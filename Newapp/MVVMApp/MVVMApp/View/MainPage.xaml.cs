using MVVMApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
