using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace YouTubeVideos;
public class Video
{
    private string commentersName;
    private string commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commenterText;

    }
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetCommentText()
    {
        return _commenterText;
    }
}