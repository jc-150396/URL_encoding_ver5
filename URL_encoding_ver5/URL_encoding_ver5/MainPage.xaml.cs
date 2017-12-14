using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

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
            var p = new person();
            p.Name = "Kamada Yuto";
            p.country = "Japan";
            p.Age = 20;

            var json = JsonConvert.SerializeObject(p);  //---------------------------Json形式に変更
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand };

            var label = new Label
            {
                Text = $"{json}" //{"Name":"Kamada Yuto","Age":20}
            };
            layout.Children.Add(label);

            var deserialized = JsonConvert.DeserializeObject<person>(json); //---------------------------Json形式から元に戻す
            var label2 = new Label
            {
                Text = $"Name: {deserialized.Name}" //Kamada Yuto
            };
            var label3 = new Label
            {
                Text = $"Age: {deserialized.Age}" //20
            };
            layout.Children.Add(label2);
            layout.Children.Add(label3);

            Content = layout;



            string keyword =  abc.Text;

            string result = keyword;


        }
    }
}



    public class person
    {
        [JsonProperty("name")] //プロパティ名とは別のキーを指定したい場合はJsonProperty属性を使用
        public string Name { get; set; }

        [JsonIgnore] //対象のプロパティにJsonIgnore属性を付与することでシリアライズの対象外にすることができます。
        public string country { get; set; }

        public int Age { get; set; }
    }