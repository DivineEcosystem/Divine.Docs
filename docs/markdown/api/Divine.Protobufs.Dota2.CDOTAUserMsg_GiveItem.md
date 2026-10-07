# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem"></a> Class CDOTAUserMsg\_GiveItem

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GiveItem : IMessage<CDOTAUserMsg_GiveItem>, IEquatable<CDOTAUserMsg_GiveItem>, IDeepCloneable<CDOTAUserMsg_GiveItem>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)

#### Implements

IMessage<CDOTAUserMsg\_GiveItem\>, 
[IEquatable<CDOTAUserMsg\_GiveItem\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GiveItem\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GiveItem\>\(CDOTAUserMsg\_GiveItem, params CDOTAUserMsg\_GiveItem\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem__ctor"></a> CDOTAUserMsg\_GiveItem\(\)

```csharp
public CDOTAUserMsg_GiveItem()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_"></a> CDOTAUserMsg\_GiveItem\(CDOTAUserMsg\_GiveItem\)

```csharp
public CDOTAUserMsg_GiveItem(CDOTAUserMsg_GiveItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_GiverEntIndexFieldNumber"></a> GiverEntIndexFieldNumber

```csharp
public const int GiverEntIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_GiveStatusFieldNumber"></a> GiveStatusFieldNumber

```csharp
public const int GiveStatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ItemEntIndexFieldNumber"></a> ItemEntIndexFieldNumber

```csharp
public const int ItemEntIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ReceiverEntIndexFieldNumber"></a> ReceiverEntIndexFieldNumber

```csharp
public const int ReceiverEntIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_GiverEntIndex"></a> GiverEntIndex

```csharp
public uint GiverEntIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_GiveStatus"></a> GiveStatus

```csharp
public CDOTAUserMsg_GiveItem.Types.EGiveStatus GiveStatus { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.Types.md).[EGiveStatus](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.Types.EGiveStatus.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_HasGiverEntIndex"></a> HasGiverEntIndex

```csharp
public bool HasGiverEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_HasGiveStatus"></a> HasGiveStatus

```csharp
public bool HasGiveStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_HasItemEntIndex"></a> HasItemEntIndex

```csharp
public bool HasItemEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_HasReceiverEntIndex"></a> HasReceiverEntIndex

```csharp
public bool HasReceiverEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ItemEntIndex"></a> ItemEntIndex

```csharp
public uint ItemEntIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GiveItem> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ReceiverEntIndex"></a> ReceiverEntIndex

```csharp
public uint ReceiverEntIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ClearGiverEntIndex"></a> ClearGiverEntIndex\(\)

```csharp
public void ClearGiverEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ClearGiveStatus"></a> ClearGiveStatus\(\)

```csharp
public void ClearGiveStatus()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ClearItemEntIndex"></a> ClearItemEntIndex\(\)

```csharp
public void ClearItemEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ClearReceiverEntIndex"></a> ClearReceiverEntIndex\(\)

```csharp
public void ClearReceiverEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GiveItem Clone()
```

#### Returns

 [CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_"></a> Equals\(CDOTAUserMsg\_GiveItem\)

```csharp
public bool Equals(CDOTAUserMsg_GiveItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_"></a> MergeFrom\(CDOTAUserMsg\_GiveItem\)

```csharp
public void MergeFrom(CDOTAUserMsg_GiveItem other)
```

#### Parameters

`other` [CDOTAUserMsg\_GiveItem](Divine.Protobufs.Dota2.CDOTAUserMsg\_GiveItem.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GiveItem_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

