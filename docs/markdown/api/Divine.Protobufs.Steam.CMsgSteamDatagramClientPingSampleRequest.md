# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest"></a> Class CMsgSteamDatagramClientPingSampleRequest

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramClientPingSampleRequest : IMessage<CMsgSteamDatagramClientPingSampleRequest>, IEquatable<CMsgSteamDatagramClientPingSampleRequest>, IDeepCloneable<CMsgSteamDatagramClientPingSampleRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)

#### Implements

IMessage<CMsgSteamDatagramClientPingSampleRequest\>, 
[IEquatable<CMsgSteamDatagramClientPingSampleRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramClientPingSampleRequest\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramClientPingSampleRequest\>\(CMsgSteamDatagramClientPingSampleRequest, params CMsgSteamDatagramClientPingSampleRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest__ctor"></a> CMsgSteamDatagramClientPingSampleRequest\(\)

```csharp
public CMsgSteamDatagramClientPingSampleRequest()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_"></a> CMsgSteamDatagramClientPingSampleRequest\(CMsgSteamDatagramClientPingSampleRequest\)

```csharp
public CMsgSteamDatagramClientPingSampleRequest(CMsgSteamDatagramClientPingSampleRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_ConnectionIdFieldNumber"></a> ConnectionIdFieldNumber

```csharp
public const int ConnectionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_ConnectionId"></a> ConnectionId

```csharp
public uint ConnectionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_HasConnectionId"></a> HasConnectionId

```csharp
public bool HasConnectionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramClientPingSampleRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_ClearConnectionId"></a> ClearConnectionId\(\)

```csharp
public void ClearConnectionId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramClientPingSampleRequest Clone()
```

#### Returns

 [CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_"></a> Equals\(CMsgSteamDatagramClientPingSampleRequest\)

```csharp
public bool Equals(CMsgSteamDatagramClientPingSampleRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_"></a> MergeFrom\(CMsgSteamDatagramClientPingSampleRequest\)

```csharp
public void MergeFrom(CMsgSteamDatagramClientPingSampleRequest other)
```

#### Parameters

`other` [CMsgSteamDatagramClientPingSampleRequest](Divine.Protobufs.Steam.CMsgSteamDatagramClientPingSampleRequest.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramClientPingSampleRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

