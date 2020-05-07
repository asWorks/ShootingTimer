using System;
using System.Linq;
using Xamarin.Forms;
using ShootingTimer.Data;

namespace ShootingTimer.Views
{
    [QueryProperty("Name", "name")]
    public partial class BearDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = BearData.Bears.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public BearDetailPage()
        {
            InitializeComponent();
        }
    }
}
