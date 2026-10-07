# <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero"></a> Class CMsgSuccessfulHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSuccessfulHero : IMessage<CMsgSuccessfulHero>, IEquatable<CMsgSuccessfulHero>, IDeepCloneable<CMsgSuccessfulHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)

#### Implements

IMessage<CMsgSuccessfulHero\>, 
[IEquatable<CMsgSuccessfulHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSuccessfulHero\>, 
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
[EnumerableExtensions.In<CMsgSuccessfulHero\>\(CMsgSuccessfulHero, params CMsgSuccessfulHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero__ctor"></a> CMsgSuccessfulHero\(\)

```csharp
public CMsgSuccessfulHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero__ctor_Divine_Protobufs_Dota2_CMsgSuccessfulHero_"></a> CMsgSuccessfulHero\(CMsgSuccessfulHero\)

```csharp
public CMsgSuccessfulHero(CMsgSuccessfulHero other)
```

#### Parameters

`other` [CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_LongestStreakFieldNumber"></a> LongestStreakFieldNumber

```csharp
public const int LongestStreakFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_WinPercentFieldNumber"></a> WinPercentFieldNumber

```csharp
public const int WinPercentFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_HasLongestStreak"></a> HasLongestStreak

```csharp
public bool HasLongestStreak { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_HasWinPercent"></a> HasWinPercent

```csharp
public bool HasWinPercent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_LongestStreak"></a> LongestStreak

```csharp
public uint LongestStreak { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSuccessfulHero> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_WinPercent"></a> WinPercent

```csharp
public float WinPercent { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_ClearLongestStreak"></a> ClearLongestStreak\(\)

```csharp
public void ClearLongestStreak()
```

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_ClearWinPercent"></a> ClearWinPercent\(\)

```csharp
public void ClearWinPercent()
```

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_Clone"></a> Clone\(\)

```csharp
public CMsgSuccessfulHero Clone()
```

#### Returns

 [CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_Equals_Divine_Protobufs_Dota2_CMsgSuccessfulHero_"></a> Equals\(CMsgSuccessfulHero\)

```csharp
public bool Equals(CMsgSuccessfulHero other)
```

#### Parameters

`other` [CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_MergeFrom_Divine_Protobufs_Dota2_CMsgSuccessfulHero_"></a> MergeFrom\(CMsgSuccessfulHero\)

```csharp
public void MergeFrom(CMsgSuccessfulHero other)
```

#### Parameters

`other` [CMsgSuccessfulHero](Divine.Protobufs.Dota2.CMsgSuccessfulHero.md)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSuccessfulHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

