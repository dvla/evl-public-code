<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Code/MasterPages/ApplicationTemplate.Master"
    CodeBehind="ExamplepageFromMaster.aspx.vb" Inherits="EVLPublicCode.ExamplepageFromMaster" %>

<%@ Register Assembly="EVLPublicCode" Namespace="EVLPublicCode.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <cc1:ScriptGenerator ID="TaxStepScriptGenerator" runat="server" StepId="TaxStep"
        XslPath="<%$ Resources:EVLFilePaths, TaxScriptPath %>" />
</asp:Content>
