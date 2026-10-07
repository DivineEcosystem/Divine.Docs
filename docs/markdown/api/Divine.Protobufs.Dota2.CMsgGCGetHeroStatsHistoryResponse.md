# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse"></a> Class CMsgGCGetHeroStatsHistoryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroStatsHistoryResponse : IMessage<CMsgGCGetHeroStatsHistoryResponse>, IEquatable<CMsgGCGetHeroStatsHistoryResponse>, IDeepCloneable<CMsgGCGetHeroStatsHistoryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)

#### Implements

IMessage<CMsgGCGetHeroStatsHistoryResponse\>, 
[IEquatable<CMsgGCGetHeroStatsHistoryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroStatsHistoryResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroStatsHistoryResponse\>\(CMsgGCGetHeroStatsHistoryResponse, params CMsgGCGetHeroStatsHistoryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse__ctor"></a> CMsgGCGetHeroStatsHistoryResponse\(\)

```csharp
public CMsgGCGetHeroStatsHistoryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_"></a> CMsgGCGetHeroStatsHistoryResponse\(CMsgGCGetHeroStatsHistoryResponse\)

```csharp
public CMsgGCGetHeroStatsHistoryResponse(CMsgGCGetHeroStatsHistoryResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_RecordsFieldNumber"></a> RecordsFieldNumber

```csharp
public const int RecordsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroStatsHistoryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Records"></a> Records

```csharp
public RepeatedField<CMsgDOTASDOHeroStatsHistory> Records { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTASDOHeroStatsHistory](Divine.Protobufs.Dota2.CMsgDOTASDOHeroStatsHistory.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Result"></a> Result

```csharp
public CMsgGCGetHeroStatsHistoryResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroStatsHistoryResponse Clone()
```

#### Returns

 [CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_"></a> Equals\(CMsgGCGetHeroStatsHistoryResponse\)

```csharp
public bool Equals(CMsgGCGetHeroStatsHistoryResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_"></a> MergeFrom\(CMsgGCGetHeroStatsHistoryResponse\)

```csharp
public void MergeFrom(CMsgGCGetHeroStatsHistoryResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStatsHistoryResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStatsHistoryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStatsHistoryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

