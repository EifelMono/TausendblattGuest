namespace TausendblattGuest.Data;

public class Pages
{
    public Page About { get; init; } = new Page
    {
        Route = "/Über",
        Title = "Über...",
        IconName = IconName.InfoCircle
    };
    public Page Contact { get; init; } = new Page
    {
        Route = "/contact",
        Title = "Kontakt",
        IconName = IconName.UserFriends
    };

    public Page Eat { get; init; } = new Page
    {
        Route="/eat",
        Title="Essen",
        IconName= IconName.Utensils
    };

    public Page Emergency { get; init; } = new Page
    {
        Route = "/emergency",
        Title = "Notfall",
        IconName = IconName.Hospital
    };

    public Page Index { get; init; } = new Page
    {
        Route = "/",
        Title = "Begrüßung",
        IconName = IconName.HandsHelping
    };

    public Page Vicinity { get; init; } = new Page
    {
        Route = "/Vicinity",
        Title = "Umgebung",
        IconName = IconName.Infinity
    };


    public Page House { get; init; } = new Page
    {
        Route = "/house",
        Title = "Haus",
        IconName = IconName.Home
    };

    public Page Shopping { get; init; } = new Page
    {
        Route = "/shopping",
        Title = "Einkaufen",
        IconName = IconName.ShoppingBag
    };
}
