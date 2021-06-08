using System;
using Grpc.Core;
using GRPCDemo;

namespace gRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "10.203.24.76:50051";
            //var host = "127.0.0.1:9007";
            Channel channel = new Channel(host, ChannelCredentials.Insecure);

            var client = new gRPC.gRPCClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "LineZero" });
            Console.WriteLine("来自" + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
