# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike"></a> Class CDOTAClientMsg\_HeroStatueLike

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_HeroStatueLike : IMessage<CDOTAClientMsg_HeroStatueLike>, IEquatable<CDOTAClientMsg_HeroStatueLike>, IDeepCloneable<CDOTAClientMsg_HeroStatueLike>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)

#### Implements

IMessage<CDOTAClientMsg\_HeroStatueLike\>, 
[IEquatable<CDOTAClientMsg\_HeroStatueLike\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_HeroStatueLike\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_HeroStatueLike\>\(CDOTAClientMsg\_HeroStatueLike, params CDOTAClientMsg\_HeroStatueLike\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike__ctor"></a> CDOTAClientMsg\_HeroStatueLike\(\)

```csharp
public CDOTAClientMsg_HeroStatueLike()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_"></a> CDOTAClientMsg\_HeroStatueLike\(CDOTAClientMsg\_HeroStatueLike\)

```csharp
public CDOTAClientMsg_HeroStatueLike(CDOTAClientMsg_HeroStatueLike other)
```

#### Parameters

`other` [CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_OwnerPlayerIdFieldNumber"></a> OwnerPlayerIdFieldNumber

```csharp
public const int OwnerPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_HasOwnerPlayerId"></a> HasOwnerPlayerId

```csharp
public bool HasOwnerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_OwnerPlayerId"></a> OwnerPlayerId

```csharp
public int OwnerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_HeroStatueLike> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_ClearOwnerPlayerId"></a> ClearOwnerPlayerId\(\)

```csharp
public void ClearOwnerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_HeroStatueLike Clone()
```

#### Returns

 [CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_"></a> Equals\(CDOTAClientMsg\_HeroStatueLike\)

```csharp
public bool Equals(CDOTAClientMsg_HeroStatueLike other)
```

#### Parameters

`other` [CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_"></a> MergeFrom\(CDOTAClientMsg\_HeroStatueLike\)

```csharp
public void MergeFrom(CDOTAClientMsg_HeroStatueLike other)
```

#### Parameters

`other` [CDOTAClientMsg\_HeroStatueLike](Divine.Protobufs.Dota2.CDOTAClientMsg\_HeroStatueLike.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_HeroStatueLike_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

