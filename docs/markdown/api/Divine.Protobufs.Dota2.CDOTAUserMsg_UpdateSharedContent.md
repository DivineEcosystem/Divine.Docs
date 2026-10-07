# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent"></a> Class CDOTAUserMsg\_UpdateSharedContent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_UpdateSharedContent : IMessage<CDOTAUserMsg_UpdateSharedContent>, IEquatable<CDOTAUserMsg_UpdateSharedContent>, IDeepCloneable<CDOTAUserMsg_UpdateSharedContent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)

#### Implements

IMessage<CDOTAUserMsg\_UpdateSharedContent\>, 
[IEquatable<CDOTAUserMsg\_UpdateSharedContent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_UpdateSharedContent\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_UpdateSharedContent\>\(CDOTAUserMsg\_UpdateSharedContent, params CDOTAUserMsg\_UpdateSharedContent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent__ctor"></a> CDOTAUserMsg\_UpdateSharedContent\(\)

```csharp
public CDOTAUserMsg_UpdateSharedContent()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_"></a> CDOTAUserMsg\_UpdateSharedContent\(CDOTAUserMsg\_UpdateSharedContent\)

```csharp
public CDOTAUserMsg_UpdateSharedContent(CDOTAUserMsg_UpdateSharedContent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_SlotTypeFieldNumber"></a> SlotTypeFieldNumber

```csharp
public const int SlotTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_HasSlotType"></a> HasSlotType

```csharp
public bool HasSlotType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_UpdateSharedContent> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_SlotType"></a> SlotType

```csharp
public int SlotType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_ClearSlotType"></a> ClearSlotType\(\)

```csharp
public void ClearSlotType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_UpdateSharedContent Clone()
```

#### Returns

 [CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_"></a> Equals\(CDOTAUserMsg\_UpdateSharedContent\)

```csharp
public bool Equals(CDOTAUserMsg_UpdateSharedContent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_"></a> MergeFrom\(CDOTAUserMsg\_UpdateSharedContent\)

```csharp
public void MergeFrom(CDOTAUserMsg_UpdateSharedContent other)
```

#### Parameters

`other` [CDOTAUserMsg\_UpdateSharedContent](Divine.Protobufs.Dota2.CDOTAUserMsg\_UpdateSharedContent.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_UpdateSharedContent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

