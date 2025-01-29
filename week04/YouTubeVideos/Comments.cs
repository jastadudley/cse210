using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace YouTubeVideos;
public class Comment
{
    private string _commentersName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commentersName = commenterName;
        _commentText = commentText;
    }
    public string GetCommenterName()
    {
        return _commentersName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
}