using System.Transactions;

namespace YouTubeVideos;
public class Videos
{
    private string _title;
    private string _author;
    private int _legnth;
    private List<Comment> _comments;

    public Video(string title, string author, int legnth)
    {
        _title = title;
        _author = author;
        _legnth = legnth;
        _comments = new List<Comment>();
    }
    public void AddComment( Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count
    }
    




}