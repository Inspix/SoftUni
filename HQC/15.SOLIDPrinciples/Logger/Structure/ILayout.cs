namespace LoggerSOLID.Structure
{
    public interface ILayout
    {
        string Convert(ReportLevel level, string msg, params object[] args);
    }
}
