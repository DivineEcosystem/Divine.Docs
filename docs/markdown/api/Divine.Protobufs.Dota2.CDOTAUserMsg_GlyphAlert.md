# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert"></a> Class CDOTAUserMsg\_GlyphAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GlyphAlert : IMessage<CDOTAUserMsg_GlyphAlert>, IEquatable<CDOTAUserMsg_GlyphAlert>, IDeepCloneable<CDOTAUserMsg_GlyphAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_GlyphAlert\>, 
[IEquatable<CDOTAUserMsg\_GlyphAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GlyphAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GlyphAlert\>\(CDOTAUserMsg\_GlyphAlert, params CDOTAUserMsg\_GlyphAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert__ctor"></a> CDOTAUserMsg\_GlyphAlert\(\)

```csharp
public CDOTAUserMsg_GlyphAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_"></a> CDOTAUserMsg\_GlyphAlert\(CDOTAUserMsg\_GlyphAlert\)

```csharp
public CDOTAUserMsg_GlyphAlert(CDOTAUserMsg_GlyphAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_NegativeFieldNumber"></a> NegativeFieldNumber

```csharp
public const int NegativeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_HasNegative"></a> HasNegative

```csharp
public bool HasNegative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Negative"></a> Negative

```csharp
public bool Negative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GlyphAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_ClearNegative"></a> ClearNegative\(\)

```csharp
public void ClearNegative()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GlyphAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_"></a> Equals\(CDOTAUserMsg\_GlyphAlert\)

```csharp
public bool Equals(CDOTAUserMsg_GlyphAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_"></a> MergeFrom\(CDOTAUserMsg\_GlyphAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_GlyphAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_GlyphAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_GlyphAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GlyphAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

