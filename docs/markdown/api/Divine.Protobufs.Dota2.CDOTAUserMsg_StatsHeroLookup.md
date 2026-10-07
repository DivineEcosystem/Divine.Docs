# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup"></a> Class CDOTAUserMsg\_StatsHeroLookup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_StatsHeroLookup : IMessage<CDOTAUserMsg_StatsHeroLookup>, IEquatable<CDOTAUserMsg_StatsHeroLookup>, IDeepCloneable<CDOTAUserMsg_StatsHeroLookup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)

#### Implements

IMessage<CDOTAUserMsg\_StatsHeroLookup\>, 
[IEquatable<CDOTAUserMsg\_StatsHeroLookup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_StatsHeroLookup\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_StatsHeroLookup\>\(CDOTAUserMsg\_StatsHeroLookup, params CDOTAUserMsg\_StatsHeroLookup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup__ctor"></a> CDOTAUserMsg\_StatsHeroLookup\(\)

```csharp
public CDOTAUserMsg_StatsHeroLookup()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_"></a> CDOTAUserMsg\_StatsHeroLookup\(CDOTAUserMsg\_StatsHeroLookup\)

```csharp
public CDOTAUserMsg_StatsHeroLookup(CDOTAUserMsg_StatsHeroLookup other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HeroNameFieldNumber"></a> HeroNameFieldNumber

```csharp
public const int HeroNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_PersonaFieldNumber"></a> PersonaFieldNumber

```csharp
public const int PersonaFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HasHeroName"></a> HasHeroName

```csharp
public bool HasHeroName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HasPersona"></a> HasPersona

```csharp
public bool HasPersona { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_HeroName"></a> HeroName

```csharp
public string HeroName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_StatsHeroLookup> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Persona"></a> Persona

```csharp
public string Persona { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_ClearHeroName"></a> ClearHeroName\(\)

```csharp
public void ClearHeroName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_ClearPersona"></a> ClearPersona\(\)

```csharp
public void ClearPersona()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_StatsHeroLookup Clone()
```

#### Returns

 [CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_"></a> Equals\(CDOTAUserMsg\_StatsHeroLookup\)

```csharp
public bool Equals(CDOTAUserMsg_StatsHeroLookup other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_"></a> MergeFrom\(CDOTAUserMsg\_StatsHeroLookup\)

```csharp
public void MergeFrom(CDOTAUserMsg_StatsHeroLookup other)
```

#### Parameters

`other` [CDOTAUserMsg\_StatsHeroLookup](Divine.Protobufs.Dota2.CDOTAUserMsg\_StatsHeroLookup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_StatsHeroLookup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

