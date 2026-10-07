# <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse"></a> Class CMsgClientToGCItemBattlerGameActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCItemBattlerGameActionResponse : IMessage<CMsgClientToGCItemBattlerGameActionResponse>, IEquatable<CMsgClientToGCItemBattlerGameActionResponse>, IDeepCloneable<CMsgClientToGCItemBattlerGameActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)

#### Implements

IMessage<CMsgClientToGCItemBattlerGameActionResponse\>, 
[IEquatable<CMsgClientToGCItemBattlerGameActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCItemBattlerGameActionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCItemBattlerGameActionResponse\>\(CMsgClientToGCItemBattlerGameActionResponse, params CMsgClientToGCItemBattlerGameActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse__ctor"></a> CMsgClientToGCItemBattlerGameActionResponse\(\)

```csharp
public CMsgClientToGCItemBattlerGameActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_"></a> CMsgClientToGCItemBattlerGameActionResponse\(CMsgClientToGCItemBattlerGameActionResponse\)

```csharp
public CMsgClientToGCItemBattlerGameActionResponse(CMsgClientToGCItemBattlerGameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_UpdatedWorldDataFieldNumber"></a> UpdatedWorldDataFieldNumber

```csharp
public const int UpdatedWorldDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCItemBattlerGameActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Response"></a> Response

```csharp
public CMsgClientToGCItemBattlerGameActionResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_UpdatedWorldData"></a> UpdatedWorldData

```csharp
public CMsgItemBattlerWorldData UpdatedWorldData { get; set; }
```

#### Property Value

 [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCItemBattlerGameActionResponse Clone()
```

#### Returns

 [CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_"></a> Equals\(CMsgClientToGCItemBattlerGameActionResponse\)

```csharp
public bool Equals(CMsgClientToGCItemBattlerGameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_"></a> MergeFrom\(CMsgClientToGCItemBattlerGameActionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCItemBattlerGameActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGameActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGameActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGameActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

