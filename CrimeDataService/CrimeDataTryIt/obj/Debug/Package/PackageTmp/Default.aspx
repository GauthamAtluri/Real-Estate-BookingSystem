<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrimeDataTryIt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="#993399" Text="CRIME DATA TRYIT PAGE"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" BackColor="#FFCCFF" Text="DESCRIPTION:"></asp:Label>
&nbsp;Crime Data Service that returns crime data for a particular location.<br />
        <asp:Label ID="Label3" runat="server" BackColor="#99FFCC" Text="INPUT"></asp:Label>
        :&nbsp; Integer (ZipCode of a Particular Location).<br />
        <asp:Label ID="Label4" runat="server" BackColor="#FFCC66" Text="OPERATION"></asp:Label>
        : int CrimeData(String ZipCode)<br />
        <asp:Label ID="Label5" runat="server" BackColor="#66CCFF" Text="OUTPUT"></asp:Label>
        : Integer (CrimeRate Index)<br />
        Service URL:<pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);"><a href="http://localhost:61873/Service1.svc?wsdl">http://10.1.12.42:61873/Service1.svc?wsdl</a></pre>
        TryIt URL : <a href="http://10.1.12.42:61956/Default.aspx">http://10.1.12.42:61956/Default.aspx</a><br />
        Main URL :http://10.1.12.42:19908/Default.aspx<br />
        &nbsp;<br />
        <asp:Label ID="Label6" runat="server" Text="Enter ZipCode:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Get CrimeData" OnClick="Button1_Click1" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="CrimeRate:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
