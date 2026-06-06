using System;
using System.Windows.Forms;
using StatBrawl.Services;
using StatBrawl.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StatBrawl
{
    public partial class StatBrawl : Form
    {
        private List<Brawler> _brawlers = new List<Brawler>();
        private string _currentPlayerTag;

        public StatBrawl()
        {
            InitializeComponent();

            pnlStart.Visible = true;
            pnlStats.Visible = false;

            dgvBrawlers.AutoGenerateColumns = false;
            dgvBrawlers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Brawler",
                DataPropertyName = "name"
            });

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "🏆",
                DataPropertyName = "trophies"
            });

            dgvBrawlers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Рекорд",
                DataPropertyName = "highestTrophies"
            });
        }

        private async Task LoadPlayerAsync(string tag)
        {
            BrawlApiService api = new BrawlApiService();

            Player player = await api.GetPlayerAsync(tag);

            _currentPlayerTag = tag;
            _brawlers = player.brawlers;

            lblName.Text = $"Name: {player.name}";
            lblTrophies.Text = $"🏆: {player.trophies}";
            lblHighest.Text = $"Рекорд: {player.highestTrophies}";
            lblBrawlersCount.Text = $"Brawlers: {player.brawlers.Count}";

            dgvBrawlers.DataSource = _brawlers.OrderByDescending(b => b.trophies).ToList();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadPlayerAsync(txtTag.Text);

                pnlStart.Visible = false;
                pnlStats.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            dgvBrawlers.DataSource = _brawlers.Where(b => b.name.ToLower().Contains(search)).OrderByDescending(b => b.trophies).ToList();
        }

        private async void miRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadPlayerAsync(_currentPlayerTag);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void miBack_Click(object sender, EventArgs e)
        {
            pnlStats.Visible = false;
            pnlStart.Visible = true;

            txtSearch.Clear();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miTop5_Click(object sender, EventArgs e)
        {
            if (_brawlers == null || !_brawlers.Any())
            {
                MessageBox.Show("Спочатку завантажте статистику.");
                return;
            }

            var top5 = _brawlers.OrderByDescending(b => b.trophies).Take(5).ToList();

            string text = "";

            for (int i = 0; i < top5.Count; i++)
            {
                text += $"{i + 1}. {top5[i].name} - {top5[i].trophies} 🏆\n";
            }

            MessageBox.Show(text, "TOP-5 Brawlers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
