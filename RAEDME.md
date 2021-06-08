# 安装步骤



## C#安装工具

```
Install-Package Grpc
Install-Package Google.Protobuf
Install-Package Grpc.Tools

```

## 生成c# 语言

```
C:\Users\chenqian\.nuget\packages\grpc.tools\2.38.0\tools\windows_x86\protoc.exe -IgRPCDemo --csharp_out gRPCDemo  gRPCDemo\helloworld.proto --grpc_out gRPCDemo --plugin=protoc-gen-grpc=C:\Users\chenqian\.nuget\packages\grpc.tools\2.38.0\tools\windows_x86\grpc_csharp_plugin.exe
```





## python 安装工具

```
python -m pip install grpcio
python -m pip install grpcio-tools
pip install --upgrade protobuf
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out. ./helloworld.proto
```





## 相关连接:

https://www.cnblogs.com/linezero/p/grpc.html