namespace ApiLogin.Api.Helpers
{
    public static class ExceptionHelper
    {
        public static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                LogExceptionTxt(ex);
            }
        }
    
        private static void LogExceptionTxt(Exception ex)
        {
            string logDirectory = "Logs";
            string fileName = $"{DateTime.Now:yyyy-MM-dd}.txt";
            string logPath = Path.Combine(logDirectory, fileName);
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex.GetType().FullName}:" +
                                "{ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
            Directory.CreateDirectory(logDirectory);
            File.AppendAllText(logPath, logMessage);
        }
    }
}