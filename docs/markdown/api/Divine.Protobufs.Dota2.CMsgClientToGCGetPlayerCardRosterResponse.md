# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse"></a> Class CMsgClientToGCGetPlayerCardRosterResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetPlayerCardRosterResponse : IMessage<CMsgClientToGCGetPlayerCardRosterResponse>, IEquatable<CMsgClientToGCGetPlayerCardRosterResponse>, IDeepCloneable<CMsgClientToGCGetPlayerCardRosterResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)

#### Implements

IMessage<CMsgClientToGCGetPlayerCardRosterResponse\>, 
[IEquatable<CMsgClientToGCGetPlayerCardRosterResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetPlayerCardRosterResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetPlayerCardRosterResponse\>\(CMsgClientToGCGetPlayerCardRosterResponse, params CMsgClientToGCGetPlayerCardRosterResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse__ctor"></a> CMsgClientToGCGetPlayerCardRosterResponse\(\)

```csharp
public CMsgClientToGCGetPlayerCardRosterResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_"></a> CMsgClientToGCGetPlayerCardRosterResponse\(CMsgClientToGCGetPlayerCardRosterResponse\)

```csharp
public CMsgClientToGCGetPlayerCardRosterResponse(CMsgClientToGCGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_FinalizedFieldNumber"></a> FinalizedFieldNumber

```csharp
public const int FinalizedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_PercentileFieldNumber"></a> PercentileFieldNumber

```csharp
public const int PercentileFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_PlayerCardItemIdFieldNumber"></a> PlayerCardItemIdFieldNumber

```csharp
public const int PlayerCardItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Finalized"></a> Finalized

```csharp
public bool Finalized { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_HasFinalized"></a> HasFinalized

```csharp
public bool HasFinalized { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_HasPercentile"></a> HasPercentile

```csharp
public bool HasPercentile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetPlayerCardRosterResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Percentile"></a> Percentile

```csharp
public float Percentile { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_PlayerCardItemId"></a> PlayerCardItemId

```csharp
public RepeatedField<ulong> PlayerCardItemId { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetPlayerCardRosterResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Score"></a> Score

```csharp
public float Score { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ClearFinalized"></a> ClearFinalized\(\)

```csharp
public void ClearFinalized()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ClearPercentile"></a> ClearPercentile\(\)

```csharp
public void ClearPercentile()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetPlayerCardRosterResponse Clone()
```

#### Returns

 [CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_"></a> Equals\(CMsgClientToGCGetPlayerCardRosterResponse\)

```csharp
public bool Equals(CMsgClientToGCGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_"></a> MergeFrom\(CMsgClientToGCGetPlayerCardRosterResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

