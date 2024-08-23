using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using MongoDbEgitim.Services.ProductServices;

namespace MongoDbEgitim.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IProductService _productService;

        public ExcelController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ExcelList()
        {
            return View();
        }
        public async Task<IActionResult> ProductWithCategoryExcelList()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Ürünler");
                workSheet.Cell(1, 1).Value = "Ürün Adı";
                workSheet.Cell(1, 2).Value = "Kategori";
                workSheet.Cell(1, 3).Value = "Stok";
                workSheet.Cell(1, 4).Value = "Adet Fiyat";
                workSheet.Cell(1, 5).Value = "Toplam Deger";

                var model = await _productService.GetProductWithCategoryExcelListAsync();

                int rowCount = 2;
                foreach (var item in model)
                {
                    workSheet.Cell(rowCount, 1).Value = item.Name;
                    workSheet.Cell(rowCount, 2).Value = item.Category.CategoryName;
                    workSheet.Cell(rowCount, 3).Value = item.Stock;
                    workSheet.Cell(rowCount, 4).Value = item.Price;
                    workSheet.Cell(rowCount, 5).Value = (item.Price * item.Stock).ToString("N2") + " TL"; rowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ProductList.xlsx");
                }
            }
        }
    }
}

