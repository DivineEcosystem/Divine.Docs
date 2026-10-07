# <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse"></a> Class CMsgGCToClientTopFriendMatchesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientTopFriendMatchesResponse : IMessage<CMsgGCToClientTopFriendMatchesResponse>, IEquatable<CMsgGCToClientTopFriendMatchesResponse>, IDeepCloneable<CMsgGCToClientTopFriendMatchesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)

#### Implements

IMessage<CMsgGCToClientTopFriendMatchesResponse\>, 
[IEquatable<CMsgGCToClientTopFriendMatchesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientTopFriendMatchesResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientTopFriendMatchesResponse\>\(CMsgGCToClientTopFriendMatchesResponse, params CMsgGCToClientTopFriendMatchesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse__ctor"></a> CMsgGCToClientTopFriendMatchesResponse\(\)

```csharp
public CMsgGCToClientTopFriendMatchesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_"></a> CMsgGCToClientTopFriendMatchesResponse\(CMsgGCToClientTopFriendMatchesResponse\)

```csharp
public CMsgGCToClientTopFriendMatchesResponse(CMsgGCToClientTopFriendMatchesResponse other)
```

#### Parameters

`other` [CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_MatchesFieldNumber"></a> MatchesFieldNumber

```csharp
public const int MatchesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Matches"></a> Matches

```csharp
public RepeatedField<CMsgDOTAMatchMinimal> Matches { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatchMinimal](Divine.Protobufs.Dota2.CMsgDOTAMatchMinimal.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientTopFriendMatchesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientTopFriendMatchesResponse Clone()
```

#### Returns

 [CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_"></a> Equals\(CMsgGCToClientTopFriendMatchesResponse\)

```csharp
public bool Equals(CMsgGCToClientTopFriendMatchesResponse other)
```

#### Parameters

`other` [CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_"></a> MergeFrom\(CMsgGCToClientTopFriendMatchesResponse\)

```csharp
public void MergeFrom(CMsgGCToClientTopFriendMatchesResponse other)
```

#### Parameters

`other` [CMsgGCToClientTopFriendMatchesResponse](Divine.Protobufs.Dota2.CMsgGCToClientTopFriendMatchesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientTopFriendMatchesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

