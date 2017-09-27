namespace Iterator
{
    partial class MainFormIterator
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
            this.lb_months = new System.Windows.Forms.ListBox();
            this.btn_Fall = new System.Windows.Forms.Button();
            this.btn_Winter = new System.Windows.Forms.Button();
            this.btn_Spring = new System.Windows.Forms.Button();
            this.btn_Summer = new System.Windows.Forms.Button();
            this.btn_Calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_months
            // 
            this.lb_months.FormattingEnabled = true;
            this.lb_months.Location = new System.Drawing.Point(101, 41);
            this.lb_months.Name = "lb_months";
            this.lb_months.Size = new System.Drawing.Size(164, 212);
            this.lb_months.TabIndex = 4;
            // 
            // btn_Fall
            // 
            this.btn_Fall.Location = new System.Drawing.Point(12, 166);
            this.btn_Fall.Name = "btn_Fall";
            this.btn_Fall.Size = new System.Drawing.Size(75, 23);
            this.btn_Fall.TabIndex = 5;
            this.btn_Fall.Text = "Fall";
            this.btn_Fall.UseVisualStyleBackColor = true;
            this.btn_Fall.Click += new System.EventHandler(this.btn_fall_Click);
            // 
            // btn_Winter
            // 
            this.btn_Winter.Location = new System.Drawing.Point(12, 230);
            this.btn_Winter.Name = "btn_Winter";
            this.btn_Winter.Size = new System.Drawing.Size(75, 23);
            this.btn_Winter.TabIndex = 6;
            this.btn_Winter.Text = "Winter";
            this.btn_Winter.UseVisualStyleBackColor = true;
            this.btn_Winter.Click += new System.EventHandler(this.btn_Winter_Click);
            // 
            // btn_Spring
            // 
            this.btn_Spring.Location = new System.Drawing.Point(12, 41);
            this.btn_Spring.Name = "btn_Spring";
            this.btn_Spring.Size = new System.Drawing.Size(75, 23);
            this.btn_Spring.TabIndex = 7;
            this.btn_Spring.Text = "Spring";
            this.btn_Spring.UseVisualStyleBackColor = true;
            this.btn_Spring.Click += new System.EventHandler(this.btn_Spring_Click_1);
            // 
            // btn_Summer
            // 
            this.btn_Summer.Location = new System.Drawing.Point(12, 107);
            this.btn_Summer.Name = "btn_Summer";
            this.btn_Summer.Size = new System.Drawing.Size(75, 23);
            this.btn_Summer.TabIndex = 8;
            this.btn_Summer.Text = "Summer";
            this.btn_Summer.UseVisualStyleBackColor = true;
            this.btn_Summer.Click += new System.EventHandler(this.btn_Summer_Click_1);
            // 
            // btn_Calendar
            // 
            this.btn_Calendar.Location = new System.Drawing.Point(101, 12);
            this.btn_Calendar.Name = "btn_Calendar";
            this.btn_Calendar.Size = new System.Drawing.Size(164, 23);
            this.btn_Calendar.TabIndex = 9;
            this.btn_Calendar.Text = "Full Calendar";
            this.btn_Calendar.UseVisualStyleBackColor = true;
            this.btn_Calendar.Click += new System.EventHandler(this.btn_Calendar_Click);
            // 
            // MainFormIterator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 265);
            this.Controls.Add(this.btn_Calendar);
            this.Controls.Add(this.btn_Summer);
            this.Controls.Add(this.btn_Spring);
            this.Controls.Add(this.btn_Winter);
            this.Controls.Add(this.btn_Fall);
            this.Controls.Add(this.lb_months);
            this.Name = "MainFormIterator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_months;
        private System.Windows.Forms.Button btn_Fall;
        private System.Windows.Forms.Button btn_Winter;
        private System.Windows.Forms.Button btn_Spring;
        private System.Windows.Forms.Button btn_Summer;
        private System.Windows.Forms.Button btn_Calendar;
    }
}

