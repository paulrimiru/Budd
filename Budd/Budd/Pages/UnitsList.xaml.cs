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
            unitsList.ItemsSource = connection.Table<Unit>();
        }


    }
}
