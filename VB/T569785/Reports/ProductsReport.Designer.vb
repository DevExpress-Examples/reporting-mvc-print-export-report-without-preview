Namespace T569785.Reports
    Partial Public Class ProductsReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductsReport))
            Me.tcUnitsInStockHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.tcUnitsOnOrder = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcDiscont = New DevExpress.XtraReports.UI.XRTableCell()
            Me.cbDiscont = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.trProductData = New DevExpress.XtraReports.UI.XRTableRow()
            Me.GroupHeaderTitle = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tcProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitPriceHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcProductNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcUnitsOnOrderHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tbProductData = New DevExpress.XtraReports.UI.XRTable()
            Me.tcDiscontHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.tcUnitsInStock = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tbProductHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
            Me.trProductHeader = New DevExpress.XtraReports.UI.XRTableRow()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.tbProductData, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' tcUnitsInStockHeader
            ' 
            Me.tcUnitsInStockHeader.Dpi = 100F
            Me.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader"
            Me.tcUnitsInStockHeader.Text = "Units In Stock"
            Me.tcUnitsInStockHeader.Weight = 0.46634598636061309R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' tcUnitsOnOrder
            ' 
            Me.tcUnitsOnOrder.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
            Me.tcUnitsOnOrder.Dpi = 100F
            Me.tcUnitsOnOrder.Name = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.StylePriority.UseTextAlignment = False
            Me.tcUnitsOnOrder.Text = "tcUnitsOnOrder"
            Me.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitsOnOrder.Weight = 0.44903843327809811R
            ' 
            ' tcDiscont
            ' 
            Me.tcDiscont.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.cbDiscont})
            Me.tcDiscont.Dpi = 100F
            Me.tcDiscont.Name = "tcDiscont"
            Me.tcDiscont.Text = "tcDiscont"
            Me.tcDiscont.Weight = 0.2384614904279494R
            ' 
            ' cbDiscont
            ' 
            Me.cbDiscont.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.cbDiscont.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Products.Discontinued")})
            Me.cbDiscont.Dpi = 100F
            Me.cbDiscont.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.cbDiscont.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.cbDiscont.Name = "cbDiscont"
            Me.cbDiscont.SizeF = New System.Drawing.SizeF(50F, 23F)
            Me.cbDiscont.StylePriority.UseBorders = False
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
            Me.ReportHeader.Dpi = 100F
            Me.ReportHeader.HeightF = 100F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' trProductData
            ' 
            Me.trProductData.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductName, Me.tcUnitPrice, Me.tcUnitsInStock, Me.tcUnitsOnOrder, Me.tcDiscont})
            Me.trProductData.Dpi = 100F
            Me.trProductData.Name = "trProductData"
            Me.trProductData.Weight = 1R
            ' 
            ' GroupHeaderTitle
            ' 
            Me.GroupHeaderTitle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.GroupHeaderTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductHeader})
            Me.GroupHeaderTitle.Dpi = 100F
            Me.GroupHeaderTitle.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeaderTitle.HeightF = 25F
            Me.GroupHeaderTitle.Name = "GroupHeaderTitle"
            Me.GroupHeaderTitle.RepeatEveryPage = True
            Me.GroupHeaderTitle.StylePriority.UseBorders = False
            Me.GroupHeaderTitle.StylePriority.UseFont = False
            Me.GroupHeaderTitle.StylePriority.UseTextAlignment = False
            Me.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' tcProductName
            ' 
            Me.tcProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
            Me.tcProductName.Dpi = 100F
            Me.tcProductName.Name = "tcProductName"
            Me.tcProductName.StylePriority.UseTextAlignment = False
            Me.tcProductName.Text = "tcProductName"
            Me.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.tcProductName.Weight = 1.3798077514467915R
            ' 
            ' tcUnitPrice
            ' 
            Me.tcUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
            Me.tcUnitPrice.Dpi = 100F
            Me.tcUnitPrice.Name = "tcUnitPrice"
            Me.tcUnitPrice.StylePriority.UseTextAlignment = False
            Me.tcUnitPrice.Text = "tcUnitPrice"
            Me.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitPrice.Weight = 0.4663461624235804R
            ' 
            ' tcUnitPriceHeader
            ' 
            Me.tcUnitPriceHeader.Dpi = 100F
            Me.tcUnitPriceHeader.Name = "tcUnitPriceHeader"
            Me.tcUnitPriceHeader.Text = "Unit Price"
            Me.tcUnitPriceHeader.Weight = 0.4663460215732067R
            ' 
            ' tcProductNameHeader
            ' 
            Me.tcProductNameHeader.Dpi = 100F
            Me.tcProductNameHeader.Name = "tcProductNameHeader"
            Me.tcProductNameHeader.Text = "Product Name"
            Me.tcProductNameHeader.Weight = 1.379807857084572R
            ' 
            ' tcUnitsOnOrderHeader
            ' 
            Me.tcUnitsOnOrderHeader.Dpi = 100F
            Me.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader"
            Me.tcUnitsOnOrderHeader.Text = "Units On Order"
            Me.tcUnitsOnOrderHeader.Weight = 0.44903843327809806R
            ' 
            ' tbProductData
            ' 
            Me.tbProductData.Dpi = 100F
            Me.tbProductData.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbProductData.Name = "tbProductData"
            Me.tbProductData.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trProductData})
            Me.tbProductData.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            ' 
            ' tcDiscontHeader
            ' 
            Me.tcDiscontHeader.Dpi = 100F
            Me.tcDiscontHeader.Name = "tcDiscontHeader"
            Me.tcDiscontHeader.Text = "Discont."
            Me.tcDiscontHeader.Weight = 0.23846170170351017R
            ' 
            ' Detail
            ' 
            Me.Detail.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbProductData})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.StylePriority.UseBorders = False
            Me.Detail.StylePriority.UseTextAlignment = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' tcUnitsInStock
            ' 
            Me.tcUnitsInStock.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
            Me.tcUnitsInStock.Dpi = 100F
            Me.tcUnitsInStock.Name = "tcUnitsInStock"
            Me.tcUnitsInStock.StylePriority.UseTextAlignment = False
            Me.tcUnitsInStock.Text = "tcUnitsInStock"
            Me.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcUnitsInStock.Weight = 0.46634616242358046R
            ' 
            ' tbProductHeader
            ' 
            Me.tbProductHeader.Dpi = 100F
            Me.tbProductHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbProductHeader.Name = "tbProductHeader"
            Me.tbProductHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trProductHeader})
            Me.tbProductHeader.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            ' 
            ' lbHeader
            ' 
            Me.lbHeader.Dpi = 100F
            Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
            Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
            Me.lbHeader.Name = "lbHeader"
            Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
            Me.lbHeader.StylePriority.UseFont = False
            Me.lbHeader.StylePriority.UseTextAlignment = False
            Me.lbHeader.Text = "Products Report"
            Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' trProductHeader
            ' 
            Me.trProductHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcProductNameHeader, Me.tcUnitPriceHeader, Me.tcUnitsInStockHeader, Me.tcUnitsOnOrderHeader, Me.tcDiscontHeader})
            Me.trProductHeader.Dpi = 100F
            Me.trProductHeader.Name = "trProductHeader"
            Me.trProductHeader.Weight = 1R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind.mdb"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Name = "Products"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' ProductsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderTitle, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "16.1"
            CType(Me.tbProductData, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tbProductHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private tcUnitsInStockHeader As DevExpress.XtraReports.UI.XRTableCell
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private tcUnitsOnOrder As DevExpress.XtraReports.UI.XRTableCell
        Private tcDiscont As DevExpress.XtraReports.UI.XRTableCell
        Private cbDiscont As DevExpress.XtraReports.UI.XRCheckBox
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private lbHeader As DevExpress.XtraReports.UI.XRLabel
        Private trProductData As DevExpress.XtraReports.UI.XRTableRow
        Private tcProductName As DevExpress.XtraReports.UI.XRTableCell
        Private tcUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Private tcUnitsInStock As DevExpress.XtraReports.UI.XRTableCell
        Private GroupHeaderTitle As DevExpress.XtraReports.UI.GroupHeaderBand
        Private tbProductHeader As DevExpress.XtraReports.UI.XRTable
        Private trProductHeader As DevExpress.XtraReports.UI.XRTableRow
        Private tcProductNameHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcUnitPriceHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcUnitsOnOrderHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcDiscontHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tbProductData As DevExpress.XtraReports.UI.XRTable
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

    End Class
End Namespace
