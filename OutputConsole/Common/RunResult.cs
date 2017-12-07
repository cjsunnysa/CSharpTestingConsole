namespace OutputConsole.Common
{
    public class RunResult
    {
        public bool Success { get; private set; }
        public string ErrorMessage { get; private set; }

        public RunResult(bool success, string errorMessage = null)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }
    }
}