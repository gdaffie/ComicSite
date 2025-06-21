@Code
            ViewData("Title") = "About Us"
End Code

<div class="jumbotron">
    <style>
        h2, h3, address {
            text-align: center;
        }
    </style>
    <h2>@ViewData("Title")</h2>
    <h3>We're a company based on the convenience of fellow comic enthusiasts.</br> We make it easy to find the best comic deals near you! </h3>
    </br>

    <address>
        <h4><b>Based In</b></h4>
        Reitz Street 28<br />
        Potchefstroom, NW <br />
        <abbr title="Phone">P#:</abbr>
        060 883 1825
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">comicsalestore@support.co.za</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">comicsalestore@marketing.co.za</a>
    </address>


        <style>

            img {
                text-align: center;
                vertical-align:middle;
                width: 1025px;
                height: 440px;
            }

        </style>
        <img class="img" src="~/img/comtact-img.jpg" />


</div>