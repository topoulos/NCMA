<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MemberCerts.aspx.cs" Inherits="NcmaMembership.Admin.MemberCerts" %>

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
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="edCerts"
        KeyFieldName="ID" ClientInstanceName="grid" OnHtmlRowPrepared="ASPxGridView1_HtmlRowPrepared"
        OnHtmlDataCellPrepared="ASPxGridView1_HtmlDataCellPrepared" OnRowInserting="ASPxGridView1_RowInserting"
        OnRowUpdating="ASPxGridView1_RowUpdating" OnCustomButtonCallback="ASPxGridView1_CustomButtonCallback"
        OnInitNewRow="ASPxGridView1_InitNewRow" SettingsEditing-Mode="Inline" 
        OnCustomCallback="ASPxGridView1_CustomCallback" 
        CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" 
        CssPostfix="Office2010Blue">
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsText ConfirmDelete="Delete the record?" />
        <SettingsCookies Enabled="true" StorePaging="true" StoreFiltering="true" />
        <Images HeaderSortDown-Url="~/images/Down.png" 
            HeaderSortUp-Url="~/images/Up.png" 
            SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
            <LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanelOnStatusBar>
            <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanel>
        </Images>
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="Clone">
                        <Image Url="~/images/clone.jpg" />
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
                <ClearFilterButton Visible="True">
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
            <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="MemberID" Caption="Member" VisibleIndex="2">
                <Settings FilterMode="DisplayText" />
                <EditItemTemplate>
                    <dx:ASPxGridLookup ID="ASPxGridLookup1" runat="server" AutoGenerateColumns="False"
                        ClientInstanceName="comboMember" DataSourceID="LinqServerModeDataSource1" GridViewImages-HeaderSortDown-Url="images\Down.png"
                        GridViewImages-HeaderSortUp-Url="images\Up.png" IncrementalFilteringMode="Contains"
                        KeyFieldName="ID" TextFormatString="{0}" Value='<%# Bind("MemberID") %>'>
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
                            <HeaderSortDown Url="images\Down.png">
                            </HeaderSortDown>
                            <HeaderSortUp Url="images\Up.png">
                            </HeaderSortUp>
                        </GridViewImages>
                        <ClientSideEvents ValueChanged="function(s,e) { OnMemberChanged(s);}" />
                    </dx:ASPxGridLookup>
                </EditItemTemplate>
                <DataItemTemplate>
                    <dx:ASPxLabel ID="lblMember" runat="server" Text=''>
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="DojoID" VisibleIndex="3" Caption="Dojo">
                <DataItemTemplate>
                    <dx:ASPxLabel ID="lblDojo" runat="server" Text=''>
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="CertificateTypeID" VisibleIndex="4" Caption="Certificate">
                <PropertiesComboBox DataSourceID="edCertTypes" TextField="Name" ValueField="ID">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="RankText" VisibleIndex="6" Caption="Rank">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="InstructorID" VisibleIndex="7" Caption="Member's Instructor">
                <DataItemTemplate>
                    <dx:ASPxLabel ID="lblInstructor" runat="server" Text=''>
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn 
                FieldName="InstructorTypeID" 
                VisibleIndex="5" 
                Caption="Certificate Instructor Type">
                <PropertiesComboBox DataSourceID="edInstructorTypes" TextField="InstructorTypeName" ValueType="System.Int32"
                    ValueField="ID">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn FieldName="FromDate" VisibleIndex="8">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="ThruDate" VisibleIndex="9">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataCheckColumn FieldName="Completed" VisibleIndex="11">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataComboBoxColumn FieldName="TourneyID" VisibleIndex="10" Caption="Associated Tourney">
                <PropertiesComboBox DataSourceID="edTournaments" TextField="TournDate" ValueField="ID">
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
        </Columns>
        <SettingsEditing Mode="Inline"></SettingsEditing>
        <Settings ShowFilterRow="True" />
        <ImagesFilterControl>
            <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
            </LoadingPanel>
        </ImagesFilterControl>
        <Styles CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" 
            CssPostfix="Office2010Blue">
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
    </dx:ASPxGridView>
    <asp:EntityDataSource ID="edCerts" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" EnableDelete="True" EnableFlattening="False"
        EnableInsert="True" EnableUpdate="True" EntitySetName="membercerts">
    </asp:EntityDataSource>
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
        DefaultContainerName="MyNcmaEntities" EntitySetName="tournaments">
    </asp:EntityDataSource>
</asp:Content>
