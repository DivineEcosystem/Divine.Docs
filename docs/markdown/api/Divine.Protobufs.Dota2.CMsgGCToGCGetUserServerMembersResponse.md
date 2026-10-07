# <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse"></a> Class CMsgGCToGCGetUserServerMembersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCGetUserServerMembersResponse : IMessage<CMsgGCToGCGetUserServerMembersResponse>, IEquatable<CMsgGCToGCGetUserServerMembersResponse>, IDeepCloneable<CMsgGCToGCGetUserServerMembersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)

#### Implements

IMessage<CMsgGCToGCGetUserServerMembersResponse\>, 
[IEquatable<CMsgGCToGCGetUserServerMembersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCGetUserServerMembersResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCGetUserServerMembersResponse\>\(CMsgGCToGCGetUserServerMembersResponse, params CMsgGCToGCGetUserServerMembersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse__ctor"></a> CMsgGCToGCGetUserServerMembersResponse\(\)

```csharp
public CMsgGCToGCGetUserServerMembersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_"></a> CMsgGCToGCGetUserServerMembersResponse\(CMsgGCToGCGetUserServerMembersResponse\)

```csharp
public CMsgGCToGCGetUserServerMembersResponse(CMsgGCToGCGetUserServerMembersResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_MemberAccountIdFieldNumber"></a> MemberAccountIdFieldNumber

```csharp
public const int MemberAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_MemberAccountId"></a> MemberAccountId

```csharp
public RepeatedField<uint> MemberAccountId { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCGetUserServerMembersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCGetUserServerMembersResponse Clone()
```

#### Returns

 [CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_"></a> Equals\(CMsgGCToGCGetUserServerMembersResponse\)

```csharp
public bool Equals(CMsgGCToGCGetUserServerMembersResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_"></a> MergeFrom\(CMsgGCToGCGetUserServerMembersResponse\)

```csharp
public void MergeFrom(CMsgGCToGCGetUserServerMembersResponse other)
```

#### Parameters

`other` [CMsgGCToGCGetUserServerMembersResponse](Divine.Protobufs.Dota2.CMsgGCToGCGetUserServerMembersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCGetUserServerMembersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

