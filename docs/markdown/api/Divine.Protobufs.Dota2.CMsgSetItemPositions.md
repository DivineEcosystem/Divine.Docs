# <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions"></a> Class CMsgSetItemPositions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSetItemPositions : IMessage<CMsgSetItemPositions>, IEquatable<CMsgSetItemPositions>, IDeepCloneable<CMsgSetItemPositions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)

#### Implements

IMessage<CMsgSetItemPositions\>, 
[IEquatable<CMsgSetItemPositions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSetItemPositions\>, 
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
[EnumerableExtensions.In<CMsgSetItemPositions\>\(CMsgSetItemPositions, params CMsgSetItemPositions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions__ctor"></a> CMsgSetItemPositions\(\)

```csharp
public CMsgSetItemPositions()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions__ctor_Divine_Protobufs_Dota2_CMsgSetItemPositions_"></a> CMsgSetItemPositions\(CMsgSetItemPositions\)

```csharp
public CMsgSetItemPositions(CMsgSetItemPositions other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_ItemPositionsFieldNumber"></a> ItemPositionsFieldNumber

```csharp
public const int ItemPositionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_ItemPositions"></a> ItemPositions

```csharp
public RepeatedField<CMsgSetItemPositions.Types.ItemPosition> ItemPositions { get; }
```

#### Property Value

 RepeatedField<[CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md).[Types](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.md).[ItemPosition](Divine.Protobufs.Dota2.CMsgSetItemPositions.Types.ItemPosition.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSetItemPositions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Clone"></a> Clone\(\)

```csharp
public CMsgSetItemPositions Clone()
```

#### Returns

 [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_Equals_Divine_Protobufs_Dota2_CMsgSetItemPositions_"></a> Equals\(CMsgSetItemPositions\)

```csharp
public bool Equals(CMsgSetItemPositions other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_MergeFrom_Divine_Protobufs_Dota2_CMsgSetItemPositions_"></a> MergeFrom\(CMsgSetItemPositions\)

```csharp
public void MergeFrom(CMsgSetItemPositions other)
```

#### Parameters

`other` [CMsgSetItemPositions](Divine.Protobufs.Dota2.CMsgSetItemPositions.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSetItemPositions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

