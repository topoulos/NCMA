<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="NcmaMembership.Members" MasterPageFile="~/Site.master" ViewStateMode="Disabled" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2.Export, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView.Export" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxDocking" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<asp:Content 
    ID="HeaderContent" 
    runat="server" 
    ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content 
    ID="BodyContent" 
    runat="server" 
    ContentPlaceHolderID="MainContent">
</script>
 <table>
        <tr>
            <td >
                <dx:ASPxLabel ID="lblTableName" runat="server" Text="Members" Style="font-weight: 700;
                    font-size: large">
                </dx:ASPxLabel>
            </td>
            <td> &nbsp;
            </td>
            <td style="text-align: right">
                <dx:ASPxHyperLink ID="lnkActiveMembers" runat="server"  NavigateUrl="Members.aspx?viewType=true" Text="Active">
                </dx:ASPxHyperLink> &nbsp;|&nbsp;
                <dx:ASPxHyperLink ID="lnkInactiveMembers" runat="server"  NavigateUrl="Members.aspx?viewType=false" Text="Inactive">
                </dx:ASPxHyperLink> &nbsp;|&nbsp;
                <dx:ASPxHyperLink ID="lnkAllMembers" runat="server"  NavigateUrl="Members.aspx?viewType=all" Text="All">
                </dx:ASPxHyperLink>
            </td>

        </tr>
        <tr>
        <td colspan=3>    
    <table 
       cellpadding="0" 
       cellspacing="0">
        
        <tr>
            <td 
               style="padding-right: 4px">
                <dx:ASPxButton 
                   ID="btnPdfExport" 
                   runat="server" 
                   Text="Export to PDF" 
                   UseSubmitBehavior="False"
                   OnClick="btnPdfExport_Click">
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton 
                   ID="btnXlsExport" 
                   runat="server" 
                   Text="Export to XLS" 
                   UseSubmitBehavior="False"
                   OnClick="btnXlsExport_Click">
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton 
                   ID="btnXlsxExport" 
                   runat="server" 
                   Text="Export to XLSX" 
                   UseSubmitBehavior="False"
                   OnClick="btnXlsxExport_Click">
                </dx:ASPxButton>
            </td>
            <td style="padding-right: 4px">
                <dx:ASPxButton 
                   ID="btnRtfExport" 
                   runat="server" 
                   Text="Export to RTF" 
                   UseSubmitBehavior="False"
                   OnClick="btnRtfExport_Click" />
            </td>
            <td>
                <dx:ASPxButton 
                   ID="btnCsvExport" 
                   runat="server" 
                   Text="Export to CSV" 
                   UseSubmitBehavior="False"
                   OnClick="btnCsvExport_Click">
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    </td>
    </tr>
    <tr>
    <td colspan="3">
    <dx:ASPxGridView 
       ID="ASPxGridView1" 
       runat="server" 
       DataSourceID="LinqServerModeDataSource1"
       AutoGenerateColumns="False" 
       ClientInstanceName="grid"
       CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" 
       CssPostfix="Office2010Blue"
        ViewStateMode="Disabled" 
       KeyFieldName="ID" 
       OnRowUpdating="ASPxGridView1_RowUpdating"
       OnRowInserting="ASPxGridView1_RowInserting"
       OnRowDeleting="ASPxGridView1_RowDeleting"  
       Settings-ShowFilterBar="Visible"
       Settings-ShowFilterRowMenu="true"
       OnCustomCallback="ASPxGridView1_CustomCallback" 
            oninitnewrow="ASPxGridView1_InitNewRow">
        <SettingsPager PageSize="10" />
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsText ConfirmDelete="Delete the record?" />
        <SettingsCookies Enabled="true" StorePaging="true" StoreFiltering="true" />
        
        <Images 
            HeaderSortDown-Url="~/images/Down.png" 
            HeaderSortUp-Url="~/images/Up.png">
<LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Blue/GridView/Loading.gif"></LoadingPanelOnStatusBar>

            <HeaderSortDown Url="~/images/Down.png">
            </HeaderSortDown>
            <HeaderSortUp Url="~/images/Up.png">
            </HeaderSortUp>

<LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif"></LoadingPanel>
        </Images>

        <Columns>
            <dx:GridViewCommandColumn 
                VisibleIndex="0" 
                ButtonType="Image">

                <EditButton 
                    Visible="True" 
                    Image-Url="~/images/Edit.png">
                    <Image Url="~/images/Edit.png">
                    </Image>
                </EditButton>

               

                <DeleteButton 
                    Visible="True" 
                    Image-Url="~/images/Trash.png">
                    <Image Url="~/images/Trash.png">
                    </Image>
                </DeleteButton>

                <ClearFilterButton 
                    Visible="True" 
                    Image-Url="~/images/ClearFilter.png" 
                    Text="Clear">
                    <Image Url="~/images/ClearFilter.png">
                    </Image>
                </ClearFilterButton>

                <UpdateButton 
                    Visible="true" 
                    Image-Url="~/images/OK.png">
                    <Image Url="~/images/OK.png">
                    </Image>
                </UpdateButton>

                <CancelButton 
                    Visible="true" 
                    Image-Url="~/images/Cancel.png">
                    <Image Url="~/images/Cancel.png">
                    </Image>
                </CancelButton>

                <HeaderCaptionTemplate>
                    <dx:ASPxImage 
                        ID="btnNew" 
                        runat="server" 
                        ImageUrl="~/images/Add.png" 
                        IsPng="true">
                        <ClientSideEvents Click="function (s,e) { grid.AddNewRow();}" />
                    </dx:ASPxImage>
                    <dx:ASPxImage 
                        ID="btnFilter" 
                        runat="server" 
                        ImageUrl="~/images/search-icon.png" 
                        IsPng="true">
                        <ClientSideEvents Click="function(s, e) { grid.PerformCallback(); }" />
                    </dx:ASPxImage>
                </HeaderCaptionTemplate>
            </dx:GridViewCommandColumn>

            <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="1" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="LastName" VisibleIndex="2" Settings-AutoFilterCondition="Contains">
<Settings AutoFilterCondition="Contains"></Settings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="3" Settings-AutoFilterCondition="Contains">
<Settings AutoFilterCondition="Contains"></Settings>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="MiddleName" VisibleIndex="4" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Suffix" VisibleIndex="5" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Address1" VisibleIndex="6" Visible="false"
                Settings-AutoFilterCondition="Contains">
