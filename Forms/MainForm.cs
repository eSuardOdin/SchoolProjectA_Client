using SchoolProjectA_Client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProjectA_ClientA.Forms
{
    public partial class MainForm : Form
    {
        private Moni MyMoni { get; set; }
        private ConnexionForm MyConnexionForm { get; set; }
        public MainForm(Moni myMoni, ConnexionForm myConnexionForm)
        {
            InitializeComponent();
            MyMoni = myMoni;
            MyConnexionForm = myConnexionForm;
            this.Text = $"MoniWatch - {MyMoni.MoniLogin}";
            loginLbl.Text = $"Utilisateur : {MyMoni.LastName} {MyMoni.FirstName}";
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (MyConnexionForm != null && !MyConnexionForm.Visible) MyConnexionForm.Show();
            this.Dispose();
        }

        private void ConnexionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyConnexionForm != null) MyConnexionForm.Dispose();
        }
    }
}
