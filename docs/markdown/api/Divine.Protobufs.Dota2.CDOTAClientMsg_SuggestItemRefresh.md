# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh"></a> Class CDOTAClientMsg\_SuggestItemRefresh

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SuggestItemRefresh : IMessage<CDOTAClientMsg_SuggestItemRefresh>, IEquatable<CDOTAClientMsg_SuggestItemRefresh>, IDeepCloneable<CDOTAClientMsg_SuggestItemRefresh>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)

#### Implements

IMessage<CDOTAClientMsg\_SuggestItemRefresh\>, 
[IEquatable<CDOTAClientMsg\_SuggestItemRefresh\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SuggestItemRefresh\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SuggestItemRefresh\>\(CDOTAClientMsg\_SuggestItemRefresh, params CDOTAClientMsg\_SuggestItemRefresh\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh__ctor"></a> CDOTAClientMsg\_SuggestItemRefresh\(\)

```csharp
public CDOTAClientMsg_SuggestItemRefresh()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_"></a> CDOTAClientMsg\_SuggestItemRefresh\(CDOTAClientMsg\_SuggestItemRefresh\)

```csharp
public CDOTAClientMsg_SuggestItemRefresh(CDOTAClientMsg_SuggestItemRefresh other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_IsOutOfItemsFieldNumber"></a> IsOutOfItemsFieldNumber

```csharp
public const int IsOutOfItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_HasIsOutOfItems"></a> HasIsOutOfItems

```csharp
public bool HasIsOutOfItems { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_IsOutOfItems"></a> IsOutOfItems

```csharp
public bool IsOutOfItems { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SuggestItemRefresh> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_ClearIsOutOfItems"></a> ClearIsOutOfItems\(\)

```csharp
public void ClearIsOutOfItems()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SuggestItemRefresh Clone()
```

#### Returns

 [CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_"></a> Equals\(CDOTAClientMsg\_SuggestItemRefresh\)

```csharp
public bool Equals(CDOTAClientMsg_SuggestItemRefresh other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_"></a> MergeFrom\(CDOTAClientMsg\_SuggestItemRefresh\)

```csharp
public void MergeFrom(CDOTAClientMsg_SuggestItemRefresh other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemRefresh](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemRefresh.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemRefresh_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

