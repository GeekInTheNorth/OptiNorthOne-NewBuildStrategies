namespace OptiNorthOne.Cms.News.Article;

using OptiNorthOne.Cms.Core.Pages;

public class NewsArticlePageViewModel : ISitePageViewModel<NewsArticlePage>
{
    public NewsArticlePageViewModel(NewsArticlePage currentPage)
    {
        CurrentPage = currentPage;
    }

    public NewsArticlePage CurrentPage { get; set; }
}