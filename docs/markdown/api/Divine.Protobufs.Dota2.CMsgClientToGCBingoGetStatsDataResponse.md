# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse"></a> Class CMsgClientToGCBingoGetStatsDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoGetStatsDataResponse : IMessage<CMsgClientToGCBingoGetStatsDataResponse>, IEquatable<CMsgClientToGCBingoGetStatsDataResponse>, IDeepCloneable<CMsgClientToGCBingoGetStatsDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)

#### Implements

IMessage<CMsgClientToGCBingoGetStatsDataResponse\>, 
[IEquatable<CMsgClientToGCBingoGetStatsDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoGetStatsDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoGetStatsDataResponse\>\(CMsgClientToGCBingoGetStatsDataResponse, params CMsgClientToGCBingoGetStatsDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse__ctor"></a> CMsgClientToGCBingoGetStatsDataResponse\(\)

```csharp
public CMsgClientToGCBingoGetStatsDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_"></a> CMsgClientToGCBingoGetStatsDataResponse\(CMsgClientToGCBingoGetStatsDataResponse\)

```csharp
public CMsgClientToGCBingoGetStatsDataResponse(CMsgClientToGCBingoGetStatsDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_StatsDataFieldNumber"></a> StatsDataFieldNumber

```csharp
public const int StatsDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoGetStatsDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCBingoGetStatsDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_StatsData"></a> StatsData

```csharp
public CMsgBingoStatsData StatsData { get; set; }
```

#### Property Value

 [CMsgBingoStatsData](Divine.Protobufs.Dota2.CMsgBingoStatsData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoGetStatsDataResponse Clone()
```

#### Returns

 [CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_"></a> Equals\(CMsgClientToGCBingoGetStatsDataResponse\)

```csharp
public bool Equals(CMsgClientToGCBingoGetStatsDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_"></a> MergeFrom\(CMsgClientToGCBingoGetStatsDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCBingoGetStatsDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCBingoGetStatsDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCBingoGetStatsDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoGetStatsDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

