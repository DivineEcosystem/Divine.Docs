# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone"></a> Class CDOTAClientMsg\_GiftEveryone

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_GiftEveryone : IMessage<CDOTAClientMsg_GiftEveryone>, IEquatable<CDOTAClientMsg_GiftEveryone>, IDeepCloneable<CDOTAClientMsg_GiftEveryone>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)

#### Implements

IMessage<CDOTAClientMsg\_GiftEveryone\>, 
[IEquatable<CDOTAClientMsg\_GiftEveryone\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_GiftEveryone\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_GiftEveryone\>\(CDOTAClientMsg\_GiftEveryone, params CDOTAClientMsg\_GiftEveryone\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone__ctor"></a> CDOTAClientMsg\_GiftEveryone\(\)

```csharp
public CDOTAClientMsg_GiftEveryone()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_"></a> CDOTAClientMsg\_GiftEveryone\(CDOTAClientMsg\_GiftEveryone\)

```csharp
public CDOTAClientMsg_GiftEveryone(CDOTAClientMsg_GiftEveryone other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_ItemDefIndexFieldNumber"></a> ItemDefIndexFieldNumber

```csharp
public const int ItemDefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_HasItemDefIndex"></a> HasItemDefIndex

```csharp
public bool HasItemDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_ItemDefIndex"></a> ItemDefIndex

```csharp
public uint ItemDefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_GiftEveryone> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_ClearItemDefIndex"></a> ClearItemDefIndex\(\)

```csharp
public void ClearItemDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_GiftEveryone Clone()
```

#### Returns

 [CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_"></a> Equals\(CDOTAClientMsg\_GiftEveryone\)

```csharp
public bool Equals(CDOTAClientMsg_GiftEveryone other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_"></a> MergeFrom\(CDOTAClientMsg\_GiftEveryone\)

```csharp
public void MergeFrom(CDOTAClientMsg_GiftEveryone other)
```

#### Parameters

`other` [CDOTAClientMsg\_GiftEveryone](Divine.Protobufs.Dota2.CDOTAClientMsg\_GiftEveryone.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GiftEveryone_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

