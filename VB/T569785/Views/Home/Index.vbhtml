@Code
    Layout = Nothing
End Code
@ModelType T569785.Models.ExportModel
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <script type="text/javascript">
        function PrintWithiFrame() {
            window.open('@Url.Action("Print", "Home")', "PrintingFrame");
            var frameElement = document.getElementById("FrameToPrint");
            frameElement.addEventListener("load", function (e) {
                if (frameElement.contentDocument.contentType !== "text/html")
                    frameElement.contentWindow.print();
            });
        }
            function PrintInNewWindow() {
            var frameElement = window.open('@Url.Action("Print", "Home")', "_blank");

            frameElement.addEventListener("load", function (e) {
                if (frameElement.document.contentType !== "text/html")
                    frameElement.print();
            });
        }
    </script>
</head>
<body>
    <div>
        @Using Html.BeginForm("Export", "Home")
        @<table style="text-align: center; border-collapse: collapse">
            <tr style="border-bottom: 1pt solid black">
                <td style="width: 150px">
                    PDF-based Printing
                </td>
                <td style="width: 150px" colspan="2">
                    Exporting
                </td>
            </tr>
            <tr>
                <td width="500px">
                    <input type="button" value="Print With iFrame" onclick="PrintWithiFrame(); return false;" /> <br />
                    <b>Note:</b> Printing with an invisible iFrame element is not recommended. Although this solution provides more desktop-like experience, it's not guaranteed to work reliably across all browsers. For example, it won't work in the Edge or Safari browser. <br />
                    <br />
                    <input type="button" value="Print New Window" onclick="PrintInNewWindow(); return false;" /> <br />
                    <b>Note:</b> clicking this button will open a separate tab in the browser. This is the recommented approach.
                    <iframe id="FrameToPrint" name="PrintingFrame" style="position:absolute; left: -10000px; top: -10000px;"></iframe>
                </td>
                <td style="vertical-align: top">
                    @Html.DropDownListFor(Function(m) m.Format, New SelectListItem() {
                        New SelectListItem() With {.Value = "pdf", .Text = "Pdf"},
                        New SelectListItem() With {.Value = "docx", .Text = "Docx"},
                        New SelectListItem() With {.Value = "xls", .Text = "Xls"},
                        New SelectListItem() With {.Value = "xlsx", .Text = "Xlsx"},
                        New SelectListItem() With {.Value = "rtf", .Text = "Rtf"},
                        New SelectListItem() With {.Value = "mht", .Text = "Mht"},
                        New SelectListItem() With {.Value = "html", .Text = "Html"},
                        New SelectListItem() With {.Value = "txt", .Text = "Text"},
                        New SelectListItem() With {.Value = "csv", .Text = "Csv"},
                        New SelectListItem() With {.Value = "png", .Text = "Image"}
                    })
                </td>
                <td style="vertical-align: top">
                    <input type="submit" value="Export" />
                </td>
            </tr>
        </table>
		End Using
    </div>
</body>
</html>
