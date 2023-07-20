
namespace TausendblattGuest.Data;

public interface IAppDataTransient
{
    int HouseNumber { get; set; }
}

public class AppDataTransient : IAppDataTransient
{
    public int HouseNumber { get; set; }
}
