using Grpc.Net.Client;
using JetBrains.Annotations;
using ProtoBuf.Grpc.Client;
using Service.SomeLogic.Grpc;

namespace Service.SomeLogic.Client
{
    [UsedImplicitly]
    public class SomeLogicClientFactory
    {
        private readonly GrpcChannel _channel;

        public SomeLogicClientFactory(string assetsDictionaryGrpcServiceUrl)
        {
            _channel = GrpcChannel.ForAddress("http://localhost:5001");
        }

        public IHelloService GetHelloService() => _channel.CreateGrpcService<IHelloService>();
    }
}