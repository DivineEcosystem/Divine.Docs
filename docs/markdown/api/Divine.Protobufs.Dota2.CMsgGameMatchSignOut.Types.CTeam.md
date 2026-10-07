# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam"></a> Class CMsgGameMatchSignOut.Types.CTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut.Types.CTeam : IMessage<CMsgGameMatchSignOut.Types.CTeam>, IEquatable<CMsgGameMatchSignOut.Types.CTeam>, IDeepCloneable<CMsgGameMatchSignOut.Types.CTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut.Types.CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)

#### Implements

IMessage<CMsgGameMatchSignOut.Types.CTeam\>, 
[IEquatable<CMsgGameMatchSignOut.Types.CTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut.Types.CTeam\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut.Types.CTeam\>\(CMsgGameMatchSignOut.Types.CTeam, params CMsgGameMatchSignOut.Types.CTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam__ctor"></a> CTeam\(\)

```csharp
public CTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_"></a> CTeam\(CTeam\)

```csharp
public CTeam(CMsgGameMatchSignOut.Types.CTeam other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_TeamTrackedStatsFieldNumber"></a> TeamTrackedStatsFieldNumber

```csharp
public const int TeamTrackedStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut.Types.CTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Players"></a> Players

```csharp
public RepeatedField<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_TeamTrackedStats"></a> TeamTrackedStats

```csharp
public RepeatedField<CMsgTrackedStat> TeamTrackedStats { get; }
```

#### Property Value

 RepeatedField<[CMsgTrackedStat](Divine.Protobufs.Dota2.CMsgTrackedStat.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut.Types.CTeam Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_"></a> Equals\(CTeam\)

```csharp
public bool Equals(CMsgGameMatchSignOut.Types.CTeam other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_"></a> MergeFrom\(CTeam\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut.Types.CTeam other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

