<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br /><br /><br />
            
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />
            
            <label for="txtMessage">Message:</label>
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="4" OnTextChanged="txtMessage_TextChanged"></asp:TextBox><br /><br />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
           <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
