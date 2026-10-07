# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine"></a> Class CDOTAUserMsg\_WorldLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_WorldLine : IMessage<CDOTAUserMsg_WorldLine>, IEquatable<CDOTAUserMsg_WorldLine>, IDeepCloneable<CDOTAUserMsg_WorldLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)

#### Implements

IMessage<CDOTAUserMsg\_WorldLine\>, 
[IEquatable<CDOTAUserMsg\_WorldLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_WorldLine\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_WorldLine\>\(CDOTAUserMsg\_WorldLine, params CDOTAUserMsg\_WorldLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine__ctor"></a> CDOTAUserMsg\_WorldLine\(\)

```csharp
public CDOTAUserMsg_WorldLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_"></a> CDOTAUserMsg\_WorldLine\(CDOTAUserMsg\_WorldLine\)

```csharp
public CDOTAUserMsg_WorldLine(CDOTAUserMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_WorldlineFieldNumber"></a> WorldlineFieldNumber

```csharp
public const int WorldlineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_WorldLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Worldline"></a> Worldline

```csharp
public CDOTAMsg_WorldLine Worldline { get; set; }
```

#### Property Value

 [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_WorldLine Clone()
```

#### Returns

 [CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_"></a> Equals\(CDOTAUserMsg\_WorldLine\)

```csharp
public bool Equals(CDOTAUserMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_"></a> MergeFrom\(CDOTAUserMsg\_WorldLine\)

```csharp
public void MergeFrom(CDOTAUserMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAUserMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAUserMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WorldLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

