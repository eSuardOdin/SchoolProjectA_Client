namespace SchoolProjectA_Client
{
    partial class Connexion
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
            validBtn = new Button();
            loginTxtBox = new TextBox();
            pwdTextBox = new TextBox();
            SuspendLayout();
            // 
            // validBtn
            // 
            validBtn.Location = new Point(170, 172);
            validBtn.Name = "validBtn";
            validBtn.Size = new Size(75, 23);
            validBtn.TabIndex = 0;
            validBtn.Text = "Go";
            validBtn.UseVisualStyleBackColor = true;
            // 
            // loginTxtBox
            // 
            loginTxtBox.Location = new Point(127, 48);
            loginTxtBox.Name = "loginTxtBox";
            loginTxtBox.Size = new Size(168, 23);
            loginTxtBox.TabIndex = 1;
            // 
            // pwdTextBox
            // 
            pwdTextBox.Location = new Point(127, 94);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Size = new Size(168, 23);
            pwdTextBox.TabIndex = 2;
            pwdTextBox.UseSystemPasswordChar = true;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 222);
            Controls.Add(pwdTextBox);
            Controls.Add(loginTxtBox);
            Controls.Add(validBtn);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button validBtn;
        private TextBox loginTxtBox;
        private TextBox pwdTextBox;
    }
}