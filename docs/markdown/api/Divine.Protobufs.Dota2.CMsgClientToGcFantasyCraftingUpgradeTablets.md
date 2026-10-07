# <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets"></a> Class CMsgClientToGcFantasyCraftingUpgradeTablets

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGcFantasyCraftingUpgradeTablets : IMessage<CMsgClientToGcFantasyCraftingUpgradeTablets>, IEquatable<CMsgClientToGcFantasyCraftingUpgradeTablets>, IDeepCloneable<CMsgClientToGcFantasyCraftingUpgradeTablets>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)

#### Implements

IMessage<CMsgClientToGcFantasyCraftingUpgradeTablets\>, 
[IEquatable<CMsgClientToGcFantasyCraftingUpgradeTablets\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGcFantasyCraftingUpgradeTablets\>, 
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
[EnumerableExtensions.In<CMsgClientToGcFantasyCraftingUpgradeTablets\>\(CMsgClientToGcFantasyCraftingUpgradeTablets, params CMsgClientToGcFantasyCraftingUpgradeTablets\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets__ctor"></a> CMsgClientToGcFantasyCraftingUpgradeTablets\(\)

```csharp
public CMsgClientToGcFantasyCraftingUpgradeTablets()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets__ctor_Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_"></a> CMsgClientToGcFantasyCraftingUpgradeTablets\(CMsgClientToGcFantasyCraftingUpgradeTablets\)

```csharp
public CMsgClientToGcFantasyCraftingUpgradeTablets(CMsgClientToGcFantasyCraftingUpgradeTablets other)
```

#### Parameters

`other` [CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_FantasyLeagueFieldNumber"></a> FantasyLeagueFieldNumber

```csharp
public const int FantasyLeagueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_FantasyLeague"></a> FantasyLeague

```csharp
public uint FantasyLeague { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_HasFantasyLeague"></a> HasFantasyLeague

```csharp
public bool HasFantasyLeague { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGcFantasyCraftingUpgradeTablets> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_ClearFantasyLeague"></a> ClearFantasyLeague\(\)

```csharp
public void ClearFantasyLeague()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGcFantasyCraftingUpgradeTablets Clone()
```

#### Returns

 [CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_Equals_Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_"></a> Equals\(CMsgClientToGcFantasyCraftingUpgradeTablets\)

```csharp
public bool Equals(CMsgClientToGcFantasyCraftingUpgradeTablets other)
```

#### Parameters

`other` [CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_"></a> MergeFrom\(CMsgClientToGcFantasyCraftingUpgradeTablets\)

```csharp
public void MergeFrom(CMsgClientToGcFantasyCraftingUpgradeTablets other)
```

#### Parameters

`other` [CMsgClientToGcFantasyCraftingUpgradeTablets](Divine.Protobufs.Dota2.CMsgClientToGcFantasyCraftingUpgradeTablets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGcFantasyCraftingUpgradeTablets_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

