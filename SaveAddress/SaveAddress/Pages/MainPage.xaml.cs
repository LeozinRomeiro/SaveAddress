using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SaveAddress
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Navegar(ContentPage page)
        {
            Detail = new NavigationPage(page);
            IsPresented = false;
        }
    }
}
