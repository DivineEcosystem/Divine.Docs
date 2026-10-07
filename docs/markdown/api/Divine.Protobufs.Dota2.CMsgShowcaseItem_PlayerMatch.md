# <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch"></a> Class CMsgShowcaseItem\_PlayerMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseItem_PlayerMatch : IMessage<CMsgShowcaseItem_PlayerMatch>, IEquatable<CMsgShowcaseItem_PlayerMatch>, IDeepCloneable<CMsgShowcaseItem_PlayerMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)

#### Implements

IMessage<CMsgShowcaseItem\_PlayerMatch\>, 
[IEquatable<CMsgShowcaseItem\_PlayerMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseItem\_PlayerMatch\>, 
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
[EnumerableExtensions.In<CMsgShowcaseItem\_PlayerMatch\>\(CMsgShowcaseItem\_PlayerMatch, params CMsgShowcaseItem\_PlayerMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch__ctor"></a> CMsgShowcaseItem\_PlayerMatch\(\)

```csharp
public CMsgShowcaseItem_PlayerMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch__ctor_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_"></a> CMsgShowcaseItem\_PlayerMatch\(CMsgShowcaseItem\_PlayerMatch\)

```csharp
public CMsgShowcaseItem_PlayerMatch(CMsgShowcaseItem_PlayerMatch other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Data"></a> Data

```csharp
public CMsgShowcaseItem_PlayerMatch.Types.Data Data { get; set; }
```

#### Property Value

 [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseItem_PlayerMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_PlayerSlot"></a> PlayerSlot

```csharp
public uint PlayerSlot { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseItem_PlayerMatch Clone()
```

#### Returns

 [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_Equals_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_"></a> Equals\(CMsgShowcaseItem\_PlayerMatch\)

```csharp
public bool Equals(CMsgShowcaseItem_PlayerMatch other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_"></a> MergeFrom\(CMsgShowcaseItem\_PlayerMatch\)

```csharp
public void MergeFrom(CMsgShowcaseItem_PlayerMatch other)
```

#### Parameters

`other` [CMsgShowcaseItem\_PlayerMatch](Divine.Protobufs.Dota2.CMsgShowcaseItem\_PlayerMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseItem_PlayerMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

