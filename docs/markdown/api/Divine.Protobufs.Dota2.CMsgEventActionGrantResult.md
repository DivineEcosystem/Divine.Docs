# <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult"></a> Class CMsgEventActionGrantResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventActionGrantResult : IMessage<CMsgEventActionGrantResult>, IEquatable<CMsgEventActionGrantResult>, IDeepCloneable<CMsgEventActionGrantResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)

#### Implements

IMessage<CMsgEventActionGrantResult\>, 
[IEquatable<CMsgEventActionGrantResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventActionGrantResult\>, 
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
[EnumerableExtensions.In<CMsgEventActionGrantResult\>\(CMsgEventActionGrantResult, params CMsgEventActionGrantResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult__ctor"></a> CMsgEventActionGrantResult\(\)

```csharp
public CMsgEventActionGrantResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult__ctor_Divine_Protobufs_Dota2_CMsgEventActionGrantResult_"></a> CMsgEventActionGrantResult\(CMsgEventActionGrantResult\)

```csharp
public CMsgEventActionGrantResult(CMsgEventActionGrantResult other)
```

#### Parameters

`other` [CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_GrantDataFieldNumber"></a> GrantDataFieldNumber

```csharp
public const int GrantDataFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_GrantIndexFieldNumber"></a> GrantIndexFieldNumber

```csharp
public const int GrantIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_RewardIndexFieldNumber"></a> RewardIndexFieldNumber

```csharp
public const int RewardIndexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ScoreIndexFieldNumber"></a> ScoreIndexFieldNumber

```csharp
public const int ScoreIndexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_GrantData"></a> GrantData

```csharp
public ByteString GrantData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_GrantIndex"></a> GrantIndex

```csharp
public uint GrantIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_HasGrantData"></a> HasGrantData

```csharp
public bool HasGrantData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_HasGrantIndex"></a> HasGrantIndex

```csharp
public bool HasGrantIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_HasRewardIndex"></a> HasRewardIndex

```csharp
public bool HasRewardIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_HasScoreIndex"></a> HasScoreIndex

```csharp
public bool HasScoreIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventActionGrantResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_RewardIndex"></a> RewardIndex

```csharp
public uint RewardIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ScoreIndex"></a> ScoreIndex

```csharp
public uint ScoreIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ClearGrantData"></a> ClearGrantData\(\)

```csharp
public void ClearGrantData()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ClearGrantIndex"></a> ClearGrantIndex\(\)

```csharp
public void ClearGrantIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ClearRewardIndex"></a> ClearRewardIndex\(\)

```csharp
public void ClearRewardIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ClearScoreIndex"></a> ClearScoreIndex\(\)

```csharp
public void ClearScoreIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_Clone"></a> Clone\(\)

```csharp
public CMsgEventActionGrantResult Clone()
```

#### Returns

 [CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_Equals_Divine_Protobufs_Dota2_CMsgEventActionGrantResult_"></a> Equals\(CMsgEventActionGrantResult\)

```csharp
public bool Equals(CMsgEventActionGrantResult other)
```

#### Parameters

`other` [CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_MergeFrom_Divine_Protobufs_Dota2_CMsgEventActionGrantResult_"></a> MergeFrom\(CMsgEventActionGrantResult\)

```csharp
public void MergeFrom(CMsgEventActionGrantResult other)
```

#### Parameters

`other` [CMsgEventActionGrantResult](Divine.Protobufs.Dota2.CMsgEventActionGrantResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionGrantResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

