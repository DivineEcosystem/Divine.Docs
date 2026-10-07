# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse"></a> Class CMsgClientToGCRequestSlarkGameResultResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestSlarkGameResultResponse : IMessage<CMsgClientToGCRequestSlarkGameResultResponse>, IEquatable<CMsgClientToGCRequestSlarkGameResultResponse>, IDeepCloneable<CMsgClientToGCRequestSlarkGameResultResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestSlarkGameResultResponse\>, 
[IEquatable<CMsgClientToGCRequestSlarkGameResultResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestSlarkGameResultResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestSlarkGameResultResponse\>\(CMsgClientToGCRequestSlarkGameResultResponse, params CMsgClientToGCRequestSlarkGameResultResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse__ctor"></a> CMsgClientToGCRequestSlarkGameResultResponse\(\)

```csharp
public CMsgClientToGCRequestSlarkGameResultResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_"></a> CMsgClientToGCRequestSlarkGameResultResponse\(CMsgClientToGCRequestSlarkGameResultResponse\)

```csharp
public CMsgClientToGCRequestSlarkGameResultResponse(CMsgClientToGCRequestSlarkGameResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_AuraWonFieldNumber"></a> AuraWonFieldNumber

```csharp
public const int AuraWonFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_PointsWonFieldNumber"></a> PointsWonFieldNumber

```csharp
public const int PointsWonFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_AuraWon"></a> AuraWon

```csharp
public bool AuraWon { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_HasAuraWon"></a> HasAuraWon

```csharp
public bool HasAuraWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_HasPointsWon"></a> HasPointsWon

```csharp
public bool HasPointsWon { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestSlarkGameResultResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_PointsWon"></a> PointsWon

```csharp
public uint PointsWon { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_ClearAuraWon"></a> ClearAuraWon\(\)

```csharp
public void ClearAuraWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_ClearPointsWon"></a> ClearPointsWon\(\)

```csharp
public void ClearPointsWon()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestSlarkGameResultResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_"></a> Equals\(CMsgClientToGCRequestSlarkGameResultResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestSlarkGameResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_"></a> MergeFrom\(CMsgClientToGCRequestSlarkGameResultResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestSlarkGameResultResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestSlarkGameResultResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestSlarkGameResultResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestSlarkGameResultResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

