﻿Imports BL
Public Class ClienteSelect
    Inherits System.Web.UI.Page

    Dim clientesTable As New DataTable
    Dim clienteBL As New Cliente

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            clientesTable = ViewState.Item("table")
            grdClientes.DataSource = clientesTable
            grdClientes.DataBind()
            ViewState.Remove("table")
            ViewState.Add("table", clientesTable)
        Else
            clientesTable.Columns.Add("Cedula")
            clientesTable.Columns.Add("Nombre")
            clientesTable.Columns.Add("Apellido")
            clientesTable.Columns.Add("Correo")
            clientesTable.Columns.Add("Telefono")
            clienteBL.getClients(clientesTable)
            grdClientes.DataSource = clientesTable
            grdClientes.DataBind()
            ViewState.Add("table", clientesTable)
        End If
    End Sub

End Class