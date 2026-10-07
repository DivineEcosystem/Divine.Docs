# <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen"></a> Class CSVCMsg\_SplitScreen

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_SplitScreen : IMessage<CSVCMsg_SplitScreen>, IEquatable<CSVCMsg_SplitScreen>, IDeepCloneable<CSVCMsg_SplitScreen>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)

#### Implements

IMessage<CSVCMsg\_SplitScreen\>, 
[IEquatable<CSVCMsg\_SplitScreen\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_SplitScreen\>, 
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
[EnumerableExtensions.In<CSVCMsg\_SplitScreen\>\(CSVCMsg\_SplitScreen, params CSVCMsg\_SplitScreen\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen__ctor"></a> CSVCMsg\_SplitScreen\(\)

```csharp
public CSVCMsg_SplitScreen()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen__ctor_Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_"></a> CSVCMsg\_SplitScreen\(CSVCMsg\_SplitScreen\)

```csharp
public CSVCMsg_SplitScreen(CSVCMsg_SplitScreen other)
```

#### Parameters

`other` [CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_PlayerIndexFieldNumber"></a> PlayerIndexFieldNumber

```csharp
public const int PlayerIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_SlotFieldNumber"></a> SlotFieldNumber

```csharp
public const int SlotFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_HasPlayerIndex"></a> HasPlayerIndex

```csharp
public bool HasPlayerIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_HasSlot"></a> HasSlot

```csharp
public bool HasSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_SplitScreen> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_PlayerIndex"></a> PlayerIndex

```csharp
public int PlayerIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Slot"></a> Slot

```csharp
public int Slot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Type"></a> Type

```csharp
public ESplitScreenMessageType Type { get; set; }
```

#### Property Value

 [ESplitScreenMessageType](Divine.Protobufs.Dota2.ESplitScreenMessageType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_ClearPlayerIndex"></a> ClearPlayerIndex\(\)

```csharp
public void ClearPlayerIndex()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_ClearSlot"></a> ClearSlot\(\)

```csharp
public void ClearSlot()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_SplitScreen Clone()
```

#### Returns

 [CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_Equals_Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_"></a> Equals\(CSVCMsg\_SplitScreen\)

```csharp
public bool Equals(CSVCMsg_SplitScreen other)
```

#### Parameters

`other` [CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_"></a> MergeFrom\(CSVCMsg\_SplitScreen\)

```csharp
public void MergeFrom(CSVCMsg_SplitScreen other)
```

#### Parameters

`other` [CSVCMsg\_SplitScreen](Divine.Protobufs.Dota2.CSVCMsg\_SplitScreen.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_SplitScreen_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

