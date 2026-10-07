# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse"></a> Class CMsgClientToGCRequestGuildEventMembersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestGuildEventMembersResponse : IMessage<CMsgClientToGCRequestGuildEventMembersResponse>, IEquatable<CMsgClientToGCRequestGuildEventMembersResponse>, IDeepCloneable<CMsgClientToGCRequestGuildEventMembersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestGuildEventMembersResponse\>, 
[IEquatable<CMsgClientToGCRequestGuildEventMembersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestGuildEventMembersResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestGuildEventMembersResponse\>\(CMsgClientToGCRequestGuildEventMembersResponse, params CMsgClientToGCRequestGuildEventMembersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse__ctor"></a> CMsgClientToGCRequestGuildEventMembersResponse\(\)

```csharp
public CMsgClientToGCRequestGuildEventMembersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_"></a> CMsgClientToGCRequestGuildEventMembersResponse\(CMsgClientToGCRequestGuildEventMembersResponse\)

```csharp
public CMsgClientToGCRequestGuildEventMembersResponse(CMsgClientToGCRequestGuildEventMembersResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_MembersFieldNumber"></a> MembersFieldNumber

```csharp
public const int MembersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Members"></a> Members

```csharp
public RepeatedField<CMsgGuildEventMember> Members { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildEventMember](Divine.Protobufs.Dota2.CMsgGuildEventMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestGuildEventMembersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestGuildEventMembersResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestGuildEventMembersResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_"></a> Equals\(CMsgClientToGCRequestGuildEventMembersResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestGuildEventMembersResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_"></a> MergeFrom\(CMsgClientToGCRequestGuildEventMembersResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestGuildEventMembersResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildEventMembersResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildEventMembersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildEventMembersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

