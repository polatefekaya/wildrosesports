namespace SportsApp.Core.Helpers {
    public class ConvertingHelper : IConvertingHelper {
        public async Task<T?> ConvertResponseMessageToJson<T>(HttpResponseMessage response) {
            Stream stream = response.Content.ReadAsStream();

            StreamReader reader = new StreamReader(stream);
            string readedResponse = await reader.ReadToEndAsync();

            T? responseObject = JsonConvert.DeserializeObject<T>(readedResponse);

            return responseObject;
        }
    }
}
