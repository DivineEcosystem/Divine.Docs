# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError"></a> Class CDOTAUserMsg\_HudError

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HudError : IMessage<CDOTAUserMsg_HudError>, IEquatable<CDOTAUserMsg_HudError>, IDeepCloneable<CDOTAUserMsg_HudError>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)

#### Implements

IMessage<CDOTAUserMsg\_HudError\>, 
[IEquatable<CDOTAUserMsg\_HudError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HudError\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HudError\>\(CDOTAUserMsg\_HudError, params CDOTAUserMsg\_HudError\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError__ctor"></a> CDOTAUserMsg\_HudError\(\)

```csharp
public CDOTAUserMsg_HudError()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_"></a> CDOTAUserMsg\_HudError\(CDOTAUserMsg\_HudError\)

```csharp
public CDOTAUserMsg_HudError(CDOTAUserMsg_HudError other)
```

#### Parameters

`other` [CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_OrderIdFieldNumber"></a> OrderIdFieldNumber

```csharp
public const int OrderIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_SequenceNumberFieldNumber"></a> SequenceNumberFieldNumber

```csharp
public const int SequenceNumberFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_HasOrderId"></a> HasOrderId

```csharp
public bool HasOrderId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_HasSequenceNumber"></a> HasSequenceNumber

```csharp
public bool HasSequenceNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_OrderId"></a> OrderId

```csharp
public int OrderId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HudError> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_SequenceNumber"></a> SequenceNumber

```csharp
public int SequenceNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_ClearOrderId"></a> ClearOrderId\(\)

```csharp
public void ClearOrderId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_ClearSequenceNumber"></a> ClearSequenceNumber\(\)

```csharp
public void ClearSequenceNumber()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HudError Clone()
```

#### Returns

 [CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_"></a> Equals\(CDOTAUserMsg\_HudError\)

```csharp
public bool Equals(CDOTAUserMsg_HudError other)
```

#### Parameters

`other` [CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_"></a> MergeFrom\(CDOTAUserMsg\_HudError\)

```csharp
public void MergeFrom(CDOTAUserMsg_HudError other)
```

#### Parameters

`other` [CDOTAUserMsg\_HudError](Divine.Protobufs.Dota2.CDOTAUserMsg\_HudError.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HudError_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

