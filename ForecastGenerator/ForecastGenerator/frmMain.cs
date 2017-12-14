using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using ForecastGenerator.Classes;

namespace ForecastGenerator
{
    public partial class frmMain : Form
    {
        private ForecastDTO calcDataContainer;
        private string[] OutColNames = new string[]
            {
                "length", "start", "finish", "current", "min", "max", "total change", "avg daily change",
                "pos days", "neg days"
            };
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            this.txtHistoryFilePath.Text = appSettings["historyDataPath"];
            //Set up the cols of the dgv output
            var dgvOutputControl = (DataGridView)this.gbOutput.Controls["dgvData"];
            //Length, start, finish, min, max, avg daily change.  Num Increase days, num decrease days.  
            //Take in current value of btc, total contribution, buy fee, sell fee.
            SetColumnsForOutput(dgvOutputControl, this.OutColNames);
            //This is hacky but w/e
            List<Label> labelsToAdd = new List<Label>();
            foreach (var ctrl in this.gbParamCtrls.Controls)
            {
                TextBox inputCtrl = ctrl as TextBox;
                Label tempLabel = new Label();
                labelsToAdd.Add(tempLabel);
                tempLabel.Name = (ctrl as TextBox).Name.Replace("tBox", "lbl");
                tempLabel.Location = new Point(inputCtrl.Location.X, inputCtrl.Location.Y - 15);
                tempLabel.Text = tempLabel.Name.Replace("lbl", "");
            }
            this.gbParamCtrls.Controls.AddRange(labelsToAdd.ToArray<Control>());
        }

        private void SetColumnsForOutput(DataGridView dgvCtrl, string[] colNames)
        {
            dgvCtrl.Rows.Clear();
            //
            dgvCtrl.Columns.Clear();
            //
            foreach (string colName in colNames)
            {
                dgvCtrl.Columns.Add(colName, colName);
            }
        }

        private void btnDoCalcs_Click(object sender, EventArgs e)
        {
            var outputDGV = this.gbOutput.Controls["dgvData"] as DataGridView;
            outputDGV.Rows.Clear();
            //Open up the history CSV and let's go to work
            string historyFilePath = this.txtHistoryFilePath.Text;
            

        }
    }
}
