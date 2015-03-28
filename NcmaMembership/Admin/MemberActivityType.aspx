<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberActivityType.aspx.cs" Inherits="NcmaMembership.MemberActivityType" %>
<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxDocking" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxLabel ID="lblTableName" runat="server" Text="Member Activity Types" 
    style="font-weight: 700; font-size: large"></dx:ASPxLabel>
<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" ClientInstanceName="grid" 
    DataSourceID="edMemActTypes" KeyFieldName="ID">
    <SettingsBehavior ConfirmDelete="true" />
    <SettingsText ConfirmDelete="Delete the record?" />
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
        <dx:GridViewDataTextColumn Caption="ID" FieldName="ID" ReadOnly="True" 
            Visible="False" VisibleIndex="1">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn Caption="Member Activity Type" 
            FieldName="Description" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
    </Columns>
    <Settings ShowFilterRow="True" />
</dx:ASPxGridView>
<asp:EntityDataSource ID="edMemActTypes" runat="server" 
    ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities" ContextTypeName="NcmaMembership.MyNcmaEntities"
    EnableDelete="True" EnableFlattening="False" EnableInsert="True" 
    EnableUpdate="True" EntitySetName="memberactivitytypes">
</asp:EntityDataSource>
</asp:Content>
