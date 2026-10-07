# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse"></a> Class CMsgGCToClientRankResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRankResponse : IMessage<CMsgGCToClientRankResponse>, IEquatable<CMsgGCToClientRankResponse>, IDeepCloneable<CMsgGCToClientRankResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

#### Implements

IMessage<CMsgGCToClientRankResponse\>, 
[IEquatable<CMsgGCToClientRankResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRankResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRankResponse\>\(CMsgGCToClientRankResponse, params CMsgGCToClientRankResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse__ctor"></a> CMsgGCToClientRankResponse\(\)

```csharp
public CMsgGCToClientRankResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_"></a> CMsgGCToClientRankResponse\(CMsgGCToClientRankResponse\)

```csharp
public CMsgGCToClientRankResponse(CMsgGCToClientRankResponse other)
```

#### Parameters

`other` [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData1FieldNumber"></a> RankData1FieldNumber

```csharp
public const int RankData1FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData2FieldNumber"></a> RankData2FieldNumber

```csharp
public const int RankData2FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData3FieldNumber"></a> RankData3FieldNumber

```csharp
public const int RankData3FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankValueFieldNumber"></a> RankValueFieldNumber

```csharp
public const int RankValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_HasRankData1"></a> HasRankData1

```csharp
public bool HasRankData1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_HasRankData2"></a> HasRankData2

```csharp
public bool HasRankData2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_HasRankData3"></a> HasRankData3

```csharp
public bool HasRankData3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_HasRankValue"></a> HasRankValue

```csharp
public bool HasRankValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRankResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData1"></a> RankData1

```csharp
public uint RankData1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData2"></a> RankData2

```csharp
public uint RankData2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankData3"></a> RankData3

```csharp
public uint RankData3 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_RankValue"></a> RankValue

```csharp
public uint RankValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Result"></a> Result

```csharp
public CMsgGCToClientRankResponse.Types.EResultCode Result { get; set; }
```

#### Property Value

 [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.Types.md).[EResultCode](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.Types.EResultCode.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ClearRankData1"></a> ClearRankData1\(\)

```csharp
public void ClearRankData1()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ClearRankData2"></a> ClearRankData2\(\)

```csharp
public void ClearRankData2()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ClearRankData3"></a> ClearRankData3\(\)

```csharp
public void ClearRankData3()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ClearRankValue"></a> ClearRankValue\(\)

```csharp
public void ClearRankValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRankResponse Clone()
```

#### Returns

 [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_"></a> Equals\(CMsgGCToClientRankResponse\)

```csharp
public bool Equals(CMsgGCToClientRankResponse other)
```

#### Parameters

`other` [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_"></a> MergeFrom\(CMsgGCToClientRankResponse\)

```csharp
public void MergeFrom(CMsgGCToClientRankResponse other)
```

#### Parameters

`other` [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

