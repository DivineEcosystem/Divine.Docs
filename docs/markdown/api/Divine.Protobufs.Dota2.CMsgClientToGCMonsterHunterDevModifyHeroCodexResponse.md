# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse"></a> Class CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse : IMessage<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse>, IEquatable<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\>\(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse, params CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse__ctor"></a> CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_"></a> CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_"></a> Equals\(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevModifyHeroCodexResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

