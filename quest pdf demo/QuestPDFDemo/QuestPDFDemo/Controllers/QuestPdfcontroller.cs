using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace QuestPDFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestPdfcontroller : ControllerBase
    {
        [HttpGet("GeneratePDF")]
        public IActionResult GeneratePdf()
        {
            // var filePath = "invoice.pdf";
            
            var model = InvoiceDocumentDataSource.GetInvoiceDetails();
            var document = new InvoiceDocument(model);
            document.ShowInPreviewer();


            //Process.Start("explorer.exe", "data.pdf");
            return Ok();
        }
    }
}
