Sub ConfigureSettingsOfLayer 
'VBA27
    Dim objLayer As HMILayer 
    Set objLayer = ActiveDocument.Layers(1) 
    With objLayer 
        'Configure "Layer 0"
        .MinZoom = 10 
        .MaxZoom = 100 
        .Name = "Configured with VBA" 
    End With
End Sub