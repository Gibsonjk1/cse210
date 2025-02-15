using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using System.Xml.Schema;
public class Reference
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;
    string _text;
    string _reference;
    string _url;
    string _urlEnd;
    HttpClient _client = new HttpClient();

    public Reference()
    {
        _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _book = "Proverbs";
        _chapter = 3;
        _firstVerse = 5;
        _lastVerse = 6;
        CreateReference();
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        CreateReference();
        // }

        _url = $"https://api.nephi.org/scriptures/?q={_urlEnd}";
        GetScripture(_url);
    }
    public void GetScripture(string url)
    {
        _client.BaseAddress = new Uri(_url);
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = _client.GetAsync(url).Result;
        response.EnsureSuccessStatusCode();
        // Parse the response body.
        var data = response.Content.ReadAsStringAsync().Result;
        dynamic json = JsonConvert.DeserializeObject<dynamic>(data);
        foreach (var o in json.scriptures)
        {
            _text += o.text;
            _text += " ";
        }

    }

    public string GetReference()
    {
        return _reference;
    }
    public string GetText()
    {
        return _text;
    }
    private void CreateReference()
    {
        string end = "";
        if (_lastVerse != 0)
        {
            end = $"-{_lastVerse}";
        }
        _reference = $"{_book} {_chapter}:{_firstVerse}{end}";
        _urlEnd = $"{_book}+{_chapter}%3A{_firstVerse}{end}";
    }
}