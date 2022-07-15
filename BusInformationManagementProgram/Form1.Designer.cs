
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
            this.lblBIMPFull = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.busNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBIMPTitle = new System.Windows.Forms.Label();
            this.lblViewDataFor = new System.Windows.Forms.Label();
            this.cmbBxBuses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBIMPFull
            // 
            this.lblBIMPFull.AutoSize = true;
            this.lblBIMPFull.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIMPFull.Location = new System.Drawing.Point(433, 48);
            this.lblBIMPFull.Name = "lblBIMPFull";
            this.lblBIMPFull.Size = new System.Drawing.Size(317, 23);
            this.lblBIMPFull.TabIndex = 2;
            this.lblBIMPFull.Text = "Bus Information Management Program";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busNumber,
            this.ArrivalStatus,
            this.arrivalTime,
            this.departureTime,
            this.arrivalDate});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 377);
            this.dataGridView1.TabIndex = 6;
            // 
            // busNumber
            // 
            this.busNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.busNumber.HeaderText = "Bus Number";
            this.busNumber.Name = "busNumber";
            // 
            // ArrivalStatus
            // 
            this.ArrivalStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivalStatus.HeaderText = "At School?";
            this.ArrivalStatus.Name = "ArrivalStatus";
            // 
            // arrivalTime
            // 
            this.arrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.Name = "arrivalTime";
            // 
            // departureTime
            // 
            this.departureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureTime.HeaderText = "Departure Time";
            this.departureTime.Name = "departureTime";
            // 
            // arrivalDate
            // 
            this.arrivalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalDate.HeaderText = "Date";
            this.arrivalDate.Name = "arrivalDate";
            // 
            // lblBIMPTitle
            // 
            this.lblBIMPTitle.AutoSize = true;
            this.lblBIMPTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIMPTitle.Location = new System.Drawing.Point(539, 9);
            this.lblBIMPTitle.Name = "lblBIMPTitle";
            this.lblBIMPTitle.Size = new System.Drawing.Size(89, 39);
            this.lblBIMPTitle.TabIndex = 1;
            this.lblBIMPTitle.Text = "BIMP";
            // 
            // lblViewDataFor
            // 
            this.lblViewDataFor.AutoSize = true;
            this.lblViewDataFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDataFor.Location = new System.Drawing.Point(22, 84);
            this.lblViewDataFor.Name = "lblViewDataFor";
            this.lblViewDataFor.Size = new System.Drawing.Size(146, 20);
            this.lblViewDataFor.TabIndex = 8;
            this.lblViewDataFor.Text = "View Data For Bus:";
            // 
            // cmbBxBuses
            // 
            this.cmbBxBuses.FormattingEnabled = true;
            this.cmbBxBuses.Location = new System.Drawing.Point(174, 86);
            this.cmbBxBuses.Name = "cmbBxBuses";
            this.cmbBxBuses.Size = new System.Drawing.Size(121, 21);
            this.cmbBxBuses.TabIndex = 9;
            this.cmbBxBuses.SelectedIndexChanged += new System.EventHandler(this.cmbBxBuses_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.cmbBxBuses);
            this.Controls.Add(this.lblViewDataFor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBIMPFull);
            this.Controls.Add(this.lblBIMPTitle);
            this.Name = "MainForm";
            this.Text = "BIMP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBIMPFull;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBIMPTitle;
        private System.Windows.Forms.Label lblViewDataFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDate;
        private System.Windows.Forms.ComboBox cmbBxBuses;
    }
}

