namespace Proeflokaal_Project.View.Subcategorie
{
    partial class frmSubcategorieBewerken
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
            cbx_categorie = new ComboBox();
            label1 = new Label();
            btn_Opslaan = new Button();
            btn_Terug = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tbx_SubcategorieNaam = new TextBox();
            lbl_SubcategorieNaam = new Label();
            lbl_SubcategorieBewerken = new Label();
            SuspendLayout();
            // 
            // cbx_categorie
            // 
            cbx_categorie.FormattingEnabled = true;
            cbx_categorie.Location = new Point(68, 176);
            cbx_categorie.Name = "cbx_categorie";
            cbx_categorie.Size = new Size(179, 28);
            cbx_categorie.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(109, 145);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 20;
            label1.Text = "Categorie";
            // 
            // btn_Opslaan
            // 
            btn_Opslaan.ForeColor = SystemColors.MenuHighlight;
            btn_Opslaan.Location = new Point(168, 225);
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
            btn_Terug.Location = new Point(20, 225);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 18;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // tbx_SubcategorieNaam
            // 
            tbx_SubcategorieNaam.Location = new Point(68, 115);
            tbx_SubcategorieNaam.Name = "tbx_SubcategorieNaam";
            tbx_SubcategorieNaam.Size = new Size(179, 27);
            tbx_SubcategorieNaam.TabIndex = 17;
            // 
            // lbl_SubcategorieNaam
            // 
            lbl_SubcategorieNaam.AutoSize = true;
            lbl_SubcategorieNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SubcategorieNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_SubcategorieNaam.Location = new Point(66, 84);
            lbl_SubcategorieNaam.Name = "lbl_SubcategorieNaam";
            lbl_SubcategorieNaam.Size = new Size(181, 28);
            lbl_SubcategorieNaam.TabIndex = 16;
            lbl_SubcategorieNaam.Text = "Subcategorie naam";
            // 
            // lbl_SubcategorieBewerken
            // 
            lbl_SubcategorieBewerken.AutoSize = true;
            lbl_SubcategorieBewerken.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SubcategorieBewerken.ForeColor = SystemColors.MenuHighlight;
            lbl_SubcategorieBewerken.Location = new Point(9, 27);
            lbl_SubcategorieBewerken.Name = "lbl_SubcategorieBewerken";
            lbl_SubcategorieBewerken.Size = new Size(295, 38);
            lbl_SubcategorieBewerken.TabIndex = 15;
            lbl_SubcategorieBewerken.Text = "Subategorie bewerken";
            // 
            // frmSubcategorieBewerken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 291);
            Controls.Add(cbx_categorie);
            Controls.Add(label1);
            Controls.Add(btn_Opslaan);
            Controls.Add(btn_Terug);
            Controls.Add(tbx_SubcategorieNaam);
            Controls.Add(lbl_SubcategorieNaam);
            Controls.Add(lbl_SubcategorieBewerken);
            Name = "frmSubcategorieBewerken";
            Text = "Subcategorie Bewerken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_categorie;
        private Label label1;
        private Button btn_Opslaan;
        private Button btn_Terug;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox tbx_SubcategorieNaam;
        private Label lbl_SubcategorieNaam;
        private Label lbl_SubcategorieBewerken;
    }
}