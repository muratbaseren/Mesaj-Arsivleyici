#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.SqlClient
#End Region

Public Class GrilToDatabase

#Region "Local Variables"
    Private _UserName As String
    Private _Password As String
    Private _Password2 As String
    Private _Conn As SqlConnection
    Private _Cmd As SqlCommand
#End Region

#Region "Properties"
    Public Property Conn() As SqlConnection
        Get
            Return _Conn
        End Get
        Set(ByVal value As SqlConnection)
            _Conn = value
        End Set
    End Property
    Public Property Cmd() As SqlCommand
        Get
            Return _Cmd
        End Get
        Set(ByVal value As SqlCommand)
            _Cmd = value
        End Set
    End Property
#End Region

#Region "Methods"
    'UserName ve Password kontrolu..
    Public Function LoginPasswordControl(ByVal UserName As String, ByVal Password As String) As Integer
        Dim result As Integer = 0
        'Sorgu olusturulur..
        _Cmd.CommandText = "SELECT logi_ID,logi_Name,logi_Password FROM Login WHERE logi_Name='" & UserName & "'"
        'Baðlantý açýk deðilse,açýlýr..
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        'DataReader tanýmlanýr ve sorgu sonucu okunur..
        Dim DR As SqlDataReader
        DR = Cmd.ExecuteReader

        Do While DR.Read
            'Eger UserName ve Password doðru ise result=UserID yapýlýr ve döngüden çýkýlýr..
            If DR.Item(1).ToString = UserName AndAlso DR.Item(2).ToString = Password Then
                result = DR.Item(0)
                Exit Do
            End If
        Loop
        'Baðlantý kapatýlýr..
        If Not Conn.State = ConnectionState.Closed Then
            Conn.Close()
        End If
        'Sonuç bize döndürülür..
        Return result
    End Function

    'O An sisteme baðlý User'ýn UserID deðerini alýp o user'ýn Password2 deðerini sonduren function.
    Public Function SecondLevelPasswordControl() As String
        Dim result As String = ""
        'Sorgu olusturulur..
        _Cmd.CommandText = "SELECT logi_Password2 FROM Login WHERE logi_ID=" & Module1.UserID
        'Baðlantý açýk deðilse,açýlýr..
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        'DataReader tanýmlanýr ve sorgu sonucu okunur..
        Dim DR As SqlDataReader
        DR = Cmd.ExecuteReader

        Do While DR.Read
            'UserID kullanýlarak Password2 elde edilir..
            result = DR.Item(0).ToString
        Loop
        'Baðlantý kapatýlýr..
        If Not Conn.State = ConnectionState.Closed Then
            Conn.Close()
        End If
        'Sonuç bize döndürülür..
        Return result
    End Function

    'Database'den Msjlarý alan function..
    Public Function ReadToMsj(ByVal Command As String) As DataTable
        Dim DT As DataTable = New DataTable
        Cmd.CommandText = Command
        Dim DA As SqlDataAdapter = New SqlDataAdapter(Cmd)
        DA.Fill(DT)
        Return DT
    End Function

    'Database Insert,Update,Delete sorgusu için function..
    Public Function DataInsUpdDel(ByVal Command As String) As Integer
        Dim result As Integer = 0
        'Gelen CommandText SqlCommand a atanýr..
        Cmd.CommandText = Command
        'Baðlantý açýk deðilse açýlýr..
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        'Insert,Update,Delete iþlemi gerçekleþtirilir..
        result = Cmd.ExecuteNonQuery
        Conn.Close()

        'iþlemin gerçekleþip gerçekleþmediði sonucu döndururlur..
        Return result
    End Function
#End Region

#Region "Events"
    Public Sub New()
        _Conn = New SqlConnection("Server=" & My.Computer.Name & ";Database=MobileMsjArchive;Integrated Security=SSPI;")
        _Cmd = New SqlCommand
        _Cmd.Connection = Conn
    End Sub

    Public Sub New(ByVal ChangeDatabase As String)
        _Conn = New SqlConnection("Server=" & My.Computer.Name & ";Database=" & ChangeDatabase & ";Integrated Security=SSPI;")
        _Cmd = New SqlCommand
        _Cmd.Connection = Conn
    End Sub
#End Region
End Class
