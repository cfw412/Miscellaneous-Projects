using Habit_Tracker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Habit_Tracker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}