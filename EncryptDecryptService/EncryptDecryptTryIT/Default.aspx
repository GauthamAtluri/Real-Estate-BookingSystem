<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EncryptDecryptTryIT.Default" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#99FF99" Text="Encryption-Decryption Service"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description:" BackColor="#3399FF"></asp:Label>
        &nbsp; This is an encryption-decryption service which takes the user input as string and encrypts it using a secure triple DES algorithm and can be decrypted back.<br />
        <asp:Label ID="Label3" runat="server" Text="Input:" BackColor="#FF99FF"></asp:Label>
        &nbsp;String( text to be encrypted/decrypted)<br />
        <asp:Label ID="Label4" runat="server" Text="Output:" BackColor="#66FF99"></asp:Label>
        : String(Encypted/Decrypted Output)<br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Service URL:"></asp:Label>
        &nbsp;<pre style="border: 1px solid rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: 'Courier New'; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(229, 229, 204);">http://10.1.12.42:43131/Service1.svc?wsdl</a></pre>
        TryIT Page URL:&nbsp;&nbsp; <a href="http://10.1.12.42:54464/Default.aspx">http://10.1.12.42:54464/Default.aspx</a><br />
        MainPageURL: http://10.1.12.42:19908/Default.aspx<br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Enter the String for Encryption:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="351px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Encrypt" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Encrypted String is:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Width="354px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Decrypt" />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Decrypted String is:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="355px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
