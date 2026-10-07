# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults"></a> Class CMsgDOTADPCSearchResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCSearchResults : IMessage<CMsgDOTADPCSearchResults>, IEquatable<CMsgDOTADPCSearchResults>, IDeepCloneable<CMsgDOTADPCSearchResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)

#### Implements

IMessage<CMsgDOTADPCSearchResults\>, 
[IEquatable<CMsgDOTADPCSearchResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCSearchResults\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCSearchResults\>\(CMsgDOTADPCSearchResults, params CMsgDOTADPCSearchResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults__ctor"></a> CMsgDOTADPCSearchResults\(\)

```csharp
public CMsgDOTADPCSearchResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_"></a> CMsgDOTADPCSearchResults\(CMsgDOTADPCSearchResults\)

```csharp
public CMsgDOTADPCSearchResults(CMsgDOTADPCSearchResults other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_LeaguesFieldNumber"></a> LeaguesFieldNumber

```csharp
public const int LeaguesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_PlayersFieldNumber"></a> PlayersFieldNumber

```csharp
public const int PlayersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Leagues"></a> Leagues

```csharp
public RepeatedField<CMsgDOTADPCSearchResults.Types.League> Leagues { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[League](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.League.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCSearchResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Players"></a> Players

```csharp
public RepeatedField<CMsgDOTADPCSearchResults.Types.Player> Players { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Player](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Player.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Teams"></a> Teams

```csharp
public RepeatedField<CMsgDOTADPCSearchResults.Types.Team> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.md).[Team](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.Types.Team.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCSearchResults Clone()
```

#### Returns

 [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_"></a> Equals\(CMsgDOTADPCSearchResults\)

```csharp
public bool Equals(CMsgDOTADPCSearchResults other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_"></a> MergeFrom\(CMsgDOTADPCSearchResults\)

```csharp
public void MergeFrom(CMsgDOTADPCSearchResults other)
```

#### Parameters

`other` [CMsgDOTADPCSearchResults](Divine.Protobufs.Dota2.CMsgDOTADPCSearchResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCSearchResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

