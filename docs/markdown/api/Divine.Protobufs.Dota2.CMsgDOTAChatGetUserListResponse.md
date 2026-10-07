# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse"></a> Class CMsgDOTAChatGetUserListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatGetUserListResponse : IMessage<CMsgDOTAChatGetUserListResponse>, IEquatable<CMsgDOTAChatGetUserListResponse>, IDeepCloneable<CMsgDOTAChatGetUserListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)

#### Implements

IMessage<CMsgDOTAChatGetUserListResponse\>, 
[IEquatable<CMsgDOTAChatGetUserListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatGetUserListResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatGetUserListResponse\>\(CMsgDOTAChatGetUserListResponse, params CMsgDOTAChatGetUserListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse__ctor"></a> CMsgDOTAChatGetUserListResponse\(\)

```csharp
public CMsgDOTAChatGetUserListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_"></a> CMsgDOTAChatGetUserListResponse\(CMsgDOTAChatGetUserListResponse\)

```csharp
public CMsgDOTAChatGetUserListResponse(CMsgDOTAChatGetUserListResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_ChannelId"></a> ChannelId

```csharp
public ulong ChannelId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Members"></a> Members

```csharp
public RepeatedField<CMsgDOTAChatGetUserListResponse.Types.Member> Members { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.Types.Member.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatGetUserListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatGetUserListResponse Clone()
```

#### Returns

 [CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_"></a> Equals\(CMsgDOTAChatGetUserListResponse\)

```csharp
public bool Equals(CMsgDOTAChatGetUserListResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_"></a> MergeFrom\(CMsgDOTAChatGetUserListResponse\)

```csharp
public void MergeFrom(CMsgDOTAChatGetUserListResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetUserListResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetUserListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetUserListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

