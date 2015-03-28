<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MemCertsView.aspx.cs" Inherits="NcmaMembership.Admin.MemCertsView" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridLookup" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Data.Linq" TagPrefix="cc1" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <% if (DesignMode){ %>
    <script src="ASPxScriptIntelliSense.js" type="text/javascript"></script>
<% } %>
<script language="javascript" type="text/javascript">
    function OnSelectedIndexChanged(s, e) {

        var value = s.GetValue();

        switch (value) {
            //rank
            case 1:case 5:
                memberLabel.SetVisible(true);
                comboMember.SetVisible(true);
                rankLabel.SetVisible(true);
                rankText.SetVisible(true);
                instructorTypeLabel.SetVisible(false);
                instructorTypeCbo.SetVisible(false);
                fromLabel.SetVisible(true);
                fromLabel.SetText('Date of Rank');
                fromDate.SetVisible(true);
                thruLabel.SetVisible(false);
                thruDate.SetVisible(false);
                tourneyLabel.SetVisible(true);
                tourneyCbo.SetVisible(true);
                completedLabel.SetVisible(true);
                completedChk.SetVisible(true);
                break;
            //Instructor 
            case 3: case 6:case 9:
                memberLabel.SetVisible(true);
                comboMember.SetVisible(true);
                rankLabel.SetVisible(false);
                rankText.SetVisible(false);
                instructorTypeLabel.SetVisible(true);
                instructorTypeCbo.SetVisible(true);
                instructorTypeCbo.SetText(certTypeCbo.GetText());
                fromLabel.SetVisible(true);
                fromLabel.SetText('Valid From');
                fromDate.SetVisible(true);
                thruLabel.SetVisible(true);
                thruDate.SetVisible(true);
                tourneyLabel.SetVisible(false);
                tourneyCbo.SetVisible(false);
                completedLabel.SetVisible(true);
                completedChk.SetVisible(true);

                break;
            //school 
            case 2: case 8:
                memberLabel.SetVisible(true);
                comboMember.SetVisible(true);
                rankLabel.SetVisible(false);
                rankText.SetVisible( false);
                instructorTypeLabel.SetVisible( false);
                instructorTypeCbo.SetVisible( false);
                fromLabel.SetVisible( true);
                fromLabel.SetText('Valid From');
                fromDate.SetVisible( true);
                thruLabel.SetVisible( true);
                thruDate.SetVisible( true);
                tourneyLabel.SetVisible( false);
                tourneyCbo.SetVisible( false);
                completedLabel.SetVisible(true);
                completedChk.SetVisible(true);

                break;
            //member 
            case 4: case 7:
                memberLabel.SetVisible(true);
                comboMember.SetVisible(true);
                rankLabel.SetVisible(false);
                rankText.SetVisible( false);
                instructorTypeLabel.SetVisible( false);
                instructorTypeCbo.SetVisible( false);
                fromLabel.SetVisible( true);
                fromLabel.SetText('Valid From');
                fromDate.SetVisible( true);
                thruLabel.SetVisible( true);
                thruDate.SetVisible( true);
                tourneyLabel.SetVisible( false);
                tourneyCbo.SetVisible( false);
                completedLabel.SetVisible(true);
                completedChk.SetVisible(true);

                break;
            //seminar
            case 10:
                memberLabel.SetVisible(true);
                comboMember.SetVisible(true);
                rankLabel.SetVisible(false);
                rankText.SetVisible( false);
                instructorTypeLabel.SetVisible( false);
                instructorTypeCbo.SetVisible( false);
                fromLabel.SetVisible( true);
                fromLabel.SetText('Seminar Date');
                fromDate.SetVisible( true);
                thruLabel.SetVisible( false);
                thruDate.SetVisible( false);
                tourneyLabel.SetVisible( true);
                tourneyCbo.SetVisible( true);
                completedLabel.SetVisible(true);
                completedChk.SetVisible(true);

                break;

        }
    }
    </script>
    <table>
        <tr>
            <td >
                <dx:ASPxLabel ID="lblTableName" runat="server" Text="Certificates" Style="font-weight: 700;
                    font-size: large">
                </dx:ASPxLabel>
            </td>
            <td> &nbsp;
            </td>
            <td style="text-align: right">
                <dx:ASPxHyperLink ID="lnkNewCerts" runat="server"  NavigateUrl="MemCertsView.aspx?viewType=incomplete" Text="New">
                </dx:ASPxHyperLink> &nbsp;|&nbsp;
                <dx:ASPxHyperLink ID="lnkOldCerts" runat="server"  NavigateUrl="MemCertsView.aspx?viewType=completed" Text="Completed">
                </dx:ASPxHyperLink> &nbsp;|&nbsp;
                <dx:ASPxHyperLink ID="lnkAllCerts" runat="server"  NavigateUrl="MemCertsView.aspx?viewType=all" Text="All">
                </dx:ASPxHyperLink>
            </td>

        </tr>
        <tr>
        <td colspan=3>
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="ID"
        ClientInstanceName="grid" OnHtmlRowPrepared="ASPxGridView1_HtmlRowPrepared" OnHtmlDataCellPrepared="ASPxGridView1_HtmlDataCellPrepared"
        OnRowInserting="ASPxGridView1_RowInserting" OnRowUpdating="ASPxGridView1_RowUpdating" 
        OnRowDeleting="ASPxGridView1_RowDeleting" OnCustomButtonCallback="ASPxGridView1_CustomButtonCallback"
        OnInitNewRow="ASPxGridView1_InitNewRow" SettingsEditing-Mode="EditForm"  OnHtmlRowCreated="ASPxGridView1_HtmlRowCreated"
        OnCustomCallback="ASPxGridView1_CustomCallback">
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsText ConfirmDelete="Delete the record?" />
        <SettingsCookies Enabled="true" StorePaging="true" StoreFiltering="true" />

