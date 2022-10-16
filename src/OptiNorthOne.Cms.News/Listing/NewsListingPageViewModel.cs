namespace OptiNorthOne.Cms.News.Listing;

using OptiNorthOne.Cms.Core.Pages;
using OptiNorthOne.Cms.News.Article;

public class NewsListingPageViewModel : ISitePageViewModel<NewsListingPage>
{
    public NewsListingPageViewModel(NewsListingPage currentPage)
    {
        CurrentPage = currentPage;
        Articles = new List<NewsArticlePage>();
    }

    public NewsListingPage CurrentPage { get; set; }

    public List<NewsArticlePage> Articles { get; set; }
}