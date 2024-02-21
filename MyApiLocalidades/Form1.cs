using Newtonsoft.Json.Linq;
using System.Net.WebSockets;
using System.Text.Json;

namespace MyApiLocalidades
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            lblErro.Visible = false;
            lblCopiado.Visible = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var msgErro = "";
            lblCopiado.Text = "";
            lblCopiado.Visible = false;
            rtxtCodigo.Text = string.Empty;
            try
            {
                var uf = txtUF.Text.ToUpper();
                string endpoint = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(endpoint).Result;

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the JSON response to extract data
                    string json = response.Content.ReadAsStringAsync().Result;
                    if (string.IsNullOrEmpty(json)) return;
                    JArray jsonArray = JArray.Parse(json);
                    List<Municipio> list = new List<Municipio>();
                    foreach (JObject item in jsonArray)
                    {
                        int id = (int)item["id"];
                        string nome = (string)item["nome"];
                        nome = nome.Replace("'", "`");
                        list.Add(new Municipio()
                        {
                            Id = id,
                            Nome = nome
                        });
                    }
                    rtxtCodigo.AppendText($"INSERT INTO conf_city (id, city, ufId) VALUES {Environment.NewLine}");

                    list.ForEach(municipio =>
                    {
                        rtxtCodigo.AppendText($"({municipio.Id}, '{municipio.Nome}', {txtCodUF.Text}), {Environment.NewLine}");
                    });

                    if (rtxtCodigo.Text.EndsWith($"\n"))
                    {
                        rtxtCodigo.Text = rtxtCodigo.Text.TrimEnd(Environment.NewLine.ToCharArray()) + ";";
                        rtxtCodigo.Text = rtxtCodigo.Text.TrimEnd($", ;".ToCharArray()) + ";";
                    }
                }
                else
                {
                    msgErro = $"Failed to retrieve data. Status code: {response.StatusCode}";
                    Console.WriteLine(msgErro);
                    lblErro.Visible = true;
                    lblErro.Text = msgErro;
                }
            }
            catch (Exception ex)
            {
                msgErro = $"An error occurred: {ex.Message}";
                Console.WriteLine(msgErro);
                lblErro.Visible = true;
                lblErro.Text = msgErro;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            rtxtCodigo.SelectAll();
            if (string.IsNullOrEmpty(rtxtCodigo.SelectedText)) return;
            Clipboard.SetText(rtxtCodigo.SelectedText);
            lblCopiado.Visible = true;
            lblCopiado.Text = "Seleção copiada com sucesso!";
        }
    }
}
