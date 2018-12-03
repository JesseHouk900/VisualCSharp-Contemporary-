using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace DisplayTable
{
    public partial class DisplayPlayersTable : Form
    {
        private BaseballExample.BaseballEntities dbcontext = new BaseballExample.BaseballEntities();
        public DisplayPlayersTable()
        {
            InitializeComponent();
        }

        private void DisplayPlayersTable_Load(object sender, EventArgs e)
        {
            dbcontext.Players.OrderBy(Player => Player.PlayerID).Load();
        }
    }
}
