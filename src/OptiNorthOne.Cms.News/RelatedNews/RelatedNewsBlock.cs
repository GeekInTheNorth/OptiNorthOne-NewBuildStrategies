namespace OptiNorthOne.Cms.News.RelatedNews;

using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAnnotations;

[ContentType(
    DisplayName = "Related News Block",
    Description = "A baseline related news block",
    GroupName = "Content",
    GUID = "D4873CBF-525F-4639-8502-24DD45C71BE1")]
public partial class RelatedNewsBlock : BlockData
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
    public virtual int? ArticlesToShow { get; set; }
}