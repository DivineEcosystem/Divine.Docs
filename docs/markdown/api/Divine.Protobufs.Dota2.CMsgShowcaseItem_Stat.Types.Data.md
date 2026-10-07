# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data"></a> Class CMsgShowcaseItem\_Stat.Types.Data

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_Stat.Types.Data : IMessage<CMsgShowcaseItem_Stat.Types.Data>, IEquatable<CMsgShowcaseItem_Stat.Types.Data>, IDeepCloneable<CMsgShowcaseItem_Stat.Types.Data>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_Stat.Types.Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

#### Implements

IMessage<CMsgShowcaseItem\_Stat.Types.Data\>, 
[IEquatable<CMsgShowcaseItem\_Stat.Types.Data\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_Stat.Types.Data\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_Stat.Types.Data\>\(CMsgShowcaseItem\_Stat.Types.Data, params CMsgShowcaseItem\_Stat.Types.Data\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data__ctor"></a> Data\(\)

```csharp
public Data()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_"></a> Data\(Data\)

```csharp
public Data(CMsgShowcaseItem_Stat.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_StatScoreFieldNumber"></a> StatScoreFieldNumber

```csharp
public const int StatScoreFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_HasStatScore"></a> HasStatScore

```csharp
public bool HasStatScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_Stat.Types.Data> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_StatScore"></a> StatScore

```csharp
public uint StatScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_ClearStatScore"></a> ClearStatScore\(\)

```csharp
public void ClearStatScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_Stat.Types.Data Clone()
```

#### Returns

 [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_"></a> Equals\(Data\)

```csharp
public bool Equals(CMsgShowcaseItem_Stat.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_"></a> MergeFrom\(Data\)

```csharp
public void MergeFrom(CMsgShowcaseItem_Stat.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Types_Data_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

