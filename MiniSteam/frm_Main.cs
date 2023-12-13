using Microsoft.EntityFrameworkCore.Query.Internal;
using MiniSteam.Data;

namespace MiniSteam
{
    public partial class frm_Main : Form
    {
        MiniSteamDbContext SteamDb=new MiniSteamDbContext();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            dgvData.DataSource = SteamDb.Games.ToList();

        }
    }
}
