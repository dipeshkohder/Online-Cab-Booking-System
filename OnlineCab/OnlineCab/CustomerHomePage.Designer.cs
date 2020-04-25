namespace OnlineCab
{
    partial class CustomerHomePage
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
            this.source = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.TextBox();
            this.ou = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCabs = new System.Windows.Forms.Button();
            this.driverInformation = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverid = new System.Windows.Forms.TextBox();
            this.drivername = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.acceptedRejectedRequest = new System.Windows.Forms.DataGridView();
            this.show_rejected_request = new System.Windows.Forms.Button();
            this.show_accepted_request = new System.Windows.Forms.Button();
            this.intro = new System.Windows.Forms.Label();
            this.show_panding_request = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driverInformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedRejectedRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(121, 20);
            this.source.Margin = new System.Windows.Forms.Padding(4);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(132, 22);
            this.source.TabIndex = 0;
            this.source.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(379, 22);
            this.destination.Margin = new System.Windows.Forms.Padding(4);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(132, 22);
            this.destination.TabIndex = 1;
            // 
            // ou
            // 
            this.ou.AutoSize = true;
            this.ou.Location = new System.Drawing.Point(34, 23);
            this.ou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ou.Name = "ou";
            this.ou.Size = new System.Drawing.Size(61, 17);
            this.ou.TabIndex = 2;
            this.ou.Text = "Source :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination :";
            // 
            // ShowCabs
            // 
            this.ShowCabs.Location = new System.Drawing.Point(576, 22);
            this.ShowCabs.Margin = new System.Windows.Forms.Padding(4);
            this.ShowCabs.Name = "ShowCabs";
            this.ShowCabs.Size = new System.Drawing.Size(100, 28);
            this.ShowCabs.TabIndex = 4;
            this.ShowCabs.Text = "Show Cabs";
            this.ShowCabs.UseVisualStyleBackColor = true;
            this.ShowCabs.Click += new System.EventHandler(this.ShowCabs_Click);
            // 
            // driverInformation
            // 
            this.driverInformation.AllowUserToAddRows = false;
            this.driverInformation.AllowUserToDeleteRows = false;
            this.driverInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book});
            this.driverInformation.Location = new System.Drawing.Point(58, 74);
            this.driverInformation.Margin = new System.Windows.Forms.Padding(4);
            this.driverInformation.Name = "driverInformation";
            this.driverInformation.ReadOnly = true;
            this.driverInformation.RowHeadersWidth = 51;
            this.driverInformation.Size = new System.Drawing.Size(653, 143);
            this.driverInformation.TabIndex = 6;
            this.driverInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverInformation_CellContentClick);
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 6;
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Width = 125;
            // 
            // driverid
            // 
            this.driverid.Location = new System.Drawing.Point(101, 251);
            this.driverid.Name = "driverid";
            this.driverid.Size = new System.Drawing.Size(139, 22);
            this.driverid.TabIndex = 7;
            // 
            // drivername
            // 
            this.drivername.Location = new System.Drawing.Point(355, 246);
            this.drivername.Name = "drivername";
            this.drivername.Size = new System.Drawing.Size(139, 22);
            this.drivername.TabIndex = 8;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(597, 246);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(139, 22);
            this.distance.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Driver Id : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Driver Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Distance : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Book cab";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.source);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ou);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ShowCabs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.drivername);
            this.groupBox1.Controls.Add(this.driverInformation);
            this.groupBox1.Controls.Add(this.driverid);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 372);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(25, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "* In order to book a cab please click on corresponding row";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.show_panding_request);
            this.groupBox2.Controls.Add(this.acceptedRejectedRequest);
            this.groupBox2.Controls.Add(this.show_rejected_request);
            this.groupBox2.Controls.Add(this.show_accepted_request);
            this.groupBox2.Location = new System.Drawing.Point(13, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 282);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // acceptedRejectedRequest
            // 
            this.acceptedRejectedRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedRejectedRequest.Location = new System.Drawing.Point(58, 100);
            this.acceptedRejectedRequest.Name = "acceptedRejectedRequest";
            this.acceptedRejectedRequest.RowHeadersWidth = 51;
            this.acceptedRejectedRequest.RowTemplate.Height = 24;
            this.acceptedRejectedRequest.Size = new System.Drawing.Size(652, 150);
            this.acceptedRejectedRequest.TabIndex = 2;
            // 
            // show_rejected_request
            // 
            this.show_rejected_request.Location = new System.Drawing.Point(520, 31);
            this.show_rejected_request.Name = "show_rejected_request";
            this.show_rejected_request.Size = new System.Drawing.Size(190, 29);
            this.show_rejected_request.TabIndex = 1;
            this.show_rejected_request.Text = "Show Rejected Request";
            this.show_rejected_request.UseVisualStyleBackColor = true;
            this.show_rejected_request.Click += new System.EventHandler(this.Show_rejected_request_Click);
            // 
            // show_accepted_request
            // 
            this.show_accepted_request.Location = new System.Drawing.Point(286, 31);
            this.show_accepted_request.Name = "show_accepted_request";
            this.show_accepted_request.Size = new System.Drawing.Size(191, 29);
            this.show_accepted_request.TabIndex = 0;
            this.show_accepted_request.Text = "Show Accepted Request";
            this.show_accepted_request.UseVisualStyleBackColor = true;
            this.show_accepted_request.Click += new System.EventHandler(this.Show_accepted_request_Click);
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro.ForeColor = System.Drawing.Color.Red;
            this.intro.Location = new System.Drawing.Point(32, 31);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(102, 25);
            this.intro.TabIndex = 16;
            this.intro.Text = "Welcome";
            // 
            // show_panding_request
            // 
            this.show_panding_request.Location = new System.Drawing.Point(58, 31);
            this.show_panding_request.Name = "show_panding_request";
            this.show_panding_request.Size = new System.Drawing.Size(184, 29);
            this.show_panding_request.TabIndex = 18;
            this.show_panding_request.Text = "Show Panding Request";
            this.show_panding_request.UseVisualStyleBackColor = true;
            this.show_panding_request.Click += new System.EventHandler(this.Show_panding_request_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 777);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.driverInformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acceptedRejectedRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label ou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowCabs;
        private System.Windows.Forms.DataGridView driverInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.TextBox driverid;
        private System.Windows.Forms.TextBox drivername;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView acceptedRejectedRequest;
        private System.Windows.Forms.Button show_rejected_request;
        private System.Windows.Forms.Button show_accepted_request;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.Button show_panding_request;
    }
}