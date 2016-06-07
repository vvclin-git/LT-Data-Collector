Imports System.Collections.ObjectModel
Imports LightTools
Imports LTCOM64
Imports LTJumpStartNET
Imports LTLOCATORLib
Imports System.ComponentModel
Imports System.Math

Class MainWindow
    Class valData
        Private _key As String
        Private _name As String
        Private _value As String
        Public Sub New(ByVal key As String, ByVal name As String, ByVal value As String)
            Me.Key = key
            Me.Name = name
            Me.Value = value
        End Sub

        Public Property Key As String
            Get
                Return _key
            End Get
            Set(value As String)
                _key = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Property Value As String
            Get
                Return _value
            End Get
            Set(value As String)
                _value = value
            End Set
        End Property
    End Class
    Dim ltLoc As New Locator
    Dim lt As LTAPI
    Dim js As New LTCOM64.JSNET
    Dim pID As Integer
    Dim stat As LTReturnCodeEnum
    Dim debugMode As Boolean
    Public valDataList As New ObservableCollection(Of valData)
    Public Sub New()
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        'debugMode = False
        debugMode = True
        lt = LTGetter.getLTAPIServer
        If Not debugMode Then
            If IsNothing(lt) Then
                MsgBox("LightTools session not found!")
            Else
                Me.Title = "LT Data Collector (PID = " + Str(lt.GetServerID()) + ")"
            End If
        Else
            pID = 14956
            lt = ltLoc.GetLTAPI(pID)
        End If
        Call loadValTab()
    End Sub
    Private Sub loadValTab()
        For i = 1 To 10
            valDataList.Add(New valData("", "", ""))
        Next
        valGrid.ItemsSource = valDataList
    End Sub
    Private Sub addRow(sender As Object, e As RoutedEventArgs)
        valDataList.Insert(valGrid.SelectedIndex, New valData("", "", ""))
    End Sub
    Private Sub removeRow(sender As Object, e As RoutedEventArgs)
        If valDataList.Count > 1 Then
            valDataList.RemoveAt(valGrid.SelectedIndex)
        End If
    End Sub
    Private Sub getData()
        Dim keyArray As String()
        Dim key As String
        Dim dataName As String
        For Each r In valDataList
            keyArray = r.Key.Split(".")
            dataName = keyArray(UBound(keyArray))
            key = r.Key.Replace("." + dataName, "")
            r.Value = lt.DbGet(key, dataName)
            r.Name = dataName
        Next
    End Sub

    Private Sub valGetData_btn_Click(sender As Object, e As RoutedEventArgs) Handles valGetData_btn.Click
        Call getData()
        valGrid.Items.Refresh()
    End Sub
End Class
