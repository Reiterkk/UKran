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
            int step;
            if (PnlHaken.Location.Y + PnlHaken.Height <= ClientSize.Height - 20)
            {
                step = 10;
            }
            else if (PnlHaken.Location.Y + PnlHaken.Height <= ClientSize.Height - 10)
            {
                step = ClientSize.Height - (PnlHaken.Location.Y + PnlHaken.Height) - 10;
            }
            else
            {
                return;
            }
            PnlHaken.Height += step;
        }

        private void CmdHakenEin_Click(object sender, EventArgs e)
        {
            PnlHaken.Height -= 10;
        }

        private void CmdAuslegerAus_Click(object sender, EventArgs e)
        {
            int step = 0;
            if (PnlAusleger.Location.X >= 10)
            {
                step = 10;
            }
            else if (PnlAusleger.Location.X >= 0)
            {
                step = PnlAusleger.Location.X;
            }
            else
            {
                return;
            }
            PnlAusleger.Width += step;
            PnlAusleger.Location = new Point(PnlAusleger.Location.X - step, PnlAusleger.Location.Y);
            PnlHaken.Location = new Point(PnlHaken.Location.X - step, PnlHaken.Location.Y);
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

        private void CmdKranRechts_Click(object sender, EventArgs e)
        {

            int step = 0;
            if (PnlFundament.Location.X + PnlFundament.Width <= CmdAuslegerAus.Location.X - 10)
            {
                step = 10;
            }
            else if (PnlFundament.Location.X + PnlFundament.Width <= CmdAuslegerAus.Location.X)
            {
                step = CmdAuslegerAus.Location.X - (PnlFundament.Location.X + PnlFundament.Width);
            }
            else
            {
                return;
            }
            PnlAusleger.Location = new Point(PnlAusleger.Location.X + step, PnlAusleger.Location.Y);
            PnlHaken.Location = new Point(PnlHaken.Location.X + step, PnlHaken.Location.Y);
            PnlFundament.Location = new Point(PnlFundament.Location.X + step, PnlFundament.Location.Y);
            PnlHauptelement.Location = new Point(PnlHauptelement.Location.X + step, PnlHauptelement.Location.Y);
        }

        private void CmdKranLinks_Click(object sender, EventArgs e)
        {
            int step = 0;
            if (PnlAusleger.Location.X >= 10 && PnlFundament.Location.X >= 10)
            {
                step = 10;
            }
            else if (PnlAusleger.Location.X >= 0 || PnlFundament.Location.X > 0)
            {
                step = Math.Min(PnlAusleger.Location.X, PnlFundament.Location.X);
            }
            else
            {
                return;
            }
            PnlAusleger.Location = new Point(PnlAusleger.Location.X - step, PnlAusleger.Location.Y);
            PnlHaken.Location = new Point(PnlHaken.Location.X - step, PnlHaken.Location.Y);
            PnlFundament.Location = new Point(PnlFundament.Location.X - step, PnlFundament.Location.Y);
            PnlHauptelement.Location = new Point(PnlHauptelement.Location.X - step, PnlHauptelement.Location.Y);
        }

        private void CmdKranAus_Click(object sender, EventArgs e)
        {
            int step;
            if (PnlAusleger.Location.Y >= 10)
            {
                step = 10;
            }
            else if (PnlAusleger.Location.Y >= 0)
            {
                step = PnlAusleger.Location.Y;

            }
            else
            {
                return;
            }

            PnlAusleger.Location = new Point(PnlAusleger.Location.X, PnlAusleger.Location.Y - step);
            PnlHaken.Location = new Point(PnlHaken.Location.X, PnlHaken.Location.Y - step);
            PnlHauptelement.Location = new Point(PnlHauptelement.Location.X, PnlHauptelement.Location.Y - step);
            PnlHauptelement.Height += step;
        }

        private void CmdKranEin_Click(object sender, EventArgs e)
        {
            if (PnlHauptelement.Height > 10)
            {
                PnlAusleger.Location = new Point(PnlAusleger.Location.X, PnlAusleger.Location.Y + 10);
                PnlHaken.Location = new Point(PnlHaken.Location.X, PnlHaken.Location.Y + 10);
                PnlHauptelement.Location = new Point(PnlHauptelement.Location.X, PnlHauptelement.Location.Y + 10);
                PnlHauptelement.Height -= 10;
            }
        }

        private void rBtnHakenAus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimKran.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            TimKran.Enabled = false;
        }

        private void TimKran_Tick(object sender, EventArgs e)
        {
            if (rBtnHakenAus.Checked)
            {
                CmdHakenAus_Click(sender, e);
            }
            else if (rBtnHakenEin.Checked)
            {
                CmdHakenEin_Click(sender, e);
            }
            else if (rBtnAuslegerAus.Checked)
            {
                CmdAuslegerAus_Click(sender, e);
            }
            else if (rBtnAuslegerEin.Checked)
            {
                CmdAuslegerEin_Click(sender, e);
            }
            else if (rBtnKranAus.Checked)
            {
                CmdKranAus_Click(sender, e);
            }
            else if (rBtnKranEin.Checked)
            {
                CmdKranEin_Click(sender, e);
            }
            else if (rBtnKranRechts.Checked)
            {
                CmdKranRechts_Click(sender, e);
            }
            else if (rBtnKranLinks.Checked)
            {
                CmdKranLinks_Click(sender, e);
            }

        }
    }
}
