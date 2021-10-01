''Copyright (c) 2016-2017 Swiss Agency for Development and Cooperation (SDC)
''
''The program users must agree to the following terms:
''
''Copyright notices
''This program is free software: you can redistribute it and/or modify it under the terms of the GNU AGPL v3 License as published by the 
''Free Software Foundation, version 3 of the License.
''This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
''MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU AGPL v3 License for more details www.gnu.org.
''
''Disclaimer of Warranty
''There is no warranty for the program, to the extent permitted by applicable law; except when otherwise stated in writing the copyright 
''holders and/or other parties provide the program "as is" without warranty of any kind, either expressed or implied, including, but not 
''limited to, the implied warranties of merchantability and fitness for a particular purpose. The entire risk as to the quality and 
''performance of the program is with you. Should the program prove defective, you assume the cost of all necessary servicing, repair or correction.
''
''Limitation of Liability 
''In no event unless required by applicable law or agreed to in writing will any copyright holder, or any other party who modifies and/or 
''conveys the program as permitted above, be liable to you for damages, including any general, special, incidental or consequential damages 
''arising out of the use or inability to use the program (including but not limited to loss of data or data being rendered inaccurate or losses 
''sustained by you or third parties or a failure of the program to operate with any other programs), even if such holder or other party has been 
''advised of the possibility of such damages.
''
''In case of dispute arising out or in relation to the use of the program, it is subject to the public law of Switzerland. The place of jurisdiction is Berne.

Public Class AddSamplePercent
    Inherits System.Web.UI.Page
    Private userBI As New IMIS_BI.UserBI
    Protected imisgen As New IMIS_Gen
    Private FundBI As New IMIS_BI.AddSamplePercentBI
    Private ePremium As New IMIS_EN.tblPremium
    Private ePayer As New IMIS_EN.tblPayer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub RunPageSecurity()
        Dim RoleID As Integer = imisgen.getRoleId(Session("User"))
        Dim UserID As Integer = imisgen.getUserId(Session("User"))
        If userBI.RunPageSecurity(IMIS_EN.Enums.Pages.Funding, Page) Then
            B_SAVE.Visible = userBI.checkRights(IMIS_EN.Enums.Rights.FundingSave, UserID)
            If Not B_SAVE.Visible Then
                pnlBody.Enabled = False
            End If
        Else
            Server.Transfer("Home.aspx")
        End If
    End Sub


    Private Sub B_SAVE_Click(sender As Object, e As EventArgs) Handles B_SAVE.Click
        Dim privateMin As String = private_min.Text
        Dim privateMax As String = private_max.Text
        Dim privatePercent As String = private_percent.Text
        Dim publicMin As String = public_min.Text
        Dim publicMax As String = public_max.Text
        Dim publicPercent As String = public_percent.Text






        'Try
        '    Dim msg As String = String.Empty
        '    If Not String.IsNullOrWhiteSpace(ddlProduct.Text) Then

        '        SetEntity()
        '        Dim Result As Integer = FundBI.AddFund(ePremium, ddlProduct.SelectedValue)
        '        Select Case Result
        '            Case 0
        '                msg = imisgen.getMessage("M_FUNDADDED")
        '            Case 99
        '                msg = imisgen.getMessage("M_AJAXERROR")
        '        End Select

        '        Session("msg") = msg
        '        Response.Redirect("Home.aspx")
        '        'Added by Emmanuel
        '    Else
        '        imisgen.Alert(imisgen.getMessage("M_MUSTFILLPRODUCT"), pnlBody, alertPopupTitle:="IMIS")
        '    End If

        '    'imisgen.Alert(msg, pnlBody, alertPopupTitle:="IMIS-Funding"    Commeted by developer initially

        'Catch ex As Exception
        '    imisgen.Alert(imisgen.getMessage("M_ERRORMESSAGE"), pnlBody, alertPopupTitle:="IMIS")
        '    imisgen.Log(Page.Title & " : " & imisgen.getLoginName(Session("User")), ex, 1)
        '    'EventLog.WriteEntry("IMIS", Page.Title & " : " & imisgen.getLoginName(Session("User")) & " : " & ex.ToString(), EventLogEntryType.Error, 1)
        '    Return
        'End Try
    End Sub

    Private Sub B_CANCEL_Click(sender As Object, e As EventArgs) Handles B_CANCEL.Click
        Response.Redirect("Home.aspx")
    End Sub


End Class
