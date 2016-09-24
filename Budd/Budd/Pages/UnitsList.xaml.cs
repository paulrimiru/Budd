using Budd.Models;
using Buddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Budd.Pages
{
    public partial class UnitsList : ContentPage
    {
        public UnitsList()
        {
            InitializeComponent();
            this.Appearing += UnitsList_Appearing;
        }

        private void UnitsList_Appearing(object sender, EventArgs e)
        {
            var connection = new SqlConnectorClass().myConnection;
            unitsList.BindingContext = connection.Table<Unit>();
        }

        private async void unitsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var unitInfo = e.Item as Unit;
            await Navigation.PushAsync(new UnitsPage(unitInfo.name, unitInfo.code, unitInfo.lecturer));
        }
    }
}
