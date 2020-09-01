using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHakenAus_Click(object sender, EventArgs e)
        {
            PnlHaken.Height += 10;
        }

        private void CmdHakenEin_Click(object sender, EventArgs e)
        {
            PnlHaken.Height -= 10;
        }

        private void CmdAuslegerAus_Click(object sender, EventArgs e)
        {
            PnlAusleger.Width += 10;
            PnlAusleger.Location = new Point(PnlAusleger.Location.X - 10, PnlAusleger.Location.Y);
            PnlHaken.Location = new Point(PnlHaken.Location.X - 10, PnlHaken.Location.Y);
        }

        private void CmdAuslegerEin_Click(object sender, EventArgs e)
        {
            
            if (PnlAusleger.Width > 10)
            {
                PnlAusleger.Width -= 10;
                PnlAusleger.Location = new Point(PnlAusleger.Location.X + 10, PnlAusleger.Location.Y);
                PnlHaken.Location = new Point(PnlHaken.Location.X + 10, PnlHaken.Location.Y);
            }
            
        }
    }
}
