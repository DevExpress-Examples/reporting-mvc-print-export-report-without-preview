using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T569785.Models;
using DevExpress.XtraReports.UI;
using T569785.Reports;
using System.IO;
using DevExpress.XtraPrinting;

namespace T569785.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        private FileResult ExportDocument(byte[] document, string format, string fileName, bool isInline) {
            string contentType;
            string disposition = (isInline) ? "inline" : "attachment";

            switch (format.ToLower()) {
                case "docx":
                    contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "xls":
                    contentType = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case "mht":
                    contentType = "message/rfc822";
                    break;
                case "html":
                    contentType = "text/html";
                    break;
                case "txt":
                case "csv":
                    contentType = "text/plain";
                    break;
                case "png":
                    contentType = "image/png";
                    break;
                default:
                    contentType = String.Format("application/{0}", format);
                    break;
            }

            Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName));
            return File(document, contentType);
        }

        public ActionResult Index() {
            return View(new ExportModel() { Format = "pdf" });
        }

        [HttpGet]
        public ActionResult Print() {
            XtraReport report = new ProductsReport();
            using (MemoryStream ms = new MemoryStream()) {
                report.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = true });
                return ExportDocument(ms.ToArray(), "pdf", "Report.pdf", true);
            }
        }


        [HttpPost]
        public ActionResult Export(ExportModel model) {
            XtraReport report = new ProductsReport();
            string fileName = String.Format("Report.{0}", model.Format);

            using (MemoryStream ms = new MemoryStream()) {
                switch (model.Format) {
                    case "pdf":
                        report.ExportToPdf(ms);
                        break;
                    case "docx":
                        report.ExportToDocx(ms);
                        break;
                    case "xls":
                        report.ExportToXls(ms);
                        break;
                    case "xlsx":
                        report.ExportToXlsx(ms);
                        break;
                    case "rtf":
                        report.ExportToRtf(ms);
                        break;
                    case "mht":
                        report.ExportToMht(ms);
                        break;
                    case "html":
                        report.ExportToHtml(ms);
                        break;
                    case "txt":
                        report.ExportToText(ms);
                        break;
                    case "csv":
                        report.ExportToCsv(ms);
                        break;
                    case "png":
                        report.ExportToImage(ms, new ImageExportOptions() { Format = System.Drawing.Imaging.ImageFormat.Png });
                        break;                      
                }
                
                return ExportDocument(ms.ToArray(), model.Format, fileName, false);
            }
        }
       
    }
}
