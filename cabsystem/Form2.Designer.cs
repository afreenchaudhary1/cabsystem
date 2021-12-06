
namespace cabsystem
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signupbtn = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.signupbtn);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.usertxt);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.uname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(149, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 566);
            this.panel1.TabIndex = 0;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.Goldenrod;
            this.signupbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupbtn.Location = new System.Drawing.Point(305, 440);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(152, 42);
            this.signupbtn.TabIndex = 7;
            this.signupbtn.Text = "Signup";
            this.signupbtn.UseVisualStyleBackColor = false;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.loginbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton.Location = new System.Drawing.Point(307, 349);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(150, 46);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(276, 243);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(339, 27);
            this.passtxt.TabIndex = 5;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(276, 168);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(339, 27);
            this.usertxt.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(87, 243);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(122, 27);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uname.Location = new System.Drawing.Point(87, 168);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(127, 27);
            this.uname.TabIndex = 2;
            this.uname.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(305, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(996, 654);
            this.Controls.Add(this.panel1);
            this.Name = "loginpage";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button signupbtn;
    }
}