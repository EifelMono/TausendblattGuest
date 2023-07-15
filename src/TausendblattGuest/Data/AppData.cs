using Microsoft.AspNetCore.Components;

namespace TausendblattGuest.Data;

public interface IAppData
{
    int HouseNumber { get; }
    string ImageLogoFerienhausTausendblatt { get; }
    string ImageHouse { get; }
    IHost? Host { get; set; }

    NavigationManager? NavigationManager { get; set; }

    Pages Pages { get; }
}
public class AppData : IAppData
{
    public IHost? Host { get; set; }

    public NavigationManager? NavigationManager { get; set; }


    public int HouseNumber
    {
        get
        {
            var uri = new Uri(NavigationManager!.BaseUri);
            var house = uri.Port - 61000;
            return house switch
            {
                5 => 5,
                6 => 5,
                7 => 7,
                8 => 7,
                _ => 0
            };
        }
    }

    public string ImageLogoFerienhausTausendblatt
        => HouseNumber switch
        {
            5 => "images/Logo Ferienhaus Tausendblatt 5.svg",
            7 => "images/Logo Ferienhaus Tausendblatt 7.svg",
            _ => "images/Logo Ferienhaus Tausendblatt.svg"
        };
    public string ImageHouse
        => HouseNumber switch
        {
            5 => "images/House 5 with number.svg",
            7 => "images/House 7 with number.svg",
            _ => "images/House.svg"
        };


    public Pages Pages => new();
}
