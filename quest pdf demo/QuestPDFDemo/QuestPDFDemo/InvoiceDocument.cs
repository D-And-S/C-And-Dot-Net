using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Data.Common;
using System.Reflection;

namespace QuestPDFDemo
{
    public class InvoiceDocument : IDocument
    {
        public InvoiceModel Model { get; }

        public InvoiceDocument(InvoiceModel model)
        {
            Model = model;
        }
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
             .Page(page =>
             {
                 page.Size(PageSizes.A4);
                 page.Margin(5, Unit.Point);

                 page.Header().Column(col =>
                 {
                     col.Item()
                     //.MinHeight(90)
                     .Background(Colors.Grey.Lighten1)
                     .ShowOnce()
                     .Element(ComposeHeader);
                 });


                 page.Content()
                 .Background(Colors.Grey.Lighten3)
                 .Element(ComposeContent);

                 page.Footer()
                 .MinHeight(20)
                 .Background(Colors.Grey.Lighten1)
                 .Element(ComposeFooter);
             });
        }

        private void ComposeHeader(IContainer container)
        {
            var companyNameStyle = TextStyle.Default
                .FontSize(20)
                .SemiBold()
                .FontColor(Colors.Blue.Medium);

            container.Row(row =>
            {
                row.RelativeItem()
                .Padding(5)
                //.ExtendHorizontal()
                .Column(column =>
                {
                    column.Item().Text($"Neurogen").Style(companyNameStyle);
                    column.Item().Text("716 Dynamic Street, Torronto, Canada").Style(GeneralStyle());
                    column.Item().Text("Phone 12345689,    Phone 12356978").Style(GeneralStyle());
                    column.Item().Text("Web: www.something.com").Style(GeneralStyle());
                });

                row.ConstantItem(80)
                .Height(80)
                .Image("RPC-JP_Logo.png", ImageScaling.FitArea);
            });

        }

        private void ComposeContent(IContainer container)
        {
            container.Padding(5).Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent("From", Model.SellerAddress));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new AddressComponent("For", Model.CustomerAddress));
                });

                column.Spacing(10);

                column.Item().Element(ComposeTable);

                column.Item().Element(ComposeInTotal);
            });



            //container.Grid(grid =>
            //{
            //    //grid.Columns(12);


            //    grid.Item(12).Background("#eeeeee").Height(1);
            //    grid.VerticalSpacing(6);

            //    grid.Item(6).Background(Colors.Blue.Lighten1).MinHeight(50).Padding(5).Row(row =>
            //    {
            //        row.RelativeItem().Component(new AddressComponent("From", Model.SellerAddress));
            //    });

            //    grid.HorizontalSpacing(20);
            //    grid.Item(6).Background(Colors.Blue.Lighten1).MinHeight(40).Padding(5).Row(row =>
            //    {
            //        row.RelativeItem().Component(new AddressComponent("For", Model.CustomerAddress));
            //    });

            //    grid.VerticalSpacing(6);
            //    grid.Item(12).Background(Colors.Teal.Lighten1).MinHeight(70).Row(row =>
            //    {
            //        row.RelativeItem().Element(ComposeTable);
            //    });

            //});
        }

        private void ComposeInTotal(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(20);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(0);
                    columns.RelativeColumn(27);

                });

                var totalPrice = Model.Items.Sum(x => x.Price * x.Quantity);
                var totalUnitPrice = Model.Items.Sum(x => x.Price);

                table.Cell();
                table.Cell().Text("In Total").SemiBold().FontSize(14);
                table.Cell().Text($"{totalUnitPrice + 90000000}$").SemiBold().FontSize(14);
                table.Cell();
                table.Cell().Text($"{totalPrice + 90000000}$").SemiBold().FontSize(14);
            });
        }

        private void ComposeTable(IContainer container)
        {
            container.Padding(5).Table(table =>
            {

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Products");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Unit price");
                    header.Cell().Element(CellStyle).AlignCenter().Text("QTY");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Total");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Stock Price");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Knit Price");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Total Loss");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Total Gain");
                    header.Cell().Element(CellStyle).AlignCenter().Text("Purchase Price");


                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(30);
                    columns.RelativeColumn(50);
                    columns.RelativeColumn(20);
                    columns.RelativeColumn(15);
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(25);
                });

                foreach (var item in Model.Items)
                {
                    table.Cell().Element(CellStyle).Text(Model.Items.IndexOf(item) + 1);
                    table.Cell().Element(CellStyle).Text(item.Name);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.Quantity);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity + 589658778}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity}$");
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.Price * item.Quantity}$");

                }


                static IContainer CellStyle(IContainer container)
                {
                    return container.Border(3)
                    .BorderColor(Colors.Grey.Lighten2)
                    .Padding(5);
                }
            });

        }

        private void ComposeFooter(IContainer container)
        {
            container.Padding(5).DefaultTextStyle(GeneralStyle()).Row(row =>
            {
                row.RelativeItem()
                 .Column(column =>
                 {
                     column.Item()
                     .AlignLeft()
                     .Text(x =>
                     {
                         x.Span("Page ");
                         x.CurrentPageNumber();
                         x.Span("  /  ");
                         x.TotalPages();
                     });

                 });

                row.RelativeItem()
                   .AlignRight()
                   .Text(DateTime.Now.ToString("dd/MM/yyy"));
            });
        }

        private TextStyle GeneralStyle()
        {
            return TextStyle.Default
                            .FontSize(11)
                            .SemiBold();
        }
    }
}
