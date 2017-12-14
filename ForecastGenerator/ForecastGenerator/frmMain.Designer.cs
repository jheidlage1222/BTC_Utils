namespace ForecastGenerator
{
    partial class frmMain
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
            this.txtHistoryFilePath = new System.Windows.Forms.TextBox();
            this.lblHistDataPath = new System.Windows.Forms.Label();
            this.btnDoCalcs = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gbParamCtrls = new System.Windows.Forms.GroupBox();
            this.tBoxSellFee = new System.Windows.Forms.TextBox();
            this.tBoxPurchaseFee = new System.Windows.Forms.TextBox();
            this.tBoxPrincipalAmt = new System.Windows.Forms.TextBox();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbParamCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHistoryFilePath
            // 
            this.txtHistoryFilePath.Location = new System.Drawing.Point(39, 44);
            this.txtHistoryFilePath.Name = "txtHistoryFilePath";
            this.txtHistoryFilePath.Size = new System.Drawing.Size(421, 20);
            this.txtHistoryFilePath.TabIndex = 0;
            // 
            // lblHistDataPath
            // 
            this.lblHistDataPath.AutoSize = true;
            this.lblHistDataPath.Location = new System.Drawing.Point(39, 25);
            this.lblHistDataPath.Name = "lblHistDataPath";
            this.lblHistDataPath.Size = new System.Drawing.Size(100, 13);
            this.lblHistDataPath.TabIndex = 1;
            this.lblHistDataPath.Text = "Path to History CSV";
            // 
            // btnDoCalcs
            // 
            this.btnDoCalcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoCalcs.Location = new System.Drawing.Point(495, 44);
            this.btnDoCalcs.Name = "btnDoCalcs";
            this.btnDoCalcs.Size = new System.Drawing.Size(167, 60);
            this.btnDoCalcs.TabIndex = 2;
            this.btnDoCalcs.Text = "Generate Forecasts";
            this.btnDoCalcs.UseVisualStyleBackColor = true;
            this.btnDoCalcs.Click += new System.EventHandler(this.btnDoCalcs_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.dgvData);
            this.gbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutput.Location = new System.Drawing.Point(57, 379);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(824, 176);
            this.gbOutput.TabIndex = 3;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output Data";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 19);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(818, 154);
            this.dgvData.TabIndex = 0;
            // 
            // gbParamCtrls
            // 
            this.gbParamCtrls.Controls.Add(this.tBoxSellFee);
            this.gbParamCtrls.Controls.Add(this.tBoxPurchaseFee);
            this.gbParamCtrls.Controls.Add(this.tBoxPrincipalAmt);
            this.gbParamCtrls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParamCtrls.Location = new System.Drawing.Point(57, 179);
            this.gbParamCtrls.Name = "gbParamCtrls";
            this.gbParamCtrls.Size = new System.Drawing.Size(824, 176);
            this.gbParamCtrls.TabIndex = 4;
            this.gbParamCtrls.TabStop = false;
            this.gbParamCtrls.Text = "Input Params";
            // 
            // tBoxSellFee
            // 
            this.tBoxSellFee.Location = new System.Drawing.Point(276, 118);
            this.tBoxSellFee.Name = "tBoxSellFee";
            this.tBoxSellFee.Size = new System.Drawing.Size(100, 23);
            this.tBoxSellFee.TabIndex = 2;
            // 
            // tBoxPurchaseFee
            // 
            this.tBoxPurchaseFee.Location = new System.Drawing.Point(137, 118);
            this.tBoxPurchaseFee.Name = "tBoxPurchaseFee";
            this.tBoxPurchaseFee.Size = new System.Drawing.Size(100, 23);
            this.tBoxPurchaseFee.TabIndex = 1;
            // 
            // tBoxPrincipalAmt
            // 
            this.tBoxPrincipalAmt.Location = new System.Drawing.Point(7, 118);
            this.tBoxPrincipalAmt.Name = "tBoxPrincipalAmt";
            this.tBoxPrincipalAmt.Size = new System.Drawing.Size(100, 23);
            this.tBoxPrincipalAmt.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 588);
            this.Controls.Add(this.gbParamCtrls);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.btnDoCalcs);
            this.Controls.Add(this.lblHistDataPath);
            this.Controls.Add(this.txtHistoryFilePath);
            this.Name = "frmMain";
            this.Text = "Forecast Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbParamCtrls.ResumeLayout(false);
            this.gbParamCtrls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistoryFilePath;
        private System.Windows.Forms.Label lblHistDataPath;
        private System.Windows.Forms.Button btnDoCalcs;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox gbParamCtrls;
        private System.Windows.Forms.TextBox tBoxPrincipalAmt;
        private System.Windows.Forms.TextBox tBoxSellFee;
        private System.Windows.Forms.TextBox tBoxPurchaseFee;
    }
}

