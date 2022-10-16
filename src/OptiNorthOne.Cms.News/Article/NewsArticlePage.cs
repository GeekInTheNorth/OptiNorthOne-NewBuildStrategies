namespace OptiNorthOne.Cms.News.Article;

using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAnnotations;

using OptiNorthOne.Cms.Core.Pages;

[ContentType(
    DisplayName = "News Article Page",
    Description = "A baseline article page",
    GroupName = "Content",
    GUID = "1B66A034-B0A1-4BEB-93C5-6436912DB09C")]
public partial class NewsArticlePage : SitePageData
{
    [Display(
        Name = "Title",
        GroupName = "Content",
        Order = 10)]
    public virtual string? Title { get; set; }

    [Display(
        Name = "Content",
        GroupName = "Content",
        Order = 20)]
    public virtual XhtmlString? ArticleContent { get; set; }
}