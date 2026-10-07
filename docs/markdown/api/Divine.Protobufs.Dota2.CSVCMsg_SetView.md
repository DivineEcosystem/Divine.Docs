# <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView"></a> Class CSVCMsg\_SetView

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_SetView : IMessage<CSVCMsg_SetView>, IEquatable<CSVCMsg_SetView>, IDeepCloneable<CSVCMsg_SetView>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)

#### Implements

IMessage<CSVCMsg\_SetView\>, 
[IEquatable<CSVCMsg\_SetView\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_SetView\>, 
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
[EnumerableExtensions.In<CSVCMsg\_SetView\>\(CSVCMsg\_SetView, params CSVCMsg\_SetView\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView__ctor"></a> CSVCMsg\_SetView\(\)

```csharp
public CSVCMsg_SetView()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView__ctor_Divine_Protobufs_Dota2_CSVCMsg_SetView_"></a> CSVCMsg\_SetView\(CSVCMsg\_SetView\)

```csharp
public CSVCMsg_SetView(CSVCMsg_SetView other)
```

#### Parameters

`other` [CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_SetView> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_SetView Clone()
```

#### Returns

 [CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_Equals_Divine_Protobufs_Dota2_CSVCMsg_SetView_"></a> Equals\(CSVCMsg\_SetView\)

```csharp
public bool Equals(CSVCMsg_SetView other)
```

#### Parameters

`other` [CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_SetView_"></a> MergeFrom\(CSVCMsg\_SetView\)

```csharp
public void MergeFrom(CSVCMsg_SetView other)
```

#### Parameters

`other` [CSVCMsg\_SetView](Divine.Protobufs.Dota2.CSVCMsg\_SetView.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SetView_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

