namespace InterfacesAndExtensibility
{
    public interface ILogger
    {
        //responsible for showing error message
        void LogError(string message); 

        //responsible for show log info 
        void LogInfo(string message);
    }
}
