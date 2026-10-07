# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat"></a> Class CMsgShowcaseItem\_Stat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_Stat : IMessage<CMsgShowcaseItem_Stat>, IEquatable<CMsgShowcaseItem_Stat>, IDeepCloneable<CMsgShowcaseItem_Stat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)

#### Implements

IMessage<CMsgShowcaseItem\_Stat\>, 
[IEquatable<CMsgShowcaseItem\_Stat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_Stat\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_Stat\>\(CMsgShowcaseItem\_Stat, params CMsgShowcaseItem\_Stat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat__ctor"></a> CMsgShowcaseItem\_Stat\(\)

```csharp
public CMsgShowcaseItem_Stat()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_"></a> CMsgShowcaseItem\_Stat\(CMsgShowcaseItem\_Stat\)

```csharp
public CMsgShowcaseItem_Stat(CMsgShowcaseItem_Stat other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_StatIdFieldNumber"></a> StatIdFieldNumber

```csharp
public const int StatIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Data"></a> Data

```csharp
public CMsgShowcaseItem_Stat.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_HasStatId"></a> HasStatId

```csharp
public bool HasStatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_Stat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_StatId"></a> StatId

```csharp
public CMsgDOTAProfileCard.Types.EStatID StatId { get; set; }
```

#### Property Value

 [CMsgDOTAProfileCard](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.md).[EStatID](Divine.Protobufs.Dota2.CMsgDOTAProfileCard.Types.EStatID.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_ClearStatId"></a> ClearStatId\(\)

```csharp
public void ClearStatId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_Stat Clone()
```

#### Returns

 [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_"></a> Equals\(CMsgShowcaseItem\_Stat\)

```csharp
public bool Equals(CMsgShowcaseItem_Stat other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_"></a> MergeFrom\(CMsgShowcaseItem\_Stat\)

```csharp
public void MergeFrom(CMsgShowcaseItem_Stat other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Stat](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Stat.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Stat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

