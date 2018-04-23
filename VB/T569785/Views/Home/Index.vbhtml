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
        function Print() {
            window.open('@Url.Action("Print", "Home")', "PrintingFrame");
        }    
    </script>
</head>
<body>
    <div>
        @Using Html.BeginForm("Export", "Home")
            @<table style="text-align: center">
                <tr>
                    <td style="width: 150px">Printing</td>
                    <td style="width: 150px" colspan="2">Exporting</td>
                </tr>
                <tr>
                    <td>
                        <input type="button" value="Print" onclick="Print(); return false;" />
                        <iframe name="PrintingFrame" style="position:absolute; left: -10000px; top: -10000px;"></iframe>

                    </td>
                    <td>
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
                    <td>
                        <input type="submit" value="Export" />
                    </td>
                </tr>
            </table>
        End Using
    </div>
</body>
</html>
