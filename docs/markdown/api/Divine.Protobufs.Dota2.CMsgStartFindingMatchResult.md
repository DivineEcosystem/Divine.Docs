# <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult"></a> Class CMsgStartFindingMatchResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStartFindingMatchResult : IMessage<CMsgStartFindingMatchResult>, IEquatable<CMsgStartFindingMatchResult>, IDeepCloneable<CMsgStartFindingMatchResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)

#### Implements

IMessage<CMsgStartFindingMatchResult\>, 
[IEquatable<CMsgStartFindingMatchResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStartFindingMatchResult\>, 
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
[EnumerableExtensions.In<CMsgStartFindingMatchResult\>\(CMsgStartFindingMatchResult, params CMsgStartFindingMatchResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult__ctor"></a> CMsgStartFindingMatchResult\(\)

```csharp
public CMsgStartFindingMatchResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult__ctor_Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_"></a> CMsgStartFindingMatchResult\(CMsgStartFindingMatchResult\)

```csharp
public CMsgStartFindingMatchResult(CMsgStartFindingMatchResult other)
```

#### Parameters

`other` [CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_DebugMessageFieldNumber"></a> DebugMessageFieldNumber

```csharp
public const int DebugMessageFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ErrorTokenFieldNumber"></a> ErrorTokenFieldNumber

```csharp
public const int ErrorTokenFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_LegacyGenericEresultFieldNumber"></a> LegacyGenericEresultFieldNumber

```csharp
public const int LegacyGenericEresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ResponsiblePartyMembersFieldNumber"></a> ResponsiblePartyMembersFieldNumber

```csharp
public const int ResponsiblePartyMembersFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ResultMetadataFieldNumber"></a> ResultMetadataFieldNumber

```csharp
public const int ResultMetadataFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_DebugMessage"></a> DebugMessage

```csharp
public string DebugMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ErrorToken"></a> ErrorToken

```csharp
public string ErrorToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_HasDebugMessage"></a> HasDebugMessage

```csharp
public bool HasDebugMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_HasErrorToken"></a> HasErrorToken

```csharp
public bool HasErrorToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_HasLegacyGenericEresult"></a> HasLegacyGenericEresult

```csharp
public bool HasLegacyGenericEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_HasResultMetadata"></a> HasResultMetadata

```csharp
public bool HasResultMetadata { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_LegacyGenericEresult"></a> LegacyGenericEresult

```csharp
public uint LegacyGenericEresult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStartFindingMatchResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ResponsiblePartyMembers"></a> ResponsiblePartyMembers

```csharp
public RepeatedField<ulong> ResponsiblePartyMembers { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Result"></a> Result

```csharp
public EStartFindingMatchResult Result { get; set; }
```

#### Property Value

 [EStartFindingMatchResult](Divine.Protobufs.Dota2.EStartFindingMatchResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ResultMetadata"></a> ResultMetadata

```csharp
public uint ResultMetadata { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ClearDebugMessage"></a> ClearDebugMessage\(\)

```csharp
public void ClearDebugMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ClearErrorToken"></a> ClearErrorToken\(\)

```csharp
public void ClearErrorToken()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ClearLegacyGenericEresult"></a> ClearLegacyGenericEresult\(\)

```csharp
public void ClearLegacyGenericEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ClearResultMetadata"></a> ClearResultMetadata\(\)

```csharp
public void ClearResultMetadata()
```

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Clone"></a> Clone\(\)

```csharp
public CMsgStartFindingMatchResult Clone()
```

#### Returns

 [CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_Equals_Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_"></a> Equals\(CMsgStartFindingMatchResult\)

```csharp
public bool Equals(CMsgStartFindingMatchResult other)
```

#### Parameters

`other` [CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_MergeFrom_Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_"></a> MergeFrom\(CMsgStartFindingMatchResult\)

```csharp
public void MergeFrom(CMsgStartFindingMatchResult other)
```

#### Parameters

`other` [CMsgStartFindingMatchResult](Divine.Protobufs.Dota2.CMsgStartFindingMatchResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStartFindingMatchResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

