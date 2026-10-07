# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow"></a> Class CMsgClientToGCBingoClaimRow

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoClaimRow : IMessage<CMsgClientToGCBingoClaimRow>, IEquatable<CMsgClientToGCBingoClaimRow>, IDeepCloneable<CMsgClientToGCBingoClaimRow>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)

#### Implements

IMessage<CMsgClientToGCBingoClaimRow\>, 
[IEquatable<CMsgClientToGCBingoClaimRow\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoClaimRow\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoClaimRow\>\(CMsgClientToGCBingoClaimRow, params CMsgClientToGCBingoClaimRow\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow__ctor"></a> CMsgClientToGCBingoClaimRow\(\)

```csharp
public CMsgClientToGCBingoClaimRow()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_"></a> CMsgClientToGCBingoClaimRow\(CMsgClientToGCBingoClaimRow\)

```csharp
public CMsgClientToGCBingoClaimRow(CMsgClientToGCBingoClaimRow other)
```

#### Parameters

`other` [CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_RowIndexFieldNumber"></a> RowIndexFieldNumber

```csharp
public const int RowIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_HasRowIndex"></a> HasRowIndex

```csharp
public bool HasRowIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoClaimRow> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_RowIndex"></a> RowIndex

```csharp
public uint RowIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_ClearRowIndex"></a> ClearRowIndex\(\)

```csharp
public void ClearRowIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoClaimRow Clone()
```

#### Returns

 [CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_"></a> Equals\(CMsgClientToGCBingoClaimRow\)

```csharp
public bool Equals(CMsgClientToGCBingoClaimRow other)
```

#### Parameters

`other` [CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_"></a> MergeFrom\(CMsgClientToGCBingoClaimRow\)

```csharp
public void MergeFrom(CMsgClientToGCBingoClaimRow other)
```

#### Parameters

`other` [CMsgClientToGCBingoClaimRow](Divine.Protobufs.Dota2.CMsgClientToGCBingoClaimRow.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoClaimRow_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

