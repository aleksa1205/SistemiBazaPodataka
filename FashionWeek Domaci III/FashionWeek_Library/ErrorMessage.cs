namespace FashionWeek_Library;

public class ErrorMessage
{
    public required int StatusCode { get; set; }
    public required string Message { get; set; }

    [SetsRequiredMembers]
    public ErrorMessage(string msg, int sCode = 400)
    {
        StatusCode = sCode;
        Message = msg;
    }
}
