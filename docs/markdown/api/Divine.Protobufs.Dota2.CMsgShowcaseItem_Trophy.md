# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy"></a> Class CMsgShowcaseItem\_Trophy

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_Trophy : IMessage<CMsgShowcaseItem_Trophy>, IEquatable<CMsgShowcaseItem_Trophy>, IDeepCloneable<CMsgShowcaseItem_Trophy>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)

#### Implements

IMessage<CMsgShowcaseItem\_Trophy\>, 
[IEquatable<CMsgShowcaseItem\_Trophy\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_Trophy\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_Trophy\>\(CMsgShowcaseItem\_Trophy, params CMsgShowcaseItem\_Trophy\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy__ctor"></a> CMsgShowcaseItem\_Trophy\(\)

```csharp
public CMsgShowcaseItem_Trophy()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_"></a> CMsgShowcaseItem\_Trophy\(CMsgShowcaseItem\_Trophy\)

```csharp
public CMsgShowcaseItem_Trophy(CMsgShowcaseItem_Trophy other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_TrophyIdFieldNumber"></a> TrophyIdFieldNumber

```csharp
public const int TrophyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Data"></a> Data

```csharp
public CMsgShowcaseItem_Trophy.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_HasTrophyId"></a> HasTrophyId

```csharp
public bool HasTrophyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_Trophy> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_TrophyId"></a> TrophyId

```csharp
public uint TrophyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_ClearTrophyId"></a> ClearTrophyId\(\)

```csharp
public void ClearTrophyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_Trophy Clone()
```

#### Returns

 [CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_"></a> Equals\(CMsgShowcaseItem\_Trophy\)

```csharp
public bool Equals(CMsgShowcaseItem_Trophy other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_"></a> MergeFrom\(CMsgShowcaseItem\_Trophy\)

```csharp
public void MergeFrom(CMsgShowcaseItem_Trophy other)
```

#### Parameters

`other` [CMsgShowcaseItem\_Trophy](Divine.Protobufs.Dota2.CMsgShowcaseItem\_Trophy.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_Trophy_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

