
namespace cabsystem
{
    partial class Form6
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
            this.home = new System.Windows.Forms.Button();
            this.driver = new System.Windows.Forms.Button();
            this.cab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vieww = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Goldenrod;
            this.home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(0, 89);
            this.home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(341, 68);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // driver
            // 
            this.driver.BackColor = System.Drawing.Color.Goldenrod;
            this.driver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driver.Location = new System.Drawing.Point(336, 89);
            this.driver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(361, 68);
            this.driver.TabIndex = 3;
            this.driver.Text = "Drivers";
            this.driver.UseVisualStyleBackColor = false;
            // 
            // cab
            // 
            this.cab.BackColor = System.Drawing.Color.Goldenrod;
            this.cab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cab.Location = new System.Drawing.Point(690, 89);
            this.cab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cab.Name = "cab";
            this.cab.Size = new System.Drawing.Size(341, 68);
            this.cab.TabIndex = 4;
            this.cab.Text = "Cabs";
            this.cab.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "driver record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 310);
            this.dataGridView1.TabIndex = 6;
            // 
            // vieww
            // 
            this.vieww.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vieww.Location = new System.Drawing.Point(12, 600);
            this.vieww.Name = "vieww";
            this.vieww.Size = new System.Drawing.Size(163, 43);
            this.vieww.TabIndex = 7;
            this.vieww.Text = "view";
            this.vieww.UseVisualStyleBackColor = true;
            this.vieww.Click += new System.EventHandler(this.vieww_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(414, 600);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(163, 42);
            this.delete.TabIndex = 8;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(452, 563);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(125, 27);
            this.fname.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(414, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(825, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1029, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.vieww);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cab);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.home);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel v;
        private System.Windows.Forms.Label fp1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button u4;
        private System.Windows.Forms.Button u3;
        private System.Windows.Forms.Button u2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button u1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aadhar;
        private System.Windows.Forms.TextBox licence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button driver;
        private System.Windows.Forms.Button cab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button vieww;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}