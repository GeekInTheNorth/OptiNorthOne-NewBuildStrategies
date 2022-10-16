namespace OptiNorthOne.Cms.News.RelatedNews;

using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

using OptiNorthOne.Cms.News.Article;

public class RelatedNewsViewComponent : BlockComponent<RelatedNewsBlock>
{
    private readonly IClient _findClient;

    public RelatedNewsViewComponent(IClient findClient)
    {
        _findClient = findClient;
    }

    protected override IViewComponentResult InvokeComponent(RelatedNewsBlock currentContent)
    {
        var results = _findClient.Search<NewsArticlePage>()
                                 .FilterForVisitor()
                                 .OrderByDescending(x => x.StartPublish)
                                 .Take(currentContent.ArticlesToShow ?? 3)
                                 .GetContentResult();

        var model = new RelatedNewsViewModel
        {
            Title = currentContent.Title,
            Articles = results.ToList()
        };

        return View(model);
    }
}
