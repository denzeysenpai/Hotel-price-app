namespace Hotel_price
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
            this.button1 = new System.Windows.Forms.Button();
            this.monthStay = new System.Windows.Forms.TextBox();
            this.OutputApartment = new System.Windows.Forms.TextBox();
            this.numberOfStays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputStudio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Hotel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Prices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthStay
            // 
            this.monthStay.Location = new System.Drawing.Point(339, 32);
            this.monthStay.Name = "monthStay";
            this.monthStay.Size = new System.Drawing.Size(100, 23);
            this.monthStay.TabIndex = 1;
            this.monthStay.TextChanged += new System.EventHandler(this.monthStay_TextChanged);
            // 
            // OutputApartment
            // 
            this.OutputApartment.Location = new System.Drawing.Point(339, 110);
            this.OutputApartment.Name = "OutputApartment";
            this.OutputApartment.Size = new System.Drawing.Size(100, 23);
            this.OutputApartment.TabIndex = 2;
            this.OutputApartment.TextChanged += new System.EventHandler(this.OutputApaartment_TextChanged);
            // 
            // numberOfStays
            // 
            this.numberOfStays.Location = new System.Drawing.Point(339, 61);
            this.numberOfStays.Name = "numberOfStays";
            this.numberOfStays.Size = new System.Drawing.Size(100, 23);
            this.numberOfStays.TabIndex = 3;
            this.numberOfStays.TextChanged += new System.EventHandler(this.numberOfStays_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Month of stay:  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of stays(night): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apartment Price: ";
            // 
            // OutputStudio
            // 
            this.OutputStudio.Location = new System.Drawing.Point(339, 139);
            this.OutputStudio.Name = "OutputStudio";
            this.OutputStudio.Size = new System.Drawing.Size(100, 23);
            this.OutputStudio.TabIndex = 7;
            this.OutputStudio.TextChanged += new System.EventHandler(this.OutputStudio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Studio Price: ";
            // 
            // Hotel
            // 
            this.Hotel.AccessibleName = "Hotel Prices";
            this.Hotel.AutoSize = true;
            this.Hotel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Hotel.Location = new System.Drawing.Point(46, 32);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(107, 23);
            this.Hotel.TabIndex = 9;
            this.Hotel.Text = "Hotel Prices";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 219);
            this.Controls.Add(this.Hotel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputStudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfStays);
            this.Controls.Add(this.OutputApartment);
            this.Controls.Add(this.monthStay);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Prices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox monthStay;
        private TextBox OutputApartment;
        private TextBox numberOfStays;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox OutputStudio;
        private Label label4;
        private Label Hotel;
    }
}