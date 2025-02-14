public class Reference
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;
    string _text;

    string _reference;
    string _url;
    HttpClient _client = new HttpClient();
    public Reference(string reference)
    {
        _reference = reference;
    }
    // public Reference(string reference)
    // {
    //     _reference = reference;
    //     _url = $"https://api.nephi.org/scriptures/?q={reference}";
    //     GetScripture(reference);
    // }
    // public async void GetScripture(string url)
    // {
    //     _client.BaseAddress = new Uri(_url);
    //     _client.DefaultRequestHeaders.Accept.Clear();
    //     _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //     HttpResponseMessage response = await _client.GetAsync(url);
    //     if (response.IsSuccessStatusCode)
    //     {
    //         // Parse the response body.
    //         var data = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
    //         foreach (var datum in data)
    //         {
    //             Console.WriteLine(datum.Name);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine($"{response.StatusCode} ({response.ReasonPhrase})");
    //     }
    // }

    public void GetReference()
    {
        // will use the reference provided to access api.nephi.org to populate the text
    }
    public string GetText()
    {
        return _text;
    }
}