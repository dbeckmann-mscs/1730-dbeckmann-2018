namespace dbeckmann_2b1
{
    partial class Form2b1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2b1));
            this.txtUSDTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountAntigua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUSDSwaziland = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRatesSwaziland = new System.Windows.Forms.TextBox();
            this.txtUSDBhutan = new System.Windows.Forms.TextBox();
            this.txtAmountSwaziland = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtUSDBarbados = new System.Windows.Forms.TextBox();
            this.txtRatesBhutan = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtAmountBhutan = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtRatesAntigua = new System.Windows.Forms.TextBox();
            this.txtRatesBarbados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountBarbados = new System.Windows.Forms.TextBox();
            this.txtUSDAntigua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUSDTotal
            // 
            this.txtUSDTotal.Location = new System.Drawing.Point(536, 187);
            this.txtUSDTotal.Name = "txtUSDTotal";
            this.txtUSDTotal.ReadOnly = true;
            this.txtUSDTotal.Size = new System.Drawing.Size(91, 20);
            this.txtUSDTotal.TabIndex = 57;
            this.txtUSDTotal.TabStop = false;
            this.txtUSDTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "+";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReset.Location = new System.Drawing.Point(181, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Antigua - Dollar";
            // 
            // txtAmountAntigua
            // 
            this.txtAmountAntigua.Location = new System.Drawing.Point(84, 131);
            this.txtAmountAntigua.Name = "txtAmountAntigua";
            this.txtAmountAntigua.Size = new System.Drawing.Size(91, 20);
            this.txtAmountAntigua.TabIndex = 31;
            this.txtAmountAntigua.Text = "0.00";
            this.txtAmountAntigua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAntigua.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Dollar U.S.";
            // 
            // txtUSDSwaziland
            // 
            this.txtUSDSwaziland.Location = new System.Drawing.Point(375, 187);
            this.txtUSDSwaziland.Name = "txtUSDSwaziland";
            this.txtUSDSwaziland.ReadOnly = true;
            this.txtUSDSwaziland.Size = new System.Drawing.Size(91, 20);
            this.txtUSDSwaziland.TabIndex = 56;
            this.txtUSDSwaziland.TabStop = false;
            this.txtUSDSwaziland.Text = "0.00";
            this.txtUSDSwaziland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDSwaziland.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(181, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 85);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // txtRatesSwaziland
            // 
            this.txtRatesSwaziland.Location = new System.Drawing.Point(375, 157);
            this.txtRatesSwaziland.Name = "txtRatesSwaziland";
            this.txtRatesSwaziland.Size = new System.Drawing.Size(91, 20);
            this.txtRatesSwaziland.TabIndex = 45;
            this.txtRatesSwaziland.Text = "0.06571";
            this.txtRatesSwaziland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRatesSwaziland.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtUSDBhutan
            // 
            this.txtUSDBhutan.Location = new System.Drawing.Point(278, 187);
            this.txtUSDBhutan.Name = "txtUSDBhutan";
            this.txtUSDBhutan.ReadOnly = true;
            this.txtUSDBhutan.Size = new System.Drawing.Size(91, 20);
            this.txtUSDBhutan.TabIndex = 55;
            this.txtUSDBhutan.TabStop = false;
            this.txtUSDBhutan.Text = "0.00";
            this.txtUSDBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDBhutan.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtAmountSwaziland
            // 
            this.txtAmountSwaziland.Location = new System.Drawing.Point(375, 131);
            this.txtAmountSwaziland.Name = "txtAmountSwaziland";
            this.txtAmountSwaziland.Size = new System.Drawing.Size(91, 20);
            this.txtAmountSwaziland.TabIndex = 36;
            this.txtAmountSwaziland.Text = "0.00";
            this.txtAmountSwaziland.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountSwaziland.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(278, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 85);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // txtUSDBarbados
            // 
            this.txtUSDBarbados.Location = new System.Drawing.Point(181, 187);
            this.txtUSDBarbados.Name = "txtUSDBarbados";
            this.txtUSDBarbados.ReadOnly = true;
            this.txtUSDBarbados.Size = new System.Drawing.Size(91, 20);
            this.txtUSDBarbados.TabIndex = 54;
            this.txtUSDBarbados.TabStop = false;
            this.txtUSDBarbados.Text = "0.00";
            this.txtUSDBarbados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDBarbados.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtRatesBhutan
            // 
            this.txtRatesBhutan.Location = new System.Drawing.Point(278, 157);
            this.txtRatesBhutan.Name = "txtRatesBhutan";
            this.txtRatesBhutan.Size = new System.Drawing.Size(91, 20);
            this.txtRatesBhutan.TabIndex = 44;
            this.txtRatesBhutan.Text = "0.01390";
            this.txtRatesBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRatesBhutan.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(375, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 85);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // txtAmountBhutan
            // 
            this.txtAmountBhutan.Location = new System.Drawing.Point(278, 131);
            this.txtAmountBhutan.Name = "txtAmountBhutan";
            this.txtAmountBhutan.Size = new System.Drawing.Size(91, 20);
            this.txtAmountBhutan.TabIndex = 35;
            this.txtAmountBhutan.Text = "0.00";
            this.txtAmountBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBhutan.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(536, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 85);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // txtRatesAntigua
            // 
            this.txtRatesAntigua.Location = new System.Drawing.Point(84, 161);
            this.txtRatesAntigua.Name = "txtRatesAntigua";
            this.txtRatesAntigua.Size = new System.Drawing.Size(91, 20);
            this.txtRatesAntigua.TabIndex = 41;
            this.txtRatesAntigua.Text = "0.37037";
            this.txtRatesAntigua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRatesAntigua.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtRatesBarbados
            // 
            this.txtRatesBarbados.Location = new System.Drawing.Point(181, 161);
            this.txtRatesBarbados.Name = "txtRatesBarbados";
            this.txtRatesBarbados.Size = new System.Drawing.Size(91, 20);
            this.txtRatesBarbados.TabIndex = 42;
            this.txtRatesBarbados.Text = "0.50";
            this.txtRatesBarbados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRatesBarbados.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Rates";
            // 
            // txtAmountBarbados
            // 
            this.txtAmountBarbados.Location = new System.Drawing.Point(181, 131);
            this.txtAmountBarbados.Name = "txtAmountBarbados";
            this.txtAmountBarbados.Size = new System.Drawing.Size(91, 20);
            this.txtAmountBarbados.TabIndex = 33;
            this.txtAmountBarbados.Text = "0.00";
            this.txtAmountBarbados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBarbados.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtUSDAntigua
            // 
            this.txtUSDAntigua.Location = new System.Drawing.Point(84, 187);
            this.txtUSDAntigua.Name = "txtUSDAntigua";
            this.txtUSDAntigua.ReadOnly = true;
            this.txtUSDAntigua.Size = new System.Drawing.Size(91, 20);
            this.txtUSDAntigua.TabIndex = 53;
            this.txtUSDAntigua.TabStop = false;
            this.txtUSDAntigua.Text = "0.00";
            this.txtUSDAntigua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDAntigua.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Barbados - Dollar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "United States - Dollar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Bhutan - Ngultan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Swaziland - Lilangeni";
            // 
            // Form2b1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 295);
            this.Controls.Add(this.txtUSDTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountAntigua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUSDSwaziland);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtRatesSwaziland);
            this.Controls.Add(this.txtUSDBhutan);
            this.Controls.Add(this.txtAmountSwaziland);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUSDBarbados);
            this.Controls.Add(this.txtRatesBhutan);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtAmountBhutan);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtRatesAntigua);
            this.Controls.Add(this.txtRatesBarbados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmountBarbados);
            this.Controls.Add(this.txtUSDAntigua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Form2b1";
            this.Text = "Form 2a1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUSDTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountAntigua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUSDSwaziland;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtRatesSwaziland;
        private System.Windows.Forms.TextBox txtUSDBhutan;
        private System.Windows.Forms.TextBox txtAmountSwaziland;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUSDBarbados;
        private System.Windows.Forms.TextBox txtRatesBhutan;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtAmountBhutan;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtRatesAntigua;
        private System.Windows.Forms.TextBox txtRatesBarbados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountBarbados;
        private System.Windows.Forms.TextBox txtUSDAntigua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

