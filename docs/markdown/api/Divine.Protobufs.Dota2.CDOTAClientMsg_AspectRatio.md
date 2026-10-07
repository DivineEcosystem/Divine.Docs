# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio"></a> Class CDOTAClientMsg\_AspectRatio

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AspectRatio : IMessage<CDOTAClientMsg_AspectRatio>, IEquatable<CDOTAClientMsg_AspectRatio>, IDeepCloneable<CDOTAClientMsg_AspectRatio>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)

#### Implements

IMessage<CDOTAClientMsg\_AspectRatio\>, 
[IEquatable<CDOTAClientMsg\_AspectRatio\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AspectRatio\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AspectRatio\>\(CDOTAClientMsg\_AspectRatio, params CDOTAClientMsg\_AspectRatio\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio__ctor"></a> CDOTAClientMsg\_AspectRatio\(\)

```csharp
public CDOTAClientMsg_AspectRatio()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_"></a> CDOTAClientMsg\_AspectRatio\(CDOTAClientMsg\_AspectRatio\)

```csharp
public CDOTAClientMsg_AspectRatio(CDOTAClientMsg_AspectRatio other)
```

#### Parameters

`other` [CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_RatioFieldNumber"></a> RatioFieldNumber

```csharp
public const int RatioFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_HasRatio"></a> HasRatio

```csharp
public bool HasRatio { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AspectRatio> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Ratio"></a> Ratio

```csharp
public float Ratio { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_ClearRatio"></a> ClearRatio\(\)

```csharp
public void ClearRatio()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AspectRatio Clone()
```

#### Returns

 [CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_"></a> Equals\(CDOTAClientMsg\_AspectRatio\)

```csharp
public bool Equals(CDOTAClientMsg_AspectRatio other)
```

#### Parameters

`other` [CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_"></a> MergeFrom\(CDOTAClientMsg\_AspectRatio\)

```csharp
public void MergeFrom(CDOTAClientMsg_AspectRatio other)
```

#### Parameters

`other` [CDOTAClientMsg\_AspectRatio](Divine.Protobufs.Dota2.CDOTAClientMsg\_AspectRatio.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AspectRatio_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

