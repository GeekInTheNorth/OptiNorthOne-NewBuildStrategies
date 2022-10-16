namespace OptiNorthOne.Cms.News.RelatedNews;

using OptiNorthOne.Cms.News.Article;

public class RelatedNewsViewModel
{
    public string? Title { get; set; }

    public List<NewsArticlePage>? Articles { get; set; }
}