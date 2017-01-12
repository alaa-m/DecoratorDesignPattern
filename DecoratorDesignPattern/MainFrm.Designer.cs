namespace DecoratorDesignPattern
{
    partial class MainFrm
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
            this.ram8GBOption = new System.Windows.Forms.RadioButton();
            this.ram16GBOption = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mdlLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HDD128SSDOption = new System.Windows.Forms.RadioButton();
            this.HDD256SSDOption = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ram8GBOption
            // 
            this.ram8GBOption.AutoSize = true;
            this.ram8GBOption.Location = new System.Drawing.Point(30, 19);
            this.ram8GBOption.Name = "ram8GBOption";
            this.ram8GBOption.Size = new System.Drawing.Size(71, 17);
            this.ram8GBOption.TabIndex = 0;
            this.ram8GBOption.Text = "Ram 8 GB";
            this.ram8GBOption.UseVisualStyleBackColor = true;
            // 
            // ram16GBOption
            // 
            this.ram16GBOption.AutoSize = true;
            this.ram16GBOption.Location = new System.Drawing.Point(30, 52);
            this.ram16GBOption.Name = "ram16GBOption";
            this.ram16GBOption.Size = new System.Drawing.Size(77, 17);
            this.ram16GBOption.TabIndex = 1;
            this.ram16GBOption.Text = "Ram 16 GB";
            this.ram16GBOption.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ram8GBOption);
            this.groupBox1.Controls.Add(this.ram16GBOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra RAM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Compute Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer Price:";
            // 
            // mdlLbl
            // 
            this.mdlLbl.AutoSize = true;
            this.mdlLbl.Location = new System.Drawing.Point(109, 287);
            this.mdlLbl.Name = "mdlLbl";
            this.mdlLbl.Size = new System.Drawing.Size(0, 13);
            this.mdlLbl.TabIndex = 5;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(112, 312);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(23, 13);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HDD128SSDOption);
            this.groupBox2.Controls.Add(this.HDD256SSDOption);
            this.groupBox2.Location = new System.Drawing.Point(14, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra HDD";
            // 
            // HDD128SSDOption
            // 
            this.HDD128SSDOption.AutoSize = true;
            this.HDD128SSDOption.Location = new System.Drawing.Point(30, 19);
            this.HDD128SSDOption.Name = "HDD128SSDOption";
            this.HDD128SSDOption.Size = new System.Drawing.Size(105, 17);
            this.HDD128SSDOption.TabIndex = 0;
            this.HDD128SSDOption.Text = "HDD 128 GB SSD";
            this.HDD128SSDOption.UseVisualStyleBackColor = true;
            // 
            // HDD256SSDOption
            // 
            this.HDD256SSDOption.AutoSize = true;
            this.HDD256SSDOption.Location = new System.Drawing.Point(30, 52);
            this.HDD256SSDOption.Name = "HDD256SSDOption";
            this.HDD256SSDOption.Size = new System.Drawing.Size(105, 17);
            this.HDD256SSDOption.TabIndex = 1;
            this.HDD256SSDOption.Text = "HDD 256 GB SSD";
            this.HDD256SSDOption.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.mdlLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "Computer Assembling Decorator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ram8GBOption;
        private System.Windows.Forms.RadioButton ram16GBOption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mdlLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton HDD128SSDOption;
        private System.Windows.Forms.RadioButton HDD256SSDOption;
    }
}

