using AngleSharp.Dom.Html;

namespace ParserAutoZone54.Core.Interfaces
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
