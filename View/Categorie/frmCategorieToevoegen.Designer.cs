namespace Proeflokaal_Project.View.Categorie
{
    partial class frmCategorieToevoegen
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
            lbl_CatToevoegen = new Label();
            lbl_CategorieNaam = new Label();
            tbx_CategorieNaam = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btn_Terug = new Button();
            btn_Toevoegen = new Button();
            SuspendLayout();
            // 
            // lbl_CatToevoegen
            // 
            lbl_CatToevoegen.AutoSize = true;
            lbl_CatToevoegen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CatToevoegen.ForeColor = SystemColors.MenuHighlight;
            lbl_CatToevoegen.Location = new Point(11, 32);
            lbl_CatToevoegen.Name = "lbl_CatToevoegen";
            lbl_CatToevoegen.Size = new Size(275, 38);
            lbl_CatToevoegen.TabIndex = 3;
            lbl_CatToevoegen.Text = "Categorie toevoegen";
            // 
            // lbl_CategorieNaam
            // 
            lbl_CategorieNaam.AutoSize = true;
            lbl_CategorieNaam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CategorieNaam.ForeColor = SystemColors.MenuHighlight;
            lbl_CategorieNaam.Location = new Point(70, 121);
            lbl_CategorieNaam.Name = "lbl_CategorieNaam";
            lbl_CategorieNaam.Size = new Size(150, 28);
            lbl_CategorieNaam.TabIndex = 4;
            lbl_CategorieNaam.Text = "Categorie naam";
            // 
            // tbx_CategorieNaam
            // 
            tbx_CategorieNaam.Location = new Point(58, 152);
            tbx_CategorieNaam.Name = "tbx_CategorieNaam";
            tbx_CategorieNaam.Size = new Size(179, 27);
            tbx_CategorieNaam.TabIndex = 5;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(11, 229);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 6;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(159, 229);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(127, 39);
            btn_Toevoegen.TabIndex = 7;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // frmCategorieToevoegen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 291);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Controls.Add(tbx_CategorieNaam);
            Controls.Add(lbl_CategorieNaam);
            Controls.Add(lbl_CatToevoegen);
            Name = "frmCategorieToevoegen";
            Text = "frmCategorieToevoegen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CatToevoegen;
        private Label lbl_CategorieNaam;
        private TextBox tbx_CategorieNaam;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btn_Terug;
        private Button btn_Toevoegen;
    }
}