<Settings AutoFilterCondition="Contains"></Settings>
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Address2" VisibleIndex="7" Visible="false">
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Address3" VisibleIndex="8" Visible="false">
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="City" VisibleIndex="9" Visible="false">
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="StateID" VisibleIndex="10" Visible="true"
                Caption="State">
                <PropertiesComboBox DataSourceID="edStates" TextField="StateAbbrev" IncrementalFilteringMode="StartsWith"
                    ValueField="ID" ValueType="System.Int32">
                </PropertiesComboBox>
                <EditFormSettings Visible="True" />
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Country" FieldName="CountryID" VisibleIndex="11">
                <PropertiesComboBox DataSourceID="edCountries" TextField="Name" ValueField="ID" ValueType="System.Int32" IncrementalFilteringMode="StartsWith" >
                
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="PostalCode" VisibleIndex="12" Visible="false">
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="HomePhone" VisibleIndex="13" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="CellPhone" VisibleIndex="14" Visible="false">
                <EditFormSettings Visible="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Email" VisibleIndex="15" Visible="false">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="DOB" VisibleIndex="16" Visible="false">
                <PropertiesDateEdit Spacing="0">
                </PropertiesDateEdit>
                <EditFormSettings Visible="True" />
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataComboBoxColumn Caption="Dojo" FieldName="DojoID" VisibleIndex="18">
                <PropertiesComboBox DataSourceID="edDojos" TextField="Name" ValueField="ID" ValueType="System.Int32" IncrementalFilteringMode="StartsWith">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="MemberTypeID" VisibleIndex="19">
                <PropertiesComboBox DataSourceID="edMemTypes" TextField="Name" ValueField="ID" ValueType="System.Int32" IncrementalFilteringMode="StartsWith">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn FieldName="DateJoined" VisibleIndex="20">
                <PropertiesDateEdit Spacing="0">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn Caption="Rank" FieldName="RankText" VisibleIndex="21">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="DateOfRank" VisibleIndex="22">
                <PropertiesDateEdit Spacing="0">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataCheckColumn FieldName="Active" VisibleIndex="23">
                 <EditFormSettings Visible="True"></EditFormSettings>
                <PropertiesCheckEdit AllowGrayedByClick="False" DisplayTextChecked="Active" DisplayTextGrayed="All"
                    DisplayTextUnchecked="Inactive" DisplayTextUndefined="All" >
                    
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



            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataDateColumn FieldName="DateInactive" VisibleIndex="24" Visible="false">
                <PropertiesDateEdit Spacing="0">
                </PropertiesDateEdit>
                <EditFormSettings Visible="True" />
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="DateLastPaid" VisibleIndex="25" Visible="true">
                <PropertiesDateEdit Spacing="0">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Comments" VisibleIndex="26" Visible="False">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsEditing Mode="PopupEditForm" PopupEditFormWidth="800px"></SettingsEditing>
        <Settings ShowFilterRow="True" ShowGroupPanel="True" />
        <Images SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
            <LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanelOnStatusBar>
            <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanel>
        </Images>
        <ImagesFilterControl>
            <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanel>
        </ImagesFilterControl>
        <Styles CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue">
            <Header ImageSpacing="5px" SortingImageSpacing="5px">
            </Header>
            <LoadingPanel ImageSpacing="5px">
            </LoadingPanel>
        </Styles>
        <StylesPager>
            <PageNumber ForeColor="#3E4846">
            </PageNumber>
            <Summary ForeColor="#1E395B">
            </Summary>
        </StylesPager>
        <StylesEditors ButtonEditCellSpacing="0">
            <ProgressBar Height="21px">
            </ProgressBar>
        </StylesEditors>
        <Templates>
            <EditForm>
                
                <div style="padding: 4px 4px 3px 4px;">
                    <dx:ASPxPageControl runat="server" ID="pageControl" Width="100%">
                        <TabPages>
                            <dx:TabPage Text="Info" Visible="true">
                                <ContentCollection>
                                    <dx:ContentControl runat="server">
                                        <dx:ASPxGridViewTemplateReplacement ID="Editors" ReplacementType="EditFormEditors" 
                                            Width="100%" runat="server"></dx:ASPxGridViewTemplateReplacement>
                                    </dx:ContentControl>
                                </ContentCollection>
                            </dx:TabPage>
                            <dx:TabPage Text="Notes" Visible="true">
                                <ContentCollection>
                                    <dx:ContentControl runat="server">
                                        <dx:ASPxMemo runat="server" ID="commentsEditor" Text='<%# Eval("Comments")%>' Width="100%"
                                            Height="93px">
                                        </dx:ASPxMemo>
                                    </dx:ContentControl>
                                </ContentCollection>
                            </dx:TabPage>
                        </TabPages>
                    </dx:ASPxPageControl>
                </div>
                <div style="text-align: right; padding: 2px 2px 2px 2px">
                    <dx:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton"
                        runat="server"></dx:ASPxGridViewTemplateReplacement>
                    <dx:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton"
                        runat="server"></dx:ASPxGridViewTemplateReplacement>
                </div>
            </EditForm>
        </Templates>
    </dx:ASPxGridView>
    </td>
    </tr>
    </table>
    <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="ASPxGridView1"
        ExportedRowType="All" Landscape="true" TopMargin="10" RightMargin="10" LeftMargin="10"
        BottomMargin="10" PaperKind="Legal">
    </dx:ASPxGridViewExporter>
    <asp:EntityDataSource ID="edStates" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="states">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edCountries" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="countries">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edPlans" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="products">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edDojos" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="dojoes">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edMemTypes" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="membertypes">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edRanks" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities"
        EnableFlattening="False" EntitySetName="ranks">
    </asp:EntityDataSource>
    <cc1:LinqServerModeDataSource 
        ID="LinqServerModeDataSource1" 
        runat="server" 
        ContextTypeName="NcmaMembership.LargeSetsDataContext" 
        TableName="members" onselecting="LinqServerModeDataSource1_Selecting">
    </cc1:LinqServerModeDataSource>

</asp:Content>
