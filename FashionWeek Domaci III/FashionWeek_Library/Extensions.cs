namespace FashionWeek_Library;

public static class Extensions
{
    internal static ErrorMessage ToError(this string message, int statusCode = 400)
    {
        return new ErrorMessage(message, statusCode);
    }

    internal static ErrorMessage GetError(string message, int statusCode = 400)
    {
        return new ErrorMessage(message, statusCode);
    } 
}