<SettingsBehavior ConfirmDelete="True"></SettingsBehavior>

<SettingsEditing Mode="EditForm"></SettingsEditing>

<Settings ShowFilterRow="True"></Settings>

<SettingsText ConfirmDelete="Delete the record?" 
            PopupEditFormCaption="Edit Certificate"></SettingsText>

<SettingsCookies Enabled="True"></SettingsCookies>

        <Images HeaderSortDown-Url="~/images/Down.png" HeaderSortUp-Url="~/images/Up.png">
            <HeaderSortDown Url="~/images/Down.png">
            </HeaderSortDown>
            <HeaderSortUp Url="~/images/Up.png">
            </HeaderSortUp>
        </Images>
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="Clone">
                        <Image Url="~/images/clone.jpg" />
<Image Url="~/images/clone.jpg"></Image>
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
                <EditButton Visible="True" Image-Url="~/images/Edit.png">
                    <Image Url="~/images/Edit.png">
                    </Image>
                </EditButton>
                <NewButton Visible="false">
                </NewButton>
                <DeleteButton Visible="True" Image-Url="~/images/Trash.png">
                    <Image Url="~/images/Trash.png">
                    </Image>
                </DeleteButton>
                <ClearFilterButton Visible="True" Image-Url="~/images/ClearFilter.png" Text="Clear">
                    <Image Url="~/images/ClearFilter.png">
                    </Image>
                </ClearFilterButton>
                <UpdateButton Visible="true" Image-Url="~/images/OK.png">
                    <Image Url="~/images/OK.png">
                    </Image>
                </UpdateButton>
                <CancelButton Visible="true" Image-Url="~/images/Cancel.png">
                    <Image Url="~/images/Cancel.png">
                    </Image>
                </CancelButton>
                <HeaderCaptionTemplate>
                    <dx:ASPxImage ID="btnNew" runat="server" Text="New" ImageUrl="~/images/Add.png" IsPng="true">
                        <ClientSideEvents Click="function (s,e) { grid.AddNewRow();}" />
                    </dx:ASPxImage>
                    <dx:ASPxImage ID="btnFilter" runat="server" Text="Search" ImageUrl="~/images/search-icon.png"
                        IsPng="true">
                        <ClientSideEvents Click="function(s, e) {
	                                                                    grid.PerformCallback();
                                                                      }"></ClientSideEvents>
                    </dx:ASPxImage>
                </HeaderCaptionTemplate>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="FullName" ReadOnly="True" EditFormSettings-Visible="False"
                Settings-FilterMode="DisplayText" Settings-AutoFilterCondition="Contains" 
                VisibleIndex="3">
                <Settings FilterMode="DisplayText" AutoFilterCondition="Contains"></Settings>
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="InstructorsName" VisibleIndex="4" EditFormSettings-Visible="False"
                ReadOnly="True">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Dojo" VisibleIndex="2" EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="RankText" VisibleIndex="5" EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="InstructorType" VisibleIndex="6" EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CertType" VisibleIndex="1" 
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
                <DataItemTemplate><dx:ASPxImage ID="dimgCertType" OnInit="dimgCertType_OnInit" runat="server" Width="45" Height="45" /></DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="TournamentDate" VisibleIndex="11" 
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="FromDate" VisibleIndex="7" 
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="ThruDate" VisibleIndex="8" 
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" Visible="False" VisibleIndex="9"
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataCheckColumn FieldName="Completed" VisibleIndex="10" 
                EditFormSettings-Visible="False">
                <PropertiesCheckEdit AllowGrayedByClick="False" DisplayTextChecked="Completed" DisplayTextGrayed="All"
                    DisplayTextUnchecked="Incomplete" DisplayTextUndefined="All"  Style-Border-BorderColor="Black" Style-Border-BorderStyle="Solid" Style-Border-BorderWidth="1">
                    
                    <DisplayImageChecked Height="21px" Url="~/images/check.png" Width="21px" >
                    </DisplayImageChecked>
                    <DisplayImageUnchecked Height="21px" Url="~/images/blank.png" Width="21px">
                    </DisplayImageUnchecked>
                    <DisplayImageUndefined Height="21px" Url="~/images/blank.png" Width="21px">
                    </DisplayImageUndefined>
                    <DisplayImageGrayed Height="21px" Url="~/images/blank.png" Width="21px">
                    </DisplayImageGrayed>
                </PropertiesCheckEdit>
                <Settings AllowAutoFilter="False" AllowHeaderFilter="False" />

