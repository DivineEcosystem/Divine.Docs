# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine"></a> Class CDOTAClientMsg\_WorldLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_WorldLine : IMessage<CDOTAClientMsg_WorldLine>, IEquatable<CDOTAClientMsg_WorldLine>, IDeepCloneable<CDOTAClientMsg_WorldLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)

#### Implements

IMessage<CDOTAClientMsg\_WorldLine\>, 
[IEquatable<CDOTAClientMsg\_WorldLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_WorldLine\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_WorldLine\>\(CDOTAClientMsg\_WorldLine, params CDOTAClientMsg\_WorldLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine__ctor"></a> CDOTAClientMsg\_WorldLine\(\)

```csharp
public CDOTAClientMsg_WorldLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_"></a> CDOTAClientMsg\_WorldLine\(CDOTAClientMsg\_WorldLine\)

```csharp
public CDOTAClientMsg_WorldLine(CDOTAClientMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_WorldlineFieldNumber"></a> WorldlineFieldNumber

```csharp
public const int WorldlineFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_WorldLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Worldline"></a> Worldline

```csharp
public CDOTAMsg_WorldLine Worldline { get; set; }
```

#### Property Value

 [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_WorldLine Clone()
```

#### Returns

 [CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_"></a> Equals\(CDOTAClientMsg\_WorldLine\)

```csharp
public bool Equals(CDOTAClientMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_"></a> MergeFrom\(CDOTAClientMsg\_WorldLine\)

```csharp
public void MergeFrom(CDOTAClientMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_WorldLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

