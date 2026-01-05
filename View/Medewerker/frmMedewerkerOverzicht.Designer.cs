namespace Proeflokaal_Project.View.Medewerker
{
    partial class frmMedewerkerOverzicht
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
            lv_medewerker = new ListView();
            lbl_Proeflokaal = new Label();
            SuspendLayout();
            // 
            // btn_Verwijderen
            // 
            btn_Verwijderen.ForeColor = SystemColors.MenuHighlight;
            btn_Verwijderen.Location = new Point(395, 392);
            btn_Verwijderen.Name = "btn_Verwijderen";
            btn_Verwijderen.Size = new Size(127, 39);
            btn_Verwijderen.TabIndex = 14;
            btn_Verwijderen.Text = "Verwijderen";
            btn_Verwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_Bewerken
            // 
            btn_Bewerken.ForeColor = SystemColors.MenuHighlight;
            btn_Bewerken.Location = new Point(528, 392);
            btn_Bewerken.Name = "btn_Bewerken";
            btn_Bewerken.Size = new Size(127, 39);
            btn_Bewerken.TabIndex = 13;
            btn_Bewerken.Text = "Bewerken";
            btn_Bewerken.UseVisualStyleBackColor = true;
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(661, 392);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(127, 39);
            btn_Toevoegen.TabIndex = 12;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(12, 392);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(127, 39);
            btn_Terug.TabIndex = 11;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // lv_medewerker
            // 
            lv_medewerker.Location = new Point(103, 73);
            lv_medewerker.MultiSelect = false;
            lv_medewerker.Name = "lv_medewerker";
            lv_medewerker.Size = new Size(584, 242);
            lv_medewerker.TabIndex = 10;
            lv_medewerker.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Proeflokaal
            // 
            lbl_Proeflokaal.AutoSize = true;
            lbl_Proeflokaal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Proeflokaal.ForeColor = SystemColors.MenuHighlight;
            lbl_Proeflokaal.Location = new Point(298, 19);
            lbl_Proeflokaal.Name = "lbl_Proeflokaal";
            lbl_Proeflokaal.Size = new Size(197, 41);
            lbl_Proeflokaal.TabIndex = 9;
            lbl_Proeflokaal.Text = "Medewerkers";
            // 
            // frmMedewerkerOverzicht
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Verwijderen);
            Controls.Add(btn_Bewerken);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Controls.Add(lv_medewerker);
            Controls.Add(lbl_Proeflokaal);
            Name = "frmMedewerkerOverzicht";
            Text = "Medewerker overzicht";
            Load += frmMedewerkerOverzicht_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Verwijderen;
        private Button btn_Bewerken;
        private Button btn_Toevoegen;
        private Button btn_Terug;
        private ListView lv_medewerker;
        private Label lbl_Proeflokaal;
    }
}