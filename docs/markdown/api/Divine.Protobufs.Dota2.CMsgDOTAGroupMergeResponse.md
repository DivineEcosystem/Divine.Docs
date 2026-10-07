# <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse"></a> Class CMsgDOTAGroupMergeResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGroupMergeResponse : IMessage<CMsgDOTAGroupMergeResponse>, IEquatable<CMsgDOTAGroupMergeResponse>, IDeepCloneable<CMsgDOTAGroupMergeResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)

#### Implements

IMessage<CMsgDOTAGroupMergeResponse\>, 
[IEquatable<CMsgDOTAGroupMergeResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGroupMergeResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGroupMergeResponse\>\(CMsgDOTAGroupMergeResponse, params CMsgDOTAGroupMergeResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse__ctor"></a> CMsgDOTAGroupMergeResponse\(\)

```csharp
public CMsgDOTAGroupMergeResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_"></a> CMsgDOTAGroupMergeResponse\(CMsgDOTAGroupMergeResponse\)

```csharp
public CMsgDOTAGroupMergeResponse(CMsgDOTAGroupMergeResponse other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_AcceptFieldNumber"></a> AcceptFieldNumber

```csharp
public const int AcceptFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_InitiatorGroupIdFieldNumber"></a> InitiatorGroupIdFieldNumber

```csharp
public const int InitiatorGroupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Accept"></a> Accept

```csharp
public bool Accept { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_HasAccept"></a> HasAccept

```csharp
public bool HasAccept { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_HasInitiatorGroupId"></a> HasInitiatorGroupId

```csharp
public bool HasInitiatorGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_InitiatorGroupId"></a> InitiatorGroupId

```csharp
public ulong InitiatorGroupId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGroupMergeResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_ClearAccept"></a> ClearAccept\(\)

```csharp
public void ClearAccept()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_ClearInitiatorGroupId"></a> ClearInitiatorGroupId\(\)

```csharp
public void ClearInitiatorGroupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGroupMergeResponse Clone()
```

#### Returns

 [CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_"></a> Equals\(CMsgDOTAGroupMergeResponse\)

```csharp
public bool Equals(CMsgDOTAGroupMergeResponse other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_"></a> MergeFrom\(CMsgDOTAGroupMergeResponse\)

```csharp
public void MergeFrom(CMsgDOTAGroupMergeResponse other)
```

#### Parameters

`other` [CMsgDOTAGroupMergeResponse](Divine.Protobufs.Dota2.CMsgDOTAGroupMergeResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGroupMergeResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

