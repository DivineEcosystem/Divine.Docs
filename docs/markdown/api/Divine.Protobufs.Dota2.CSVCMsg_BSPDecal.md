# <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal"></a> Class CSVCMsg\_BSPDecal

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_BSPDecal : IMessage<CSVCMsg_BSPDecal>, IEquatable<CSVCMsg_BSPDecal>, IDeepCloneable<CSVCMsg_BSPDecal>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)

#### Implements

IMessage<CSVCMsg\_BSPDecal\>, 
[IEquatable<CSVCMsg\_BSPDecal\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_BSPDecal\>, 
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
[EnumerableExtensions.In<CSVCMsg\_BSPDecal\>\(CSVCMsg\_BSPDecal, params CSVCMsg\_BSPDecal\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal__ctor"></a> CSVCMsg\_BSPDecal\(\)

```csharp
public CSVCMsg_BSPDecal()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal__ctor_Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_"></a> CSVCMsg\_BSPDecal\(CSVCMsg\_BSPDecal\)

```csharp
public CSVCMsg_BSPDecal(CSVCMsg_BSPDecal other)
```

#### Parameters

`other` [CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_DecalTextureIndexFieldNumber"></a> DecalTextureIndexFieldNumber

```csharp
public const int DecalTextureIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_LowPriorityFieldNumber"></a> LowPriorityFieldNumber

```csharp
public const int LowPriorityFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ModelIndexFieldNumber"></a> ModelIndexFieldNumber

```csharp
public const int ModelIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_PosFieldNumber"></a> PosFieldNumber

```csharp
public const int PosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_DecalTextureIndex"></a> DecalTextureIndex

```csharp
public int DecalTextureIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_HasDecalTextureIndex"></a> HasDecalTextureIndex

```csharp
public bool HasDecalTextureIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_HasLowPriority"></a> HasLowPriority

```csharp
public bool HasLowPriority { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_HasModelIndex"></a> HasModelIndex

```csharp
public bool HasModelIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_LowPriority"></a> LowPriority

```csharp
public bool LowPriority { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ModelIndex"></a> ModelIndex

```csharp
public int ModelIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_BSPDecal> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Pos"></a> Pos

```csharp
public CMsgVector Pos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ClearDecalTextureIndex"></a> ClearDecalTextureIndex\(\)

```csharp
public void ClearDecalTextureIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ClearLowPriority"></a> ClearLowPriority\(\)

```csharp
public void ClearLowPriority()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ClearModelIndex"></a> ClearModelIndex\(\)

```csharp
public void ClearModelIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_BSPDecal Clone()
```

#### Returns

 [CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_Equals_Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_"></a> Equals\(CSVCMsg\_BSPDecal\)

```csharp
public bool Equals(CSVCMsg_BSPDecal other)
```

#### Parameters

`other` [CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_"></a> MergeFrom\(CSVCMsg\_BSPDecal\)

```csharp
public void MergeFrom(CSVCMsg_BSPDecal other)
```

#### Parameters

`other` [CSVCMsg\_BSPDecal](Divine.Protobufs.Dota2.CSVCMsg\_BSPDecal.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_BSPDecal_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

