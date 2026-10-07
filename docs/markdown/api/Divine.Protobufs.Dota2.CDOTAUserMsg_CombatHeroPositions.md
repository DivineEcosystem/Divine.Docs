# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions"></a> Class CDOTAUserMsg\_CombatHeroPositions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CombatHeroPositions : IMessage<CDOTAUserMsg_CombatHeroPositions>, IEquatable<CDOTAUserMsg_CombatHeroPositions>, IDeepCloneable<CDOTAUserMsg_CombatHeroPositions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)

#### Implements

IMessage<CDOTAUserMsg\_CombatHeroPositions\>, 
[IEquatable<CDOTAUserMsg\_CombatHeroPositions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CombatHeroPositions\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CombatHeroPositions\>\(CDOTAUserMsg\_CombatHeroPositions, params CDOTAUserMsg\_CombatHeroPositions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions__ctor"></a> CDOTAUserMsg\_CombatHeroPositions\(\)

```csharp
public CDOTAUserMsg_CombatHeroPositions()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_"></a> CDOTAUserMsg\_CombatHeroPositions\(CDOTAUserMsg\_CombatHeroPositions\)

```csharp
public CDOTAUserMsg_CombatHeroPositions(CDOTAUserMsg_CombatHeroPositions other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_HealthFieldNumber"></a> HealthFieldNumber

```csharp
public const int HealthFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_WorldPosFieldNumber"></a> WorldPosFieldNumber

```csharp
public const int WorldPosFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_HasHealth"></a> HasHealth

```csharp
public bool HasHealth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Health"></a> Health

```csharp
public int Health { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Index"></a> Index

```csharp
public uint Index { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CombatHeroPositions> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Time"></a> Time

```csharp
public int Time { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_WorldPos"></a> WorldPos

```csharp
public CMsgVector2D WorldPos { get; set; }
```

#### Property Value

 [CMsgVector2D](Divine.Protobufs.Dota2.CMsgVector2D.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_ClearHealth"></a> ClearHealth\(\)

```csharp
public void ClearHealth()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CombatHeroPositions Clone()
```

#### Returns

 [CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_"></a> Equals\(CDOTAUserMsg\_CombatHeroPositions\)

```csharp
public bool Equals(CDOTAUserMsg_CombatHeroPositions other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_"></a> MergeFrom\(CDOTAUserMsg\_CombatHeroPositions\)

```csharp
public void MergeFrom(CDOTAUserMsg_CombatHeroPositions other)
```

#### Parameters

`other` [CDOTAUserMsg\_CombatHeroPositions](Divine.Protobufs.Dota2.CDOTAUserMsg\_CombatHeroPositions.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CombatHeroPositions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

