namespace Proeflokaal_Project.View.Subcategorie
{
    partial class frmSubcategorieToevoegen
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
            lbl_SubcategorieNaam = new Label();
            lbl_CatToevoegen = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btn_Toevoegen = new Button();
            btn_Terug = new Button();
            label1 = new Label();
            cbx_categorie = new ComboBox();
            SuspendLayout();
            // 
            // tbx_SubcategorieNaam
            // 
            tbx_SubcategorieNaam.Location = new Point(67, 115);
            tbx_SubcategorieNaam.Name = "tbx_SubcategorieNaam";
            tbx_SubcategorieNaam.Size = new Size(179, 27);
            tbx_SubcategorieNaam.TabIndex = 10;
            // 
            // lbl_SubcategorieNaam
            // 
            lbl_SubcategorieNaam.AutoSize = true;
            lbl_SubcategorieNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SubcategorieNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_SubcategorieNaam.Location = new Point(65, 84);
            lbl_SubcategorieNaam.Name = "lbl_SubcategorieNaam";
            lbl_SubcategorieNaam.Size = new Size(181, 28);
            lbl_SubcategorieNaam.TabIndex = 9;
            lbl_SubcategorieNaam.Text = "Subcategorie naam";
            // 
            // lbl_CatToevoegen
            // 
            lbl_CatToevoegen.AutoSize = true;
            lbl_CatToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_CatToevoegen.Location = new Point(5, 27);
            lbl_CatToevoegen.Name = "lbl_CatToevoegen";
            lbl_CatToevoegen.Size = new Size(305, 38);
            lbl_CatToevoegen.TabIndex = 8;
            lbl_CatToevoegen.Text = "Subategorie toevoegen";
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(167, 225);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(127, 39);
            btn_Toevoegen.TabIndex = 12;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(19, 225);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 11;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(108, 145);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 13;
            label1.Text = "Categorie";
            // 
            // cbx_categorie
            // 
            cbx_categorie.FormattingEnabled = true;
            cbx_categorie.Location = new Point(67, 176);
            cbx_categorie.Name = "cbx_categorie";
            cbx_categorie.Size = new Size(179, 28);
            cbx_categorie.TabIndex = 14;
            // 
            // frmSubcategorieToevoegen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 291);
            Controls.Add(cbx_categorie);
            Controls.Add(label1);
            Controls.Add(tbx_SubcategorieNaam);
            Controls.Add(lbl_SubcategorieNaam);
            Controls.Add(lbl_CatToevoegen);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Name = "frmSubcategorieToevoegen";
            Text = "Subcategorie Toevoegen";
            Load += frmSubcategorieBewerken_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_SubcategorieNaam;
        private Label lbl_SubcategorieNaam;
        private Label lbl_CatToevoegen;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btn_Toevoegen;
        private Button btn_Terug;
        private Label label1;
        private ComboBox cbx_categorie;
    }
}