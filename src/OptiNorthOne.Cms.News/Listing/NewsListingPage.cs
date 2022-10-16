namespace OptiNorthOne.Cms.News.Listing;

using System.ComponentModel.DataAnnotations;

using EPiServer.DataAnnotations;

using OptiNorthOne.Cms.Core.Pages;

[ContentType(
    DisplayName = "News Listing Page",
    Description = "A baseline listing page",
    GroupName = "Content",
    GUID = "021BA91C-B5F1-45F4-B483-C94667D9DDA6")]
public partial class NewsListingPage : SitePageData
{
    [Display(
        Name = "Title",
        GroupName = "Content",
        Order = 10)]
    public virtual string? Title { get; set; }

    [Display(
        Name = "Page Size",
        GroupName = "Content",
        Order = 20)]
    public virtual int? PageSize { get; set; }
}
