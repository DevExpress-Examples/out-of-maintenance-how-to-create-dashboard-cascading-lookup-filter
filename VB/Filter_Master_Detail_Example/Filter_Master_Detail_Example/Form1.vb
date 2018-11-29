Imports DevExpress.DashboardCommon
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Filter_Master_Detail_Example
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            AddHandler dashboardDesigner1.ConfigureDataConnection, AddressOf DashboardDesigner1_ConfigureDataConnection
            dashboardDesigner1.UseNeutralFilterMode = True
            dashboardDesigner1.CreateRibbon()
            dashboardDesigner1.LoadDashboard("CascadeFiltersDashboard.xml")
        End Sub

        Private Sub DashboardDesigner1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs)
            Dim parameters As ExtractDataSourceConnectionParameters = TryCast(e.ConnectionParameters, ExtractDataSourceConnectionParameters)
            If parameters IsNot Nothing Then
                parameters.FileName = Path.GetFileName(parameters.FileName)
            End If
        End Sub
    End Class
End Namespace
