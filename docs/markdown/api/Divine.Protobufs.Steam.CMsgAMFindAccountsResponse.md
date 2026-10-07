# <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse"></a> Class CMsgAMFindAccountsResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMFindAccountsResponse : IMessage<CMsgAMFindAccountsResponse>, IEquatable<CMsgAMFindAccountsResponse>, IDeepCloneable<CMsgAMFindAccountsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)

#### Implements

IMessage<CMsgAMFindAccountsResponse\>, 
[IEquatable<CMsgAMFindAccountsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMFindAccountsResponse\>, 
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
[EnumerableExtensions.In<CMsgAMFindAccountsResponse\>\(CMsgAMFindAccountsResponse, params CMsgAMFindAccountsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse__ctor"></a> CMsgAMFindAccountsResponse\(\)

```csharp
public CMsgAMFindAccountsResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse__ctor_Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_"></a> CMsgAMFindAccountsResponse\(CMsgAMFindAccountsResponse\)

```csharp
public CMsgAMFindAccountsResponse(CMsgAMFindAccountsResponse other)
```

#### Parameters

`other` [CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMFindAccountsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_SteamId"></a> SteamId

```csharp
public RepeatedField<ulong> SteamId { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgAMFindAccountsResponse Clone()
```

#### Returns

 [CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_Equals_Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_"></a> Equals\(CMsgAMFindAccountsResponse\)

```csharp
public bool Equals(CMsgAMFindAccountsResponse other)
```

#### Parameters

`other` [CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_MergeFrom_Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_"></a> MergeFrom\(CMsgAMFindAccountsResponse\)

```csharp
public void MergeFrom(CMsgAMFindAccountsResponse other)
```

#### Parameters

`other` [CMsgAMFindAccountsResponse](Divine.Protobufs.Steam.CMsgAMFindAccountsResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMFindAccountsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

