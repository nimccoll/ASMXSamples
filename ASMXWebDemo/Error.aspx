<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ASMXWebDemo.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application Error</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>The following error has occurred</h2>
            <p><%: this.ErrorMessage %></p>
        </div>
    </form>
</body>
</html>