<Settings AllowAutoFilter="False" AllowHeaderFilter="False"></Settings>

                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataTextColumn FieldName="InstructorTypeID" Visible="False" VisibleIndex="12"
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="TournamentID" Visible="False" VisibleIndex="13"
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="MemberID" Visible="False" VisibleIndex="14"
                EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="DojoID" Visible="False" VisibleIndex="15" EditFormSettings-Visible="False">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="InstructorID" Visible="False" EditFormSettings-Visible="False"
                VisibleIndex="16">
                <EditFormSettings Visible="False"></EditFormSettings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CertificateTypeID" Visible="False" EditFormSettings-Visible="False"
                VisibleIndex="17">
                <EditFormSettings Visible="False"></EditFormSettings>
                
            </dx:GridViewDataTextColumn>
        </Columns>

        <SettingsText PopupEditFormCaption="Edit Certificate" />
        <Settings ShowFilterRow="True" />
        <Templates>
 <%--           <DataRow>
                <table>
                    <tr>
                        <td rowspan="3"><dx:ASPxImage ID="dimgCertType" OnInit="dimgCertType_OnInit" runat="server" /></td>
                        <td><dx:ASPxLabel ID="dlblLabelFullName" OnInit="dlblLabelFullName_OnInit" runat="server" Text="Full Name:"  /></td>
                        <td><dx:ASPxLabel ID="dlblTextFullName" OnInit="dlblTextFullName_OnInit" runat="server" Text="" /></td>
                        <td><dx:ASPxLabel ID="dlblLabelDate"  OnInit="dlblLabelDate_OnInit" runat="server" Text="Valid" /></td>
                        <td>edit</td>
                    </tr>
                    <tr>
                        <td><dx:ASPxLabel ID="dlblLabelDojo" OnInit="dlblLabelDojo_OnInit" runat="server" Text="Dojo:"  /></td>
                        <td><dx:ASPxLabel ID="dlblTextDojo" OnInit="dlblTextDojo_OnInit" runat="server" Text="" /></td>
                        <td><dx:ASPxLabel ID="dlblValidDates"  OnInit="dlblValidDates_OnInit" runat="server" Text="" /></td>
                        <td>copy</td>
                    </tr>
                    <tr>
                        <td><dx:ASPxLabel ID="dlblLabelInstName" OnInit="dlblLabelInstName_OnInit" runat="server" Text="Instructor:"  /></td>
                        <td><dx:ASPxLabel ID="dlblTextInstName" OnInit="dlblTextInstName_OnInit" runat="server" Text="" /></td>
                        <td><dx:ASPxLabel ID="dlblRankText" OnInit="dlblRankText_OnInit" runat="server" Text="" /></td>
                        <td>delete</td>
                    </tr>

            
                </table>
            
            </DataRow>--%>
            <EditForm>
                <table>
                                        <tr>
                            <td>
                                <dx:ASPxLabel ID="lblCertType" runat="server" Text="Cert Type" />
                            </td>
                            <td>
                                <dx:ASPxComboBox  ClientInstanceName="certTypeCbo" ID="cboCertType" runat="server" DataSourceID="edCertTypes" TextField="Name"
                                    Value='<%# Eval("CertificateTypeID") %>' ValueField="ID" EnableClientSideAPI="true" ValueType="System.Int32" ClientSideEvents-SelectedIndexChanged="function(s,e){OnSelectedIndexChanged(s,e);}" />
                            </td>
                        </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel runat="server" ID="lblMember" Text="Member" ClientInstanceName="memberLabel" />
                        </td>

                        <td>
                            <dx:ASPxGridLookup ID="ASPxGridLookup1" runat="server" AutoGenerateColumns="False"
                                ClientInstanceName="comboMember" DataSourceID="LinqServerModeDataSource1" GridViewImages-HeaderSortDown-Url="~/images/Down.png"
                                GridViewImages-HeaderSortUp-Url="~/images/Up.png" IncrementalFilteringMode="Contains"
                                KeyFieldName="ID" TextFormatString="{0}" Value='<%# Eval("MemberID") %>'>
                                <GridViewProperties>
                                    <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                                </GridViewProperties>
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="FullName" VisibleIndex="0">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Last" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="First" VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Country" VisibleIndex="3">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Dojo" VisibleIndex="4">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="MemType" VisibleIndex="5">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="RankText" VisibleIndex="6">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="State" VisibleIndex="7">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn FieldName="DateJoined" VisibleIndex="8">
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataDateColumn FieldName="DateOfRank" VisibleIndex="9">
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn FieldName="Active" VisibleIndex="10">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn FieldName="DateLastPaid" VisibleIndex="11">
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="12">
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <GridViewImages>
                                    <HeaderSortDown Url="~/images/Down.png">
                                    </HeaderSortDown>
                                    <HeaderSortUp Url="~/images/Up.png">
                                    </HeaderSortUp>
                                </GridViewImages>
                                <ClientSideEvents ValueChanged="function(s,e) { OnMemberChanged(s);}" />
                            </dx:ASPxGridLookup>
                        </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel  ID="lblCertID" runat="server" Text="ID" Visible="false" />
                            </td>
                            <td>
                                <dx:ASPxTextBox ID="txtID" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <dx:ASPxLabel ClientInstanceName="rankLabel" ID="lblRankText" runat="server" Text="Rank" />
                            </td>
                            <td>
                                <dx:ASPxTextBox  ClientInstanceName = "rankText" ID="txtRank" runat="server" Text='<%# Eval("RankText") %>' />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel   ClientInstanceName="instructorTypeLabel" ID="lblInstructorType" runat="server" Text="Instructor Type" />
                            </td>
                            <td>
                                <dx:ASPxComboBox    ClientInstanceName="instructorTypeCbo" ID="cboInstructorType" runat="server" DataSourceID="edInstructorTypes"
                                    TextField="InstructorTypeName" Value='<%# Eval("InstructorTypeID") %>' ValueField="ID"
                                    ValueType="System.Int32" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel   ID="lblFromDate"  ClientInstanceName="fromLabel" runat="server" Text="Valid From" />
                            </td>
                            <td>
                                <dx:ASPxDateEdit    ClientInstanceName="fromDate" ID="dtFrom" runat="server" Value='<%# GetDateOnError(Eval("FromDate")) %>' 
                                        ClientSideEvents-DateChanged="function(s,e){
                                                                                        var ct = certTypeCbo.GetValue();
                                                                                        
                                                                                        if (ct != 1 && ct != 5 && ct != 10) {
                                                                                            var date = fromDate.GetDate();
                                                                                            var newDate = new Date();
                                                                                            newDate.setFullYear(date.getFullYear() + 1,date.getMonth(),date.getDate());
                                                                                            thruDate.SetDate(newDate);
                                                                                        }
                                                                                    }" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel   ClientInstanceName="thruLabel" ID="lblThruDate" runat="server" Text="Thru" />
                            </td>
                            <td>
                                <dx:ASPxDateEdit   ClientInstanceName="thruDate" ID="dtThru" runat="server" Value='<%# GetDateOnError(Eval("ThruDate")) %>' />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel   ClientInstanceName="tourneyLabel" ID="lblTourney" runat="server" Text="Associated Tourney" />
                            </td>
                            <td>
                                <dx:ASPxComboBox    ClientInstanceName="tourneyCbo" ID="cboTourney" runat="server" DataSourceID="edTournaments" TextField="TournDate"
                                    Value='<%# Eval("TournamentID") %>' ValueField="ID" ValueType="System.Int32" />
                            </td>
                            <tr>
                                <td>
                                    <dx:ASPxLabel  ClientInstanceName="completedLabel" ID="lblCompleted" runat="server" Text="Completed" />
                                </td>
                                <td>
                                    <dx:ASPxCheckBox  ID="chkCompleted" ClientInstanceName="completedChk" runat="server" Value='<%# Eval("Completed") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <dx:ASPxGridViewTemplateReplacement ID="ASPxGridViewTemplateReplacement1" runat="server"
                                        ReplacementType="EditFormUpdateButton" />
                                    &nbsp;&nbsp;
                                    <dx:ASPxGridViewTemplateReplacement ID="ASPxGridViewTemplateReplacement2" runat="server"
                                        ReplacementType="EditFormCancelButton" />
                                </td>
                            </tr>
                        </tr>
                </table>
            </EditForm>
        </Templates>
    </dx:ASPxGridView>
    </td>
    </tr>
    </table>
    <cc1:LinqServerModeDataSource ID="LinqServerModeDataSource1" runat="server" ContextTypeName="NcmaMembership.LargeSetsDataContext"
        TableName="vwMemberGridLookups" />
    <asp:EntityDataSource ID="edCertTypes" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
        EnableFlattening="False" EntitySetName="certtypes">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edInstructorTypes" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
        EnableFlattening="False" EntitySetName="instructortypes">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edTournaments" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" EntitySetName="tournaments" ContextTypeName="NcmaMembership.MyNcmaEntities">
    </asp:EntityDataSource>
</asp:Content>
