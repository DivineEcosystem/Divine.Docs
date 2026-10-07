# <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup"></a> Class CMsgShowcaseReportsRollup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseReportsRollup : IMessage<CMsgShowcaseReportsRollup>, IEquatable<CMsgShowcaseReportsRollup>, IDeepCloneable<CMsgShowcaseReportsRollup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

#### Implements

IMessage<CMsgShowcaseReportsRollup\>, 
[IEquatable<CMsgShowcaseReportsRollup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseReportsRollup\>, 
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
[EnumerableExtensions.In<CMsgShowcaseReportsRollup\>\(CMsgShowcaseReportsRollup, params CMsgShowcaseReportsRollup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup__ctor"></a> CMsgShowcaseReportsRollup\(\)

```csharp
public CMsgShowcaseReportsRollup()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup__ctor_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_"></a> CMsgShowcaseReportsRollup\(CMsgShowcaseReportsRollup\)

```csharp
public CMsgShowcaseReportsRollup(CMsgShowcaseReportsRollup other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_RollupEntriesFieldNumber"></a> RollupEntriesFieldNumber

```csharp
public const int RollupEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_RollupInfoFieldNumber"></a> RollupInfoFieldNumber

```csharp
public const int RollupInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseReportsRollup> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_RollupEntries"></a> RollupEntries

```csharp
public RepeatedField<CMsgShowcaseReportsRollupEntry> RollupEntries { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseReportsRollupEntry](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_RollupInfo"></a> RollupInfo

```csharp
public CMsgShowcaseReportsRollupInfo RollupInfo { get; set; }
```

#### Property Value

 [CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseReportsRollup Clone()
```

#### Returns

 [CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_Equals_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_"></a> Equals\(CMsgShowcaseReportsRollup\)

```csharp
public bool Equals(CMsgShowcaseReportsRollup other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_"></a> MergeFrom\(CMsgShowcaseReportsRollup\)

```csharp
public void MergeFrom(CMsgShowcaseReportsRollup other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollup](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollup.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

