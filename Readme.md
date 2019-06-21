<!-- default file list -->
*Files to look at*:

* [FilterConfig.cs](./CS/T569785/App_Start/FilterConfig.cs) (VB: [FilterConfig.vb](./VB/T569785/App_Start/FilterConfig.vb))
* [RouteConfig.cs](./CS/T569785/App_Start/RouteConfig.cs) (VB: [RouteConfig.vb](./VB/T569785/App_Start/RouteConfig.vb))
* [WebApiConfig.cs](./CS/T569785/App_Start/WebApiConfig.cs) (VB: [WebApiConfig.vb](./VB/T569785/App_Start/WebApiConfig.vb))
* [HomeController.cs](./CS/T569785/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T569785/Controllers/HomeController.vb))
* [ExportModel.cs](./CS/T569785/Models/ExportModel.cs) (VB: [ExportModel.vb](./VB/T569785/Models/ExportModel.vb))
* [Index.cshtml](./CS/T569785/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to print/export XtraReport in an ASP.NET MVC application without showing a report preview
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t569785)**
<!-- run online end -->


<p>This example demonstrates how to print/export XtraReports in an ASP.NET MVC application without displaying these reports' preview. </p>
<p>The main idea is to rerun the document exported by one of XtraReport's <strong>ExportTo...</strong> methods as the action result by using the <a href="https://msdn.microsoft.com/en-us/library/system.web.mvc.controller.file(v=vs.118).aspx">Controller.File</a> method.<br>To print the report, export it to PDF and enable the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPdfExportOptions_ShowPrintDialogOnOpentopic">ShowPrintDialogOnOpen</a> option in the export options. Then, return this PDF file as an action result with the <strong>Content-Disposition</strong> header set to the "inline" value. In this case, this PDF will be opened by the browser's PDF plugin. To avoid opening the PDF viewer in the browser's window, export the PDF to a separate iframe. In this case, only the print dialog will be displayed.<br><br><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E454">E454: How to print a report without displaying it in a web application</a><br><a href="https://www.devexpress.com/Support/Center/p/T227361">How to print/export XtraReport in an ASP.NET WebForms application without showing a report preview</a></p>

<br/>


