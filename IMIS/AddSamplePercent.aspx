<%-- Copyright (c) 2016-2017 Swiss Agency for Development and Cooperation (SDC)

The program users must agree to the following terms:

Copyright notices
This program is free software: you can redistribute it and/or modify it under the terms of the GNU AGPL v3 License as published by the 
Free Software Foundation, version 3 of the License.
This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU AGPL v3 License for more details www.gnu.org.

Disclaimer of Warranty
There is no warranty for the program, to the extent permitted by applicable law; except when otherwise stated in writing the copyright 
holders and/or other parties provide the program "as is" without warranty of any kind, either expressed or implied, including, but not 
limited to, the implied warranties of merchantability and fitness for a particular purpose. The entire risk as to the quality and 
performance of the program is with you. Should the program prove defective, you assume the cost of all necessary servicing, repair or correction.

Limitation of Liability 
In no event unless xRequired by applicable law or agreed to in writing will any copyright holder, or any other party who modifies and/or 
conveys the program as permitted above, be liable to you for damages, including any general, special, incidental or consequential damages 
arising out of the use or inability to use the program (including but not limited to loss of data or data being rendered inaccurate or losses 
sustained by you or third parties or a failure of the program to operate with any other programs), even if such holder or other party has been 
advised of the possibility of such damages.

In case of dispute arising out or in relation to the use of the program, it is subject to the public law of Switzerland. The place of jurisdiction is Berne.--%>
<%@ Page Title='<%$ Resources:Resource,CLAIM_SAMPLE_SETTING %>' Language="vb" AutoEventWireup="false" MasterPageFile="~/IMIS.Master" CodeBehind="AddSamplePercent.aspx.vb" Inherits="IMIS.AddSamplePercent" EnableEventValidation="true" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">


</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <div class="divBody">
        

        <asp:Panel ID="Panel1" runat="server"  style="flex-grow:0" CssClass="panelBody" Height="242px"  ScrollBars ="Vertical">
            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="False"
                GridLines="None"
                CssClass="mGrid"
                EmptyDataText='No data available'
                style="flex-grow:0">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText='ID' SortExpression="ID" HeaderStyle-Width="70px">
                        <HeaderStyle Width="0px" />
                    </asp:BoundField> 
                    
                    <asp:BoundField DataField="ClaimedMin" HeaderText='ClaimedMin' SortExpression="PrivateMinValue" HeaderStyle-Width="70px">
                        <HeaderStyle Width="0px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="ClaimedMax" HeaderText='ClaimedMax' SortExpression="PrivateMaxValue" HeaderStyle-Width="70px">
                        <HeaderStyle Width="0px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="SamplePercent" HeaderText='SamplePercent' SortExpression="PrivatePercent" HeaderStyle-Width="70px">
                        <HeaderStyle Width="0px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="TypeHF" HeaderText='TypeHF' SortExpression="PublicMinValue" HeaderStyle-Width="70px">
                        <HeaderStyle Width="0px" />
                    </asp:BoundField>

                    <asp:TemplateField>
                        <ItemTemplate >
                            <asp:Button Text="Edit" runat="server" OnClick="OnEdit" />
                            <asp:TextBox runat="server" ID="txtID" Visible="false"  Text='<%# Eval("ID") %>' ></asp:TextBox>
                        </ItemTemplate>
                        <ItemStyle Width="15px"  />
                     </asp:TemplateField>
                </Columns>
                <PagerStyle CssClass="pgr" />
                <SelectedRowStyle CssClass="srs" />
                <AlternatingRowStyle CssClass="alt" />
                <RowStyle CssClass="normal" />
            </asp:GridView>
        </asp:Panel>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IMISConnectionString %>" SelectCommand="SELECT * FROM [tblSamplePercentSetting]"></asp:SqlDataSource>
        
        <asp:Panel ID="pnlBody" runat="server" ScrollBars="Auto" CssClass="panel" GroupingText="Sampling Percent" style="flex-grow:0">
            <table>

                <tr>
              
                    <td class="DataEntry">
                         <asp:Label ID="label6" runat="server"  Text="MIN RS"></asp:Label>
                        <asp:TextBox ID="txtClaimedMin" xRequired="True" runat="server" Width="132px" MaxLength="10"></asp:TextBox>

			<asp:TextBox ID="txtID" xRequired="True" runat="server" Visible="False" Width="132px" MaxLength="10"></asp:TextBox>
                        
                    </td>
                    <td class="DataEntry">
                         <asp:Label ID="label7" xRequired="True" runat="server" Text="MAXIMUM RS"></asp:Label>
                        <asp:TextBox ID="txtClaimedMax" runat="server" Width="132px" MaxLength="10"></asp:TextBox>
                    </td>

                    <td class="DataEntry">
                         <asp:Label ID="label8" xRequired="True" runat="server" Text="PERCENT"></asp:Label>
                        <asp:TextBox ID="txtSamplePercent" xRequired="True" runat="server" Width="132px" MaxLength="10"></asp:TextBox>
                    </td>
    		<td>
			    <asp:DropDownList ID="ddlTypeHF" AppendDataBoundItems="true" runat="server">
		  		<%--  <asp:ListItem Text="G" Value="G" />	 --%> 
				     <asp:ListItem Text="G" Value="G" />
				     <asp:ListItem Text="P" Value="P" />
				     <asp:ListItem Text="O" Value="O" />
			    </asp:DropDownList>
		</td>
			                      <td align="left">

                    <asp:Button
                        ID="B_SAVE"
                        runat="server"
                        Text='<%$ Resources:Resource,B_SAVE%>'
                        ValidationGroup="check" />
                </td> 
                    <td align="right">
                    <asp:Button
                        ID="B_CANCEL"
                        runat="server"
                        Text='<%$ Resources:Resource,B_CANCEL%>' />
                </td>
                </tr>

                                <tr style="display:none;">
                    <td class="FormLabel">
                        <asp:Label
                            ID="Label1"
                            runat="server"
                            Text='PUBLIC'></asp:Label>
                    </td>
                    <td class="DataEntry">
                        <asp:Label ID="label2" runat="server" Text="MIN RS"></asp:Label>
                        <asp:TextBox ID="public_min" runat="server" Width="132px" MaxLength="10"></asp:TextBox>


                        
                    </td>
                    <td class="DataEntry">
                         <asp:Label ID="label4" runat="server" Text="MAXIMUM RS"></asp:Label>
                        <asp:TextBox ID="public_max" runat="server" Width="132px" MaxLength="10"></asp:TextBox>
                    </td>

                    <td class="DataEntry">
                         <asp:Label ID="label5" runat="server" Text="PERCENT"></asp:Label>
                        <asp:TextBox ID="public_percent" runat="server" Width="132px" MaxLength="10"></asp:TextBox>
                    </td>
                    
                </tr>



                
            </table>
        </asp:Panel>
    </div>
    <asp:Panel ID="pnlButtons" runat="server" CssClass="panel">
        <table width="100%" cellpadding="10 10 10 10">
        </table>

    </asp:Panel>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
