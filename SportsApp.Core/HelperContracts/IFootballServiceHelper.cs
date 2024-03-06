namespace SportsApp.Core.HelperContracts {
    public interface IFootballServiceHelper {
        Task<T?> HttpGetRequest<T>(string url);
    }
}
