using System;
using Grpc.Core;
using GRPCDemo;
using System.Threading.Tasks;
namespace gRPCClient
{
    class Program
    {
        static async Task testAsync()
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
        
        static async Task<HelloReply> MyDemo()
        {
            var host = "192.168.3.7:9007";
            Channel channel = new Channel(host, ChannelCredentials.Insecure);

            var client = new gRPC.gRPCClient(channel);
            //await client.SayHelloAsync(new HelloRequest { Name = "LineZero" });
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "LineZero" });
            return reply;
//             Console.WriteLine("来自" + reply.Message);
// 
//             await channel.ShutdownAsync();
//             Console.WriteLine("任意键退出...");
//             Console.ReadKey();
        }

        static async Task<int> Mydemo1()
        {
            var host = "192.168.3.7:9007";
            Channel channel = new Channel(host, ChannelCredentials.Insecure);

            //var client = new gRPC.gRPCClient(channel);
            //new GameService.LobbyReflection(channel);
            return 1;


        }
        static void Main(string[] args)
        {
            //var host = "10.203.24.76:50051";
            //var host = "127.0.0.1:9007";
            //             var host = "192.168.3.7:9007";
            //             Channel channel = new Channel(host, ChannelCredentials.Insecure);
            // 
            //             var client = new gRPC.gRPCClient(channel);
            //             //await client.SayHelloAsync(new HelloRequest { Name = "LineZero" });
            //             var reply = client.SayHello(new HelloRequest { Name = "LineZero" });
            //             Console.WriteLine("来自" + reply.Message);
            // 
            //             channel.ShutdownAsync().Wait();
            //             Console.WriteLine("任意键退出...");
            //             Console.ReadKey();
            //testAsync().Wait();
            using (Task<HelloReply> task1 = MyDemo())
            {
                task1.Wait();
            }
            //Console.WriteLine(task1.Result.);

            //Console.WriteLine(resp.Message);


        }
    }
}
