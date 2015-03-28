<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CertType.aspx.cs" Inherits="NcmaMembership.CertType" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Data.Linq" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxDocking" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridLookup" TagPrefix="dx" %>

<asp:Content 
    ID="HeaderContent" 
    ContentPlaceHolderID="HeadContent" 
    runat="server">
</asp:Content>

<asp:Content 
    ID="BodyContent" 
    ContentPlaceHolderID="MainContent" 
    runat="server">

    <dx:ASPxLabel 
        ID="lblTableName" 
        runat="server" 
        Text="Certificate Types" 
        Style="font-weight: 700;
        font-size: large">
    </dx:ASPxLabel>

    <dx:ASPxGridView 
        ClientInstanceName="grid" 
        ID="ASPxGridView1" 
        runat="server" 
        AutoGenerateColumns="False" 
        DataSourceID="edCertTypes" 
        KeyFieldName="ID" 
        OnHtmlDataCellPrepared="ASPxGridView1_HtmlDataCellPrepared" 
        OnCustomCallback="ASPxGridView1_CustomCallback">
        
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsBehavior ConfirmDelete="true" />
        <SettingsText ConfirmDelete="Delete the record?" />
        <SettingsCookies Enabled="true" StorePaging="true" StoreFiltering="true" />
        
        <Images 
            HeaderSortDown-Url="~/images/Down.png" 
            HeaderSortUp-Url="~/images/Up.png">
            <HeaderSortDown Url="~/images/Down.png">
            </HeaderSortDown>
            <HeaderSortUp Url="~/images/Up.png">
            </HeaderSortUp>
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

                <NewButton Visible="false">
                </NewButton>

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
                        Text="New" 
                        ImageUrl="~/images/Add.png" 
                        IsPng="true">
                        <ClientSideEvents Click="function (s,e) { grid.AddNewRow();}" />
                    </dx:ASPxImage>
                    <dx:ASPxImage 
                        ID="btnFilter" 
                        runat="server" 
                        Text="Search" 
                        ImageUrl="~/images/search-icon.png" 
                        IsPng="true">
                        <ClientSideEvents Click="function(s, e) { grid.PerformCallback(); }" />
                    </dx:ASPxImage>
                </HeaderCaptionTemplate>
            </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="1" Visible="false">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
    </Columns>
</dx:ASPxGridView>
<asp:EntityDataSource ID="edCertTypes" runat="server" 
    ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
    EnableDelete="True" EnableFlattening="False" EnableInsert="True" 
    EnableUpdate="True" EntitySetName="certtypes">
</asp:EntityDataSource>
</asp:Content>
