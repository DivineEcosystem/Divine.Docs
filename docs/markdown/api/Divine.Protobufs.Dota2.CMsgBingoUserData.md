# <a id="Divine_Protobufs_Dota2_CMsgBingoUserData"></a> Class CMsgBingoUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoUserData : IMessage<CMsgBingoUserData>, IEquatable<CMsgBingoUserData>, IDeepCloneable<CMsgBingoUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

#### Implements

IMessage<CMsgBingoUserData\>, 
[IEquatable<CMsgBingoUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoUserData\>, 
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
[EnumerableExtensions.In<CMsgBingoUserData\>\(CMsgBingoUserData, params CMsgBingoUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData__ctor"></a> CMsgBingoUserData\(\)

```csharp
public CMsgBingoUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData__ctor_Divine_Protobufs_Dota2_CMsgBingoUserData_"></a> CMsgBingoUserData\(CMsgBingoUserData\)

```csharp
public CMsgBingoUserData(CMsgBingoUserData other)
```

#### Parameters

`other` [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_BingoCardsFieldNumber"></a> BingoCardsFieldNumber

```csharp
public const int BingoCardsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_BingoTokensFieldNumber"></a> BingoTokensFieldNumber

```csharp
public const int BingoTokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_BingoCards"></a> BingoCards

```csharp
public MapField<uint, CMsgBingoCard> BingoCards { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgBingoCard](Divine.Protobufs.Dota2.CMsgBingoCard.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_BingoTokens"></a> BingoTokens

```csharp
public MapField<uint, CMsgBingoTokens> BingoTokens { get; }
```

#### Property Value

 MapField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32), [CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_Clone"></a> Clone\(\)

```csharp
public CMsgBingoUserData Clone()
```

#### Returns

 [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_Equals_Divine_Protobufs_Dota2_CMsgBingoUserData_"></a> Equals\(CMsgBingoUserData\)

```csharp
public bool Equals(CMsgBingoUserData other)
```

#### Parameters

`other` [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoUserData_"></a> MergeFrom\(CMsgBingoUserData\)

```csharp
public void MergeFrom(CMsgBingoUserData other)
```

#### Parameters

`other` [CMsgBingoUserData](Divine.Protobufs.Dota2.CMsgBingoUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

