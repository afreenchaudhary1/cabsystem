
namespace cabsystem
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.driver = new System.Windows.Forms.Button();
            this.cab = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reg1 = new System.Windows.Forms.Button();
            this.reg2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(424, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Goldenrod;
            this.home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(-3, 107);
            this.home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(341, 68);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            // 
            // driver
            // 
            this.driver.BackColor = System.Drawing.Color.Goldenrod;
            this.driver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driver.Location = new System.Drawing.Point(330, 107);
            this.driver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(361, 68);
            this.driver.TabIndex = 2;
            this.driver.Text = "Drivers";
            this.driver.UseVisualStyleBackColor = false;
            // 
            // cab
            // 
            this.cab.BackColor = System.Drawing.Color.Goldenrod;
            this.cab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cab.Location = new System.Drawing.Point(689, 107);
            this.cab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cab.Name = "cab";
            this.cab.Size = new System.Drawing.Size(341, 68);
            this.cab.TabIndex = 3;
            this.cab.Text = "Cabs";
            this.cab.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // reg1
            // 
            this.reg1.BackColor = System.Drawing.Color.Goldenrod;
            this.reg1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg1.Location = new System.Drawing.Point(339, 338);
            this.reg1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg1.Name = "reg1";
            this.reg1.Size = new System.Drawing.Size(321, 68);
            this.reg1.TabIndex = 5;
            this.reg1.Text = "Drivers  Registration";
            this.reg1.UseVisualStyleBackColor = false;
            this.reg1.Click += new System.EventHandler(this.reg1_Click);
            // 
            // reg2
            // 
            this.reg2.BackColor = System.Drawing.Color.Goldenrod;
            this.reg2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg2.Location = new System.Drawing.Point(339, 435);
            this.reg2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg2.Name = "reg2";
            this.reg2.Size = new System.Drawing.Size(321, 68);
            this.reg2.TabIndex = 6;
            this.reg2.Text = "Cab  Registration";
            this.reg2.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1033, 615);
            this.Controls.Add(this.reg2);
            this.Controls.Add(this.reg1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cab);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label1);
            this.Name = "dashboard";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button driver;
        private System.Windows.Forms.Button cab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reg1;
        private System.Windows.Forms.Button reg2;
    }
}