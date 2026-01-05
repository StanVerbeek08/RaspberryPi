namespace Proeflokaal_Project.View.Reservering
{
    partial class frmReserveringToevoegen
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
            tbx_Tafel = new TextBox();
            lbl_tafel = new Label();
            lbl_reserveringToevoegen = new Label();
            tbx_Aantalpersonen = new TextBox();
            lbl_AantalPersonen = new Label();
            lbl_Datum = new Label();
            btn_toevoegen = new Button();
            btn_Terug = new Button();
            dtp_Reservering = new DateTimePicker();
            cbx_Medewerkers = new ComboBox();
            lbl_medewerker = new Label();
            lbl_Klant = new Label();
            cbx_Klanten = new ComboBox();
            SuspendLayout();
            // 
            // tbx_Tafel
            // 
            tbx_Tafel.Location = new Point(87, 143);
            tbx_Tafel.Name = "tbx_Tafel";
            tbx_Tafel.Size = new Size(179, 27);
            tbx_Tafel.TabIndex = 72;
            // 
            // lbl_tafel
            // 
            lbl_tafel.AutoSize = true;
            lbl_tafel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tafel.ForeColor = SystemColors.MenuHighlight;
            lbl_tafel.Location = new Point(155, 112);
            lbl_tafel.Name = "lbl_tafel";
            lbl_tafel.Size = new Size(51, 28);
            lbl_tafel.TabIndex = 71;
            lbl_tafel.Text = "Tafel";
            // 
            // lbl_reserveringToevoegen
            // 
            lbl_reserveringToevoegen.AutoSize = true;
            lbl_reserveringToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_reserveringToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_reserveringToevoegen.Location = new Point(43, 44);
            lbl_reserveringToevoegen.Name = "lbl_reserveringToevoegen";
            lbl_reserveringToevoegen.Size = new Size(301, 38);
            lbl_reserveringToevoegen.TabIndex = 70;
            lbl_reserveringToevoegen.Text = "Reservering toevoegen";
            // 
            // tbx_Aantalpersonen
            // 
            tbx_Aantalpersonen.Location = new Point(87, 209);
            tbx_Aantalpersonen.Name = "tbx_Aantalpersonen";
            tbx_Aantalpersonen.Size = new Size(179, 27);
            tbx_Aantalpersonen.TabIndex = 77;
            // 
            // lbl_AantalPersonen
            // 
            lbl_AantalPersonen.AutoSize = true;
            lbl_AantalPersonen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AantalPersonen.ForeColor = SystemColors.MenuHighlight;
            lbl_AantalPersonen.Location = new Point(112, 179);
            lbl_AantalPersonen.Name = "lbl_AantalPersonen";
            lbl_AantalPersonen.Size = new Size(154, 28);
            lbl_AantalPersonen.TabIndex = 76;
            lbl_AantalPersonen.Text = "Aantal personen";
            // 
            // lbl_Datum
            // 
            lbl_Datum.AutoSize = true;
            lbl_Datum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Datum.ForeColor = SystemColors.MenuHighlight;
            lbl_Datum.Location = new Point(137, 253);
            lbl_Datum.Name = "lbl_Datum";
            lbl_Datum.Size = new Size(71, 28);
            lbl_Datum.TabIndex = 75;
            lbl_Datum.Text = "Datum";
            // 
            // btn_toevoegen
            // 
            btn_toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_toevoegen.Location = new Point(174, 500);
            btn_toevoegen.Name = "btn_toevoegen";
            btn_toevoegen.Size = new Size(127, 39);
            btn_toevoegen.TabIndex = 74;
            btn_toevoegen.Text = "Toevoegen";
            btn_toevoegen.UseVisualStyleBackColor = true;
            btn_toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(40, 500);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 73;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // dtp_Reservering
            // 
            dtp_Reservering.Location = new Point(74, 285);
            dtp_Reservering.Margin = new Padding(3, 4, 3, 4);
            dtp_Reservering.Name = "dtp_Reservering";
            dtp_Reservering.Size = new Size(214, 27);
            dtp_Reservering.TabIndex = 78;
            // 
            // cbx_Medewerkers
            // 
            cbx_Medewerkers.FormattingEnabled = true;
            cbx_Medewerkers.Location = new Point(74, 426);
            cbx_Medewerkers.Margin = new Padding(3, 4, 3, 4);
            cbx_Medewerkers.Name = "cbx_Medewerkers";
            cbx_Medewerkers.Size = new Size(214, 28);
            cbx_Medewerkers.TabIndex = 79;
            // 
            // lbl_medewerker
            // 
            lbl_medewerker.AutoSize = true;
            lbl_medewerker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_medewerker.ForeColor = SystemColors.MenuHighlight;
            lbl_medewerker.Location = new Point(125, 394);
            lbl_medewerker.Name = "lbl_medewerker";
            lbl_medewerker.Size = new Size(120, 28);
            lbl_medewerker.TabIndex = 80;
            lbl_medewerker.Text = "Medewerker";
            // 
            // lbl_Klant
            // 
            lbl_Klant.AutoSize = true;
            lbl_Klant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Klant.ForeColor = SystemColors.MenuHighlight;
            lbl_Klant.Location = new Point(149, 329);
            lbl_Klant.Name = "lbl_Klant";
            lbl_Klant.Size = new Size(57, 28);
            lbl_Klant.TabIndex = 82;
            lbl_Klant.Text = "Klant";
            // 
            // cbx_Klanten
            // 
            cbx_Klanten.FormattingEnabled = true;
            cbx_Klanten.Location = new Point(74, 361);
            cbx_Klanten.Margin = new Padding(3, 4, 3, 4);
            cbx_Klanten.Name = "cbx_Klanten";
            cbx_Klanten.Size = new Size(214, 28);
            cbx_Klanten.TabIndex = 81;
            // 
            // frmReserveringToevoegen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 551);
            Controls.Add(lbl_Klant);
            Controls.Add(cbx_Klanten);
            Controls.Add(lbl_medewerker);
            Controls.Add(cbx_Medewerkers);
            Controls.Add(dtp_Reservering);
            Controls.Add(tbx_Tafel);
            Controls.Add(lbl_tafel);
            Controls.Add(lbl_reserveringToevoegen);
            Controls.Add(tbx_Aantalpersonen);
            Controls.Add(lbl_AantalPersonen);
            Controls.Add(lbl_Datum);
            Controls.Add(btn_toevoegen);
            Controls.Add(btn_Terug);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReserveringToevoegen";
            Text = "frmReserveringToevoegen";
            Load += frmReserveringToevoegen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbx_Tafel;
        private Label lbl_tafel;
        private Label lbl_reserveringToevoegen;
        private TextBox tbx_Aantalpersonen;
        private Label lbl_AantalPersonen;
        private Label lbl_Datum;
        private Button btn_toevoegen;
        private Button btn_Terug;
        private DateTimePicker dtp_Reservering;
        private ComboBox cbx_Medewerkers;
        private Label lbl_medewerker;
        private Label lbl_Klant;
        private ComboBox cbx_Klanten;
    }
}