<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="POCXmlReader._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container" class="jumbotron">
        <h1>Test Read XML</h1>

       <%-- <p><a id="clickLink" class="btn btn-primary btn-lg">Start</a></p>--%>
        <p>
            <asp:Button runat="server" ID="BtnStart" OnClick="OnClickAction" Text="Call XML" CssClass="btn btn-primary btn-lg"></asp:Button>
        </p>

        <label>Tiempo Consumido:  </label>
        <asp:Label ID="lblSeconds" runat="server" />
        <br />

        <label>Elementos Encontrados:  </label>
        <asp:Label ID="lblTotalElements" runat="server" />

    </div>


    <p><a id="clickLinkHide" class="btn btn-primary btn-lg">Finish</a></p>

    <table class="table table-bordered">
        <thead>
            <tr>
                <th>Firstname</th>
                <th>Lastname</th>
                <th>Email</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>John</td>
                <td>Doe</td>
                <td>john@example.com</td>
            </tr>
            <tr>
                <td>Mary</td>
                <td>Moe</td>
                <td>mary@example.com</td>
            </tr>
            <tr>
                <td>July</td>
                <td>Dooley</td>
                <td>july@example.com</td>
            </tr>
        </tbody>
    </table>





    <script src="Scripts/waitMe.min.js"></script>
    <script type="text/javascript">

        

        $("#clickLink").click(function () {

            PageMethods.TestXMLReader("Name", function(result)
            {
                alert(result);
            });

            //$.ajax({
            //type: "POST",
            //url: "Default.aspx/TestXMLReader",
            //success: function (data) {
            //    alert(data);
            //}
            //});

            //$('#container').waitMe({
            //    effect: 'bounce',
            //    text: 'asdas',
            //    bg: "rgba(255, 255, 255, 0.7)",
            //    color: "#000",
            //    maxSize: '',
            //    waitTime: -1,
            //    textPos: 'vertical',
            //    fontSize: '',
            //    source: ''
            //});
        })

        $("#clickLinkHide").click(function () {
            $('#container').waitMe("hide");
        })

    </script>

</asp:Content>

