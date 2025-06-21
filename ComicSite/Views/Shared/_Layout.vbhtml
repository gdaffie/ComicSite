<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - ComicStoreSite</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                </button> 
                @Html.ActionLink("ComicSaleSite", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"});
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Location", "About", "Home")</li>
                    <li>@Html.ActionLink("Favourites", "Favourites", "Home")</li>
                    <li>@Html.ActionLink("About Us", "Contact", "Home")</li>
                    <li><a href="https://screenrant.com/comics/">Latest News</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />

        <style>

            .footer {
                position: fixed;
                left: 0;
                bottom: 0;
                width: 100%;
                color: black;
                text-align: center;
            }

            .tbl {
                background-color:white;
                border-collapse: collapse;
                margin-left: auto;
                margin-right:auto;
                text-align: center;
            }

                .tbl th, .tbl td {
                    padding: 3px;
                    border: solid 1px #777;
                    text-align: center;
                }

                .tbl th {
                    background-color: lightblue;
                    text-align: center;
                }
        </style>

        <div class="footer">
            <table id="mytable" class="tbl" style="width:500px;">
                <tr>
                    <th>Name & Surname</th>
                    <th>Student Number</th>
                    <th>Course</th>
                </tr>
                <tr>
                    <td>Gert Daffie</td>
                    <td>20230642</td>
                    <td>Software Development</td>
                </tr>
            </table>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
