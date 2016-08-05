Sub BarGraphLimitConfiguration()
'VBA755
    Dim objBarGraph As HMIBarGraph
    Set objBarGraph = ActiveDocument.HMIObjects.AddHMIObject("Bar1", "HMIBarGraph")
    With objBarGraph
        'Set analysis = absolute
        .TypeLimitLow4 = False
        'Activate monitoring
        .CheckLimitLow4 = True
        'Set barcolor = "green"
        .ColorLimitLow4 = RGB(0, 255, 0)
        'Set lower limit = "5"
        .LimitLow4 = 5
    End With
End Sub
