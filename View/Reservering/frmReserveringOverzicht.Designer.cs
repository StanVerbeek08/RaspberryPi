namespace Proeflokaal_Project.View.Reservering
{
    partial class frmReserveringOverzicht
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
            lv_reservering = new ListView();
            lbl_Proeflokaal = new Label();
            SuspendLayout();
            // 
            // btn_Verwijderen
            // 
            btn_Verwijderen.ForeColor = SystemColors.MenuHighlight;
            btn_Verwijderen.Location = new Point(346, 295);
            btn_Verwijderen.Margin = new Padding(3, 2, 3, 2);
            btn_Verwijderen.Name = "btn_Verwijderen";
            btn_Verwijderen.Size = new Size(111, 29);
            btn_Verwijderen.TabIndex = 15;
            btn_Verwijderen.Text = "Verwijderen";
            btn_Verwijderen.UseVisualStyleBackColor = true;
            btn_Verwijderen.Click += btn_Verwijderen_Click;
            // 
            // btn_Bewerken
            // 
            btn_Bewerken.ForeColor = SystemColors.MenuHighlight;
            btn_Bewerken.Location = new Point(462, 295);
            btn_Bewerken.Margin = new Padding(3, 2, 3, 2);
            btn_Bewerken.Name = "btn_Bewerken";
            btn_Bewerken.Size = new Size(111, 29);
            btn_Bewerken.TabIndex = 14;
            btn_Bewerken.Text = "Bewerken";
            btn_Bewerken.UseVisualStyleBackColor = true;
            btn_Bewerken.Click += btn_Bewerken_Click;
            // 
            // btn_Toevoegen
            // 
            btn_Toevoegen.ForeColor = SystemColors.MenuHighlight;
            btn_Toevoegen.Location = new Point(578, 295);
            btn_Toevoegen.Margin = new Padding(3, 2, 3, 2);
            btn_Toevoegen.Name = "btn_Toevoegen";
            btn_Toevoegen.Size = new Size(111, 29);
            btn_Toevoegen.TabIndex = 13;
            btn_Toevoegen.Text = "Toevoegen";
            btn_Toevoegen.UseVisualStyleBackColor = true;
            btn_Toevoegen.Click += btn_Toevoegen_Click;
            // 
            // btn_Terug
            // 
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(10, 295);
            btn_Terug.Margin = new Padding(3, 2, 3, 2);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(111, 29);
            btn_Terug.TabIndex = 12;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // lv_reservering
            // 
            lv_reservering.Location = new Point(90, 56);
            lv_reservering.Margin = new Padding(3, 2, 3, 2);
            lv_reservering.MultiSelect = false;
            lv_reservering.Name = "lv_reservering";
            lv_reservering.Size = new Size(512, 182);
            lv_reservering.TabIndex = 10;
            lv_reservering.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Proeflokaal
            // 
            lbl_Proeflokaal.AutoSize = true;
            lbl_Proeflokaal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Proeflokaal.ForeColor = SystemColors.MenuHighlight;
            lbl_Proeflokaal.Location = new Point(278, 9);
            lbl_Proeflokaal.Name = "lbl_Proeflokaal";
            lbl_Proeflokaal.Size = new Size(165, 32);
            lbl_Proeflokaal.TabIndex = 9;
            lbl_Proeflokaal.Text = "Reserveringen";
            // 
            // frmReserveringOverzicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Verwijderen);
            Controls.Add(btn_Bewerken);
            Controls.Add(btn_Toevoegen);
            Controls.Add(btn_Terug);
            Controls.Add(lv_reservering);
            Controls.Add(lbl_Proeflokaal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReserveringOverzicht";
            Text = "Reservering overzicht";
            Load += frmReserveringOverzicht_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Verwijderen;
        private Button btn_Bewerken;
        private Button btn_Toevoegen;
        private Button btn_Terug;
        private ListView lv_reservering;
        private Label lbl_Proeflokaal;
    }
}