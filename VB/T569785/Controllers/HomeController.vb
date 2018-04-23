Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports T569785.Models
Imports DevExpress.XtraReports.UI
Imports T569785.Reports
Imports System.IO
Imports DevExpress.XtraPrinting
Imports System.Web.Mvc

Namespace T569785.Controllers
    Public Class HomeController
        Inherits Controller

        '
        ' GET: /Home/

        Private Function ExportDocument(ByVal document() As Byte, ByVal format As String, ByVal fileName As String, ByVal isInline As Boolean) As FileResult
            Dim contentType As String
            Dim disposition As String = If(isInline, "inline", "attachment")

            Select Case format.ToLower()
                Case "docx"
                    contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                Case "xls"
                    contentType = "application/vnd.ms-excel"
                Case "xlsx"
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                Case "mht"
                    contentType = "message/rfc822"
                Case "html"
                    contentType = "text/html"
                Case "txt", "csv"
                    contentType = "text/plain"
                Case "png"
                    contentType = "image/png"
                Case Else
                    contentType = String.Format("application/{0}", format)
            End Select

            Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName))
            Return File(document, contentType)
        End Function

        Public Function Index() As ActionResult
            Return View(New ExportModel() With {.Format = "pdf"})
        End Function

        <HttpGet()> _
        Public Function Print() As ActionResult
            Dim report As XtraReport = New ProductsReport()
            Using ms As New MemoryStream()
                report.ExportToPdf(ms, New PdfExportOptions() With {.ShowPrintDialogOnOpen = True})
                Return ExportDocument(ms.ToArray(), "pdf", "Report.pdf", True)
            End Using
        End Function


        <HttpPost()> _
        Public Function Export(ByVal model As ExportModel) As ActionResult
            Dim report As XtraReport = New ProductsReport()
            Dim fileName As String = String.Format("Report.{0}", model.Format)

            Using ms As New MemoryStream()
                Select Case model.Format
                    Case "pdf"
                        report.ExportToPdf(ms)
                    Case "docx"
                        report.ExportToDocx(ms)
                    Case "xls"
                        report.ExportToXls(ms)
                    Case "xlsx"
                        report.ExportToXlsx(ms)
                    Case "rtf"
                        report.ExportToRtf(ms)
                    Case "mht"
                        report.ExportToMht(ms)
                    Case "html"
                        report.ExportToHtml(ms)
                    Case "txt"
                        report.ExportToText(ms)
                    Case "csv"
                        report.ExportToCsv(ms)
                    Case "png"
                        report.ExportToImage(ms, New ImageExportOptions() With {.Format = System.Drawing.Imaging.ImageFormat.Png})
                End Select

                Return ExportDocument(ms.ToArray(), model.Format, fileName, False)
            End Using
        End Function

    End Class
End Namespace
