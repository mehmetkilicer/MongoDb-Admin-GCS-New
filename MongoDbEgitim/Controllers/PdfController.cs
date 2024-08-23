using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using MongoDbEgitim.Services.OrderServices;

namespace MongoDbProject.Controllers
{
    public class PdfController : Controller
    {
        private readonly IOrderService _orderService;

        public PdfController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult PdfList()
        {
            return View();
        }
        public async Task<IActionResult> GetOrderWithCustomerAndProduct()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfdocument/" + "orderlist.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdftable = new PdfPTable(3);
            pdftable.AddCell("Müşteri Ad");
            pdftable.AddCell("Ürün");
            pdftable.AddCell("Ürün Adet");
            var model = await _orderService.GetOrderWithCustomerAndProductAsync();
            foreach (var item in model)
            {
                pdftable.AddCell(item.Customer.CustomerFullName);
                pdftable.AddCell(item.Product.Name);
                pdftable.AddCell(item.OrderProductStock.ToString());
            }
            document.Add(pdftable);
            document.Close();
            return File("/pdfdocument/orderlist.pdf", "application/pdf", "orderlist.pdf");
        }
    }
}