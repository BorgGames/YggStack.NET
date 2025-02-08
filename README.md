[![NuGet](https://img.shields.io/nuget/v/YggStack.svg)](https://www.nuget.org/packages/YggStack/)

Enables connecting to Yggdrasil network. Exposes SOCKS 5 proxy.

```csharp
YggStack.Run(["-socks", "127.0.0.1:" + port, "-autoconf"]);
```

In 0.0.2 this function never returns