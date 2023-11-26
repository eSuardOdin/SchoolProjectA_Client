using SchoolProjectA_Client.Classes;
using SchoolProjectA_ClientA.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace SchoolProjectA_ClientA
{
    public partial class ConnexionForm : Form
    {
        private Moni? MyMoni { get; set; }
        public ConnexionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérification des champs d'input
        /// </summary>
        /// <returns>Une chaîne d'erreurs ou une chaine vide si ok</returns>
        private string CheckInput()
        {
            string error = "";
            /*Regex regex = new("^[a-zA-Z0-9]+$");
            if (!regex.IsMatch(this.loginTBox.Text)) 
            {
                error += "Les pseudos ne peuvent contenir que des caractères alphanumériques";
            }*/
            if (loginTBox.Text.Trim() == "") error += "Le champ de login est vide\n";
            if (pwdTBox.Text.Trim() == "") error += "Le champ de password est vide\n";
            return error;
        }

        /// <summary>
        /// Trie les monis pour voir s'il en existe un avec le login du champ de login
        /// </summary>
        /// <param name="loginTxt">La textBox à checker</param>
        /// <returns>Un moni, null si le pseudo n'existe pas</returns>
        private async Task<Moni> GetMoni(TextBox loginTxt)
        {
            using HttpClient client = new HttpClient();
            Moni moni = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync("http://192.168.30.10:5000/moni");
                if (res.IsSuccessStatusCode)
                {
                    List<Moni> monis = await res.Content.ReadFromJsonAsync<List<Moni>>();
                    moni = monis.Find(x => x.MoniLogin == loginTxt.Text);
                }
                else
                {
                    MessageBox.Show("Connexion à l'API impossible", "Erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return moni;
        }

        /// <summary>
        /// Check le mot de passe d'un Moni par rapport au champ password
        /// </summary>
        /// <param name="moni">Le moni à checker</param>
        /// <returns>Le moni si password ok</returns>
        private async Task<Moni> CheckMoni(Moni moni)
        {
            using HttpClient client = new HttpClient();
            Moni? checkedMoni = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await client.GetAsync($"http://192.168.30.10:5000/moni/{moni.MoniId}?moniPwd={pwdTBox.Text}");
                if (res.IsSuccessStatusCode)
                {
                    //List<Moni> monis = await res.Content.ReadFromJsonAsync<List<Moni>>();
                    checkedMoni = await res.Content.ReadFromJsonAsync<Moni>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return checkedMoni;
        }

        /// <summary>
        /// Clic on connect button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            string error = CheckInput();
            // Si mauvaise saisie
            if (error != "")
            {
                MessageBox.Show(error, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // On récupère le Moni correspondant au pseudo (mauvaise pratique car je n'ai pas prévu de tri par pseudo dans l'api)
            MyMoni = await GetMoni(loginTBox);
            if (MyMoni == null)
            {
                MessageBox.Show("L'identifiant et le mot de passe saisis ne correspondent pas", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // On check le pwd
            else
            {
                MyMoni = await CheckMoni(MyMoni);
                if (MyMoni == null)
                {
                    MessageBox.Show("L'identifiant et le mot de passe saisis ne correspondent pas", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Connexion réussie
                else
                {
                    //MessageBox.Show($"{MyMoni.MoniLogin} -> {MyMoni.FirstName} {MyMoni.LastName}");
                    MainForm main = new(MyMoni, this);

                    // Reset du moni et des champs d'input
                    MyMoni = null;
                    pwdTBox.Text = "";
                    loginTBox.Text = "";
                    main.Show();
                    this.Hide();
                }
            }
            connectBtn.Enabled = true;
        }

    }
}