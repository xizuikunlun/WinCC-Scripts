Sub HMI3DBarGraphConfiguration()
'VBA571
    Dim obj3DBar As HMI3DBarGraph
    Set obj3DBar = ActiveDocument.HMIObjects.AddHMIObject("3DBar1", "HMI3DBarGraph")
    With obj3DBar
        .Layer05Checked = True
        .Layer05Value = 50
    End With
End Sub
