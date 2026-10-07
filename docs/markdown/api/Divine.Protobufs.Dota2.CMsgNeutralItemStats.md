# <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats"></a> Class CMsgNeutralItemStats

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgNeutralItemStats : IMessage<CMsgNeutralItemStats>, IEquatable<CMsgNeutralItemStats>, IDeepCloneable<CMsgNeutralItemStats>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)

#### Implements

IMessage<CMsgNeutralItemStats\>, 
[IEquatable<CMsgNeutralItemStats\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgNeutralItemStats\>, 
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
[EnumerableExtensions.In<CMsgNeutralItemStats\>\(CMsgNeutralItemStats, params CMsgNeutralItemStats\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats__ctor"></a> CMsgNeutralItemStats\(\)

```csharp
public CMsgNeutralItemStats()
```

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats__ctor_Divine_Protobufs_Dota2_CMsgNeutralItemStats_"></a> CMsgNeutralItemStats\(CMsgNeutralItemStats\)

```csharp
public CMsgNeutralItemStats(CMsgNeutralItemStats other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_NeutralItemsFieldNumber"></a> NeutralItemsFieldNumber

```csharp
public const int NeutralItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_NeutralItems"></a> NeutralItems

```csharp
public RepeatedField<CMsgNeutralItemStats.Types.NeutralItem> NeutralItems { get; }
```

#### Property Value

 RepeatedField<[CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md).[Types](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.md).[NeutralItem](Divine.Protobufs.Dota2.CMsgNeutralItemStats.Types.NeutralItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Parser"></a> Parser

```csharp
public static MessageParser<CMsgNeutralItemStats> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Clone"></a> Clone\(\)

```csharp
public CMsgNeutralItemStats Clone()
```

#### Returns

 [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_Equals_Divine_Protobufs_Dota2_CMsgNeutralItemStats_"></a> Equals\(CMsgNeutralItemStats\)

```csharp
public bool Equals(CMsgNeutralItemStats other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_MergeFrom_Divine_Protobufs_Dota2_CMsgNeutralItemStats_"></a> MergeFrom\(CMsgNeutralItemStats\)

```csharp
public void MergeFrom(CMsgNeutralItemStats other)
```

#### Parameters

`other` [CMsgNeutralItemStats](Divine.Protobufs.Dota2.CMsgNeutralItemStats.md)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgNeutralItemStats_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

