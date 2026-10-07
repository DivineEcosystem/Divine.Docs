# <a id="Divine_Protobufs_Dota2_CMsgBingoCard"></a> Class CMsgBingoCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoCard : IMessage<CMsgBingoCard>, IEquatable<CMsgBingoCard>, IDeepCloneable<CMsgBingoCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)

#### Implements

IMessage<CMsgBingoCard\>, 
[IEquatable<CMsgBingoCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoCard\>, 
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
[EnumerableExtensions.In<CMsgBingoCard\>\(CMsgBingoCard, params CMsgBingoCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard__ctor"></a> CMsgBingoCard\(\)

```csharp
public CMsgBingoCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard__ctor_Divine_Protobufs_Dota2_CMsgBingoCard_"></a> CMsgBingoCard\(CMsgBingoCard\)

```csharp
public CMsgBingoCard(CMsgBingoCard other)
```

#### Parameters

`other` [CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_SquaresFieldNumber"></a> SquaresFieldNumber

```csharp
public const int SquaresFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Squares"></a> Squares

```csharp
public RepeatedField<CMsgBingoSquare> Squares { get; }
```

#### Property Value

 RepeatedField<[CMsgBingoSquare](Divine.Protobufs.Dota2.CMsgBingoSquare.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Clone"></a> Clone\(\)

```csharp
public CMsgBingoCard Clone()
```

#### Returns

 [CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_Equals_Divine_Protobufs_Dota2_CMsgBingoCard_"></a> Equals\(CMsgBingoCard\)

```csharp
public bool Equals(CMsgBingoCard other)
```

#### Parameters

`other` [CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoCard_"></a> MergeFrom\(CMsgBingoCard\)

```csharp
public void MergeFrom(CMsgBingoCard other)
```

#### Parameters

`other` [CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

