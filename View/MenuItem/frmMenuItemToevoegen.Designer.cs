namespace Proeflokaal_Project.View.MenuItem
{
    partial class frmMenuItemToevoegen
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
            tbx_SubcategorieNaam = new TextBox();
            lbl_MenuItemNaam = new Label();
            lbl_CatToevoegen = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tbx_Omschrijving = new TextBox();
            lbl_Omschrijving = new Label();
            cbx_subcategorie = new ComboBox();
            lbl_Subcategorie = new Label();
            btn_Toevoegen = new Button();
            btn_Terug = new Button();
            SuspendLayout();
            // 
            // tbx_SubcategorieNaam
            // 
            tbx_SubcategorieNaam.Location = new Point(73, 104);
            tbx_SubcategorieNaam.Name = "tbx_SubcategorieNaam";
            tbx_SubcategorieNaam.Size = new Size(179, 27);
            tbx_SubcategorieNaam.TabIndex = 26;
            // 
            // lbl_MenuItemNaam
            // 
            lbl_MenuItemNaam.AutoSize = true;
            lbl_MenuItemNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MenuItemNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_MenuItemNaam.Location = new Point(84, 73);
            lbl_MenuItemNaam.Name = "lbl_MenuItemNaam";
            lbl_MenuItemNaam.Size = new Size(162, 28);
            lbl_MenuItemNaam.TabIndex = 25;
            lbl_MenuItemNaam.Text = "Menu-item naam";
            // 
            // lbl_CatToevoegen
            // 
            lbl_CatToevoegen.AutoSize = true;
            lbl_CatToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_CatToevoegen.Location = new Point(11, 16);
            lbl_CatToevoegen.Name = "lbl_CatToevoegen";
            lbl_CatToevoegen.Size = new Size(294, 38);
            lbl_CatToevoegen.TabIndex = 24;
            lbl_CatToevoegen.Text = "Menu-item toevoegen";
            // 
            // tbx_Omschrijving
            // 
            tbx_Omschrijving.Location = new Point(73, 171);
            tbx_Omschrijving.Name = "tbx_Omschrijving";
            tbx_Omschrijving.Size = new Size(179, 27);
            tbx_Omschrijving.TabIndex = 32;
            // 
            // lbl_Omschrijving
            // 
            lbl_Omschrijving.AutoSize = true;
            lbl_Omschrijving.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Omschrijving.ForeColor = SystemColors.MenuHighlight;
            lbl_Omschrijving.Location = new Point(98, 140);
            lbl_Omschrijving.Name = "lbl_Omschrijving";
            lbl_Omschrijving.Size = new Size(127, 28);
            lbl_Omschrijving.TabIndex = 31;
            lbl_Omschrijving.Text = "Omschrijving";
            // 
            // cbx_subcategorie
            // 
            cbx_subcategorie.FormattingEnabled = true;
            cbx_subcategorie.Location = new Point(73, 241);
            cbx_subcategorie.Name = "cbx_subcategorie";
            cbx_subcategorie.Size = new Size(179, 28);
            cbx_subcategorie.TabIndex = 30;
            // 
            // lbl_Subcategorie
            // 
            lbl_Subcategorie.AutoSize = true;
            lbl_Subcategorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subcategorie.ForeColor = SystemColors.MenuHighlight;
            lbl_Subcategorie.Location = new Point(101, 210);
            lbl_Subcategorie.Name = "lbl_Subcategorie";
            lbl_Subcategorie.Size = new Size(128, 28);
            lbl_Subcategorie.TabIndex = 29;
            lbl_Subcategorie.Text = "Subcategorie";
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(177, 297);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(127, 39);
            btn_Toevoegen.TabIndex = 28;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(29, 297);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 27;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // frmMenuItemToevoegen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 352);
            Controls.Add(tbx_SubcategorieNaam);
            Controls.Add(lbl_MenuItemNaam);
            Controls.Add(lbl_CatToevoegen);
            Controls.Add(tbx_Omschrijving);
            Controls.Add(lbl_Omschrijving);
            Controls.Add(cbx_subcategorie);
            Controls.Add(lbl_Subcategorie);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Name = "frmMenuItemToevoegen";
            Text = "Menu-Item Toevoegen";
            Load += frmMenuItemToevoegen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_SubcategorieNaam;
        private Label lbl_MenuItemNaam;
        private Label lbl_CatToevoegen;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox tbx_Omschrijving;
        private Label lbl_Omschrijving;
        private ComboBox cbx_subcategorie;
        private Label lbl_Subcategorie;
        private Button btn_Toevoegen;
        private Button btn_Terug;
    }
}