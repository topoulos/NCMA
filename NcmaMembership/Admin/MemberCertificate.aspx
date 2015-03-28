﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberCertificate.aspx.cs" Inherits="NcmaMembership.Admin.MemberCertificate" %>
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
        Text="Certificates" 
        Style="font-weight: 700;
        font-size: large">
    </dx:ASPxLabel>

    <dx:ASPxGridView 
        ClientInstanceName="grid" 
        ID="ASPxGridView1" 
        runat="server" 
        AutoGenerateColumns="False" 
        DataSourceID="edCertificates" 
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
            <dx:GridViewDataTextColumn FieldName="id" ReadOnly="True" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn 
                FieldName="MemberID" 
                VisibleIndex="2" 
                Settings-AutoFilterCondition="Contains" 
                Caption="Member">

                <EditItemTemplate>

                    <dx:ASPxGridLookup 
                        ID="ASPxGridLookup1" 
                        runat="server" 
                        AutoGenerateColumns="False" 
                        ClientInstanceName="comboMember" 
                        DataSourceID="LinqServerModeDataSource1" 
                        GridViewImages-HeaderSortDown-Url="~/images/Down.png" 
                        GridViewImages-HeaderSortUp-Url="~/images/Up.png" 
                        IncrementalFilteringMode="Contains" 
                        KeyFieldName="ID" 
                        TextFormatString="{0}" 
                        Value='<%# Bind("MemberID") %>' 
                        ValueType="System.Int32">
                        <GridViewProperties>
                            <SettingsBehavior 
                                AllowFocusedRow="True" 
                                AllowSelectByRowClick="True" 
                                AllowSelectSingleRowOnly="True"/>
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
                            <dx:GridViewDataTextColumn FieldName="Rank" VisibleIndex="6">
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
                    </dx:ASPxGridLookup>
                </EditItemTemplate>
                <DataItemTemplate>
                    <dx:ASPxLabel 
                        ID="lblMember" 
                        runat="server" 
                        Text="">
                    </dx:ASPxLabel>
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
	    <dx:GridViewDataComboBoxColumn 
		Caption="Cert Type" 
		FieldName="CertType" 
		VisibleIndex="3">
		<EditFormSettings Visible="False">
		</EditFormSettings>
		<PropertiesComboBox 
		    DataSourceID="edCertType" 
		    IncrementalFilteringMode="Contains" 
		    TextField="Name" 
		    ValueField="Name"
		    ValueType="System.String">
		    <DropDownButton 
			Enabled="True" 
			Visible="True">
		    </DropDownButton>
		</PropertiesComboBox>
		<Settings FilterMode="DisplayText" />
	    </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn FieldName="FromDate" VisibleIndex="3">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="ThruDate" VisibleIndex="4">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="RankText" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
	    <dx:GridViewDataComboBoxColumn 
		Caption="Instructor Type" 
		FieldName="InstructorType" 
		VisibleIndex="3">
		<EditFormSettings Visible="False">
		</EditFormSettings>
		<PropertiesComboBox 
		    DataSourceID="edInstructorType" 
		    IncrementalFilteringMode="Contains" 
		    TextField="InstructorTypeName" 
		    ValueField="InstructorTypeName"
		    ValueType="System.String">
		    <DropDownButton 
			Enabled="True" 
			Visible="True">
		    </DropDownButton>
		</PropertiesComboBox>
		<Settings FilterMode="DisplayText" />
		<DataItemTemplate>
		    <dx:ASPxLabel ID="lblDojo" runat="server" Text=''>
		    </dx:ASPxLabel>
		</DataItemTemplate>
	    </dx:GridViewDataComboBoxColumn>
        </Columns>
    <Settings ShowFilterRow="True" />
</dx:ASPxGridView>
    <asp:EntityDataSource ID="edCertificates" runat="server" ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" DefaultContainerName="MyNcmaEntities" 
        EnableDelete="True" EnableFlattening="False" EnableInsert="True" 
        EnableUpdate="True" EntitySetName="certificates">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edInstructorType" runat="server"  ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" 
        DefaultContainerName="MyNcmaEntities" EnableFlattening="False" 
        EntitySetName="instructortypes">
    </asp:EntityDataSource>
    <asp:EntityDataSource ID="edCertType" runat="server"  ContextTypeName="NcmaMembership.MyNcmaEntities"
        ConnectionString="name=MyNcmaEntities" 
        DefaultContainerName="MyNcmaEntities" EnableFlattening="False" 
        EntitySetName="certtypes">
    </asp:EntityDataSource>
        <cc1:LinqServerModeDataSource 
        ID="LinqServerModeDataSource1" 
        runat="server" 
        ContextTypeName="NcmaMembership.LargeSetsDataContext" 
        TableName="vwMemberGridLookups">
    </cc1:LinqServerModeDataSource>

</asp:Content>
