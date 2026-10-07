# <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade"></a> Class CMatchPlayerAbilityUpgrade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMatchPlayerAbilityUpgrade : IMessage<CMatchPlayerAbilityUpgrade>, IEquatable<CMatchPlayerAbilityUpgrade>, IDeepCloneable<CMatchPlayerAbilityUpgrade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)

#### Implements

IMessage<CMatchPlayerAbilityUpgrade\>, 
[IEquatable<CMatchPlayerAbilityUpgrade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMatchPlayerAbilityUpgrade\>, 
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
[EnumerableExtensions.In<CMatchPlayerAbilityUpgrade\>\(CMatchPlayerAbilityUpgrade, params CMatchPlayerAbilityUpgrade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade__ctor"></a> CMatchPlayerAbilityUpgrade\(\)

```csharp
public CMatchPlayerAbilityUpgrade()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade__ctor_Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_"></a> CMatchPlayerAbilityUpgrade\(CMatchPlayerAbilityUpgrade\)

```csharp
public CMatchPlayerAbilityUpgrade(CMatchPlayerAbilityUpgrade other)
```

#### Parameters

`other` [CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_AbilityFieldNumber"></a> AbilityFieldNumber

```csharp
public const int AbilityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Ability"></a> Ability

```csharp
public int Ability { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_HasAbility"></a> HasAbility

```csharp
public bool HasAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Parser"></a> Parser

```csharp
public static MessageParser<CMatchPlayerAbilityUpgrade> Parser { get; }
```

#### Property Value

 MessageParser<[CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)\>

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Time"></a> Time

```csharp
public uint Time { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_ClearAbility"></a> ClearAbility\(\)

```csharp
public void ClearAbility()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Clone"></a> Clone\(\)

```csharp
public CMatchPlayerAbilityUpgrade Clone()
```

#### Returns

 [CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_Equals_Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_"></a> Equals\(CMatchPlayerAbilityUpgrade\)

```csharp
public bool Equals(CMatchPlayerAbilityUpgrade other)
```

#### Parameters

`other` [CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_MergeFrom_Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_"></a> MergeFrom\(CMatchPlayerAbilityUpgrade\)

```csharp
public void MergeFrom(CMatchPlayerAbilityUpgrade other)
```

#### Parameters

`other` [CMatchPlayerAbilityUpgrade](Divine.Protobufs.Dota2.CMatchPlayerAbilityUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMatchPlayerAbilityUpgrade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

