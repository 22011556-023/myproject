﻿namespace myproject
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
            label1 = new Label();
            label2 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 102);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(165, 65);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(124, 23);
            txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(165, 99);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(124, 23);
            txt_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(80, 142);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(181, 142);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 28);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 188);
            Controls.Add(label3);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "user login form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Button btn_login;
        private Button btn_exit;
        private Label label3;
    }
}
