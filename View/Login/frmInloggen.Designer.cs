namespace Proeflokaal_Project.View.Login
{
    partial class frmInloggen
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
            lbl_Inloggen = new Label();
            lbl_Email = new Label();
            lbl_Wachtwoord = new Label();
            tbx_Email = new TextBox();
            tbx_Wachtwoord = new TextBox();
            btn_Inloggen = new Button();
            btn_Terug = new Button();
            SuspendLayout();
            // 
            // lbl_Inloggen
            // 
            lbl_Inloggen.AutoSize = true;
            lbl_Inloggen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Inloggen.ForeColor = SystemColors.MenuHighlight;
            lbl_Inloggen.Location = new Point(84, 46);
            lbl_Inloggen.Name = "lbl_Inloggen";
            lbl_Inloggen.Size = new Size(137, 41);
            lbl_Inloggen.TabIndex = 2;
            lbl_Inloggen.Text = "Inloggen";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = SystemColors.MenuHighlight;
            lbl_Email.Location = new Point(121, 124);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(59, 28);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // lbl_Wachtwoord
            // 
            lbl_Wachtwoord.AutoSize = true;
            lbl_Wachtwoord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Wachtwoord.ForeColor = SystemColors.MenuHighlight;
            lbl_Wachtwoord.Location = new Point(92, 196);
            lbl_Wachtwoord.Name = "lbl_Wachtwoord";
            lbl_Wachtwoord.Size = new Size(124, 28);
            lbl_Wachtwoord.TabIndex = 4;
            lbl_Wachtwoord.Text = "Wachtwoord";
            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(91, 155);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(125, 27);
            tbx_Email.TabIndex = 5;
            // 
            // tbx_Wachtwoord
            // 
            tbx_Wachtwoord.Location = new Point(91, 228);
            tbx_Wachtwoord.Name = "tbx_Wachtwoord";
            tbx_Wachtwoord.Size = new Size(125, 27);
            tbx_Wachtwoord.TabIndex = 6;
            tbx_Wachtwoord.UseSystemPasswordChar = true;
            // 
            // btn_Inloggen
            // 
            btn_Inloggen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Inloggen.ForeColor = SystemColors.MenuHighlight;
            btn_Inloggen.Location = new Point(169, 304);
            btn_Inloggen.Name = "btn_Inloggen";
            btn_Inloggen.Size = new Size(122, 43);
            btn_Inloggen.TabIndex = 7;
            btn_Inloggen.Text = "Inloggen";
            btn_Inloggen.UseVisualStyleBackColor = true;
            // 
            // btn_Terug
            // 
            btn_Terug.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Terug.ForeColor = SystemColors.MenuHighlight;
            btn_Terug.Location = new Point(12, 304);
            btn_Terug.Name = "btn_Terug";
            btn_Terug.Size = new Size(122, 43);
            btn_Terug.TabIndex = 8;
            btn_Terug.Text = "Terug";
            btn_Terug.UseVisualStyleBackColor = true;
            btn_Terug.Click += btn_Terug_Click;
            // 
            // frmInloggen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 364);
            Controls.Add(btn_Terug);
            Controls.Add(btn_Inloggen);
            Controls.Add(tbx_Wachtwoord);
            Controls.Add(tbx_Email);
            Controls.Add(lbl_Wachtwoord);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Inloggen);
            Name = "frmInloggen";
            Text = "Inloggen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Inloggen;
        private Label lbl_Email;
        private Label lbl_Wachtwoord;
        private TextBox tbx_Email;
        private TextBox tbx_Wachtwoord;
        private Button btn_Inloggen;
        private Button btn_Terug;
    }
}