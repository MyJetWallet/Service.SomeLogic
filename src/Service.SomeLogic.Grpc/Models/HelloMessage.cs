using System.Runtime.Serialization;
using Service.SomeLogic.Domain.Models;

namespace Service.SomeLogic.Grpc.Models
{
    [DataContract]
    public class HelloMessage : IHelloMessage
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }
}