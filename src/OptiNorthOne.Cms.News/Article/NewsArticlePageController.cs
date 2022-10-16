namespace OptiNorthOne.Cms.News.Article;

using EPiServer.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

public class NewsArticlePageController : PageController<NewsArticlePage>
{
    public IActionResult Index(NewsArticlePage currentPage)
    {
        var model = new NewsArticlePageViewModel(currentPage);

        return View(model);
    }
}