using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace URL_encoding_ver5
{
    public partial class MainPage : ContentPage
    {

        public string Rakuten_URL = "https://app.rakuten.co.jp/services/api/BooksGenre/Search/20121128?format=json|&applicationId=1008026300680682252";


        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
