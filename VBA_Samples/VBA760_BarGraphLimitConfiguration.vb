Sub BarGraphLimitConfiguration()
'VBA760
    Dim objBarGraph As HMIBarGraph
    Set objBarGraph = ActiveDocument.HMIObjects.AddHMIObject("Bar1", "HMIBarGraph")
    With objBarGraph
        'Set analysis = absolute
        .TypeWarningLow = False
        'Activate monitoring
        .CheckWarningLow = True
        'Set barcolor = "magenta"
        .ColorWarningLow = RGB(255, 0, 255)
        'Set lower limit = "12"
        .WarningLow = 12
    End With
End Sub
