# <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary"></a> Class CMsgServerToGCKillSummaries.Types.KillSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCKillSummaries.Types.KillSummary : IMessage<CMsgServerToGCKillSummaries.Types.KillSummary>, IEquatable<CMsgServerToGCKillSummaries.Types.KillSummary>, IDeepCloneable<CMsgServerToGCKillSummaries.Types.KillSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCKillSummaries.Types.KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)

#### Implements

IMessage<CMsgServerToGCKillSummaries.Types.KillSummary\>, 
[IEquatable<CMsgServerToGCKillSummaries.Types.KillSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCKillSummaries.Types.KillSummary\>, 
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
[EnumerableExtensions.In<CMsgServerToGCKillSummaries.Types.KillSummary\>\(CMsgServerToGCKillSummaries.Types.KillSummary, params CMsgServerToGCKillSummaries.Types.KillSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary__ctor"></a> KillSummary\(\)

```csharp
public KillSummary()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary__ctor_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_"></a> KillSummary\(KillSummary\)

```csharp
public KillSummary(CMsgServerToGCKillSummaries.Types.KillSummary other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_KillCountFieldNumber"></a> KillCountFieldNumber

```csharp
public const int KillCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_KillerHeroIdFieldNumber"></a> KillerHeroIdFieldNumber

```csharp
public const int KillerHeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_VictimHeroIdFieldNumber"></a> VictimHeroIdFieldNumber

```csharp
public const int VictimHeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_HasKillCount"></a> HasKillCount

```csharp
public bool HasKillCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_HasKillerHeroId"></a> HasKillerHeroId

```csharp
public bool HasKillerHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_HasVictimHeroId"></a> HasVictimHeroId

```csharp
public bool HasVictimHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_KillCount"></a> KillCount

```csharp
public uint KillCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_KillerHeroId"></a> KillerHeroId

```csharp
public uint KillerHeroId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCKillSummaries.Types.KillSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_VictimHeroId"></a> VictimHeroId

```csharp
public uint VictimHeroId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_ClearKillCount"></a> ClearKillCount\(\)

```csharp
public void ClearKillCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_ClearKillerHeroId"></a> ClearKillerHeroId\(\)

```csharp
public void ClearKillerHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_ClearVictimHeroId"></a> ClearVictimHeroId\(\)

```csharp
public void ClearVictimHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCKillSummaries.Types.KillSummary Clone()
```

#### Returns

 [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_Equals_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_"></a> Equals\(KillSummary\)

```csharp
public bool Equals(CMsgServerToGCKillSummaries.Types.KillSummary other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_"></a> MergeFrom\(KillSummary\)

```csharp
public void MergeFrom(CMsgServerToGCKillSummaries.Types.KillSummary other)
```

#### Parameters

`other` [CMsgServerToGCKillSummaries](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.md).[KillSummary](Divine.Protobufs.Dota2.CMsgServerToGCKillSummaries.Types.KillSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCKillSummaries_Types_KillSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

