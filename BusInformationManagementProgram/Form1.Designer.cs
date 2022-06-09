
namespace BusInformationManagementProgram
{
    partial class MainForm
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
            this.lblCreateEditRecordLabel = new System.Windows.Forms.Label();
            this.lblBIMPTitle = new System.Windows.Forms.Label();
            this.lblBIMPFull = new System.Windows.Forms.Label();
            this.btnCreateRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.lblTodayData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.busNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateEditRecordLabel
            // 
            this.lblCreateEditRecordLabel.AutoSize = true;
            this.lblCreateEditRecordLabel.Font = new System.Drawing.Font("VALORANT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateEditRecordLabel.Location = new System.Drawing.Point(456, 103);
            this.lblCreateEditRecordLabel.Name = "lblCreateEditRecordLabel";
            this.lblCreateEditRecordLabel.Size = new System.Drawing.Size(276, 24);
            this.lblCreateEditRecordLabel.TabIndex = 0;
            this.lblCreateEditRecordLabel.Text = "Create/Edit Record";
            // 
            // lblBIMPTitle
            // 
            this.lblBIMPTitle.AutoSize = true;
            this.lblBIMPTitle.Font = new System.Drawing.Font("VALORANT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIMPTitle.Location = new System.Drawing.Point(539, 9);
            this.lblBIMPTitle.Name = "lblBIMPTitle";
            this.lblBIMPTitle.Size = new System.Drawing.Size(110, 32);
            this.lblBIMPTitle.TabIndex = 1;
            this.lblBIMPTitle.Text = "BIMP";
            // 
            // lblBIMPFull
            // 
            this.lblBIMPFull.AutoSize = true;
            this.lblBIMPFull.Font = new System.Drawing.Font("VALORANT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIMPFull.Location = new System.Drawing.Point(364, 41);
            this.lblBIMPFull.Name = "lblBIMPFull";
            this.lblBIMPFull.Size = new System.Drawing.Size(484, 20);
            this.lblBIMPFull.TabIndex = 2;
            this.lblBIMPFull.Text = "Bus Information Management Program";
            // 
            // btnCreateRecord
            // 
            this.btnCreateRecord.Font = new System.Drawing.Font("VALORANT", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRecord.Location = new System.Drawing.Point(479, 145);
            this.btnCreateRecord.Name = "btnCreateRecord";
            this.btnCreateRecord.Size = new System.Drawing.Size(108, 23);
            this.btnCreateRecord.TabIndex = 3;
            this.btnCreateRecord.Text = "Create Record";
            this.btnCreateRecord.UseVisualStyleBackColor = true;
            this.btnCreateRecord.Click += new System.EventHandler(this.btnCreateRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Font = new System.Drawing.Font("VALORANT", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecord.Location = new System.Drawing.Point(602, 145);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(108, 23);
            this.btnEditRecord.TabIndex = 4;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // lblTodayData
            // 
            this.lblTodayData.AutoSize = true;
            this.lblTodayData.Font = new System.Drawing.Font("VALORANT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayData.Location = new System.Drawing.Point(495, 224);
            this.lblTodayData.Name = "lblTodayData";
            this.lblTodayData.Size = new System.Drawing.Size(188, 24);
            this.lblTodayData.TabIndex = 5;
            this.lblTodayData.Text = "Today\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busNumber,
            this.arrivalStatus,
            this.arrivalTime,
            this.averageArrivalTime});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 377);
            this.dataGridView1.TabIndex = 6;
            // 
            // busNumber
            // 
            this.busNumber.HeaderText = "Bus Number";
            this.busNumber.Name = "busNumber";
            // 
            // arrivalStatus
            // 
            this.arrivalStatus.HeaderText = "Arrival Status";
            this.arrivalStatus.Name = "arrivalStatus";
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.Name = "arrivalTime";
            // 
            // averageArrivalTime
            // 
            this.averageArrivalTime.HeaderText = "Average Arrival Time";
            this.averageArrivalTime.Name = "averageArrivalTime";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTodayData);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnCreateRecord);
            this.Controls.Add(this.lblBIMPFull);
            this.Controls.Add(this.lblBIMPTitle);
            this.Controls.Add(this.lblCreateEditRecordLabel);
            this.Name = "MainForm";
            this.Text = "BIMP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateEditRecordLabel;
        private System.Windows.Forms.Label lblBIMPTitle;
        private System.Windows.Forms.Label lblBIMPFull;
        private System.Windows.Forms.Button btnCreateRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Label lblTodayData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageArrivalTime;
    }
}

