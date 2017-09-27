namespace FacadePattern
{
    partial class Form1
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
            this.airlineLabel = new System.Windows.Forms.Label();
            this.hotelLabel = new System.Windows.Forms.Label();
            this.rentalLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dlt_r_btn = new System.Windows.Forms.RadioButton();
            this.utd_r_btn = new System.Windows.Forms.RadioButton();
            this.sw_r_btn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hld_r_btn = new System.Windows.Forms.RadioButton();
            this.mrtt_r_btn = new System.Windows.Forms.RadioButton();
            this.hltn_r_btn = new System.Windows.Forms.RadioButton();
            this.fltLabel = new System.Windows.Forms.Label();
            this.fltPriceLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nocar_r_btn = new System.Windows.Forms.RadioButton();
            this.luxry_r_btn = new System.Windows.Forms.RadioButton();
            this.suv_r_btn = new System.Windows.Forms.RadioButton();
            this.car_r_btn = new System.Windows.Forms.RadioButton();
            this.htlPriceLabel = new System.Windows.Forms.Label();
            this.htlLabel = new System.Windows.Forms.Label();
            this.rtlPriceLabel = new System.Windows.Forms.Label();
            this.rtlLabel = new System.Windows.Forms.Label();
            this.rb_chk_btn = new System.Windows.Forms.CheckBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.bestBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Location = new System.Drawing.Point(24, 12);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(40, 13);
            this.airlineLabel.TabIndex = 0;
            this.airlineLabel.Text = "Airlines";
            // 
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Location = new System.Drawing.Point(24, 111);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(37, 13);
            this.hotelLabel.TabIndex = 1;
            this.hotelLabel.Text = "Hotels";
            // 
            // rentalLabel
            // 
            this.rentalLabel.AutoSize = true;
            this.rentalLabel.Location = new System.Drawing.Point(24, 213);
            this.rentalLabel.Name = "rentalLabel";
            this.rentalLabel.Size = new System.Drawing.Size(62, 13);
            this.rentalLabel.TabIndex = 2;
            this.rentalLabel.Text = "Rental Cars";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dlt_r_btn);
            this.panel1.Controls.Add(this.utd_r_btn);
            this.panel1.Controls.Add(this.sw_r_btn);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 67);
            this.panel1.TabIndex = 3;
            // 
            // dlt_r_btn
            // 
            this.dlt_r_btn.AutoSize = true;
            this.dlt_r_btn.Location = new System.Drawing.Point(3, 3);
            this.dlt_r_btn.Name = "dlt_r_btn";
            this.dlt_r_btn.Size = new System.Drawing.Size(50, 17);
            this.dlt_r_btn.TabIndex = 3;
            this.dlt_r_btn.TabStop = true;
            this.dlt_r_btn.Text = "Delta";
            this.dlt_r_btn.UseVisualStyleBackColor = true;
            this.dlt_r_btn.CheckedChanged += new System.EventHandler(this.dlt_r_btn_CheckedChanged);
            // 
            // utd_r_btn
            // 
            this.utd_r_btn.AutoSize = true;
            this.utd_r_btn.Location = new System.Drawing.Point(3, 49);
            this.utd_r_btn.Name = "utd_r_btn";
            this.utd_r_btn.Size = new System.Drawing.Size(56, 17);
            this.utd_r_btn.TabIndex = 2;
            this.utd_r_btn.TabStop = true;
            this.utd_r_btn.Text = "United";
            this.utd_r_btn.UseVisualStyleBackColor = true;
            this.utd_r_btn.CheckedChanged += new System.EventHandler(this.utd_r_btn_CheckedChanged);
            // 
            // sw_r_btn
            // 
            this.sw_r_btn.AutoSize = true;
            this.sw_r_btn.Location = new System.Drawing.Point(3, 26);
            this.sw_r_btn.Name = "sw_r_btn";
            this.sw_r_btn.Size = new System.Drawing.Size(75, 17);
            this.sw_r_btn.TabIndex = 1;
            this.sw_r_btn.TabStop = true;
            this.sw_r_btn.Text = "Southwest";
            this.sw_r_btn.UseVisualStyleBackColor = true;
            this.sw_r_btn.CheckedChanged += new System.EventHandler(this.sw_r_btn_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hld_r_btn);
            this.panel2.Controls.Add(this.mrtt_r_btn);
            this.panel2.Controls.Add(this.hltn_r_btn);
            this.panel2.Location = new System.Drawing.Point(27, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 71);
            this.panel2.TabIndex = 4;
            // 
            // hld_r_btn
            // 
            this.hld_r_btn.AutoSize = true;
            this.hld_r_btn.Location = new System.Drawing.Point(3, 49);
            this.hld_r_btn.Name = "hld_r_btn";
            this.hld_r_btn.Size = new System.Drawing.Size(78, 17);
            this.hld_r_btn.TabIndex = 7;
            this.hld_r_btn.TabStop = true;
            this.hld_r_btn.Text = "Holiday Inn";
            this.hld_r_btn.UseVisualStyleBackColor = true;
            this.hld_r_btn.CheckedChanged += new System.EventHandler(this.hld_r_btn_CheckedChanged);
            // 
            // mrtt_r_btn
            // 
            this.mrtt_r_btn.AutoSize = true;
            this.mrtt_r_btn.Location = new System.Drawing.Point(3, 26);
            this.mrtt_r_btn.Name = "mrtt_r_btn";
            this.mrtt_r_btn.Size = new System.Drawing.Size(60, 17);
            this.mrtt_r_btn.TabIndex = 6;
            this.mrtt_r_btn.TabStop = true;
            this.mrtt_r_btn.Text = "Marriott";
            this.mrtt_r_btn.UseVisualStyleBackColor = true;
            this.mrtt_r_btn.CheckedChanged += new System.EventHandler(this.mrtt_r_btn_CheckedChanged);
            // 
            // hltn_r_btn
            // 
            this.hltn_r_btn.AutoSize = true;
            this.hltn_r_btn.Location = new System.Drawing.Point(3, 3);
            this.hltn_r_btn.Name = "hltn_r_btn";
            this.hltn_r_btn.Size = new System.Drawing.Size(52, 17);
            this.hltn_r_btn.TabIndex = 5;
            this.hltn_r_btn.TabStop = true;
            this.hltn_r_btn.Text = "Hilton";
            this.hltn_r_btn.UseVisualStyleBackColor = true;
            this.hltn_r_btn.CheckedChanged += new System.EventHandler(this.hltn_r_btn_CheckedChanged);
            // 
            // fltLabel
            // 
            this.fltLabel.AutoSize = true;
            this.fltLabel.Location = new System.Drawing.Point(162, 77);
            this.fltLabel.Name = "fltLabel";
            this.fltLabel.Size = new System.Drawing.Size(71, 13);
            this.fltLabel.TabIndex = 5;
            this.fltLabel.Text = "Price of flight:";
            // 
            // fltPriceLabel
            // 
            this.fltPriceLabel.AutoSize = true;
            this.fltPriceLabel.Location = new System.Drawing.Point(258, 77);
            this.fltPriceLabel.Name = "fltPriceLabel";
            this.fltPriceLabel.Size = new System.Drawing.Size(10, 13);
            this.fltPriceLabel.TabIndex = 6;
            this.fltPriceLabel.Text = " ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nocar_r_btn);
            this.panel3.Controls.Add(this.luxry_r_btn);
            this.panel3.Controls.Add(this.suv_r_btn);
            this.panel3.Controls.Add(this.car_r_btn);
            this.panel3.Location = new System.Drawing.Point(27, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 92);
            this.panel3.TabIndex = 7;
            // 
            // nocar_r_btn
            // 
            this.nocar_r_btn.AutoSize = true;
            this.nocar_r_btn.Location = new System.Drawing.Point(3, 3);
            this.nocar_r_btn.Name = "nocar_r_btn";
            this.nocar_r_btn.Size = new System.Drawing.Size(51, 17);
            this.nocar_r_btn.TabIndex = 8;
            this.nocar_r_btn.TabStop = true;
            this.nocar_r_btn.Text = "None";
            this.nocar_r_btn.UseVisualStyleBackColor = true;
            this.nocar_r_btn.CheckedChanged += new System.EventHandler(this.nocar_r_btn_CheckedChanged);
            // 
            // luxry_r_btn
            // 
            this.luxry_r_btn.AutoSize = true;
            this.luxry_r_btn.Location = new System.Drawing.Point(3, 72);
            this.luxry_r_btn.Name = "luxry_r_btn";
            this.luxry_r_btn.Size = new System.Drawing.Size(56, 17);
            this.luxry_r_btn.TabIndex = 7;
            this.luxry_r_btn.TabStop = true;
            this.luxry_r_btn.Text = "Luxury";
            this.luxry_r_btn.UseVisualStyleBackColor = true;
            this.luxry_r_btn.CheckedChanged += new System.EventHandler(this.luxry_r_btn_CheckedChanged);
            // 
            // suv_r_btn
            // 
            this.suv_r_btn.AutoSize = true;
            this.suv_r_btn.Location = new System.Drawing.Point(3, 49);
            this.suv_r_btn.Name = "suv_r_btn";
            this.suv_r_btn.Size = new System.Drawing.Size(47, 17);
            this.suv_r_btn.TabIndex = 6;
            this.suv_r_btn.TabStop = true;
            this.suv_r_btn.Text = "SUV";
            this.suv_r_btn.UseVisualStyleBackColor = true;
            this.suv_r_btn.CheckedChanged += new System.EventHandler(this.suv_r_btn_CheckedChanged);
            // 
            // car_r_btn
            // 
            this.car_r_btn.AutoSize = true;
            this.car_r_btn.Location = new System.Drawing.Point(3, 26);
            this.car_r_btn.Name = "car_r_btn";
            this.car_r_btn.Size = new System.Drawing.Size(41, 17);
            this.car_r_btn.TabIndex = 5;
            this.car_r_btn.TabStop = true;
            this.car_r_btn.Text = "Car";
            this.car_r_btn.UseVisualStyleBackColor = true;
            this.car_r_btn.CheckedChanged += new System.EventHandler(this.car_r_btn_CheckedChanged);
            // 
            // htlPriceLabel
            // 
            this.htlPriceLabel.AutoSize = true;
            this.htlPriceLabel.Location = new System.Drawing.Point(258, 185);
            this.htlPriceLabel.Name = "htlPriceLabel";
            this.htlPriceLabel.Size = new System.Drawing.Size(10, 13);
            this.htlPriceLabel.TabIndex = 9;
            this.htlPriceLabel.Text = " ";
            // 
            // htlLabel
            // 
            this.htlLabel.AutoSize = true;
            this.htlLabel.Location = new System.Drawing.Point(162, 185);
            this.htlLabel.Name = "htlLabel";
            this.htlLabel.Size = new System.Drawing.Size(98, 13);
            this.htlLabel.TabIndex = 8;
            this.htlLabel.Text = "Price of Hotel/Day:";
            // 
            // rtlPriceLabel
            // 
            this.rtlPriceLabel.AutoSize = true;
            this.rtlPriceLabel.Location = new System.Drawing.Point(258, 308);
            this.rtlPriceLabel.Name = "rtlPriceLabel";
            this.rtlPriceLabel.Size = new System.Drawing.Size(10, 13);
            this.rtlPriceLabel.TabIndex = 11;
            this.rtlPriceLabel.Text = " ";
            // 
            // rtlLabel
            // 
            this.rtlLabel.AutoSize = true;
            this.rtlLabel.Location = new System.Drawing.Point(162, 308);
            this.rtlLabel.Name = "rtlLabel";
            this.rtlLabel.Size = new System.Drawing.Size(89, 13);
            this.rtlLabel.TabIndex = 10;
            this.rtlLabel.Text = "Price of Car/Day:";
            // 
            // rb_chk_btn
            // 
            this.rb_chk_btn.AutoSize = true;
            this.rb_chk_btn.Location = new System.Drawing.Point(165, 31);
            this.rb_chk_btn.Name = "rb_chk_btn";
            this.rb_chk_btn.Size = new System.Drawing.Size(81, 17);
            this.rb_chk_btn.TabIndex = 12;
            this.rb_chk_btn.Text = "Round trip?";
            this.rb_chk_btn.UseVisualStyleBackColor = true;
            this.rb_chk_btn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalLabel.Location = new System.Drawing.Point(24, 352);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(125, 17);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total Price of Trip:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(176, 352);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(39, 16);
            this.totalPriceLabel.TabIndex = 14;
            this.totalPriceLabel.Text = "Total";
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // bestBtn
            // 
            this.bestBtn.Location = new System.Drawing.Point(261, 343);
            this.bestBtn.Name = "bestBtn";
            this.bestBtn.Size = new System.Drawing.Size(75, 23);
            this.bestBtn.TabIndex = 15;
            this.bestBtn.Text = "Best Option";
            this.bestBtn.UseVisualStyleBackColor = true;
            this.bestBtn.Click += new System.EventHandler(this.bestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 378);
            this.Controls.Add(this.bestBtn);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.rb_chk_btn);
            this.Controls.Add(this.rtlPriceLabel);
            this.Controls.Add(this.rtlLabel);
            this.Controls.Add(this.htlPriceLabel);
            this.Controls.Add(this.htlLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fltPriceLabel);
            this.Controls.Add(this.fltLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rentalLabel);
            this.Controls.Add(this.hotelLabel);
            this.Controls.Add(this.airlineLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label airlineLabel;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label rentalLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton utd_r_btn;
        private System.Windows.Forms.RadioButton sw_r_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hld_r_btn;
        private System.Windows.Forms.RadioButton mrtt_r_btn;
        private System.Windows.Forms.RadioButton hltn_r_btn;
        private System.Windows.Forms.Label fltLabel;
        private System.Windows.Forms.Label fltPriceLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton luxry_r_btn;
        private System.Windows.Forms.RadioButton suv_r_btn;
        private System.Windows.Forms.RadioButton car_r_btn;
        private System.Windows.Forms.Label htlPriceLabel;
        private System.Windows.Forms.Label htlLabel;
        private System.Windows.Forms.Label rtlPriceLabel;
        private System.Windows.Forms.Label rtlLabel;
        private System.Windows.Forms.RadioButton nocar_r_btn;
        private System.Windows.Forms.CheckBox rb_chk_btn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button bestBtn;
        private System.Windows.Forms.RadioButton dlt_r_btn;
    }
}

