namespace IO_Project.IO
{
    interface IRequestConfigurationProvider
    {
        RequestType HandledRequestType { get; }
        object Payload { get; }
    }
}
