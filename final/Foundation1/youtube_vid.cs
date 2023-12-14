using System;
public class youtube_vid
{
    private string _title;
    private string _author;
    private string _length;
    private Comments _comments;

    public youtube_vid(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Comments getComments()
    {
        return _comments;
    }

    public void setComments(Comments comments)
    {
        _comments = comments;
    }

    public void displayAllComments(List<Comments> allComments)
    {
        Console.WriteLine("Here is some of the comments on the video.");
        foreach (Comments comment in allComments)
        {
            comment.com_info();
        }
    }

    public void vid_details()
    {
        Console.WriteLine("Here is some info on the Youtube video");
        Console.WriteLine($"The video is titled {_title}.");
        Console.WriteLine($"The video is made by the chanal called {_author}.");
        Console.WriteLine($"The video is {_length} seconds long.");
    }
}