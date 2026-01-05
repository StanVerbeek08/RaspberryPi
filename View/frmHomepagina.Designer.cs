namespace Proeflokaal_Project
{
    partial class frmHomepagina
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Inloggen = new Button();
            lbl_Proeflokaal = new Label();
            btn_ReserveringOverzicht = new Button();
            btn_CategorieOverzicht = new Button();
            btn_SubcategorieOverzicht = new Button();
            btn_MenuItemOverzicht = new Button();
            btn_KlantOverzicht = new Button();
            btn_MedewerkerOverzicht = new Button();
            SuspendLayout();
            // 
            // btn_Inloggen
            // 
            btn_Inloggen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Inloggen.ForeColor = SystemColors.MenuHighlight;
            btn_Inloggen.Location = new Point(12, 395);
            btn_Inloggen.Name = "btn_Inloggen";
            btn_Inloggen.Size = new Size(122, 43);
            btn_Inloggen.TabIndex = 0;
            btn_Inloggen.Text = "Inloggen";
            btn_Inloggen.UseVisualStyleBackColor = true;
            btn_Inloggen.Click += btn_Inloggen_Click;
            // 
            // lbl_Proeflokaal
            // 
            lbl_Proeflokaal.AutoSize = true;
            lbl_Proeflokaal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Proeflokaal.ForeColor = SystemColors.MenuHighlight;
            lbl_Proeflokaal.Location = new Point(364, 191);
            lbl_Proeflokaal.Name = "lbl_Proeflokaal";
            lbl_Proeflokaal.Size = new Size(165, 41);
            lbl_Proeflokaal.TabIndex = 1;
            lbl_Proeflokaal.Text = "Proeflokaal";
            // 
            // btn_ReserveringOverzicht
            // 
            btn_ReserveringOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_ReserveringOverzicht.Location = new Point(12, 12);
            btn_ReserveringOverzicht.Name = "btn_ReserveringOverzicht";
            btn_ReserveringOverzicht.Size = new Size(148, 57);
            btn_ReserveringOverzicht.TabIndex = 2;
            btn_ReserveringOverzicht.Text = "Reservering overzicht";
            btn_ReserveringOverzicht.UseVisualStyleBackColor = true;
            btn_ReserveringOverzicht.Click += btn_ReserveringenOverzicht_Click;
            // 
            // btn_CategorieOverzicht
            // 
            btn_CategorieOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_CategorieOverzicht.Location = new Point(166, 12);
            btn_CategorieOverzicht.Name = "btn_CategorieOverzicht";
            btn_CategorieOverzicht.Size = new Size(135, 57);
            btn_CategorieOverzicht.TabIndex = 3;
            btn_CategorieOverzicht.Text = "Categorie overzicht";
            btn_CategorieOverzicht.UseVisualStyleBackColor = true;
            btn_CategorieOverzicht.Click += btn_CategorieOverzicht_Click;
            // 
            // btn_SubcategorieOverzicht
            // 
            btn_SubcategorieOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_SubcategorieOverzicht.Location = new Point(307, 12);
            btn_SubcategorieOverzicht.Name = "btn_SubcategorieOverzicht";
            btn_SubcategorieOverzicht.Size = new Size(135, 57);
            btn_SubcategorieOverzicht.TabIndex = 4;
            btn_SubcategorieOverzicht.Text = "Subcategorie overzicht";
            btn_SubcategorieOverzicht.UseVisualStyleBackColor = true;
            btn_SubcategorieOverzicht.Click += btn_SubcategorieOverzicht_Click;
            // 
            // btn_MenuItemOverzicht
            // 
            btn_MenuItemOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_MenuItemOverzicht.Location = new Point(448, 12);
            btn_MenuItemOverzicht.Name = "btn_MenuItemOverzicht";
            btn_MenuItemOverzicht.Size = new Size(135, 57);
            btn_MenuItemOverzicht.TabIndex = 5;
            btn_MenuItemOverzicht.Text = "Menu-Item overzicht";
            btn_MenuItemOverzicht.UseVisualStyleBackColor = true;
            btn_MenuItemOverzicht.Click += btn_MenuItemOverzicht_Click;
            // 
            // btn_KlantOverzicht
            // 
            btn_KlantOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_KlantOverzicht.Location = new Point(589, 12);
            btn_KlantOverzicht.Name = "btn_KlantOverzicht";
            btn_KlantOverzicht.Size = new Size(119, 57);
            btn_KlantOverzicht.TabIndex = 6;
            btn_KlantOverzicht.Text = "Klant overzicht";
            btn_KlantOverzicht.UseVisualStyleBackColor = true;
            btn_KlantOverzicht.Click += btn_KlantenOverzicht_Click;
            // 
            // btn_MedewerkerOverzicht
            // 
            btn_MedewerkerOverzicht.ForeColor = SystemColors.MenuHighlight;
            btn_MedewerkerOverzicht.Location = new Point(714, 12);
            btn_MedewerkerOverzicht.Name = "btn_MedewerkerOverzicht";
            btn_MedewerkerOverzicht.Size = new Size(119, 57);
            btn_MedewerkerOverzicht.TabIndex = 7;
            btn_MedewerkerOverzicht.Text = "Medewerker overzicht";
            btn_MedewerkerOverzicht.UseVisualStyleBackColor = true;
            btn_MedewerkerOverzicht.Click += btn_MedewerkerOverzicht_Click;
            // 
            // frmHomepagina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(btn_MedewerkerOverzicht);
            Controls.Add(btn_KlantOverzicht);
            Controls.Add(btn_MenuItemOverzicht);
            Controls.Add(btn_SubcategorieOverzicht);
            Controls.Add(btn_CategorieOverzicht);
            Controls.Add(btn_ReserveringOverzicht);
            Controls.Add(lbl_Proeflokaal);
            Controls.Add(btn_Inloggen);
            Name = "frmHomepagina";
            Text = "Hoofdpagina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Inloggen;
        private Label lbl_Proeflokaal;
        private Button btn_ReserveringOverzicht;
        private Button btn_CategorieOverzicht;
        private Button btn_SubcategorieOverzicht;
        private Button btn_MenuItemOverzicht;
        private Button btn_KlantOverzicht;
        private Button btn_MedewerkerOverzicht;
    }
}
