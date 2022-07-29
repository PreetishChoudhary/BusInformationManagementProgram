
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
            this.lblViewDataFor = new System.Windows.Forms.Label();
            this.cmbBxBuses = new System.Windows.Forms.ComboBox();
            this.cmbBxBusTypes = new System.Windows.Forms.ComboBox();
            this.lblAvgArrTime = new System.Windows.Forms.Label();
            this.lblAvgDeptTime = new System.Windows.Forms.Label();
            this.lblAvgArrTimeValue = new System.Windows.Forms.Label();
            this.lblAvgDeptTimeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBIMPFull
            // 
            this.lblBIMPFull.AutoSize = true;
            this.lblBIMPFull.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIMPFull.Location = new System.Drawing.Point(282, 9);
            this.lblBIMPFull.Name = "lblBIMPFull";
            this.lblBIMPFull.Size = new System.Drawing.Size(535, 39);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 491);
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
            this.cmbBxBuses.Location = new System.Drawing.Point(278, 86);
            this.cmbBxBuses.Name = "cmbBxBuses";
            this.cmbBxBuses.Size = new System.Drawing.Size(51, 21);
            this.cmbBxBuses.TabIndex = 9;
            this.cmbBxBuses.SelectedIndexChanged += new System.EventHandler(this.cmbBxBuses_SelectedIndexChanged);
            // 
            // cmbBxBusTypes
            // 
            this.cmbBxBusTypes.FormattingEnabled = true;
            this.cmbBxBusTypes.Location = new System.Drawing.Point(174, 86);
            this.cmbBxBusTypes.Name = "cmbBxBusTypes";
            this.cmbBxBusTypes.Size = new System.Drawing.Size(98, 21);
            this.cmbBxBusTypes.TabIndex = 10;
            this.cmbBxBusTypes.SelectedIndexChanged += new System.EventHandler(this.cmbBxBusTypes_SelectedIndexChanged);
            // 
            // lblAvgArrTime
            // 
            this.lblAvgArrTime.AutoSize = true;
            this.lblAvgArrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgArrTime.Location = new System.Drawing.Point(802, 84);
            this.lblAvgArrTime.Name = "lblAvgArrTime";
            this.lblAvgArrTime.Size = new System.Drawing.Size(157, 20);
            this.lblAvgArrTime.TabIndex = 11;
            this.lblAvgArrTime.Text = "Average Arrival Time:";
            // 
            // lblAvgDeptTime
            // 
            this.lblAvgDeptTime.AutoSize = true;
            this.lblAvgDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgDeptTime.Location = new System.Drawing.Point(773, 113);
            this.lblAvgDeptTime.Name = "lblAvgDeptTime";
            this.lblAvgDeptTime.Size = new System.Drawing.Size(186, 20);
            this.lblAvgDeptTime.TabIndex = 12;
            this.lblAvgDeptTime.Text = "Average Departure Time:";
            // 
            // lblAvgArrTimeValue
            // 
            this.lblAvgArrTimeValue.AutoSize = true;
            this.lblAvgArrTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgArrTimeValue.Location = new System.Drawing.Point(965, 86);
            this.lblAvgArrTimeValue.Name = "lblAvgArrTimeValue";
            this.lblAvgArrTimeValue.Size = new System.Drawing.Size(49, 20);
            this.lblAvgArrTimeValue.TabIndex = 13;
            this.lblAvgArrTimeValue.Text = "00:00";
            // 
            // lblAvgDeptTimeValue
            // 
            this.lblAvgDeptTimeValue.AutoSize = true;
            this.lblAvgDeptTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgDeptTimeValue.Location = new System.Drawing.Point(965, 113);
            this.lblAvgDeptTimeValue.Name = "lblAvgDeptTimeValue";
            this.lblAvgDeptTimeValue.Size = new System.Drawing.Size(49, 20);
            this.lblAvgDeptTimeValue.TabIndex = 14;
            this.lblAvgDeptTimeValue.Text = "00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblAvgDeptTimeValue);
            this.Controls.Add(this.lblAvgArrTimeValue);
            this.Controls.Add(this.lblAvgDeptTime);
            this.Controls.Add(this.lblAvgArrTime);
            this.Controls.Add(this.cmbBxBusTypes);
            this.Controls.Add(this.cmbBxBuses);
            this.Controls.Add(this.lblViewDataFor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBIMPFull);
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
        private System.Windows.Forms.Label lblViewDataFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDate;
        private System.Windows.Forms.ComboBox cmbBxBuses;
        private System.Windows.Forms.ComboBox cmbBxBusTypes;
        private System.Windows.Forms.Label lblAvgArrTime;
        private System.Windows.Forms.Label lblAvgDeptTime;
        private System.Windows.Forms.Label lblAvgArrTimeValue;
        private System.Windows.Forms.Label lblAvgDeptTimeValue;
    }
}

