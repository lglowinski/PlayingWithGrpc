using Grpc.Net.Client;
using Grpc.Net.ClientFactory;

namespace gRPCGeneration;

public class Class1
{
    public void Method()
    {
        var user = new User();

        var userServiceClient = new UserService.UserServiceClient(GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions
        {
            HttpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            }
        }));
    }

}