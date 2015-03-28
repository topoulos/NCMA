<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MembersByDojoReportViewer.aspx.cs" Inherits="NcmaMembership.Admin.Reports.MembersByDojoReportViewer" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.XtraReports.v11.2.Web, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="background-color: #DAE5F2"><tr><td valign="top">
        <dx:ASPxLabel ID="lblReportType" runat="server" Text="Report Type:">
        </dx:ASPxLabel>
        <dx:ASPxComboBox ID="cboReportType" runat="server">
            <Items>
                <dx:ListEditItem Text="Date of Rank" Value="Rank" />
                <dx:ListEditItem Text="Date Last Paid" Value="Paid" />
                <dx:ListEditItem Text="Date Joined" Value="Joined" />
            </Items>
        </dx:ASPxComboBox>
            <br />
            <dx:ASPxLabel runat="server" Text="From">
            </dx:ASPxLabel>
            <dx:ASPxDateEdit runat="server" ID="dtFrom">
            </dx:ASPxDateEdit>
            <br />
            <dx:ASPxLabel runat="server" Text="Thru">
            </dx:ASPxLabel>
            <dx:ASPxDateEdit runat="server" ID="dtThru">
            </dx:ASPxDateEdit>
            <br />
            <dx:ASPxButton runat="server" Text="Go">
            </dx:ASPxButton>
    </td><td valign="top">
    <dx:ReportToolbar ID="ReportToolbar1" runat='server' ShowDefaultButtons='False' 
        ReportViewerID="ReportViewer1">
        <Images SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
        </Images>
        <Items>
            <dx:ReportToolbarButton ItemKind='Search' />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind='PrintReport' />
            <dx:ReportToolbarButton ItemKind='PrintPage' />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton Enabled='False' ItemKind='FirstPage' />
            <dx:ReportToolbarButton Enabled='False' ItemKind='PreviousPage' />
            <dx:ReportToolbarLabel ItemKind='PageLabel' />
            <dx:ReportToolbarComboBox ItemKind='PageNumber' Width='65px'>
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind='OfLabel' />
            <dx:ReportToolbarTextBox IsReadOnly='True' ItemKind='PageCount' />
            <dx:ReportToolbarButton ItemKind='NextPage' />
            <dx:ReportToolbarButton ItemKind='LastPage' />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind='SaveToDisk' />
            <dx:ReportToolbarButton ItemKind='SaveToWindow' />
            <dx:ReportToolbarComboBox ItemKind='SaveFormat' Width='70px'>
                <Elements>
                    <dx:ListElement Value='pdf' />
                    <dx:ListElement Value='xls' />
                    <dx:ListElement Value='xlsx' />
                    <dx:ListElement Value='rtf' />
                    <dx:ListElement Value='mht' />
                    <dx:ListElement Value='html' />
                    <dx:ListElement Value='txt' />
                    <dx:ListElement Value='csv' />
                    <dx:ListElement Value='png' />
                </Elements>
            </dx:ReportToolbarComboBox>
        </Items>
        <Styles CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" 
            CssPostfix="Office2010Blue">
            <LabelStyle HorizontalAlign="Center" VerticalAlign="Middle">
            </LabelStyle>
            <ButtonStyle HorizontalAlign="Center" VerticalAlign="Middle">
            </ButtonStyle>
            <EditorStyle>
                <Paddings Padding="2px" />
            </EditorStyle>
        </Styles>
    </dx:ReportToolbar>
    <dx:ReportViewer ID="ReportViewer1" runat="server"  OnUnload="ReportViewer1_Unload"
        CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" 
        CssPostfix="Office2010Blue" 
        SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
        <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
        </LoadingPanelImage>
        <LoadingPanelStyle ForeColor="#1E395B" ImageSpacing="5px">
            <Paddings PaddingBottom="10px" PaddingLeft="14px" PaddingRight="14px" 
                PaddingTop="10px" />
            <Border BorderColor="#859EBF" BorderStyle="Solid" BorderWidth="1px" />
        </LoadingPanelStyle>
    </dx:ReportViewer></td></tr></table>
</asp:Content>
