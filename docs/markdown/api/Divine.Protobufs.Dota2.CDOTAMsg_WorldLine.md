# <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine"></a> Class CDOTAMsg\_WorldLine

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAMsg_WorldLine : IMessage<CDOTAMsg_WorldLine>, IEquatable<CDOTAMsg_WorldLine>, IDeepCloneable<CDOTAMsg_WorldLine>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

#### Implements

IMessage<CDOTAMsg\_WorldLine\>, 
[IEquatable<CDOTAMsg\_WorldLine\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAMsg\_WorldLine\>, 
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
[EnumerableExtensions.In<CDOTAMsg\_WorldLine\>\(CDOTAMsg\_WorldLine, params CDOTAMsg\_WorldLine\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine__ctor"></a> CDOTAMsg\_WorldLine\(\)

```csharp
public CDOTAMsg_WorldLine()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine__ctor_Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_"></a> CDOTAMsg\_WorldLine\(CDOTAMsg\_WorldLine\)

```csharp
public CDOTAMsg_WorldLine(CDOTAMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_EndFieldNumber"></a> EndFieldNumber

```csharp
public const int EndFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_InitialFieldNumber"></a> InitialFieldNumber

```csharp
public const int InitialFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ZFieldNumber"></a> ZFieldNumber

```csharp
public const int ZFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_End"></a> End

```csharp
public bool End { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_HasEnd"></a> HasEnd

```csharp
public bool HasEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_HasInitial"></a> HasInitial

```csharp
public bool HasInitial { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_HasZ"></a> HasZ

```csharp
public bool HasZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Initial"></a> Initial

```csharp
public bool Initial { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAMsg_WorldLine> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_X"></a> X

```csharp
public int X { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Y"></a> Y

```csharp
public int Y { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Z"></a> Z

```csharp
public int Z { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ClearEnd"></a> ClearEnd\(\)

```csharp
public void ClearEnd()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ClearInitial"></a> ClearInitial\(\)

```csharp
public void ClearInitial()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ClearZ"></a> ClearZ\(\)

```csharp
public void ClearZ()
```

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Clone"></a> Clone\(\)

```csharp
public CDOTAMsg_WorldLine Clone()
```

#### Returns

 [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_Equals_Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_"></a> Equals\(CDOTAMsg\_WorldLine\)

```csharp
public bool Equals(CDOTAMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_MergeFrom_Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_"></a> MergeFrom\(CDOTAMsg\_WorldLine\)

```csharp
public void MergeFrom(CDOTAMsg_WorldLine other)
```

#### Parameters

`other` [CDOTAMsg\_WorldLine](Divine.Protobufs.Dota2.CDOTAMsg\_WorldLine.md)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAMsg_WorldLine_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

