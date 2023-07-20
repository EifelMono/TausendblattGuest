namespace TausendblattGuest.Data;

public class Pages
{
    public Page About { get; init; } = new Page
    {
        Route = "/info",
        Title = "Info...",
        IconName = IconName.InfoCircle
    };

    public Page AboutTausendbaltt { get; init; } = new Page
    {
        Route = "/info/tausendblatt",
        Title = "Info über Tausendblatt",
        IconName = IconName.InfoCircle
    };
    public Page AboutApp { get; init; } = new Page
    {
        Route = "/info/app",
        Title = "Info über WebApp",
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
        Route = "/eat",
        Title = "Essen",
        IconName = IconName.Utensils
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

    public Page Tausendblatt { get; init; } = new Page
    {
        Route = "/tausenblatt",
        Title = "Tausendblatt",
        IconName = IconName.QuestionCircle
    };

    public Page Traumpfade { get; init; } = new Page
    {
        Route = "/traumpfade",
        Title = "Traumpfade",
        IconName = IconName.QuestionCircle
    };

    public Page Udelsheck { get; init; } = new Page
    {
        Route = "/udelsheck",
        Title = "Udelsheck",
        IconName = IconName.QuestionCircle
    };

    public Page Waldsee { get; init; } = new Page
    {
        Route = "/waldsee",
        Title = "Waldsee",
        IconName = IconName.QuestionCircle
    };

    public Page Wandern { get; init; } = new Page
    {
        Route = "/wandern",
        Title = "Wandern",
        IconName = IconName.QuestionCircle
    };
}
