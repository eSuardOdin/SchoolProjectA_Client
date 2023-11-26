namespace SchoolProjectA_ClientA
{
    partial class ConnexionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTBox = new TextBox();
            pwdTBox = new TextBox();
            connectBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // loginTBox
            // 
            loginTBox.Location = new Point(130, 62);
            loginTBox.Name = "loginTBox";
            loginTBox.Size = new Size(197, 23);
            loginTBox.TabIndex = 0;
            // 
            // pwdTBox
            // 
            pwdTBox.Location = new Point(130, 115);
            pwdTBox.Name = "pwdTBox";
            pwdTBox.Size = new Size(197, 23);
            pwdTBox.TabIndex = 1;
            pwdTBox.UseSystemPasswordChar = true;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(186, 176);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(75, 23);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "Enter";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 3;
            label1.Text = "MoniWatch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 118);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // ConnexionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 249);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(connectBtn);
            Controls.Add(pwdTBox);
            Controls.Add(loginTBox);
            MaximizeBox = false;
            Name = "ConnexionForm";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTBox;
        private TextBox pwdTBox;
        private Button connectBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}