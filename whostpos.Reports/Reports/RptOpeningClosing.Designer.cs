
using whostpos.Entitys.Entites;

namespace DPOS.Reports
{
    partial class RptOpeningClosing
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.OpeningClosingBalance = new Telerik.Reporting.ObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0665181875228882D), Telerik.Reporting.Drawing.Unit.Inch(0.208333358168602D));
            this.textBox7.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox7.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox7.StyleName = "";
            this.textBox7.Value = "Date";
            // 
            // textBox1
            // 
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5987226963043213D), Telerik.Reporting.Drawing.Unit.Inch(0.208333358168602D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox1.Value = "Opening";
            // 
            // textBox2
            // 
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6515203714370728D), Telerik.Reporting.Drawing.Unit.Inch(0.208333358168602D));
            this.textBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox2.Value = "Closing";
            // 
            // textBox3
            // 
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.683199405670166D), Telerik.Reporting.Drawing.Unit.Inch(0.208333358168602D));
            this.textBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox3.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox3.Value = "Balance";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.42712259292602539D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.detail.Name = "detail";
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.0665181875228882D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5987229347229004D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6515203714370728D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.683199405670166D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.21874985098838806D)));
            this.table1.Body.SetCellContent(0, 3, this.textBox6);
            this.table1.Body.SetCellContent(0, 0, this.textBox9);
            this.table1.Body.SetCellContent(0, 1, this.textBox8);
            this.table1.Body.SetCellContent(0, 2, this.textBox4);
            tableGroup1.Name = "Group1";
            tableGroup1.ReportItem = this.textBox7;
            tableGroup2.ReportItem = this.textBox1;
            tableGroup3.ReportItem = this.textBox2;
            tableGroup4.ReportItem = this.textBox3;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.DataSource = this.OpeningClosingBalance;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.textBox9,
            this.textBox8,
            this.textBox4,
            this.textBox7,
            this.textBox1,
            this.textBox2,
            this.textBox3});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.table1.Name = "table1";
            tableGroup5.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping(null)});
            tableGroup5.Name = "DetailGroup";
            this.table1.RowGroups.Add(tableGroup5);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.9999604225158691D), Telerik.Reporting.Drawing.Unit.Inch(0.42708322405815125D));
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.683199405670166D), Telerik.Reporting.Drawing.Unit.Inch(0.21874986588954926D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox6.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox6.Value = "= Fields.Debit - Fields.Credit";
            // 
            // textBox9
            // 
            this.textBox9.Format = "{0:d}";
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0665181875228882D), Telerik.Reporting.Drawing.Unit.Inch(0.21874986588954926D));
            this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox9.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox9.StyleName = "";
            this.textBox9.Value = "=Fields.EntityDate";
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5987226963043213D), Telerik.Reporting.Drawing.Unit.Inch(0.21874986588954926D));
            this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox8.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox8.StyleName = "";
            this.textBox8.Value = "=Fields.Debit";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6515203714370728D), Telerik.Reporting.Drawing.Unit.Inch(0.21874986588954926D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.029999999329447746D);
            this.textBox4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.019999999552965164D);
            this.textBox4.StyleName = "";
            this.textBox4.Value = "=Fields.Credit";
            // 
            // OpeningClosingBalance
            // 
            this.OpeningClosingBalance.DataSource = typeof(OpeningClosingBalance);
            this.OpeningClosingBalance.Name = "OpeningClosingBalance";
            // 
            // RptOpeningClosing
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "RptOpeningClosing";
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        public Telerik.Reporting.ObjectDataSource OpeningClosingBalance;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox4;
    }
}