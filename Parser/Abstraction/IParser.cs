namespace Console;

public interface IParser
{
    Task<IEnumerable<ParseResult>> ParseAsync(Criteria criteria);
}