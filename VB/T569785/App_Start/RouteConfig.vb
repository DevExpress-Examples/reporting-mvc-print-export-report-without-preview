Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc
Imports System.Web.Routing


Namespace T569785
    Public Class RouteConfig
        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

            routes.MapRoute(name:="Default", url:="{controller}/{action}/{id}", defaults:=New With { _
                Key .controller = "Home", _
                Key .action = "Index", _
                Key .id = Mvc.UrlParameter.Optional _
            })
        End Sub
    End Class
End Namespace
