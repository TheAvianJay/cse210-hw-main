using System;

public class Comments
{
    private string _cname;
    private string _content;
    public Comments(string cname, string content)
    {
        _cname = cname;
        _content = content;
    }
    public void com_info()
    {
        Console.WriteLine($"{_cname}:{_content}");
    }
}