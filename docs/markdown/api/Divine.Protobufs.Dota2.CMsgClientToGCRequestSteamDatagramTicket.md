# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket"></a> Class CMsgClientToGCRequestSteamDatagramTicket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestSteamDatagramTicket : IMessage<CMsgClientToGCRequestSteamDatagramTicket>, IEquatable<CMsgClientToGCRequestSteamDatagramTicket>, IDeepCloneable<CMsgClientToGCRequestSteamDatagramTicket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)

#### Implements

IMessage<CMsgClientToGCRequestSteamDatagramTicket\>, 
[IEquatable<CMsgClientToGCRequestSteamDatagramTicket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestSteamDatagramTicket\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgClientToGCRequestSteamDatagramTicket\>\(CMsgClientToGCRequestSteamDatagramTicket, params CMsgClientToGCRequestSteamDatagramTicket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket__ctor"></a> CMsgClientToGCRequestSteamDatagramTicket\(\)

```csharp
public CMsgClientToGCRequestSteamDatagramTicket()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_"></a> CMsgClientToGCRequestSteamDatagramTicket\(CMsgClientToGCRequestSteamDatagramTicket\)

```csharp
public CMsgClientToGCRequestSteamDatagramTicket(CMsgClientToGCRequestSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_ServerSteamIdFieldNumber"></a> ServerSteamIdFieldNumber

```csharp
public const int ServerSteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_HasServerSteamId"></a> HasServerSteamId

```csharp
public bool HasServerSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestSteamDatagramTicket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_ServerSteamId"></a> ServerSteamId

```csharp
public ulong ServerSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_ClearServerSteamId"></a> ClearServerSteamId\(\)

```csharp
public void ClearServerSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestSteamDatagramTicket Clone()
```

#### Returns

 [CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_"></a> Equals\(CMsgClientToGCRequestSteamDatagramTicket\)

```csharp
public bool Equals(CMsgClientToGCRequestSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_"></a> MergeFrom\(CMsgClientToGCRequestSteamDatagramTicket\)

```csharp
public void MergeFrom(CMsgClientToGCRequestSteamDatagramTicket other)
```

#### Parameters

`other` [CMsgClientToGCRequestSteamDatagramTicket](Divine.Protobufs.Dota2.CMsgClientToGCRequestSteamDatagramTicket.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSteamDatagramTicket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

