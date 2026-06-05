using System;
using System.Windows.Forms;
using StatBrawl.Services;
using StatBrawl.Models;

namespace StatBrawl
{
    public partial class StatBrawl : Form
    {
        public StatBrawl()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                BrawlApiService api = new BrawlApiService();

                Player player = await api.GetPlayerAsync(txtTag.Text);

                lblName.Text = $"Ім'я: {player.name}";
                lblTrophies.Text = $"Кубки: {player.trophies}";
                lblHighest.Text = $"Рекорд: {player.highestTrophies}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
