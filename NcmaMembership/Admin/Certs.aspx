<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Certs.aspx.cs" Inherits="NcmaMembership.Certs" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridLookup" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Xpo.v11.2.Web, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Data.Linq" TagPrefix="cc1" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
<!--

-->
    </script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxLabel ID="lblTableName" runat="server" Text="Certificates" Style="font-weight: 700;
        font-size: large">
    </dx:ASPxLabel>
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" SettingsEditing-Mode="PopupEditForm"
        DataSourceID="edCerts" KeyFieldName="ID" ClientInstanceName="grid" OnHtmlRowPrepared="ASPxGridView1_HtmlRowPrepared"
        OnHtmlDataCellPrepared="ASPxGridView1_HtmlDataCellPrepared" OnRowInserting="ASPxGridView1_RowInserting">
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsText ConfirmDelete="Delete the record?" />
        <SettingsCookies Enabled="true" StorePaging="true" StoreFiltering="true" />
        <Images HeaderSortDown-Url="~/images/Down.png" HeaderSortUp-Url="~/images/Up.png">
            <HeaderSortDown Url="~/images/Down.png">
            </HeaderSortDown>
            <HeaderSortUp Url="~/images/Up.png">
            </HeaderSortUp>
        </Images>
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0" ButtonType="Image">
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
                </HeaderCaptionTemplate>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="1" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Member" FieldName="MemberID" VisibleIndex="2">
                <Settings FilterMode="DisplayText" />
                <EditItemTemplate>
                    <dx:ASPxGridLookup ID="ASPxGridLookup1" runat="server" AutoGenerateColumns="False"
                        ClientInstanceName="comboMember" DataSourceID="LinqServerModeDataSource1" GridViewImages-HeaderSortDown-Url="images\Down.png"
                        GridViewImages-HeaderSortUp-Url="images\Up.png" IncrementalFilteringMode="Contains"
                        KeyFieldName="ID" TextFormatString="{1}" Value='<%# Bind("MemberID") %>'>
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
            <dx:GridViewDataComboBoxColumn 
                
                Caption="Dojo" 
                FieldName="DojoID" 
                VisibleIndex="3">
                <EditFormSettings Visible="False">
                </EditFormSettings>
                <PropertiesComboBox 
                    DataSourceID="edDojos" 
                    IncrementalFilteringMode="Contains" 
                    TextField="Name" 
                    ValueField="ID"
                    ValueType="System.Int32">
                    <DropDownButton 
                        Enabled="False" 
                        Visible="False">
                    </DropDownButton>
                </PropertiesComboBox>
                <Settings FilterMode="DisplayText" />
                <DataItemTemplate>
                    <dx:ASPxLabel ID="lblDojo" runat="server" Text=''>
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Cert Type" FieldName="CertificateTypeID"
                VisibleIndex="3">
                <PropertiesComboBox DataSourceID="edCertTypes" IncrementalFilteringMode="Contains"
                    TextField="Name" ValueField="ID">
                    <DropDownButton Enabled="False" Visible="False">
                    </DropDownButton>
                </PropertiesComboBox>
                <Settings FilterMode="DisplayText" />
                <EditItemTemplate>
                    <dx:ASPxGridLookup ID="ASPxGridLookup3" runat="server" TextFormatString="{1}" DataSourceID="edCertTypes"
                        KeyFieldName="ID" Value='<%# Bind("CertificateTypeID") %>' IncrementalFilteringMode="Contains"
                        GridViewImages-HeaderSortDown-Url="~/images/Down.png" GridViewImages-HeaderSortUp-Url="~/images/Up.png">
                        <GridViewProperties>
                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                        </GridViewProperties>
                        <Columns>
                            <dx:GridViewDataColumn FieldName="ID" ReadOnly="true" Visible="false" />
                            <dx:GridViewDataColumn FieldName="Name" ReadOnly="true" />
                            <dx:GridViewDataColumn FieldName="Description" ReadOnly="true" />
                        </Columns>
                    </dx:ASPxGridLookup>
                </EditItemTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn Caption="Rank" FieldName="RankText" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn Caption="Member's Instructor" FieldName="InstructorID"
                VisibleIndex="2">
                <EditFormSettings Visible="False" />
                <PropertiesComboBox DataSourceID="edInstructors" IncrementalFilteringMode="Contains"
                    TextField="FullName" ValueField="ID">
                    <DropDownButton Enabled="False" Visible="False">
                    </DropDownButton>
                </PropertiesComboBox>
                <Settings FilterMode="DisplayText" />
                <DataItemTemplate>
                    <dx:ASPxLabel ID="lblInstructor" runat="server" Text=''>
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Instructor Type" FieldName="InstructorTypeID"
                VisibleIndex="7">
                <PropertiesComboBox DataSourceID="edInstructorTypes" IncrementalFilteringMode="Contains"
                    TextField="InstructorTypeName" ValueField="ID">
                    <DropDownButton Enabled="False" Visible="False">
                    </DropDownButton>
                </PropertiesComboBox>
                <Settings FilterMode="DisplayText" />
                <EditItemTemplate>
                    <dx:ASPxGridLookup ID="ASPxGridLookup2" runat="server" TextFormatString="{1}" DataSourceID="edInstructorTypes"
                        KeyFieldName="ID" Value='<%# Bind("InstructorTypeID") %>' IncrementalFilteringMode="Contains"
                        GridViewImages-HeaderSortDown-Url="~/images/Down.png" GridViewImages-HeaderSortUp-Url="~/images/Up.png">
                        <GridViewProperties>
                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                        </GridViewProperties>
                        <Columns>
                            <dx:GridViewDataColumn FieldName="ID" ReadOnly="true" Visible="false" />
                            <dx:GridViewDataColumn FieldName="InstructorTypeName" ReadOnly="true" />
                        </Columns>
                    </dx:ASPxGridLookup>
                </EditItemTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn FieldName="FromDate" VisibleIndex="8">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="ThruDate" VisibleIndex="9">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataCheckColumn FieldName="Completed" VisibleIndex="10">
            </dx:GridViewDataCheckColumn>
            <dx:GridViewDataComboBoxColumn 
                Caption="Tournament" 
                FieldName="TourneyID" 
                VisibleIndex="3">
                <PropertiesComboBox 
                    DataSourceID="edTournaments" 
                    IncrementalFilteringMode="Contains" 
                    TextField="TournDate" 
                    ValueField="ID">
                    <DropDownButton 
                        Enabled="False" 
                        Visible="False">
                    </DropDownButton>
                </PropertiesComboBox>
                <Settings FilterMode="DisplayText" />
                <EditItemTemplate>
                    <dx:ASPxGridLookup ID="ASPxGridLookup2" runat="server" TextFormatString="{1}" DataSourceID="edTournaments"
                        KeyFieldName="ID" Value='<%# Bind("TourneyID") %>' IncrementalFilteringMode="Contains"
                        GridViewImages-HeaderSortDown-Url="~/images/Down.png" GridViewImages-HeaderSortUp-Url="~/images/Up.png"
                        AutoGenerateColumns="False">
                        <GridViewProperties>
                            <SettingsBehavior AllowFocusedRow="True" AllowSelectByRowClick="True" AllowSelectSingleRowOnly="True" />
                        </GridViewProperties>
                        <Columns>
                            <dx:GridViewDataColumn FieldName="ID" ReadOnly="true" Visible="false" />
                            <dx:GridViewDataColumn FieldName="TournDate" ReadOnly="true" />
                        </Columns>
                    </dx:ASPxGridLookup>
                </EditItemTemplate>
            </dx:GridViewDataComboBoxColumn>
        </Columns>
        <SettingsEditing Mode="PopupEditForm"></SettingsEditing>
        <Settings ShowFilterRow="True" ShowGroupPanel="True" />
    </dx:ASPxGridView>
    <cc1:LinqServerModeDataSource ID="LinqServerModeDataSource1" runat="server" ContextTypeName="NcmaMembership.LargeSetsDataContext"
        TableName="vwMemberGridLookups" />
    <asp:EntityDataSource ID="edCerts" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
        EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True"
        EntitySetName="membercerts">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edDojos" runat="server" ConnectionString="name=MyNcmaEntities"
        DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
        EnableFlattening="False" EntitySetName="dojoes">
    </asp:EntityDataSource>
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
