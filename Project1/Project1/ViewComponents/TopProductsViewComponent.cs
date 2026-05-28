using Microsoft.AspNetCore.Mvc;

namespace Project1.ViewComponents
{
    public class TopProductsViewComponent : ViewComponent
    {
        private readonly Services.IProductService _productService;
        public TopProductsViewComponent(Services.IProductService productService)
        {
            _productService = productService;
        }
        //public IViewComponentResult Invoke(int Count)
        //{
        //    var topProducts = _productService.GetAllProducts().Take(Count).ToList();
        //    return View(topProducts);
        //}
        public async Task<IViewComponentResult> InvokeAsync(int Count)
        {
            var topProducts = _productService.GetAllProducts().Take(Count).ToList();
            return View(topProducts);
        }
    }
}
