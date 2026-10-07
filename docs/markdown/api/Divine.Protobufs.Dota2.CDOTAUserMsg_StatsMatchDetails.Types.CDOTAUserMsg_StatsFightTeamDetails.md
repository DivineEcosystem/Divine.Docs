# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails"></a> Class CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails : IMessage<CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails>, IEquatable<CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails>, IDeepCloneable<CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails\>, 
[IEquatable<CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails\>\(CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails, params CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails__ctor"></a> CDOTAUserMsg\_StatsFightTeamDetails\(\)

```csharp
public CDOTAUserMsg_StatsFightTeamDetails()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_"></a> CDOTAUserMsg\_StatsFightTeamDetails\(CDOTAUserMsg\_StatsFightTeamDetails\)

```csharp
public CDOTAUserMsg_StatsFightTeamDetails(CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_DeathsFieldNumber"></a> DeathsFieldNumber

```csharp
public const int DeathsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_GoldDeltaFieldNumber"></a> GoldDeltaFieldNumber

```csharp
public const int GoldDeltaFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_ParticipantsFieldNumber"></a> ParticipantsFieldNumber

```csharp
public const int ParticipantsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_XpDeltaFieldNumber"></a> XpDeltaFieldNumber

```csharp
public const int XpDeltaFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Deaths"></a> Deaths

```csharp
public RepeatedField<int> Deaths { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_GoldDelta"></a> GoldDelta

```csharp
public uint GoldDelta { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_HasGoldDelta"></a> HasGoldDelta

```csharp
public bool HasGoldDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_HasXpDelta"></a> HasXpDelta

```csharp
public bool HasXpDelta { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Participants"></a> Participants

```csharp
public RepeatedField<int> Participants { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_XpDelta"></a> XpDelta

```csharp
public uint XpDelta { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_ClearGoldDelta"></a> ClearGoldDelta\(\)

```csharp
public void ClearGoldDelta()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_ClearXpDelta"></a> ClearXpDelta\(\)

```csharp
public void ClearXpDelta()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_"></a> Equals\(CDOTAUserMsg\_StatsFightTeamDetails\)

```csharp
public bool Equals(CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_"></a> MergeFrom\(CDOTAUserMsg\_StatsFightTeamDetails\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsMatchDetails.Types.CDOTAUserMsg_StatsFightTeamDetails other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsMatchDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.md).[CDOTAUserMsg\_StatsFightTeamDetails](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsMatchDetails.Types.CDOTAUserMsg\_StatsFightTeamDetails.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsMatchDetails_Types_CDOTAUserMsg_StatsFightTeamDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

