public class MathAssignment : Assignment
{
    private string _textbooksection = "";
    private string _problems = "";

    public string GetTextbookSection()
    {
        return _textbooksection;
    }
    public void SetTextbookSection(string textbooksection)
    {
        _textbooksection = textbooksection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{GetSummary()}: \nSection: {_textbooksection} Problems: {_problems}\n";
    }
}