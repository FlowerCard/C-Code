<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxTest01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="JS/jquery-3.5.1.min.js"></script>
    <script type="text/javascript">
        $(function () {
            console.log($('a'));
        });
        var formElement = document.form1;
        alert(formElement.action);
    </script>
</head>
<body>
    <p>段落1</p>
    <p>段落2</p>
    <p>段落3</p>
    <table border="1">
        <tr>
            <td>第1行</td><td>第1行</td>
        </tr>

        <tr>
            <td>第2行</td><td>第2行</td>
        </tr>

        <tr>
            <td>第3行</td><td>第3行</td>
        </tr>

        <tr>
            <td>第4行</td><td>第4行</td>
        </tr>

        <tr>
            <td>第5行</td><td>第5行</td>
        </tr>

        <tr>
            <td>第6行</td><td>第6行</td>
        </tr>

    </table>

    <table border="1">
        <tr>
            <td>第1行</td><td>第1行</td>
        </tr>

        <tr>
            <td>第2行</td><td>第2行</td>
        </tr>

        <tr>
            <td>第3行</td><td>第3行</td>
        </tr>

        <tr>
            <td>第4行</td><td>第4行</td>
        </tr>

        <tr>
            <td>第5行</td><td>第5行</td>
        </tr>

        <tr>
            <td>第6行</td><td>第6行</td>
        </tr>

    </table>

</body>
<script type="text/javascript">

    $("p").each(function (index, domEle) {
        $(domEle).click(function () {
            alert($(this).html())
        })
    })
    


</script>
</html>
