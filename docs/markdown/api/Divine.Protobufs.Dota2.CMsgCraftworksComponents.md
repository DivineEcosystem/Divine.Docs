# <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents"></a> Class CMsgCraftworksComponents

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCraftworksComponents : IMessage<CMsgCraftworksComponents>, IEquatable<CMsgCraftworksComponents>, IDeepCloneable<CMsgCraftworksComponents>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

#### Implements

IMessage<CMsgCraftworksComponents\>, 
[IEquatable<CMsgCraftworksComponents\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCraftworksComponents\>, 
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
[EnumerableExtensions.In<CMsgCraftworksComponents\>\(CMsgCraftworksComponents, params CMsgCraftworksComponents\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents__ctor"></a> CMsgCraftworksComponents\(\)

```csharp
public CMsgCraftworksComponents()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents__ctor_Divine_Protobufs_Dota2_CMsgCraftworksComponents_"></a> CMsgCraftworksComponents\(CMsgCraftworksComponents\)

```csharp
public CMsgCraftworksComponents(CMsgCraftworksComponents other)
```

#### Parameters

`other` [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_ComponentQuantitiesFieldNumber"></a> ComponentQuantitiesFieldNumber

```csharp
public const int ComponentQuantitiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_ComponentQuantities"></a> ComponentQuantities

```csharp
public MapField<uint, uint> ComponentQuantities { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCraftworksComponents> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_Clone"></a> Clone\(\)

```csharp
public CMsgCraftworksComponents Clone()
```

#### Returns

 [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_Equals_Divine_Protobufs_Dota2_CMsgCraftworksComponents_"></a> Equals\(CMsgCraftworksComponents\)

```csharp
public bool Equals(CMsgCraftworksComponents other)
```

#### Parameters

`other` [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_MergeFrom_Divine_Protobufs_Dota2_CMsgCraftworksComponents_"></a> MergeFrom\(CMsgCraftworksComponents\)

```csharp
public void MergeFrom(CMsgCraftworksComponents other)
```

#### Parameters

`other` [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksComponents_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

