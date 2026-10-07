# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference"></a> Class CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference : IMessage<CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference>, IEquatable<CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference>, IDeepCloneable<CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)

#### Implements

IMessage<CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference\>, 
[IEquatable<CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference\>\(CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference, params CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference__ctor"></a> ItemPreference\(\)

```csharp
public ItemPreference()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_"></a> ItemPreference\(ItemPreference\)

```csharp
public ItemPreference(CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_PreferenceFieldNumber"></a> PreferenceFieldNumber

```csharp
public const int PreferenceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_HasPreference"></a> HasPreference

```csharp
public bool HasPreference { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_ItemId"></a> ItemId

```csharp
public int ItemId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Preference"></a> Preference

```csharp
public EItemSuggestPreference Preference { get; set; }
```

#### Property Value

 [EItemSuggestPreference](Divine.Protobufs.Dota2.EItemSuggestPreference.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_ClearPreference"></a> ClearPreference\(\)

```csharp
public void ClearPreference()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference Clone()
```

#### Returns

 [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_"></a> Equals\(ItemPreference\)

```csharp
public bool Equals(CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_"></a> MergeFrom\(ItemPreference\)

```csharp
public void MergeFrom(CDOTAClientMsg_SuggestItemPreference.Types.ItemPreference other)
```

#### Parameters

`other` [CDOTAClientMsg\_SuggestItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.md).[Types](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.md).[ItemPreference](Divine.Protobufs.Dota2.CDOTAClientMsg\_SuggestItemPreference.Types.ItemPreference.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SuggestItemPreference_Types_ItemPreference_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

