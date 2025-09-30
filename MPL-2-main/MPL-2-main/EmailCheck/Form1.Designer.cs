namespace EmailCheck
{
    partial class Form1
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
            email = new TextBox();
            button1 = new Button();
            password = new TextBox();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(12, 93);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(313, 27);
            email.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 196);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(12, 140);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(313, 27);
            password.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(515, 356);
            Controls.Add(password);
            Controls.Add(button1);
            Controls.Add(email);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Email control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Button button1;
        private TextBox password;
    }
}
