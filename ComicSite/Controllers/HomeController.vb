Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Business description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Business contact page."

        Return View()
    End Function

    Function Favourites() As ActionResult
        ViewData("Message") = "Business favourites page."

        Return View()
    End Function

End Class

