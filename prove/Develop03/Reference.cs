public class Reference()
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;
    string _text;

    public class Reference(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
            if (lastVerse != 0)
            {
                string end = $"-{lastVerse}"
            }
            else
            {
                string end = ""
            }

string url = $"https://api.nephi.org/scriptures/?q={book} {chapter}:{firstVerse}{end}"
            HttpClient client = new HttpClient();
client.BaseAddress = new Uri(url);

client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = client.GetAsync(urlParameters).Result;
if (response.IsSuccessStatusCode)
{
    // Parse the response body.
    var data = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
    foreach (var datum in data)
    {
        Console.WriteLine(datum.Name);
    }
}
else
{
    Console.WriteLine($"{response.StatusCode} ({response.ReasonPhrase})");
}
    }

    public void GetReference()
{
    // will use the reference provided to access api.nephi.org to populate the text
}
public string GetText()
{
    return _text;
}
}