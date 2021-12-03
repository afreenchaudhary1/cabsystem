
namespace cabsystem
{
    partial class signup_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Button();
            this.pass2txt = new System.Windows.Forms.TextBox();
            this.pass1txt = new System.Windows.Forms.TextBox();
            this.utxt = new System.Windows.Forms.TextBox();
            this.etxt = new System.Windows.Forms.TextBox();
            this.ltxt = new System.Windows.Forms.TextBox();
            this.ftxt = new System.Windows.Forms.TextBox();
            this.pass2 = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.pass2txt);
            this.panel1.Controls.Add(this.pass1txt);
            this.panel1.Controls.Add(this.utxt);
            this.panel1.Controls.Add(this.etxt);
            this.panel1.Controls.Add(this.ltxt);
            this.panel1.Controls.Add(this.ftxt);
            this.panel1.Controls.Add(this.pass2);
            this.panel1.Controls.Add(this.pass1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(68, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 527);
            this.panel1.TabIndex = 0;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.register.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(371, 454);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(195, 44);
            this.register.TabIndex = 15;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // pass2txt
            // 
            this.pass2txt.Location = new System.Drawing.Point(275, 399);
            this.pass2txt.Name = "pass2txt";
            this.pass2txt.Size = new System.Drawing.Size(420, 27);
            this.pass2txt.TabIndex = 14;
            // 
            // pass1txt
            // 
            this.pass1txt.Location = new System.Drawing.Point(275, 335);
            this.pass1txt.Name = "pass1txt";
            this.pass1txt.Size = new System.Drawing.Size(420, 27);
            this.pass1txt.TabIndex = 13;
            // 
            // utxt
            // 
            this.utxt.Location = new System.Drawing.Point(264, 278);
            this.utxt.Name = "utxt";
            this.utxt.Size = new System.Drawing.Size(431, 27);
            this.utxt.TabIndex = 12;
            // 
            // etxt
            // 
            this.etxt.Location = new System.Drawing.Point(264, 210);
            this.etxt.Name = "etxt";
            this.etxt.Size = new System.Drawing.Size(431, 27);
            this.etxt.TabIndex = 11;
            // 
            // ltxt
            // 
            this.ltxt.Location = new System.Drawing.Point(610, 151);
            this.ltxt.Name = "ltxt";
            this.ltxt.Size = new System.Drawing.Size(216, 27);
            this.ltxt.TabIndex = 10;
            // 
            // ftxt
            // 
            this.ftxt.BackColor = System.Drawing.SystemColors.Window;
            this.ftxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ftxt.Location = new System.Drawing.Point(201, 151);
            this.ftxt.Name = "ftxt";
            this.ftxt.Size = new System.Drawing.Size(210, 27);
            this.ftxt.TabIndex = 9;
            // 
            // pass2
            // 
            this.pass2.AutoSize = true;
            this.pass2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass2.Location = new System.Drawing.Point(79, 398);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(190, 23);
            this.pass2.TabIndex = 8;
            this.pass2.Text = "Confirm Password";
            // 
            // pass1
            // 
            this.pass1.AutoSize = true;
            this.pass1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass1.Location = new System.Drawing.Point(79, 339);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(179, 23);
            this.pass1.TabIndex = 7;
            this.pass1.Text = "Create Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(79, 278);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(111, 23);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(79, 216);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 21);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname.Location = new System.Drawing.Point(481, 155);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(114, 23);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(79, 155);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(116, 23);
            this.fname.TabIndex = 2;
            this.fname.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(387, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signup_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1033, 664);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signup_page";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pass2;
        private System.Windows.Forms.Label pass1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass2txt;
        private System.Windows.Forms.TextBox pass1txt;
        private System.Windows.Forms.TextBox utxt;
        private System.Windows.Forms.TextBox etxt;
        private System.Windows.Forms.TextBox ltxt;
        private System.Windows.Forms.TextBox ftxt;
        private System.Windows.Forms.Button register;
    }
}

