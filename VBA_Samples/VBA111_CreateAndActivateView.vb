Sub CreateAndActivateView()
'VBA111
    Dim objView As HMIView
    Set objView = ActiveDocument.Views.Add
    objView.Activate
End Sub
