namespace SchoolProjectA_Client
{
    public partial class MainMenu : Form
    {
        private HttpClient Client { get; set; } = new();
        private Classes.Moni? MyMoni { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            Connexion con = new(this);
            con.Show();
        }


    }
}