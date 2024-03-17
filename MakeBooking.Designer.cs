namespace Group10_HotelSystem
{
    partial class MakeBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeBooking));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudRooms = new System.Windows.Forms.NumericUpDown();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkInclMeals = new System.Windows.Forms.CheckBox();
            this.Dates = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmaill = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            this.Food.SuspendLayout();
            this.Dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(-1, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(964, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ballito Lifestyle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEmaill);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Food);
            this.panel1.Controls.Add(this.Dates);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 603);
            this.panel1.TabIndex = 28;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.Location = new System.Drawing.Point(391, 531);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(220, 46);
            this.btnPayment.TabIndex = 24;
            this.btnPayment.Text = "Proceed to Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.btnProceed);
            this.panel3.Location = new System.Drawing.Point(576, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 189);
            this.panel3.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(3, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(204, 22);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total price goes here";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(35)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProceed.Location = new System.Drawing.Point(70, 27);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(219, 45);
            this.btnProceed.TabIndex = 21;
            this.btnProceed.Text = "Calculate Total";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(39, 531);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 21);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check Prices";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.nudRooms);
            this.panel2.Controls.Add(this.nudAdults);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(576, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 189);
            this.panel2.TabIndex = 7;
            // 
            // nudRooms
            // 
            this.nudRooms.Location = new System.Drawing.Point(182, 117);
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.Size = new System.Drawing.Size(67, 22);
            this.nudRooms.TabIndex = 5;
            this.nudRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAdults
            // 
            this.nudAdults.Location = new System.Drawing.Point(182, 51);
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(67, 22);
            this.nudAdults.TabIndex = 3;
            this.nudAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Room(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. of People";
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.Food.Controls.Add(this.label7);
            this.Food.Controls.Add(this.chkInclMeals);
            this.Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.ForeColor = System.Drawing.Color.White;
            this.Food.Location = new System.Drawing.Point(43, 292);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(368, 189);
            this.Food.TabIndex = 6;
            this.Food.TabStop = false;
            this.Food.Text = "Food(Buffet)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 84);
            this.label7.TabIndex = 1;
            this.label7.Text = "Meals included: \r\n●Breakfast\r\n●Lunch\r\n●Dinner";
            // 
            // chkInclMeals
            // 
            this.chkInclMeals.AutoSize = true;
            this.chkInclMeals.Location = new System.Drawing.Point(6, 31);
            this.chkInclMeals.Name = "chkInclMeals";
            this.chkInclMeals.Size = new System.Drawing.Size(161, 27);
            this.chkInclMeals.TabIndex = 0;
            this.chkInclMeals.Text = "Include Meals";
            this.chkInclMeals.UseVisualStyleBackColor = true;
            // 
            // Dates
            // 
            this.Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.Dates.Controls.Add(this.label6);
            this.Dates.Controls.Add(this.lblDays);
            this.Dates.Controls.Add(this.label4);
            this.Dates.Controls.Add(this.label3);
            this.Dates.Controls.Add(this.dateTimePickerOUT);
            this.Dates.Controls.Add(this.dateTimePickerIN);
            this.Dates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dates.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dates.ForeColor = System.Drawing.Color.White;
            this.Dates.Location = new System.Drawing.Point(43, 45);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(368, 189);
            this.Dates.TabIndex = 4;
            this.Dates.TabStop = false;
            this.Dates.Text = "Check-In AND Check-Out";
            this.Dates.Leave += new System.EventHandler(this.Dates_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day(s)";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(105, 139);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(20, 22);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check-Out:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check-In:";
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(125, 93);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerOUT.TabIndex = 1;
            this.dateTimePickerOUT.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            this.dateTimePickerOUT.Leave += new System.EventHandler(this.dateTimePickerOUT_Leave);
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIN.Location = new System.Drawing.Point(125, 41);
            this.dateTimePickerIN.MinDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerIN.TabIndex = 0;
            this.dateTimePickerIN.Value = new System.DateTime(2022, 11, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(424, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booking";
            // 
            // lblEmaill
            // 
            this.lblEmaill.AutoSize = true;
            this.lblEmaill.BackColor = System.Drawing.Color.Transparent;
            this.lblEmaill.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(78)))), ((int)(((byte)(35)))));
            this.lblEmaill.Location = new System.Drawing.Point(12, 0);
            this.lblEmaill.Name = "lblEmaill";
            this.lblEmaill.Size = new System.Drawing.Size(25, 21);
            this.lblEmaill.TabIndex = 26;
            this.lblEmaill.Text = "...";
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1013, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbnnnnnnnnnnnnnnn fv";
            this.Load += new System.EventHandler(this.MakeBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            this.Dates.ResumeLayout(false);
            this.Dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Dates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudRooms;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Food;
        private System.Windows.Forms.CheckBox chkInclMeals;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblEmaill;
    }
}