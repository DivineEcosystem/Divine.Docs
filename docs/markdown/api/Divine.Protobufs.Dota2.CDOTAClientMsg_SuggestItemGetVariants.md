# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants"></a> Class CDOTAClientMsg\_SuggestItemGetVariants

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SuggestItemGetVariants : IMessage<CDOTAClientMsg_SuggestItemGetVariants>, IEquatable<CDOTAClientMsg_SuggestItemGetVariants>, IDeepCloneable<CDOTAClientMsg_SuggestItemGetVariants>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)

#### Implements

IMessage<CDOTAClientMsg\_SuggestItemGetVariants\>, 
[IEquatable<CDOTAClientMsg\_SuggestItemGetVariants\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SuggestItemGetVariants\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SuggestItemGetVariants\>\(CDOTAClientMsg\_SuggestItemGetVariants, params CDOTAClientMsg\_SuggestItemGetVariants\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants__ctor"></a> CDOTAClientMsg\_SuggestItemGetVariants\(\)

```csharp
public CDOTAClientMsg_SuggestItemGetVariants()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_"></a> CDOTAClientMsg\_SuggestItemGetVariants\(CDOTAClientMsg\_SuggestItemGetVariants\)

```csharp
public CDOTAClientMsg_SuggestItemGetVariants(CDOTAClientMsg_SuggestItemGetVariants other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_IsOutOfItemsFieldNumber"></a> IsOutOfItemsFieldNumber

```csharp
public const int IsOutOfItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_HasIsOutOfItems"></a> HasIsOutOfItems

```csharp
public bool HasIsOutOfItems { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_IsOutOfItems"></a> IsOutOfItems

```csharp
public bool IsOutOfItems { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SuggestItemGetVariants> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_ClearIsOutOfItems"></a> ClearIsOutOfItems\(\)

```csharp
public void ClearIsOutOfItems()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SuggestItemGetVariants Clone()
```

#### Returns

 [CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_"></a> Equals\(CDOTAClientMsg\_SuggestItemGetVariants\)

```csharp
public bool Equals(CDOTAClientMsg_SuggestItemGetVariants other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_"></a> MergeFrom\(CDOTAClientMsg\_SuggestItemGetVariants\)

```csharp
public void MergeFrom(CDOTAClientMsg_SuggestItemGetVariants other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemGetVariants](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemGetVariants.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemGetVariants_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

