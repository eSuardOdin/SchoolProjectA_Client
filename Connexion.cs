using SchoolProjectA_Client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProjectA_Client
{
    public partial class Connexion : Form
    {
        private static HttpClient Client = new();
        private MainMenu MyMainMenu { get; set; }
        public Connexion(MainMenu main)
        {
            InitializeComponent();
            MyMainMenu = main;
            MyMainMenu.Hide();
        }

        static async Task<Moni> GetMoni(TextBox loginTxt)
        {
            Moni moni = null;
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage res = await Client.GetAsync("http://192.168.30.10:5000/moni");
                if (res.IsSuccessStatusCode)
                {
                    List<Moni> monis = await res.Content.ReadFromJsonAsync<List<Moni>>();
                    string content = await res.Content.ReadAsStringAsync();
                    MessageBox.Show(content);
                    moni = monis.Find(x => x.MoniLogin == loginTxt.Text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return moni;
        }
        



        private void Connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyMainMenu.Show();
            this.Dispose();
        }
        private async void validBtn_Click(object sender, EventArgs e)
        {
            Moni moni = await GetMoni(this.loginTxtBox);
            MessageBox.Show("Hello " + moni.MoniLogin);
        }
    }
}
