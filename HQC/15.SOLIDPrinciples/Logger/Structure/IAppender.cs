namespace LoggerSOLID.Structure
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ReportLevel ReportThreshold { get; set; }
        void Append(ReportLevel level, string msg,params object[] args);
        void AppendThresholdCheck(ReportLevel level, string msg, params object[] args);
    }
}
