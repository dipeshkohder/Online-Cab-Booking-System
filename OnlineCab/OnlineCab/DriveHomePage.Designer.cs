namespace OnlineCab
{
    partial class DriveHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentlocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cabrequestInformation = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.AccpetedRequest = new System.Windows.Forms.Button();
            this.acceptedGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalEarnings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cabrequestInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Current Location  :  ";
            // 
            // currentlocation
            // 
            this.currentlocation.Location = new System.Drawing.Point(287, 53);
            this.currentlocation.Margin = new System.Windows.Forms.Padding(4);
            this.currentlocation.Name = "currentlocation";
            this.currentlocation.Size = new System.Drawing.Size(193, 22);
            this.currentlocation.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cabrequestInformation
            // 
            this.cabrequestInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabrequestInformation.Location = new System.Drawing.Point(31, 185);
            this.cabrequestInformation.Name = "cabrequestInformation";
            this.cabrequestInformation.RowHeadersWidth = 51;
            this.cabrequestInformation.RowTemplate.Height = 24;
            this.cabrequestInformation.Size = new System.Drawing.Size(708, 147);
            this.cabrequestInformation.TabIndex = 3;
            this.cabrequestInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CabrequestInformation_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show Cab Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AccpetedRequest
            // 
            this.AccpetedRequest.Location = new System.Drawing.Point(310, 386);
            this.AccpetedRequest.Name = "AccpetedRequest";
            this.AccpetedRequest.Size = new System.Drawing.Size(144, 28);
            this.AccpetedRequest.TabIndex = 6;
            this.AccpetedRequest.Text = "Accepted Request";
            this.AccpetedRequest.UseVisualStyleBackColor = true;
            this.AccpetedRequest.Click += new System.EventHandler(this.AccpetedRequest_Click);
            // 
            // acceptedGridView
            // 
            this.acceptedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedGridView.Location = new System.Drawing.Point(31, 441);
            this.acceptedGridView.Name = "acceptedGridView";
            this.acceptedGridView.RowHeadersWidth = 51;
            this.acceptedGridView.RowTemplate.Height = 24;
            this.acceptedGridView.Size = new System.Drawing.Size(708, 138);
            this.acceptedGridView.TabIndex = 7;
            this.acceptedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcceptedGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(28, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "* For accepting cab request please click on corresponding row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(31, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "* Please click on corresponding row after completing fair";
            // 
            // totalEarnings
            // 
            this.totalEarnings.AutoSize = true;
            this.totalEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEarnings.ForeColor = System.Drawing.Color.Red;
            this.totalEarnings.Location = new System.Drawing.Point(48, 655);
            this.totalEarnings.Name = "totalEarnings";
            this.totalEarnings.Size = new System.Drawing.Size(149, 20);
            this.totalEarnings.TabIndex = 10;
            this.totalEarnings.Text = "Total Earnings : ";
            // 
            // DriveHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 733);
            this.Controls.Add(this.totalEarnings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acceptedGridView);
            this.Controls.Add(this.AccpetedRequest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cabrequestInformation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentlocation);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriveHomePage";
            this.Text = "DriveHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.cabrequestInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentlocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cabrequestInformation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AccpetedRequest;
        private System.Windows.Forms.DataGridView acceptedGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalEarnings;
    }
}