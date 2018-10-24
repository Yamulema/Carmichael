<!-- #include file=../globalinclude.asp --> 
<%
Response.Write "Test Login ASP"
    Response.Write "<BR>"
    Response.Write "<BR>"

if (len(Session("test")) = 0) then 
	Response.Write "<BR>"
    Response.Write "Test Session Empty - Go to Login"
    Response.Redirect "../Login/Login.aspx"
    Response.Write "<BR>"
else
	Response.Write "<BR>"
    Response.Write "Test Session Value:"  & " " & Session("test")
    Response.Write "<BR>"
end if

Response.Write "<BR>"

%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title></title></head>
<body>
    <a class="ver10pxred" href="logout.asp"><b><u>Logout</u></b></a>
</body>
</html>
