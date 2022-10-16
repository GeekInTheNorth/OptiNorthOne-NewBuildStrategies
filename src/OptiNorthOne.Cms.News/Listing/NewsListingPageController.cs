namespace OptiNorthOne.Cms.News.Listing;

using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

using OptiNorthOne.Cms.News.Article;

public class NewsListingPageController : PageController<NewsListingPage>
{
    public IClient _findClient;

    public NewsListingPageController(IClient findClient)
    {
        _findClient = findClient;
    }

    public IActionResult Index(NewsListingPage currentPage, string? query, int? from = 0, int? take = 10)
    {
        var results = _findClient.Search<NewsArticlePage>()
                                 .For(query)
                                 .UsingSynonyms()
                                 .ApplyBestBets()
                                 .FilterForVisitor()
                                 .OrderByDescending(x => x.StartPublish)
                                 .Skip(from ?? 0)
                                 .Take(take ?? 10)
                                 .GetContentResult();

        var model = new NewsListingPageViewModel(currentPage);
        model.Articles.AddRange(results);

        return View(model);
    }
}