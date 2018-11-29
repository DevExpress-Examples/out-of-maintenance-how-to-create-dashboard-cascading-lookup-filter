using DevExpress.DashboardCommon;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filter_Master_Detail_Example
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.ConfigureDataConnection += DashboardDesigner1_ConfigureDataConnection;
            dashboardDesigner1.UseNeutralFilterMode = true;
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard("CascadeFiltersDashboard.xml");
        }

        private void DashboardDesigner1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            ExtractDataSourceConnectionParameters parameters = e.ConnectionParameters as ExtractDataSourceConnectionParameters;
            if (parameters != null)
                parameters.FileName = Path.GetFileName(parameters.FileName);
        }
    }
}
