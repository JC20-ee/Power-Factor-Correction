Imports System.Windows.Forms.DataVisualization.Charting

Public Class ChartForm
    Public Sub LoadReactivePower(Q_old As Double, Q_new As Double, Q_pfc As Double)
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Titles.Clear()

        Chart1.ChartAreas.Add("MainArea")

        Dim series As New Series("Reactive Power")
        With series
            .ChartType = SeriesChartType.Column
            .Points.AddXY("Q_old", Q_old / 1000)
            .Points.AddXY("Q_new", Q_new / 1000)
            .Points.AddXY("Q_pfc", Q_pfc / 1000)
        End With

        Chart1.Series.Add(series)
        Chart1.Titles.Add("Reactive Power Comparison (kVAR)")
    End Sub
End Class
