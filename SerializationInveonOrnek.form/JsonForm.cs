using Newtonsoft.Json;

namespace SerializationInveonOrnek.form
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "MSI GF63";
            product.ExpireDate = DateTime.Now;
            product.Price = 25000.99;

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Oguzhan\\Desktop\\InveonBootcamp\\SerializationInveonOrnek\\SerializationInveonOrnek.form\\product.json"))
            {
                using (JsonWriter json = new JsonTextWriter(sw))
                {
                    serializer.Serialize(json, product);
                    MessageBox.Show("Serialize edildi.");
                }
            }

        }
    }
}
