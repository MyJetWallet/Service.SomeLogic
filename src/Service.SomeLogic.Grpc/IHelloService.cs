using System.ServiceModel;
using System.Threading.Tasks;
using Service.SomeLogic.Grpc.Models;

namespace Service.SomeLogic.Grpc
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Task<HelloMessage> SayHelloAsync(HelloRequest request);
    }
}