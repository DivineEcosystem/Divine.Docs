# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine"></a> Class CDOTAClientMsg\_MapLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_MapLine : IMessage<CDOTAClientMsg_MapLine>, IEquatable<CDOTAClientMsg_MapLine>, IDeepCloneable<CDOTAClientMsg_MapLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)

#### Implements

IMessage<CDOTAClientMsg\_MapLine\>, 
[IEquatable<CDOTAClientMsg\_MapLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_MapLine\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_MapLine\>\(CDOTAClientMsg\_MapLine, params CDOTAClientMsg\_MapLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine__ctor"></a> CDOTAClientMsg\_MapLine\(\)

```csharp
public CDOTAClientMsg_MapLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_"></a> CDOTAClientMsg\_MapLine\(CDOTAClientMsg\_MapLine\)

```csharp
public CDOTAClientMsg_MapLine(CDOTAClientMsg_MapLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_MaplineFieldNumber"></a> MaplineFieldNumber

```csharp
public const int MaplineFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Mapline"></a> Mapline

```csharp
public CDOTAMsg_MapLine Mapline { get; set; }
```

#### Property Value

 [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_MapLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_MapLine Clone()
```

#### Returns

 [CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_"></a> Equals\(CDOTAClientMsg\_MapLine\)

```csharp
public bool Equals(CDOTAClientMsg_MapLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_"></a> MergeFrom\(CDOTAClientMsg\_MapLine\)

```csharp
public void MergeFrom(CDOTAClientMsg_MapLine other)
```

#### Parameters

`other` [CDOTAClientMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAClientMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MapLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

