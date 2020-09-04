namespace UKran
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdHakenAus = new System.Windows.Forms.Button();
            this.CmdHakenEin = new System.Windows.Forms.Button();
            this.CmdAuslegerAus = new System.Windows.Forms.Button();
            this.CmdAuslegerEin = new System.Windows.Forms.Button();
            this.CmdKranRechts = new System.Windows.Forms.Button();
            this.CmdKranLinks = new System.Windows.Forms.Button();
            this.CmdKranAus = new System.Windows.Forms.Button();
            this.CmdKranEin = new System.Windows.Forms.Button();
            this.PnlHaken = new System.Windows.Forms.Panel();
            this.PnlAusleger = new System.Windows.Forms.Panel();
            this.PnlHauptelement = new System.Windows.Forms.Panel();
            this.PnlFundament = new System.Windows.Forms.Panel();
            this.rBtnHakenAus = new System.Windows.Forms.RadioButton();
            this.rBtnHakenEin = new System.Windows.Forms.RadioButton();
            this.rBtnAuslegerAus = new System.Windows.Forms.RadioButton();
            this.rBtnAuslegerEin = new System.Windows.Forms.RadioButton();
            this.rBtnKranRechts = new System.Windows.Forms.RadioButton();
            this.rBtnKranLinks = new System.Windows.Forms.RadioButton();
            this.rBtnKranAus = new System.Windows.Forms.RadioButton();
            this.rBtnKranEin = new System.Windows.Forms.RadioButton();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.TimKran = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdHakenAus
            // 
            this.CmdHakenAus.Location = new System.Drawing.Point(1329, 133);
            this.CmdHakenAus.Margin = new System.Windows.Forms.Padding(6);
            this.CmdHakenAus.Name = "CmdHakenAus";
            this.CmdHakenAus.Size = new System.Drawing.Size(172, 44);
            this.CmdHakenAus.TabIndex = 0;
            this.CmdHakenAus.Text = "Haken aus";
            this.CmdHakenAus.UseVisualStyleBackColor = true;
            this.CmdHakenAus.Click += new System.EventHandler(this.CmdHakenAus_Click);
            // 
            // CmdHakenEin
            // 
            this.CmdHakenEin.Location = new System.Drawing.Point(1329, 221);
            this.CmdHakenEin.Margin = new System.Windows.Forms.Padding(6);
            this.CmdHakenEin.Name = "CmdHakenEin";
            this.CmdHakenEin.Size = new System.Drawing.Size(172, 44);
            this.CmdHakenEin.TabIndex = 1;
            this.CmdHakenEin.Text = "Haken ein";
            this.CmdHakenEin.UseVisualStyleBackColor = true;
            this.CmdHakenEin.Click += new System.EventHandler(this.CmdHakenEin_Click);
            // 
            // CmdAuslegerAus
            // 
            this.CmdAuslegerAus.Location = new System.Drawing.Point(1329, 310);
            this.CmdAuslegerAus.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAuslegerAus.Name = "CmdAuslegerAus";
            this.CmdAuslegerAus.Size = new System.Drawing.Size(172, 44);
            this.CmdAuslegerAus.TabIndex = 2;
            this.CmdAuslegerAus.Text = "Ausleger aus";
            this.CmdAuslegerAus.UseVisualStyleBackColor = true;
            this.CmdAuslegerAus.Click += new System.EventHandler(this.CmdAuslegerAus_Click);
            // 
            // CmdAuslegerEin
            // 
            this.CmdAuslegerEin.Location = new System.Drawing.Point(1329, 398);
            this.CmdAuslegerEin.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAuslegerEin.Name = "CmdAuslegerEin";
            this.CmdAuslegerEin.Size = new System.Drawing.Size(172, 44);
            this.CmdAuslegerEin.TabIndex = 3;
            this.CmdAuslegerEin.Text = "Ausleger ein";
            this.CmdAuslegerEin.UseVisualStyleBackColor = true;
            this.CmdAuslegerEin.Click += new System.EventHandler(this.CmdAuslegerEin_Click);
            // 
            // CmdKranRechts
            // 
            this.CmdKranRechts.Location = new System.Drawing.Point(1329, 487);
            this.CmdKranRechts.Margin = new System.Windows.Forms.Padding(6);
            this.CmdKranRechts.Name = "CmdKranRechts";
            this.CmdKranRechts.Size = new System.Drawing.Size(172, 44);
            this.CmdKranRechts.TabIndex = 4;
            this.CmdKranRechts.Text = "Kran rechts";
            this.CmdKranRechts.UseVisualStyleBackColor = true;
            this.CmdKranRechts.Click += new System.EventHandler(this.CmdKranRechts_Click);
            // 
            // CmdKranLinks
            // 
            this.CmdKranLinks.Location = new System.Drawing.Point(1329, 575);
            this.CmdKranLinks.Margin = new System.Windows.Forms.Padding(6);
            this.CmdKranLinks.Name = "CmdKranLinks";
            this.CmdKranLinks.Size = new System.Drawing.Size(172, 44);
            this.CmdKranLinks.TabIndex = 5;
            this.CmdKranLinks.Text = "Kran links";
            this.CmdKranLinks.UseVisualStyleBackColor = true;
            this.CmdKranLinks.Click += new System.EventHandler(this.CmdKranLinks_Click);
            // 
            // CmdKranAus
            // 
            this.CmdKranAus.Location = new System.Drawing.Point(1329, 664);
            this.CmdKranAus.Margin = new System.Windows.Forms.Padding(6);
            this.CmdKranAus.Name = "CmdKranAus";
            this.CmdKranAus.Size = new System.Drawing.Size(172, 44);
            this.CmdKranAus.TabIndex = 6;
            this.CmdKranAus.Text = "Kran aus";
            this.CmdKranAus.UseVisualStyleBackColor = true;
            this.CmdKranAus.Click += new System.EventHandler(this.CmdKranAus_Click);
            // 
            // CmdKranEin
            // 
            this.CmdKranEin.Location = new System.Drawing.Point(1329, 752);
            this.CmdKranEin.Margin = new System.Windows.Forms.Padding(6);
            this.CmdKranEin.Name = "CmdKranEin";
            this.CmdKranEin.Size = new System.Drawing.Size(172, 44);
            this.CmdKranEin.TabIndex = 7;
            this.CmdKranEin.Text = "Kran ein";
            this.CmdKranEin.UseVisualStyleBackColor = true;
            this.CmdKranEin.Click += new System.EventHandler(this.CmdKranEin_Click);
            // 
            // PnlHaken
            // 
            this.PnlHaken.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlHaken.Location = new System.Drawing.Point(810, 577);
            this.PnlHaken.Margin = new System.Windows.Forms.Padding(6);
            this.PnlHaken.Name = "PnlHaken";
            this.PnlHaken.Size = new System.Drawing.Size(20, 38);
            this.PnlHaken.TabIndex = 8;
            // 
            // PnlAusleger
            // 
            this.PnlAusleger.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlAusleger.Location = new System.Drawing.Point(810, 558);
            this.PnlAusleger.Margin = new System.Windows.Forms.Padding(6);
            this.PnlAusleger.Name = "PnlAusleger";
            this.PnlAusleger.Size = new System.Drawing.Size(160, 19);
            this.PnlAusleger.TabIndex = 0;
            // 
            // PnlHauptelement
            // 
            this.PnlHauptelement.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlHauptelement.Location = new System.Drawing.Point(950, 577);
            this.PnlHauptelement.Margin = new System.Windows.Forms.Padding(6);
            this.PnlHauptelement.Name = "PnlHauptelement";
            this.PnlHauptelement.Size = new System.Drawing.Size(20, 192);
            this.PnlHauptelement.TabIndex = 0;
            // 
            // PnlFundament
            // 
            this.PnlFundament.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlFundament.Location = new System.Drawing.Point(900, 769);
            this.PnlFundament.Margin = new System.Windows.Forms.Padding(6);
            this.PnlFundament.Name = "PnlFundament";
            this.PnlFundament.Size = new System.Drawing.Size(120, 19);
            this.PnlFundament.TabIndex = 0;
            // 
            // rBtnHakenAus
            // 
            this.rBtnHakenAus.AutoSize = true;
            this.rBtnHakenAus.Checked = true;
            this.rBtnHakenAus.Location = new System.Drawing.Point(1131, 141);
            this.rBtnHakenAus.Name = "rBtnHakenAus";
            this.rBtnHakenAus.Size = new System.Drawing.Size(146, 29);
            this.rBtnHakenAus.TabIndex = 9;
            this.rBtnHakenAus.TabStop = true;
            this.rBtnHakenAus.Text = "Haken aus";
            this.rBtnHakenAus.UseVisualStyleBackColor = true;
            this.rBtnHakenAus.CheckedChanged += new System.EventHandler(this.rBtnHakenAus_CheckedChanged);
            // 
            // rBtnHakenEin
            // 
            this.rBtnHakenEin.AutoSize = true;
            this.rBtnHakenEin.Location = new System.Drawing.Point(1131, 229);
            this.rBtnHakenEin.Name = "rBtnHakenEin";
            this.rBtnHakenEin.Size = new System.Drawing.Size(140, 29);
            this.rBtnHakenEin.TabIndex = 10;
            this.rBtnHakenEin.Text = "Haken ein";
            this.rBtnHakenEin.UseVisualStyleBackColor = true;
            // 
            // rBtnAuslegerAus
            // 
            this.rBtnAuslegerAus.AutoSize = true;
            this.rBtnAuslegerAus.Location = new System.Drawing.Point(1131, 318);
            this.rBtnAuslegerAus.Name = "rBtnAuslegerAus";
            this.rBtnAuslegerAus.Size = new System.Drawing.Size(169, 29);
            this.rBtnAuslegerAus.TabIndex = 11;
            this.rBtnAuslegerAus.TabStop = true;
            this.rBtnAuslegerAus.Text = "Ausleger aus";
            this.rBtnAuslegerAus.UseVisualStyleBackColor = true;
            // 
            // rBtnAuslegerEin
            // 
            this.rBtnAuslegerEin.AutoSize = true;
            this.rBtnAuslegerEin.Location = new System.Drawing.Point(1131, 406);
            this.rBtnAuslegerEin.Name = "rBtnAuslegerEin";
            this.rBtnAuslegerEin.Size = new System.Drawing.Size(163, 29);
            this.rBtnAuslegerEin.TabIndex = 12;
            this.rBtnAuslegerEin.TabStop = true;
            this.rBtnAuslegerEin.Text = "Ausleger ein";
            this.rBtnAuslegerEin.UseVisualStyleBackColor = true;
            // 
            // rBtnKranRechts
            // 
            this.rBtnKranRechts.AutoSize = true;
            this.rBtnKranRechts.Location = new System.Drawing.Point(1131, 495);
            this.rBtnKranRechts.Name = "rBtnKranRechts";
            this.rBtnKranRechts.Size = new System.Drawing.Size(153, 29);
            this.rBtnKranRechts.TabIndex = 13;
            this.rBtnKranRechts.TabStop = true;
            this.rBtnKranRechts.Text = "Kran rechts";
            this.rBtnKranRechts.UseVisualStyleBackColor = true;
            // 
            // rBtnKranLinks
            // 
            this.rBtnKranLinks.AutoSize = true;
            this.rBtnKranLinks.Location = new System.Drawing.Point(1131, 583);
            this.rBtnKranLinks.Name = "rBtnKranLinks";
            this.rBtnKranLinks.Size = new System.Drawing.Size(138, 29);
            this.rBtnKranLinks.TabIndex = 14;
            this.rBtnKranLinks.TabStop = true;
            this.rBtnKranLinks.Text = "Kran links";
            this.rBtnKranLinks.UseVisualStyleBackColor = true;
            // 
            // rBtnKranAus
            // 
            this.rBtnKranAus.AutoSize = true;
            this.rBtnKranAus.Location = new System.Drawing.Point(1131, 672);
            this.rBtnKranAus.Name = "rBtnKranAus";
            this.rBtnKranAus.Size = new System.Drawing.Size(129, 29);
            this.rBtnKranAus.TabIndex = 15;
            this.rBtnKranAus.TabStop = true;
            this.rBtnKranAus.Text = "Kran aus";
            this.rBtnKranAus.UseVisualStyleBackColor = true;
            // 
            // rBtnKranEin
            // 
            this.rBtnKranEin.AutoSize = true;
            this.rBtnKranEin.Location = new System.Drawing.Point(1131, 760);
            this.rBtnKranEin.Name = "rBtnKranEin";
            this.rBtnKranEin.Size = new System.Drawing.Size(123, 29);
            this.rBtnKranEin.TabIndex = 16;
            this.rBtnKranEin.TabStop = true;
            this.rBtnKranEin.Text = "Kran ein";
            this.rBtnKranEin.UseVisualStyleBackColor = true;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(1329, 846);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(172, 44);
            this.CmdStart.TabIndex = 17;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(1329, 913);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(172, 44);
            this.CmdStop.TabIndex = 18;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // TimKran
            // 
            this.TimKran.Interval = 200;
            this.TimKran.Tick += new System.EventHandler(this.TimKran_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.rBtnKranEin);
            this.Controls.Add(this.rBtnKranAus);
            this.Controls.Add(this.rBtnKranLinks);
            this.Controls.Add(this.rBtnKranRechts);
            this.Controls.Add(this.rBtnAuslegerEin);
            this.Controls.Add(this.rBtnAuslegerAus);
            this.Controls.Add(this.rBtnHakenEin);
            this.Controls.Add(this.rBtnHakenAus);
            this.Controls.Add(this.PnlAusleger);
            this.Controls.Add(this.PnlHauptelement);
            this.Controls.Add(this.PnlFundament);
            this.Controls.Add(this.PnlHaken);
            this.Controls.Add(this.CmdKranEin);
            this.Controls.Add(this.CmdKranAus);
            this.Controls.Add(this.CmdKranLinks);
            this.Controls.Add(this.CmdKranRechts);
            this.Controls.Add(this.CmdAuslegerEin);
            this.Controls.Add(this.CmdAuslegerAus);
            this.Controls.Add(this.CmdHakenEin);
            this.Controls.Add(this.CmdHakenAus);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Kran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdHakenAus;
        private System.Windows.Forms.Button CmdHakenEin;
        private System.Windows.Forms.Button CmdAuslegerAus;
        private System.Windows.Forms.Button CmdAuslegerEin;
        private System.Windows.Forms.Button CmdKranRechts;
        private System.Windows.Forms.Button CmdKranLinks;
        private System.Windows.Forms.Button CmdKranAus;
        private System.Windows.Forms.Button CmdKranEin;
        private System.Windows.Forms.Panel PnlHaken;
        private System.Windows.Forms.Panel PnlAusleger;
        private System.Windows.Forms.Panel PnlHauptelement;
        private System.Windows.Forms.Panel PnlFundament;
        private System.Windows.Forms.RadioButton rBtnHakenAus;
        private System.Windows.Forms.RadioButton rBtnHakenEin;
        private System.Windows.Forms.RadioButton rBtnAuslegerAus;
        private System.Windows.Forms.RadioButton rBtnAuslegerEin;
        private System.Windows.Forms.RadioButton rBtnKranRechts;
        private System.Windows.Forms.RadioButton rBtnKranLinks;
        private System.Windows.Forms.RadioButton rBtnKranAus;
        private System.Windows.Forms.RadioButton rBtnKranEin;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Timer TimKran;
    }
}

