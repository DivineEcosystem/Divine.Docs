# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult"></a> Class CDOTAUserMsg\_RollDiceResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_RollDiceResult : IMessage<CDOTAUserMsg_RollDiceResult>, IEquatable<CDOTAUserMsg_RollDiceResult>, IDeepCloneable<CDOTAUserMsg_RollDiceResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)

#### Implements

IMessage<CDOTAUserMsg\_RollDiceResult\>, 
[IEquatable<CDOTAUserMsg\_RollDiceResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_RollDiceResult\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_RollDiceResult\>\(CDOTAUserMsg\_RollDiceResult, params CDOTAUserMsg\_RollDiceResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult__ctor"></a> CDOTAUserMsg\_RollDiceResult\(\)

```csharp
public CDOTAUserMsg_RollDiceResult()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_"></a> CDOTAUserMsg\_RollDiceResult\(CDOTAUserMsg\_RollDiceResult\)

```csharp
public CDOTAUserMsg_RollDiceResult(CDOTAUserMsg_RollDiceResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_RollMaxFieldNumber"></a> RollMaxFieldNumber

```csharp
public const int RollMaxFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_RollMinFieldNumber"></a> RollMinFieldNumber

```csharp
public const int RollMinFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ChannelType"></a> ChannelType

```csharp
public uint ChannelType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_HasRollMax"></a> HasRollMax

```csharp
public bool HasRollMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_HasRollMin"></a> HasRollMin

```csharp
public bool HasRollMin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_RollDiceResult> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_RollMax"></a> RollMax

```csharp
public uint RollMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_RollMin"></a> RollMin

```csharp
public uint RollMin { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ClearRollMax"></a> ClearRollMax\(\)

```csharp
public void ClearRollMax()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ClearRollMin"></a> ClearRollMin\(\)

```csharp
public void ClearRollMin()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_RollDiceResult Clone()
```

#### Returns

 [CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_"></a> Equals\(CDOTAUserMsg\_RollDiceResult\)

```csharp
public bool Equals(CDOTAUserMsg_RollDiceResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_"></a> MergeFrom\(CDOTAUserMsg\_RollDiceResult\)

```csharp
public void MergeFrom(CDOTAUserMsg_RollDiceResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_RollDiceResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_RollDiceResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_RollDiceResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

