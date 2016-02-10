<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidateTryItPage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#99FF33" Text="Validation Services"></asp:Label>
        <br />
        Service URL :
        <pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);"><a href="http://localhost:38367/Service1.svc?wsdl">http://10.1.12.42:38367/Service1.svc?wsdl</a></pre>
        Try It Page URL: <a href="http://10.1.12.42:56210/Default.aspx">http://10.1.12.42:56210/Default.aspx</a><br />
        MainPage URL: http://10.1.12.42:19908/Default.aspx<br />
        <br />
        <asp:Label ID="Label2" runat="server" BackColor="#3399FF" Text="Email Validation Service"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Description:"></asp:Label>
&nbsp;This service validates the email adress entered by the user.<br />
        <asp:Label ID="Label3" runat="server" Text="Input:"></asp:Label>
&nbsp;&nbsp; String(email)<br />
        <asp:Label ID="Label5" runat="server" Text="Output:"></asp:Label>
&nbsp;Boolean(True or False)<br />
        <br />
&nbsp;<asp:Label ID="Label6" runat="server" Text="Enter the Email address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="291px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Validate" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Valid" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" BackColor="#FFCC66" Text="Password Validation Service"></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Description:"></asp:Label>
&nbsp;This service validates the password entered by the user.<br />
        <asp:Label ID="Label10" runat="server" Text="Input:"></asp:Label>
&nbsp;String(password)<br />
        <asp:Label ID="Label11" runat="server" Text="Outut"></asp:Label>
        :&nbsp; Boolean(True or False)<br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Enter Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="297px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Validate" Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Valid" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" BackColor="#FF6600" Text="Username Validation Service"></asp:Label>
        <br />
        <asp:Label ID="Label15" runat="server" Text="Description:"></asp:Label>
&nbsp;This service validates the username entered by the user.<br />
        <asp:Label ID="Label16" runat="server" Text="Input"></asp:Label>
        : String (username)<br />
        <asp:Label ID="Label17" runat="server" Text="Output:"></asp:Label>
&nbsp;Boolea (True or False)<br />
        <br />
        <br />
        <asp:Label ID="Label18" runat="server" Text="Enter Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="303px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Validate" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label19" runat="server" Text="Valid" Visible="False"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
