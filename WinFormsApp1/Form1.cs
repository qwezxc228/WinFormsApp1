namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Player player = new("Vlad");
        Enemy enemy = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = player.name;
            labelHpPlayer.Text=player.ToString();
            labelDamagePlayer.Text=player.ToString();
            labelHealPlayer.Text=player.ToString();
            labelEnemyName.Text = enemy.name;
            labelEnemyHp.Text=enemy
        }
    }
}
