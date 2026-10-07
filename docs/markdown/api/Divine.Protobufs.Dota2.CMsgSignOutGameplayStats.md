# <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats"></a> Class CMsgSignOutGameplayStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutGameplayStats : IMessage<CMsgSignOutGameplayStats>, IEquatable<CMsgSignOutGameplayStats>, IDeepCloneable<CMsgSignOutGameplayStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

#### Implements

IMessage<CMsgSignOutGameplayStats\>, 
[IEquatable<CMsgSignOutGameplayStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutGameplayStats\>, 
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
[EnumerableExtensions.In<CMsgSignOutGameplayStats\>\(CMsgSignOutGameplayStats, params CMsgSignOutGameplayStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats__ctor"></a> CMsgSignOutGameplayStats\(\)

```csharp
public CMsgSignOutGameplayStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats__ctor_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_"></a> CMsgSignOutGameplayStats\(CMsgSignOutGameplayStats\)

```csharp
public CMsgSignOutGameplayStats(CMsgSignOutGameplayStats other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_TeamsFieldNumber"></a> TeamsFieldNumber

```csharp
public const int TeamsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutGameplayStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Teams"></a> Teams

```csharp
public RepeatedField<CMsgSignOutGameplayStats.Types.CTeam> Teams { get; }
```

#### Property Value

 RepeatedField<[CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.Types.CTeam.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutGameplayStats Clone()
```

#### Returns

 [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_Equals_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_"></a> Equals\(CMsgSignOutGameplayStats\)

```csharp
public bool Equals(CMsgSignOutGameplayStats other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_"></a> MergeFrom\(CMsgSignOutGameplayStats\)

```csharp
public void MergeFrom(CMsgSignOutGameplayStats other)
```

#### Parameters

`other` [CMsgSignOutGameplayStats](Divine.Protobufs.Dota2.CMsgSignOutGameplayStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutGameplayStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

