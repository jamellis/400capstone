Imports System.Windows.Forms

Public Class Validator

    Private Shared m_Title As String = "Entry Error"

    Public Shared Property Title() As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
        End Set
    End Property

    Public Shared Function IsPresent(ByVal textBox As Control, ByVal textBoxName As String) As Boolean
        If textBox.Text.Trim() = "" Then
            MessageBox.Show(textBoxName & " is a required field.", Title)
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsDecimal(ByVal textBox As TextBox, ByVal textBoxName As String) As Boolean
        Try
            Convert.ToDecimal(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textBoxName & " must be a decimal value.", Title)
            textBox.Focus()
            textBox.Select(0, textBox.Text.Length)
            Return False
        End Try

    End Function

    Public Shared Function IsInt32(ByVal textBox As TextBox, ByVal textBoxName As String) As Boolean
        Try
            Convert.ToInt32(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textBoxName & " must be a whole number.", Title)
            textBox.Focus()
            textBox.Select(0, textBox.Text.Length)
            Return False
        End Try
    End Function

        Public Shared Function IsWithinRange(ByVal textBox As TextBox, ByVal textBoxName As String, ByVal min As Decimal, ByVal max As Decimal) As Boolean
            Dim dNumber As Decimal = CDec(textBox.Text)
            If dNumber < min OrElse dNumber > max Then
            MessageBox.Show(textBoxName & " must be between " & min & " and " & max & ".", Title)
                textBox.Select(0, textBox.Text.Length)
                Return False
            Else
                Return True
            End If
        End Function

        Public Shared Function IsValidEmail(ByVal textBox As TextBox, ByVal textBoxName As String) As Boolean
            If textBox.Text.IndexOf("@") = -1 OrElse textBox.Text.IndexOf(".") = -1 Then
                MessageBox.Show(textBoxName & " must be a valid email address", Title)
                textBox.Select(0, textBox.Text.Length)
                Return False
            Else
                Return True
            End If
        End Function
    End Class

