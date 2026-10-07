# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine"></a> Class CDOTAUserMsg\_MapLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MapLine : IMessage<CDOTAUserMsg_MapLine>, IEquatable<CDOTAUserMsg_MapLine>, IDeepCloneable<CDOTAUserMsg_MapLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)

#### Implements

IMessage<CDOTAUserMsg\_MapLine\>, 
[IEquatable<CDOTAUserMsg\_MapLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MapLine\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MapLine\>\(CDOTAUserMsg\_MapLine, params CDOTAUserMsg\_MapLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine__ctor"></a> CDOTAUserMsg\_MapLine\(\)

```csharp
public CDOTAUserMsg_MapLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_"></a> CDOTAUserMsg\_MapLine\(CDOTAUserMsg\_MapLine\)

```csharp
public CDOTAUserMsg_MapLine(CDOTAUserMsg_MapLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_MaplineFieldNumber"></a> MaplineFieldNumber

```csharp
public const int MaplineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Mapline"></a> Mapline

```csharp
public CDOTAMsg_MapLine Mapline { get; set; }
```

#### Property Value

 [CDOTAMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MapLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MapLine Clone()
```

#### Returns

 [CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_"></a> Equals\(CDOTAUserMsg\_MapLine\)

```csharp
public bool Equals(CDOTAUserMsg_MapLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_"></a> MergeFrom\(CDOTAUserMsg\_MapLine\)

```csharp
public void MergeFrom(CDOTAUserMsg_MapLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_MapLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_MapLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MapLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

