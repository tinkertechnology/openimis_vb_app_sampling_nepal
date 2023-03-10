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
'
' 
'

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class ClaimReview
    '''<summary>
    '''pnlPage control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlPage As Global.System.Web.UI.WebControls.Panel
    '''<summary>
    '''pnlClaimReviewDetails control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlClaimReviewDetails As Global.System.Web.UI.WebControls.Panel
    '''<summary>
    '''lblHFCODE control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblHFCODE As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblHFCODEData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblHFCODEData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCHFID control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCHFID As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCHFIDData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCHFIDData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblNAME control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblNAME As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblNAMEData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblNAMEData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCLAIMTOTAL control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMTOTAL As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtCLAIMTOTALData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtCLAIMTOTALData As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''lblICD control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICD As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICDData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICDData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCLAIMCode control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMCode As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCLAIMData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCLAIMDATE control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMDATE As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblCLAIMDATEData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMDATEData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''L_APPROVED control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_APPROVED As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtApproved control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtApproved As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''lblICD1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICD1 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICDData1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICDData1 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICD2 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICD2 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICDData2 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICDData2 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICD3 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICD3 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICDData3 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICDData3 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICD4 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICD4 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblICDData4 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblICDData4 As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblDATERELEASED control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblDATERELEASED As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblDateProcessed control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblDateProcessed As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblSTARTDATE control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblSTARTDATE As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblSTARTData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblSTARTData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblEND control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblEND As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblENDData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblENDData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblVALUATED control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblVALUATED As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtPriceVALUATEDData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtPriceVALUATEDData As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''MaskedEditExtender2 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents MaskedEditExtender2 As Global.AjaxControlToolkit.MaskedEditExtender
    '''<summary>
    '''lblClaimAdminCode control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblClaimAdminCode As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''blClaimAdminCodeData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents blClaimAdminCodeData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblVisitType control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblVisitType As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblVisitTypeData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblVisitTypeData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblGuaranteeNo control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblGuaranteeNo As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblGuaranteeData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblGuaranteeData As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''lblServiceDetails control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblServiceDetails As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''pnlServiceDetails control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlServiceDetails As Global.System.Web.UI.WebControls.Panel
    '''<summary>
    '''gvService control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents gvService As Global.System.Web.UI.WebControls.GridView
    '''<summary>
    '''lblItems control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblItems As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''pnlItemsDetails control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlItemsDetails As Global.System.Web.UI.WebControls.Panel
    '''<summary>
    '''gvItems control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents gvItems As Global.System.Web.UI.WebControls.GridView
    '''<summary>
    '''lblEXPLANATION control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblEXPLANATION As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtEXPLANATION control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtEXPLANATION As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''lblCLAIMSTATUS control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblCLAIMSTATUS As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtClaimStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtClaimStatus As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''lblADJUSTMENT control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblADJUSTMENT As Global.System.Web.UI.WebControls.Label
    '''<summary>
    '''txtADJUSTMENTData control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtADJUSTMENTData As Global.System.Web.UI.WebControls.TextBox
    '''<summary>
    '''hfApprovedValue control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents hfApprovedValue As Global.System.Web.UI.WebControls.HiddenField
    '''<summary>
    '''hfClaimedValue control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents hfClaimedValue As Global.System.Web.UI.WebControls.HiddenField
    '''<summary>
    '''hfClaimAdminId control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents hfClaimAdminId As Global.System.Web.UI.WebControls.HiddenField
    '''<summary>
    '''hfBatchID control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents hfBatchID As Global.System.Web.UI.WebControls.HiddenField
    '''<summary>
    '''pnlButtons control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlButtons As Global.System.Web.UI.WebControls.Panel
    '''<summary>
    '''B_SAVE control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_SAVE As Global.System.Web.UI.WebControls.Button
    '''<summary>
    '''B_REVIEWED control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_REVIEWED As Global.System.Web.UI.WebControls.Button
    '''<summary>
    '''B_CANCEL control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_CANCEL As Global.System.Web.UI.WebControls.Button
    '''<summary>
    '''lblMsg control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblMsg As Global.System.Web.UI.WebControls.Label
End Class
