namespace MAUICommunicateWithRest.Services
{
	public interface IHttpsClientHandlerService
	{
        HttpMessageHandler GetPlatformMessageHandler();
    }
}

