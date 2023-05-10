public class MathAssignment : Assignment
{
    private string _textbookSection, _problems;
    public MathAssignment():base()
    {

    }
    public MathAssignment(string name, string topic, string section, string problems):base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetSection()
    {
        return _textbookSection;
    }
    public void SetSection(string section)
    {
        _textbookSection = section;
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
        return $"Section {_textbookSection} Problems {_problems}";
    }
}