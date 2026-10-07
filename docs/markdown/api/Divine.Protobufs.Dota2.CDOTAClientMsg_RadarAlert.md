# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert"></a> Class CDOTAClientMsg\_RadarAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RadarAlert : IMessage<CDOTAClientMsg_RadarAlert>, IEquatable<CDOTAClientMsg_RadarAlert>, IDeepCloneable<CDOTAClientMsg_RadarAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_RadarAlert\>, 
[IEquatable<CDOTAClientMsg\_RadarAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RadarAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RadarAlert\>\(CDOTAClientMsg\_RadarAlert, params CDOTAClientMsg\_RadarAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert__ctor"></a> CDOTAClientMsg\_RadarAlert\(\)

```csharp
public CDOTAClientMsg_RadarAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_"></a> CDOTAClientMsg\_RadarAlert\(CDOTAClientMsg\_RadarAlert\)

```csharp
public CDOTAClientMsg_RadarAlert(CDOTAClientMsg_RadarAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_NegativeFieldNumber"></a> NegativeFieldNumber

```csharp
public const int NegativeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_HasNegative"></a> HasNegative

```csharp
public bool HasNegative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Negative"></a> Negative

```csharp
public bool Negative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RadarAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_ClearNegative"></a> ClearNegative\(\)

```csharp
public void ClearNegative()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RadarAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_"></a> Equals\(CDOTAClientMsg\_RadarAlert\)

```csharp
public bool Equals(CDOTAClientMsg_RadarAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_"></a> MergeFrom\(CDOTAClientMsg\_RadarAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_RadarAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_RadarAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_RadarAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RadarAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

