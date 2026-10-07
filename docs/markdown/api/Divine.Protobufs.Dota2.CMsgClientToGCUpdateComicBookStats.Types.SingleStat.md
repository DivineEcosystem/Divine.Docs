# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat"></a> Class CMsgClientToGCUpdateComicBookStats.Types.SingleStat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUpdateComicBookStats.Types.SingleStat : IMessage<CMsgClientToGCUpdateComicBookStats.Types.SingleStat>, IEquatable<CMsgClientToGCUpdateComicBookStats.Types.SingleStat>, IDeepCloneable<CMsgClientToGCUpdateComicBookStats.Types.SingleStat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUpdateComicBookStats.Types.SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)

#### Implements

IMessage<CMsgClientToGCUpdateComicBookStats.Types.SingleStat\>, 
[IEquatable<CMsgClientToGCUpdateComicBookStats.Types.SingleStat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUpdateComicBookStats.Types.SingleStat\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUpdateComicBookStats.Types.SingleStat\>\(CMsgClientToGCUpdateComicBookStats.Types.SingleStat, params CMsgClientToGCUpdateComicBookStats.Types.SingleStat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat__ctor"></a> SingleStat\(\)

```csharp
public SingleStat()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_"></a> SingleStat\(SingleStat\)

```csharp
public SingleStat(CMsgClientToGCUpdateComicBookStats.Types.SingleStat other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_StatTypeFieldNumber"></a> StatTypeFieldNumber

```csharp
public const int StatTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_StatValueFieldNumber"></a> StatValueFieldNumber

```csharp
public const int StatValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_HasStatType"></a> HasStatType

```csharp
public bool HasStatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_HasStatValue"></a> HasStatValue

```csharp
public bool HasStatValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUpdateComicBookStats.Types.SingleStat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_StatType"></a> StatType

```csharp
public CMsgClientToGCUpdateComicBookStat_Type StatType { get; set; }
```

#### Property Value

 [CMsgClientToGCUpdateComicBookStat\_Type](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStat\_Type.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_StatValue"></a> StatValue

```csharp
public uint StatValue { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_ClearStatType"></a> ClearStatType\(\)

```csharp
public void ClearStatType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_ClearStatValue"></a> ClearStatValue\(\)

```csharp
public void ClearStatValue()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUpdateComicBookStats.Types.SingleStat Clone()
```

#### Returns

 [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_"></a> Equals\(SingleStat\)

```csharp
public bool Equals(CMsgClientToGCUpdateComicBookStats.Types.SingleStat other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_"></a> MergeFrom\(SingleStat\)

```csharp
public void MergeFrom(CMsgClientToGCUpdateComicBookStats.Types.SingleStat other)
```

#### Parameters

`other` [CMsgClientToGCUpdateComicBookStats](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.md).[SingleStat](Divine.Protobufs.Dota2.CMsgClientToGCUpdateComicBookStats.Types.SingleStat.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUpdateComicBookStats_Types_SingleStat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

