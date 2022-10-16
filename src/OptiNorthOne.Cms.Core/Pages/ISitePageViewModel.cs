namespace OptiNorthOne.Cms.Core.Pages;

public interface ISitePageViewModel<out T>
    where T : ISitePageData
{
    T CurrentPage { get; }
}