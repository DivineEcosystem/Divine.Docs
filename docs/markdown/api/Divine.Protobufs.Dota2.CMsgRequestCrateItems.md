# <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems"></a> Class CMsgRequestCrateItems

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRequestCrateItems : IMessage<CMsgRequestCrateItems>, IEquatable<CMsgRequestCrateItems>, IDeepCloneable<CMsgRequestCrateItems>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)

#### Implements

IMessage<CMsgRequestCrateItems\>, 
[IEquatable<CMsgRequestCrateItems\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRequestCrateItems\>, 
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
[EnumerableExtensions.In<CMsgRequestCrateItems\>\(CMsgRequestCrateItems, params CMsgRequestCrateItems\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems__ctor"></a> CMsgRequestCrateItems\(\)

```csharp
public CMsgRequestCrateItems()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems__ctor_Divine_Protobufs_Dota2_CMsgRequestCrateItems_"></a> CMsgRequestCrateItems\(CMsgRequestCrateItems\)

```csharp
public CMsgRequestCrateItems(CMsgRequestCrateItems other)
```

#### Parameters

`other` [CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_CrateItemDefFieldNumber"></a> CrateItemDefFieldNumber

```csharp
public const int CrateItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_CrateItemDef"></a> CrateItemDef

```csharp
public uint CrateItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_HasCrateItemDef"></a> HasCrateItemDef

```csharp
public bool HasCrateItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRequestCrateItems> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_ClearCrateItemDef"></a> ClearCrateItemDef\(\)

```csharp
public void ClearCrateItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_Clone"></a> Clone\(\)

```csharp
public CMsgRequestCrateItems Clone()
```

#### Returns

 [CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_Equals_Divine_Protobufs_Dota2_CMsgRequestCrateItems_"></a> Equals\(CMsgRequestCrateItems\)

```csharp
public bool Equals(CMsgRequestCrateItems other)
```

#### Parameters

`other` [CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_MergeFrom_Divine_Protobufs_Dota2_CMsgRequestCrateItems_"></a> MergeFrom\(CMsgRequestCrateItems\)

```csharp
public void MergeFrom(CMsgRequestCrateItems other)
```

#### Parameters

`other` [CMsgRequestCrateItems](Divine.Protobufs.Dota2.CMsgRequestCrateItems.md)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRequestCrateItems_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

