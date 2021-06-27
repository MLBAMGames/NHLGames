Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Module Program
    Sub Main()
        Dim t = New Threading.Thread(AddressOf Thread)
        t.SetApartmentState(Threading.ApartmentState.STA)
        t.IsBackground = True
        t.Start()
        t.Join()
    End Sub

    Sub Thread()
        Updater.ProcessUpdateAsync().GetAwaiter().GetResult()
    End Sub
End Module
