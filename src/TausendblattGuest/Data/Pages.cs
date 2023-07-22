using Microsoft.AspNetCore.Components;

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

    public Page QrCode { get; init; } = new Page
    {
        Route = "/qrcode",
        Title = "QrCode",
        IconName = IconName.BorderAll
    };


    public Page QrTausendblatt { get; init; } = new Page
    {
        Route = "/qr/tausendblatt",
        Title = "Tausendblatt",
        IconName = IconName.BorderAll
    };

    public Page QrTraumpfade { get; init; } = new Page
    {
        Route = "/qr/traumpfade",
        Title = "Traumpfade",
        IconName = IconName.BorderAll
    };

    public Page QrUdelsheck { get; init; } = new Page
    {
        Route = "/qr/udelsheck",
        Title = "Udelsheck",
        IconName = IconName.BorderAll
    };

    public Page QrWaldsee { get; init; } = new Page
    {
        Route = "/qr/waldsee",
        Title = "Waldsee",
        IconName = IconName.BorderAll
    };

    public Page QrWandern { get; init; } = new Page
    {
        Route = "/qr/wandern",
        Title = "Wandern",
        IconName = IconName.BorderAll
    };

    public Page[] QrCodesSubPages => new[]
    {
        QrTraumpfade,
        QrTausendblatt,
        QrWaldsee,
        QrUdelsheck,
        QrWandern,
    };

    public Page WebApp { get; init; } = new Page
    {
        Route = "/webapp",
        Title = "WebApp",
        IconName = IconName.InfoCircle
    };


    public Page WebAppContact { get; init; } = new Page
    {
        Route = "/webapp/contact",
        Title = "Kontakt",
        IconName = IconName.UserFriends
    };

    public Page WebAppCode{ get; init; } = new Page
    {
        Route = "/webapp/code",
        Title = "Code",
        IconName = IconName.Code
    };

    public Page[] WebAppSubPages => new[]
 {
        WebAppContact,
        WebAppCode,
    };
}
