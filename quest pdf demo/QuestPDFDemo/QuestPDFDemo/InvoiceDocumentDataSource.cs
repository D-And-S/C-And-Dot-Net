using QuestPDF.Helpers;
using System;

namespace QuestPDFDemo
{
    public static class InvoiceDocumentDataSource
    {
        private static Random random = new Random();

        public static InvoiceModel GetInvoiceDetails()
        {
            var items = Enumerable
                .Range(1, 400)
                .Select(i => GenerateRandomOrderItem())
                .ToList();

            return new InvoiceModel
            {
                InvoiceNumber = random.Next(1_000, 10_000),
                IssueDate = DateTime.Now,
                DueDate = DateTime.Now + TimeSpan.FromDays(14),

                SellerAddress = GenerateRandomAddress(),
                CustomerAddress = GenerateRandomAddress(),

                Items = items,
                Comments = Placeholders.Paragraph()
            };
        }

        private static OrderItem GenerateRandomOrderItem()
        {
            return new OrderItem
            {
                Name = Placeholders.Label(),
                Price = (decimal)Math.Round(random.NextDouble() * 100, 2),
                Quantity = random.Next(1, 10)
            };
        }

        private static Address GenerateRandomAddress()
        {
            return new Address
            {
                CompanyName = Placeholders.Name(),
                Street = Placeholders.Label(),
                City = Placeholders.Label(),
                State = Placeholders.Label(),
                Email = Placeholders.Email(),
                Phone = Placeholders.PhoneNumber()
            };
        }
    }
}
