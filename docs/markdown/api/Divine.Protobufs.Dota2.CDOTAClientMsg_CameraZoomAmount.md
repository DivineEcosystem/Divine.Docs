# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount"></a> Class CDOTAClientMsg\_CameraZoomAmount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_CameraZoomAmount : IMessage<CDOTAClientMsg_CameraZoomAmount>, IEquatable<CDOTAClientMsg_CameraZoomAmount>, IDeepCloneable<CDOTAClientMsg_CameraZoomAmount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)

#### Implements

IMessage<CDOTAClientMsg\_CameraZoomAmount\>, 
[IEquatable<CDOTAClientMsg\_CameraZoomAmount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_CameraZoomAmount\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_CameraZoomAmount\>\(CDOTAClientMsg\_CameraZoomAmount, params CDOTAClientMsg\_CameraZoomAmount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount__ctor"></a> CDOTAClientMsg\_CameraZoomAmount\(\)

```csharp
public CDOTAClientMsg_CameraZoomAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_"></a> CDOTAClientMsg\_CameraZoomAmount\(CDOTAClientMsg\_CameraZoomAmount\)

```csharp
public CDOTAClientMsg_CameraZoomAmount(CDOTAClientMsg_CameraZoomAmount other)
```

#### Parameters

`other` [CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_ZoomAmountFieldNumber"></a> ZoomAmountFieldNumber

```csharp
public const int ZoomAmountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_HasZoomAmount"></a> HasZoomAmount

```csharp
public bool HasZoomAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_CameraZoomAmount> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_ZoomAmount"></a> ZoomAmount

```csharp
public float ZoomAmount { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_ClearZoomAmount"></a> ClearZoomAmount\(\)

```csharp
public void ClearZoomAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_CameraZoomAmount Clone()
```

#### Returns

 [CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_"></a> Equals\(CDOTAClientMsg\_CameraZoomAmount\)

```csharp
public bool Equals(CDOTAClientMsg_CameraZoomAmount other)
```

#### Parameters

`other` [CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_"></a> MergeFrom\(CDOTAClientMsg\_CameraZoomAmount\)

```csharp
public void MergeFrom(CDOTAClientMsg_CameraZoomAmount other)
```

#### Parameters

`other` [CDOTAClientMsg\_CameraZoomAmount](Divine.Protobufs.Dota2.CDOTAClientMsg\_CameraZoomAmount.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_CameraZoomAmount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

