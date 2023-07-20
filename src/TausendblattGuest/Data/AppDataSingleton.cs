using Microsoft.AspNetCore.Components;

namespace TausendblattGuest.Data;

public interface IAppDataSingleton
{
    int HouseNumber { get; set; }
    string ImageLogoFerienhausTausendblatt(int house = 0);
    string ImageLogoHouse(int house = 0);
    IHost? Host { get; set; }

    NavigationManager? NavigationManager { get; set; }

    Pages Pages { get; }
}
public class AppDataSingleton : IAppDataSingleton
{
    public IHost? Host { get; set; }

    public NavigationManager? NavigationManager { get; set; }


    public int HouseNumber { get; set; }

    public string ImageLogoFerienhausTausendblatt(int house = 0)
        => house switch
        {
            5 => "images/Logo Ferienhaus Tausendblatt 5.svg",
            7 => "images/Logo Ferienhaus Tausendblatt 7.svg",
            _ => "images/Logo Ferienhaus Tausendblatt.svg"
        };
    public string ImageLogoHouse(int house = 0)
        => house switch
        {
            5 => "images/House 5 with number.svg",
            7 => "images/House 7 with number.svg",
            _ => "images/House.svg"
        };


    public Pages Pages => new();
}
