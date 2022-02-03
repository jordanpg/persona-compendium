using Persona_Compendium.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Persona_Compendium.Views
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