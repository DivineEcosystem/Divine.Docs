# <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner"></a> Class CMsgClientToGCApplyGemCombiner

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCApplyGemCombiner : IMessage<CMsgClientToGCApplyGemCombiner>, IEquatable<CMsgClientToGCApplyGemCombiner>, IDeepCloneable<CMsgClientToGCApplyGemCombiner>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)

#### Implements

IMessage<CMsgClientToGCApplyGemCombiner\>, 
[IEquatable<CMsgClientToGCApplyGemCombiner\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCApplyGemCombiner\>, 
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
[EnumerableExtensions.In<CMsgClientToGCApplyGemCombiner\>\(CMsgClientToGCApplyGemCombiner, params CMsgClientToGCApplyGemCombiner\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner__ctor"></a> CMsgClientToGCApplyGemCombiner\(\)

```csharp
public CMsgClientToGCApplyGemCombiner()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner__ctor_Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_"></a> CMsgClientToGCApplyGemCombiner\(CMsgClientToGCApplyGemCombiner\)

```csharp
public CMsgClientToGCApplyGemCombiner(CMsgClientToGCApplyGemCombiner other)
```

#### Parameters

`other` [CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ItemId1FieldNumber"></a> ItemId1FieldNumber

```csharp
public const int ItemId1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ItemId2FieldNumber"></a> ItemId2FieldNumber

```csharp
public const int ItemId2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_HasItemId1"></a> HasItemId1

```csharp
public bool HasItemId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_HasItemId2"></a> HasItemId2

```csharp
public bool HasItemId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ItemId1"></a> ItemId1

```csharp
public ulong ItemId1 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ItemId2"></a> ItemId2

```csharp
public ulong ItemId2 { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCApplyGemCombiner> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ClearItemId1"></a> ClearItemId1\(\)

```csharp
public void ClearItemId1()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ClearItemId2"></a> ClearItemId2\(\)

```csharp
public void ClearItemId2()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCApplyGemCombiner Clone()
```

#### Returns

 [CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_Equals_Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_"></a> Equals\(CMsgClientToGCApplyGemCombiner\)

```csharp
public bool Equals(CMsgClientToGCApplyGemCombiner other)
```

#### Parameters

`other` [CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_"></a> MergeFrom\(CMsgClientToGCApplyGemCombiner\)

```csharp
public void MergeFrom(CMsgClientToGCApplyGemCombiner other)
```

#### Parameters

`other` [CMsgClientToGCApplyGemCombiner](Divine.Protobufs.Dota2.CMsgClientToGCApplyGemCombiner.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCApplyGemCombiner_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

