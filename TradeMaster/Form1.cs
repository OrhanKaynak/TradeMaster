using System.Net.Http;
using Newtonsoft.Json;

namespace TradeMaster
{
    public partial class Form1 : Form
    {
        List<Urun> currentProductList = new List<Urun>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://dummyjson.com/products/categories";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);

                List<Kategori> kategoriler = JsonConvert.DeserializeObject<List<Kategori>>(response);

                lbKategoriler.DisplayMember = "name";
                lbKategoriler.ValueMember = "slug";
                lbKategoriler.DataSource = kategoriler;
            }
        }

        private async void lbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKategoriler.SelectedItem is Kategori secilenKategori)
            {
                string url = $"https://dummyjson.com/products/category/{secilenKategori.slug}";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(url);

                    UrunResponse gelenKutu = JsonConvert.DeserializeObject<UrunResponse>(response);

                    currentProductList = gelenKutu.products;

                    lbUrunler.DataSource = null;
                    lbUrunler.DisplayMember = "title";
                    lbUrunler.DataSource = currentProductList;
                }
            }
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUrunler.SelectedItem is Urun secilenUrun)
            {
                lblFiyat.Text = $"{secilenUrun.price} $";
                lblPuan.Text = $"Puan: {secilenUrun.rating}";
                txtAciklama.Text = secilenUrun.description;
                if (!string.IsNullOrEmpty(secilenUrun.thumbnail))
                {
                    pbResim.Load(secilenUrun.thumbnail);
                }
            }
        }
    }

    public class Kategori
    {
        public string slug { get; set; }
        public string name { get; set; }
    }

    public class Urun
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public double rating { get; set; }
        public string thumbnail { get; set; }
    }

    public class UrunResponse
    {
        public List<Urun> products {  get; set; }
    }
}
