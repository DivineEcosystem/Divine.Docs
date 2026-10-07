# <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats"></a> Class CMsgHeroRoleHeroStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroRoleHeroStats : IMessage<CMsgHeroRoleHeroStats>, IEquatable<CMsgHeroRoleHeroStats>, IDeepCloneable<CMsgHeroRoleHeroStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)

#### Implements

IMessage<CMsgHeroRoleHeroStats\>, 
[IEquatable<CMsgHeroRoleHeroStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroRoleHeroStats\>, 
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
[EnumerableExtensions.In<CMsgHeroRoleHeroStats\>\(CMsgHeroRoleHeroStats, params CMsgHeroRoleHeroStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats__ctor"></a> CMsgHeroRoleHeroStats\(\)

```csharp
public CMsgHeroRoleHeroStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats__ctor_Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_"></a> CMsgHeroRoleHeroStats\(CMsgHeroRoleHeroStats\)

```csharp
public CMsgHeroRoleHeroStats(CMsgHeroRoleHeroStats other)
```

#### Parameters

`other` [CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_RoleStatsFieldNumber"></a> RoleStatsFieldNumber

```csharp
public const int RoleStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroRoleHeroStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_RoleStats"></a> RoleStats

```csharp
public RepeatedField<CMsgHeroRoleStats> RoleStats { get; }
```

#### Property Value

 RepeatedField<[CMsgHeroRoleStats](Divine.Protobufs.Dota2.CMsgHeroRoleStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_Clone"></a> Clone\(\)

```csharp
public CMsgHeroRoleHeroStats Clone()
```

#### Returns

 [CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_Equals_Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_"></a> Equals\(CMsgHeroRoleHeroStats\)

```csharp
public bool Equals(CMsgHeroRoleHeroStats other)
```

#### Parameters

`other` [CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_"></a> MergeFrom\(CMsgHeroRoleHeroStats\)

```csharp
public void MergeFrom(CMsgHeroRoleHeroStats other)
```

#### Parameters

`other` [CMsgHeroRoleHeroStats](Divine.Protobufs.Dota2.CMsgHeroRoleHeroStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroRoleHeroStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

