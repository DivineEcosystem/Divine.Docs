# <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup"></a> Class CMsgDOTAFantasyCardLineup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAFantasyCardLineup : IMessage<CMsgDOTAFantasyCardLineup>, IEquatable<CMsgDOTAFantasyCardLineup>, IDeepCloneable<CMsgDOTAFantasyCardLineup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)

#### Implements

IMessage<CMsgDOTAFantasyCardLineup\>, 
[IEquatable<CMsgDOTAFantasyCardLineup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAFantasyCardLineup\>, 
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
[EnumerableExtensions.In<CMsgDOTAFantasyCardLineup\>\(CMsgDOTAFantasyCardLineup, params CMsgDOTAFantasyCardLineup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup__ctor"></a> CMsgDOTAFantasyCardLineup\(\)

```csharp
public CMsgDOTAFantasyCardLineup()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup__ctor_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_"></a> CMsgDOTAFantasyCardLineup\(CMsgDOTAFantasyCardLineup\)

```csharp
public CMsgDOTAFantasyCardLineup(CMsgDOTAFantasyCardLineup other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_PeriodsFieldNumber"></a> PeriodsFieldNumber

```csharp
public const int PeriodsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAFantasyCardLineup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Periods"></a> Periods

```csharp
public RepeatedField<CMsgDOTAFantasyCardLineup.Types.Period> Periods { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.md).[Period](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.Types.Period.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAFantasyCardLineup Clone()
```

#### Returns

 [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_Equals_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_"></a> Equals\(CMsgDOTAFantasyCardLineup\)

```csharp
public bool Equals(CMsgDOTAFantasyCardLineup other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_"></a> MergeFrom\(CMsgDOTAFantasyCardLineup\)

```csharp
public void MergeFrom(CMsgDOTAFantasyCardLineup other)
```

#### Parameters

`other` [CMsgDOTAFantasyCardLineup](Divine.Protobufs.Dota2.CMsgDOTAFantasyCardLineup.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAFantasyCardLineup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

