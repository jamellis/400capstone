﻿Public Class userInfo
    Private Shared _clearance As String
    Private Shared _employeeID As String
    Private Shared _storeNum As Integer

    Public Shared Property Clearance As String
        Get
            Return _clearance
        End Get
        Set(ByVal value As String)
            _clearance = value
        End Set
    End Property

    Public Shared Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(ByVal value As String)
            _employeeID = value
        End Set
    End Property

    Public Shared Property StoreNumber As Integer
        Get
            Return _storeNum
        End Get
        Set(ByVal value As Integer)
            _storeNum = value
        End Set
    End Property
End Class
