# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse"></a> Class CMsgGCToClientCustomGamesFriendsPlayedResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCustomGamesFriendsPlayedResponse : IMessage<CMsgGCToClientCustomGamesFriendsPlayedResponse>, IEquatable<CMsgGCToClientCustomGamesFriendsPlayedResponse>, IDeepCloneable<CMsgGCToClientCustomGamesFriendsPlayedResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)

#### Implements

IMessage<CMsgGCToClientCustomGamesFriendsPlayedResponse\>, 
[IEquatable<CMsgGCToClientCustomGamesFriendsPlayedResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCustomGamesFriendsPlayedResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCustomGamesFriendsPlayedResponse\>\(CMsgGCToClientCustomGamesFriendsPlayedResponse, params CMsgGCToClientCustomGamesFriendsPlayedResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse__ctor"></a> CMsgGCToClientCustomGamesFriendsPlayedResponse\(\)

```csharp
public CMsgGCToClientCustomGamesFriendsPlayedResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_"></a> CMsgGCToClientCustomGamesFriendsPlayedResponse\(CMsgGCToClientCustomGamesFriendsPlayedResponse\)

```csharp
public CMsgGCToClientCustomGamesFriendsPlayedResponse(CMsgGCToClientCustomGamesFriendsPlayedResponse other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_GamesFieldNumber"></a> GamesFieldNumber

```csharp
public const int GamesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Games"></a> Games

```csharp
public RepeatedField<CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame> Games { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.md).[CustomGame](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.Types.CustomGame.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCustomGamesFriendsPlayedResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCustomGamesFriendsPlayedResponse Clone()
```

#### Returns

 [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_"></a> Equals\(CMsgGCToClientCustomGamesFriendsPlayedResponse\)

```csharp
public bool Equals(CMsgGCToClientCustomGamesFriendsPlayedResponse other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_"></a> MergeFrom\(CMsgGCToClientCustomGamesFriendsPlayedResponse\)

```csharp
public void MergeFrom(CMsgGCToClientCustomGamesFriendsPlayedResponse other)
```

#### Parameters

`other` [CMsgGCToClientCustomGamesFriendsPlayedResponse](Divine.Protobufs.Dota2.CMsgGCToClientCustomGamesFriendsPlayedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCustomGamesFriendsPlayedResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

