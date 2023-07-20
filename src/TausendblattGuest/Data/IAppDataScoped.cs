using Microsoft.AspNetCore.Components;

namespace TausendblattGuest.Data;

public interface IAppDataScoped
{
    int HouseNumber { get; set; }
}

public class AppDataScoped : IAppDataScoped
{
    public int HouseNumber { get; set; }
}
