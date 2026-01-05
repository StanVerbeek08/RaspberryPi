namespace Proeflokaal_Project.View.MenuItem
{
    partial class frmMenuItemBewerken
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
            tbx_MenuItemNaam = new TextBox();
            lbl_MenuItemNaam = new Label();
            lbl_CatToevoegen = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            cbx_categorie = new ComboBox();
            lbl_Subcategorie = new Label();
            btn_Opslaan = new Button();
            btn_Terug = new Button();
            tbx_Omschrijving = new TextBox();
            lbl_Omschrijving = new Label();
            SuspendLayout();
            // 
            // tbx_MenuItemNaam
            // 
            tbx_MenuItemNaam.Location = new Point(74, 108);
            tbx_MenuItemNaam.Name = "tbx_MenuItemNaam";
            tbx_MenuItemNaam.Size = new Size(179, 27);
            tbx_MenuItemNaam.TabIndex = 17;
            // 
            // lbl_MenuItemNaam
            // 
            lbl_MenuItemNaam.AutoSize = true;
            lbl_MenuItemNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MenuItemNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_MenuItemNaam.Location = new Point(85, 77);
            lbl_MenuItemNaam.Name = "lbl_MenuItemNaam";
            lbl_MenuItemNaam.Size = new Size(162, 28);
            lbl_MenuItemNaam.TabIndex = 16;
            lbl_MenuItemNaam.Text = "Menu-item naam";
            // 
            // lbl_CatToevoegen
            // 
            lbl_CatToevoegen.AutoSize = true;
            lbl_CatToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_CatToevoegen.Location = new Point(14, 20);
            lbl_CatToevoegen.Name = "lbl_CatToevoegen";
            lbl_CatToevoegen.Size = new Size(284, 38);
            lbl_CatToevoegen.TabIndex = 15;
            lbl_CatToevoegen.Text = "Menu-item bewerken";
            // 
            // cbx_categorie
            // 
            cbx_categorie.FormattingEnabled = true;
            cbx_categorie.Location = new Point(74, 245);
            cbx_categorie.Name = "cbx_categorie";
            cbx_categorie.Size = new Size(179, 28);
            cbx_categorie.TabIndex = 21;
            // 
            // lbl_Subcategorie
            // 
            lbl_Subcategorie.AutoSize = true;
            lbl_Subcategorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subcategorie.ForeColor = SystemColors.MenuHighlight;
            lbl_Subcategorie.Location = new Point(102, 214);
            lbl_Subcategorie.Name = "lbl_Subcategorie";
            lbl_Subcategorie.Size = new Size(128, 28);
            lbl_Subcategorie.TabIndex = 20;
            lbl_Subcategorie.Text = "Subcategorie";
            // 
            // btn_Opslaan
            // 
            btn_Opslaan.ForeColor = SystemColors.MenuHighlight;
            btn_Opslaan.Location = new Point(178, 301);
            btn_Opslaan.Name = "btn_Opslaan";
            btn_Opslaan.Size = new Size(127, 39);
            btn_Opslaan.TabIndex = 19;
            btn_Opslaan.Text = "Opslaan";
            btn_Opslaan.UseVisualStyleBackColor = true;
            btn_Opslaan.Click += btn_Opslaan_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(30, 301);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 18;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // tbx_Omschrijving
            // 
            tbx_Omschrijving.Location = new Point(74, 175);
            tbx_Omschrijving.Name = "tbx_Omschrijving";
            tbx_Omschrijving.Size = new Size(179, 27);
            tbx_Omschrijving.TabIndex = 23;
            // 
            // lbl_Omschrijving
            // 
            lbl_Omschrijving.AutoSize = true;
            lbl_Omschrijving.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Omschrijving.ForeColor = SystemColors.MenuHighlight;
            lbl_Omschrijving.Location = new Point(99, 144);
            lbl_Omschrijving.Name = "lbl_Omschrijving";
            lbl_Omschrijving.Size = new Size(127, 28);
            lbl_Omschrijving.TabIndex = 22;
            lbl_Omschrijving.Text = "Omschrijving";
            // 
            // frmMenuItemBewerken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 352);
            Controls.Add(tbx_Omschrijving);
            Controls.Add(lbl_Omschrijving);
            Controls.Add(tbx_MenuItemNaam);
            Controls.Add(lbl_MenuItemNaam);
            Controls.Add(lbl_CatToevoegen);
            Controls.Add(cbx_categorie);
            Controls.Add(lbl_Subcategorie);
            Controls.Add(btn_Opslaan);
            Controls.Add(btn_Terug);
            Name = "frmMenuItemBewerken";
            Text = "Menu-Item Bewerken";
            Load += frmMenuItemBewerken_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_MenuItemNaam;
        private Label lbl_MenuItemNaam;
        private Label lbl_CatToevoegen;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private ComboBox cbx_categorie;
        private Label lbl_Subcategorie;
        private Button btn_Opslaan;
        private Button btn_Terug;
        private TextBox tbx_Omschrijving;
        private Label lbl_Omschrijving;
    }
}