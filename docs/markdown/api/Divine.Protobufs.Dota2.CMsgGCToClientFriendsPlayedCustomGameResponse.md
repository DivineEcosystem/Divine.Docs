# <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse"></a> Class CMsgGCToClientFriendsPlayedCustomGameResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientFriendsPlayedCustomGameResponse : IMessage<CMsgGCToClientFriendsPlayedCustomGameResponse>, IEquatable<CMsgGCToClientFriendsPlayedCustomGameResponse>, IDeepCloneable<CMsgGCToClientFriendsPlayedCustomGameResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)

#### Implements

IMessage<CMsgGCToClientFriendsPlayedCustomGameResponse\>, 
[IEquatable<CMsgGCToClientFriendsPlayedCustomGameResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientFriendsPlayedCustomGameResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientFriendsPlayedCustomGameResponse\>\(CMsgGCToClientFriendsPlayedCustomGameResponse, params CMsgGCToClientFriendsPlayedCustomGameResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse__ctor"></a> CMsgGCToClientFriendsPlayedCustomGameResponse\(\)

```csharp
public CMsgGCToClientFriendsPlayedCustomGameResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_"></a> CMsgGCToClientFriendsPlayedCustomGameResponse\(CMsgGCToClientFriendsPlayedCustomGameResponse\)

```csharp
public CMsgGCToClientFriendsPlayedCustomGameResponse(CMsgGCToClientFriendsPlayedCustomGameResponse other)
```

#### Parameters

`other` [CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientFriendsPlayedCustomGameResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientFriendsPlayedCustomGameResponse Clone()
```

#### Returns

 [CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_"></a> Equals\(CMsgGCToClientFriendsPlayedCustomGameResponse\)

```csharp
public bool Equals(CMsgGCToClientFriendsPlayedCustomGameResponse other)
```

#### Parameters

`other` [CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_"></a> MergeFrom\(CMsgGCToClientFriendsPlayedCustomGameResponse\)

```csharp
public void MergeFrom(CMsgGCToClientFriendsPlayedCustomGameResponse other)
```

#### Parameters

`other` [CMsgGCToClientFriendsPlayedCustomGameResponse](Divine.Protobufs.Dota2.CMsgGCToClientFriendsPlayedCustomGameResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientFriendsPlayedCustomGameResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

