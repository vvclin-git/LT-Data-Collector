Imports LightTools
Imports LTLOCATORLib
Module LTGetter
    Private m_ltServer As LTAPI
    Public Function getLTAPIServer() As LTAPI
        If m_ltServer Is Nothing Then
            Dim lt As LTAPI
            Dim ltLoc As Locator
            Dim cmd As String
            ltLoc = CreateObject("LTLocator.Locator")
            ' to get a LightTools Server pointer, you need to know
            ' the calling server process ID
            ' if it is passed to this application via command line
            ' in a shape of "-LTPID1234" (AddIn standard)
            ' (1234 being hypothetical LightTools Process ID), do this
            cmd = Command() ' get command line
            ' if command line is in the form of "-LTPID1234" you can
            ' directly pass it to Locator
            lt = ltLoc.GetLTAPIFromString(cmd)
            'if the client code knows LT PID somehow, it could use the
            ' GetLTAPI(pidNumber) interface
            m_ltServer = lt
            ltLoc = Nothing
        End If
        getLTAPIServer = m_ltServer
    End Function
End Module
