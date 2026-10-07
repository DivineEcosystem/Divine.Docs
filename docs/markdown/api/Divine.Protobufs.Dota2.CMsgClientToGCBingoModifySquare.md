# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare"></a> Class CMsgClientToGCBingoModifySquare

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBingoModifySquare : IMessage<CMsgClientToGCBingoModifySquare>, IEquatable<CMsgClientToGCBingoModifySquare>, IDeepCloneable<CMsgClientToGCBingoModifySquare>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)

#### Implements

IMessage<CMsgClientToGCBingoModifySquare\>, 
[IEquatable<CMsgClientToGCBingoModifySquare\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBingoModifySquare\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBingoModifySquare\>\(CMsgClientToGCBingoModifySquare, params CMsgClientToGCBingoModifySquare\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare__ctor"></a> CMsgClientToGCBingoModifySquare\(\)

```csharp
public CMsgClientToGCBingoModifySquare()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_"></a> CMsgClientToGCBingoModifySquare\(CMsgClientToGCBingoModifySquare\)

```csharp
public CMsgClientToGCBingoModifySquare(CMsgClientToGCBingoModifySquare other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ActionFieldNumber"></a> ActionFieldNumber

```csharp
public const int ActionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_LeaguePhaseFieldNumber"></a> LeaguePhaseFieldNumber

```csharp
public const int LeaguePhaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_SquareIndexFieldNumber"></a> SquareIndexFieldNumber

```csharp
public const int SquareIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Action"></a> Action

```csharp
public CMsgClientToGCBingoModifySquare.Types.EModifyAction Action { get; set; }
```

#### Property Value

 [CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.Types.md).[EModifyAction](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.Types.EModifyAction.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_HasAction"></a> HasAction

```csharp
public bool HasAction { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_HasLeaguePhase"></a> HasLeaguePhase

```csharp
public bool HasLeaguePhase { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_HasSquareIndex"></a> HasSquareIndex

```csharp
public bool HasSquareIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_LeaguePhase"></a> LeaguePhase

```csharp
public uint LeaguePhase { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBingoModifySquare> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_SquareIndex"></a> SquareIndex

```csharp
public uint SquareIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ClearAction"></a> ClearAction\(\)

```csharp
public void ClearAction()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ClearLeaguePhase"></a> ClearLeaguePhase\(\)

```csharp
public void ClearLeaguePhase()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ClearSquareIndex"></a> ClearSquareIndex\(\)

```csharp
public void ClearSquareIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBingoModifySquare Clone()
```

#### Returns

 [CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_"></a> Equals\(CMsgClientToGCBingoModifySquare\)

```csharp
public bool Equals(CMsgClientToGCBingoModifySquare other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_"></a> MergeFrom\(CMsgClientToGCBingoModifySquare\)

```csharp
public void MergeFrom(CMsgClientToGCBingoModifySquare other)
```

#### Parameters

`other` [CMsgClientToGCBingoModifySquare](Divine.Protobufs.Dota2.CMsgClientToGCBingoModifySquare.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBingoModifySquare_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

