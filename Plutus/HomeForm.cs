using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plutus
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void tmrAdContaint2_Tick(object sender, EventArgs e)
        {
            pbAdContaint.Image = global::Plutus.Properties.Resources.Essentials_for_Gamers;
        }

        private void tmrAdContaint_Tick(object sender, EventArgs e)
        {
            pbAdContaint.Image = global::Plutus.Properties.Resources.Shop_Toys_and_Games;
            tmrAdContaint.Enabled = false;

        }

        private void tmrAdContaint3_Tick(object sender, EventArgs e)
        {
            pbAdContaint.Image = global::Plutus.Properties.Resources.Shop_computers_and_Accessories;
            tmrAdContaint.Enabled = true;

        }
    }
}
