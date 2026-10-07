# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse"></a> Class CMsgDOTAChatGetMemberCountResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatGetMemberCountResponse : IMessage<CMsgDOTAChatGetMemberCountResponse>, IEquatable<CMsgDOTAChatGetMemberCountResponse>, IDeepCloneable<CMsgDOTAChatGetMemberCountResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)

#### Implements

IMessage<CMsgDOTAChatGetMemberCountResponse\>, 
[IEquatable<CMsgDOTAChatGetMemberCountResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatGetMemberCountResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatGetMemberCountResponse\>\(CMsgDOTAChatGetMemberCountResponse, params CMsgDOTAChatGetMemberCountResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse__ctor"></a> CMsgDOTAChatGetMemberCountResponse\(\)

```csharp
public CMsgDOTAChatGetMemberCountResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_"></a> CMsgDOTAChatGetMemberCountResponse\(CMsgDOTAChatGetMemberCountResponse\)

```csharp
public CMsgDOTAChatGetMemberCountResponse(CMsgDOTAChatGetMemberCountResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ChannelNameFieldNumber"></a> ChannelNameFieldNumber

```csharp
public const int ChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_MemberCountFieldNumber"></a> MemberCountFieldNumber

```csharp
public const int MemberCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ChannelName"></a> ChannelName

```csharp
public string ChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ChannelType"></a> ChannelType

```csharp
public DOTAChatChannelType_t ChannelType { get; set; }
```

#### Property Value

 [DOTAChatChannelType\_t](Divine.Protobufs.Dota2.DOTAChatChannelType\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_HasChannelName"></a> HasChannelName

```csharp
public bool HasChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_HasMemberCount"></a> HasMemberCount

```csharp
public bool HasMemberCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_MemberCount"></a> MemberCount

```csharp
public uint MemberCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatGetMemberCountResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ClearChannelName"></a> ClearChannelName\(\)

```csharp
public void ClearChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ClearMemberCount"></a> ClearMemberCount\(\)

```csharp
public void ClearMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatGetMemberCountResponse Clone()
```

#### Returns

 [CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_"></a> Equals\(CMsgDOTAChatGetMemberCountResponse\)

```csharp
public bool Equals(CMsgDOTAChatGetMemberCountResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_"></a> MergeFrom\(CMsgDOTAChatGetMemberCountResponse\)

```csharp
public void MergeFrom(CMsgDOTAChatGetMemberCountResponse other)
```

#### Parameters

`other` [CMsgDOTAChatGetMemberCountResponse](Divine.Protobufs.Dota2.CMsgDOTAChatGetMemberCountResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatGetMemberCountResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

