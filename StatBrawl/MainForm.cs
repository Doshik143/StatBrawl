using System;
using System.Windows.Forms;
using StatBrawl.Services;
using StatBrawl.Models;
using System.Linq;
using System.Collections.Generic;

namespace StatBrawl
{
    public partial class StatBrawl : Form
    {
        private List<Brawler> _brawlers = new List<Brawler>();

        public StatBrawl()
        {
            InitializeComponent();

            dgvBrawlers.AutoGenerateColumns = false;
            dgvBrawlers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Brawler",
                DataPropertyName = "name"
            });

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Кубки",
                DataPropertyName = "trophies"
            });

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Рекорд",
                DataPropertyName = "highestTrophies"
            });
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

                _brawlers = player.brawlers;

                dgvBrawlers.DataSource = player.brawlers.OrderByDescending(b => b.trophies).ToList();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            dgvBrawlers.DataSource = _brawlers.Where(b => b.name.ToLower().Contains(search)).OrderByDescending(b => b.trophies).ToList();
        }
    }
}
