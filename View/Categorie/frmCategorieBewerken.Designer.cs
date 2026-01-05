namespace Proeflokaal_Project.View.Categorie
{
    partial class frmCategorieBewerken
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
            tbx_CategorieNaam = new TextBox();
            lbl_CategorieNaam = new Label();
            lbl_CatBewerken = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btn_Opslaan = new Button();
            btn_Terug = new Button();
            SuspendLayout();
            // 
            // tbx_CategorieNaam
            // 
            tbx_CategorieNaam.Location = new Point(59, 147);
            tbx_CategorieNaam.Name = "tbx_CategorieNaam";
            tbx_CategorieNaam.Size = new Size(179, 27);
            tbx_CategorieNaam.TabIndex = 10;
            // 
            // lbl_CategorieNaam
            // 
            lbl_CategorieNaam.AutoSize = true;
            lbl_CategorieNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CategorieNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_CategorieNaam.Location = new Point(71, 116);
            lbl_CategorieNaam.Name = "lbl_CategorieNaam";
            lbl_CategorieNaam.Size = new Size(150, 28);
            lbl_CategorieNaam.TabIndex = 9;
            lbl_CategorieNaam.Text = "Categorie naam";
            // 
            // lbl_CatBewerken
            // 
            lbl_CatBewerken.AutoSize = true;
            lbl_CatBewerken.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatBewerken.ForeColor = SystemColors.MenuHighlight;
            lbl_CatBewerken.Location = new Point(12, 27);
            lbl_CatBewerken.Name = "lbl_CatBewerken";
            lbl_CatBewerken.Size = new Size(265, 38);
            lbl_CatBewerken.TabIndex = 8;
            lbl_CatBewerken.Text = "Categorie bewerken";
            // 
            // btn_Opslaan
            // 
            btn_Opslaan.ForeColor = SystemColors.MenuHighlight;
            btn_Opslaan.Location = new Point(160, 224);
            btn_Opslaan.Name = "btn_Opslaan";
            btn_Opslaan.Size = new Size(127, 39);
            btn_Opslaan.TabIndex = 12;
            btn_Opslaan.Text = "Opslaan";
            btn_Opslaan.UseVisualStyleBackColor = true;
            btn_Opslaan.Click += btn_Opslaan_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(12, 224);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 11;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // frmCategorieBewerken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 291);
            Controls.Add(tbx_CategorieNaam);
            Controls.Add(lbl_CategorieNaam);
            Controls.Add(lbl_CatBewerken);
            Controls.Add(btn_Opslaan);
            Controls.Add(btn_Terug);
            Name = "frmCategorieBewerken";
            Text = "frmCategorieBewerken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_CategorieNaam;
        private Label lbl_CategorieNaam;
        private Label lbl_CatBewerken;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btn_Opslaan;
        private Button btn_Terug;
    }
}