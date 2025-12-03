
namespace YemenWhatsApp
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            txtLoginPassword = new TextBox();
            txtLoginEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtLoginPassword);
            groupBox1.Controls.Add(txtLoginEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(176, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "تسجيل الدخول";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.FromArgb(192, 255, 192);
            txtLoginPassword.Location = new Point(117, 190);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(241, 27);
            txtLoginPassword.TabIndex = 3;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.BackColor = Color.FromArgb(192, 255, 192);
            txtLoginEmail.Location = new Point(117, 134);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(241, 27);
            txtLoginEmail.TabIndex = 2;
            txtLoginEmail.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Location = new Point(19, 190);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "كلمة المرور";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(6, 137);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "البريد الإلكتروني";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(192, 255, 192);
            txtName.Location = new Point(117, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Location = new Point(29, 86);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 0;
            label3.Text = "الاسم ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Location = new Point(19, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(352, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(123, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "نسيت كلمة المرور";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(77, 37);
            label4.Name = "label4";
            label4.Size = new Size(259, 28);
            label4.TabIndex = 10;
            label4.Text = "تسجيل الدخول الى يمن وتس اب";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLoginEmail;
        private Label label2;
        private Label label1;
        private TextBox txtLoginPassword;
        private TextBox txtName;
        private Label label3;
        private Button btnLogin;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}