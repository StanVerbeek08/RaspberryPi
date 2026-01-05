namespace Proeflokaal_Project.View.Subcategorie
{
    partial class frmSubcategorie
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
            btn_Verwijderen = new Button();
            btn_Bewerken = new Button();
            btn_Toevoegen = new Button();
            btn_Terug = new Button();
            lv_subcategorie = new ListView();
            lbl_Subcategorie = new Label();
            SuspendLayout();
            // 
            // btn_Verwijderen
            // 
            btn_Verwijderen.ForeColor = SystemColors.MenuHighlight;
            btn_Verwijderen.Location = new Point(395, 392);
            btn_Verwijderen.Name = "btn_Verwijderen";
            btn_Verwijderen.Size = new Size(127, 39);
            btn_Verwijderen.TabIndex = 15;
            btn_Verwijderen.Text = "Verwijderen";
            btn_Verwijderen.UseVisualStyleBackColor = true;
            btn_Verwijderen.Click += btn_Verwijderen_Click;
            // 
            // btn_Bewerken
            // 
            btn_Bewerken.ForeColor = SystemColors.MenuHighlight;
            btn_Bewerken.Location = new Point(528, 392);
            btn_Bewerken.Name = "btn_Bewerken";
            btn_Bewerken.Size = new Size(127, 39);
            btn_Bewerken.TabIndex = 14;
            btn_Bewerken.Text = "Bewerken";
            btn_Bewerken.UseVisualStyleBackColor = true;
            btn_Bewerken.Click += btn_Bewerken_Click;
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(661, 392);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(127, 39);
            btn_Toevoegen.TabIndex = 13;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(12, 392);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 12;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // lv_subcategorie
            // 
            lv_subcategorie.Location = new Point(103, 73);
            lv_subcategorie.MultiSelect = false;
            lv_subcategorie.Name = "lv_subcategorie";
            lv_subcategorie.Size = new Size(584, 242);
            lv_subcategorie.TabIndex = 10;
            lv_subcategorie.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Subcategorie
            // 
            lbl_Subcategorie.AutoSize = true;
            lbl_Subcategorie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subcategorie.ForeColor = SystemColors.MenuHighlight;
            lbl_Subcategorie.Location = new Point(298, 19);
            lbl_Subcategorie.Name = "lbl_Subcategorie";
            lbl_Subcategorie.Size = new Size(226, 41);
            lbl_Subcategorie.TabIndex = 9;
            lbl_Subcategorie.Text = "Subcategorieën";
            // 
            // frmSubcategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Verwijderen);
            Controls.Add(btn_Bewerken);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Controls.Add(lv_subcategorie);
            Controls.Add(lbl_Subcategorie);
            Name = "frmSubcategorie";
            Text = "Subcategorie overzicht";
            Load += frmSubcategorieOverzicht_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Verwijderen;
        private Button btn_Bewerken;
        private Button btn_Toevoegen;
        private Button btn_Terug;
        private ListView lv_subcategorie;
        private Label lbl_Subcategorie;
    }
}