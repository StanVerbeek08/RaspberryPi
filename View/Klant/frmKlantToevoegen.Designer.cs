namespace Proeflokaal_Project.View.Klant
{
    partial class frmKlantToevoegen
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
            txb_Voornaam = new TextBox();
            lbl_MenuItemNaam = new Label();
            lbl_CatToevoegen = new Label();
            txtb_Tussenvoegsel = new TextBox();
            lbl_Omschrijving = new Label();
            lbl_Subcategorie = new Label();
            btn_Toevoegen = new Button();
            btn_Terug = new Button();
            txtb_Achternaam = new TextBox();
            txtb_telefoonnummer = new TextBox();
            lbl_telefoonnummer = new Label();
            txtb_Email = new TextBox();
            lbl_Email = new Label();
            SuspendLayout();
            // 
            // txb_Voornaam
            // 
            txb_Voornaam.Location = new Point(51, 75);
            txb_Voornaam.Margin = new Padding(3, 2, 3, 2);
            txb_Voornaam.Name = "txb_Voornaam";
            txb_Voornaam.Size = new Size(157, 23);
            txb_Voornaam.TabIndex = 35;
            // 
            // lbl_MenuItemNaam
            // 
            lbl_MenuItemNaam.AutoSize = true;
            lbl_MenuItemNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MenuItemNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_MenuItemNaam.Location = new Point(87, 52);
            lbl_MenuItemNaam.Name = "lbl_MenuItemNaam";
            lbl_MenuItemNaam.Size = new Size(82, 21);
            lbl_MenuItemNaam.TabIndex = 34;
            lbl_MenuItemNaam.Text = "Voornaam";
            // 
            // lbl_CatToevoegen
            // 
            lbl_CatToevoegen.AutoSize = true;
            lbl_CatToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_CatToevoegen.Location = new Point(47, 9);
            lbl_CatToevoegen.Name = "lbl_CatToevoegen";
            lbl_CatToevoegen.Size = new Size(172, 30);
            lbl_CatToevoegen.TabIndex = 33;
            lbl_CatToevoegen.Text = "Klant toevoegen";
            // 
            // txtb_Tussenvoegsel
            // 
            txtb_Tussenvoegsel.Location = new Point(51, 125);
            txtb_Tussenvoegsel.Margin = new Padding(3, 2, 3, 2);
            txtb_Tussenvoegsel.Name = "txtb_Tussenvoegsel";
            txtb_Tussenvoegsel.Size = new Size(157, 23);
            txtb_Tussenvoegsel.TabIndex = 41;
            // 
            // lbl_Omschrijving
            // 
            lbl_Omschrijving.AutoSize = true;
            lbl_Omschrijving.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Omschrijving.ForeColor = SystemColors.MenuHighlight;
            lbl_Omschrijving.Location = new Point(73, 102);
            lbl_Omschrijving.Name = "lbl_Omschrijving";
            lbl_Omschrijving.Size = new Size(111, 21);
            lbl_Omschrijving.TabIndex = 40;
            lbl_Omschrijving.Text = "Tussenvoegsel";
            // 
            // lbl_Subcategorie
            // 
            lbl_Subcategorie.AutoSize = true;
            lbl_Subcategorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subcategorie.ForeColor = SystemColors.MenuHighlight;
            lbl_Subcategorie.Location = new Point(75, 155);
            lbl_Subcategorie.Name = "lbl_Subcategorie";
            lbl_Subcategorie.Size = new Size(94, 21);
            lbl_Subcategorie.TabIndex = 38;
            lbl_Subcategorie.Text = "Achternaam";
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(132, 344);
            btn_Toevoegen.Margin = new Padding(3, 2, 3, 2);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(111, 29);
            btn_Toevoegen.TabIndex = 37;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(12, 344);
            btn_Terug.Margin = new Padding(3, 2, 3, 2);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(111, 29);
            btn_Terug.TabIndex = 36;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // txtb_Achternaam
            // 
            txtb_Achternaam.Location = new Point(49, 181);
            txtb_Achternaam.Margin = new Padding(3, 2, 3, 2);
            txtb_Achternaam.Name = "txtb_Achternaam";
            txtb_Achternaam.Size = new Size(157, 23);
            txtb_Achternaam.TabIndex = 42;
            // 
            // txtb_telefoonnummer
            // 
            txtb_telefoonnummer.Location = new Point(47, 241);
            txtb_telefoonnummer.Margin = new Padding(3, 2, 3, 2);
            txtb_telefoonnummer.Name = "txtb_telefoonnummer";
            txtb_telefoonnummer.Size = new Size(157, 23);
            txtb_telefoonnummer.TabIndex = 45;
            // 
            // lbl_telefoonnummer
            // 
            lbl_telefoonnummer.AutoSize = true;
            lbl_telefoonnummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_telefoonnummer.ForeColor = SystemColors.MenuHighlight;
            lbl_telefoonnummer.Location = new Point(64, 218);
            lbl_telefoonnummer.Name = "lbl_telefoonnummer";
            lbl_telefoonnummer.Size = new Size(128, 21);
            lbl_telefoonnummer.TabIndex = 43;
            lbl_telefoonnummer.Text = "Telefoonnummer";
            // 
            // txtb_Email
            // 
            txtb_Email.Location = new Point(47, 300);
            txtb_Email.Margin = new Padding(3, 2, 3, 2);
            txtb_Email.Name = "txtb_Email";
            txtb_Email.Size = new Size(157, 23);
            txtb_Email.TabIndex = 47;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = SystemColors.MenuHighlight;
            lbl_Email.Location = new Point(106, 277);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(48, 21);
            lbl_Email.TabIndex = 46;
            lbl_Email.Text = "Email";
            // 
            // frmKlantToevoegen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 407);
            Controls.Add(txtb_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txtb_telefoonnummer);
            Controls.Add(lbl_telefoonnummer);
            Controls.Add(txtb_Achternaam);
            Controls.Add(txb_Voornaam);
            Controls.Add(lbl_MenuItemNaam);
            Controls.Add(lbl_CatToevoegen);
            Controls.Add(txtb_Tussenvoegsel);
            Controls.Add(lbl_Omschrijving);
            Controls.Add(lbl_Subcategorie);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Name = "frmKlantToevoegen";
            Text = "frmToevoegenKlant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_Voornaam;
        private Label lbl_MenuItemNaam;
        private Label lbl_CatToevoegen;
        private TextBox txtb_Tussenvoegsel;
        private Label lbl_Omschrijving;
        private Label lbl_Subcategorie;
        private Button btn_Toevoegen;
        private Button btn_Terug;
        private TextBox txtb_Achternaam;
        private TextBox txtb_telefoonnummer;
        private Label lbl_telefoonnummer;
        private TextBox txtb_Email;
        private Label lbl_Email;
    }
}