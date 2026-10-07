# <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine"></a> Class CDOTAMsg\_MapLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_MapLine : IMessage<CDOTAMsg_MapLine>, IEquatable<CDOTAMsg_MapLine>, IDeepCloneable<CDOTAMsg_MapLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

#### Implements

IMessage<CDOTAMsg\_MapLine\>, 
[IEquatable<CDOTAMsg\_MapLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_MapLine\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_MapLine\>\(CDOTAMsg\_MapLine, params CDOTAMsg\_MapLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine__ctor"></a> CDOTAMsg\_MapLine\(\)

```csharp
public CDOTAMsg_MapLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine__ctor_Divine_Protobufs_Dota2_CDOTAMsg_MapLine_"></a> CDOTAMsg\_MapLine\(CDOTAMsg\_MapLine\)

```csharp
public CDOTAMsg_MapLine(CDOTAMsg_MapLine other)
```

#### Parameters

`other` [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_InitialFieldNumber"></a> InitialFieldNumber

```csharp
public const int InitialFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_HasInitial"></a> HasInitial

```csharp
public bool HasInitial { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Initial"></a> Initial

```csharp
public bool Initial { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_MapLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_ClearInitial"></a> ClearInitial\(\)

```csharp
public void ClearInitial()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_MapLine Clone()
```

#### Returns

 [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_Equals_Divine_Protobufs_Dota2_CDOTAMsg_MapLine_"></a> Equals\(CDOTAMsg\_MapLine\)

```csharp
public bool Equals(CDOTAMsg_MapLine other)
```

#### Parameters

`other` [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_MapLine_"></a> MergeFrom\(CDOTAMsg\_MapLine\)

```csharp
public void MergeFrom(CDOTAMsg_MapLine other)
```

#### Parameters

`other` [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_MapLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

