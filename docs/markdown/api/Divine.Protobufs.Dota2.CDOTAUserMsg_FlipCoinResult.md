# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult"></a> Class CDOTAUserMsg\_FlipCoinResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_FlipCoinResult : IMessage<CDOTAUserMsg_FlipCoinResult>, IEquatable<CDOTAUserMsg_FlipCoinResult>, IDeepCloneable<CDOTAUserMsg_FlipCoinResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)

#### Implements

IMessage<CDOTAUserMsg\_FlipCoinResult\>, 
[IEquatable<CDOTAUserMsg\_FlipCoinResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_FlipCoinResult\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_FlipCoinResult\>\(CDOTAUserMsg\_FlipCoinResult, params CDOTAUserMsg\_FlipCoinResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult__ctor"></a> CDOTAUserMsg\_FlipCoinResult\(\)

```csharp
public CDOTAUserMsg_FlipCoinResult()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_"></a> CDOTAUserMsg\_FlipCoinResult\(CDOTAUserMsg\_FlipCoinResult\)

```csharp
public CDOTAUserMsg_FlipCoinResult(CDOTAUserMsg_FlipCoinResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ChannelTypeFieldNumber"></a> ChannelTypeFieldNumber

```csharp
public const int ChannelTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ChannelType"></a> ChannelType

```csharp
public uint ChannelType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_HasChannelType"></a> HasChannelType

```csharp
public bool HasChannelType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_FlipCoinResult> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ClearChannelType"></a> ClearChannelType\(\)

```csharp
public void ClearChannelType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_FlipCoinResult Clone()
```

#### Returns

 [CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_"></a> Equals\(CDOTAUserMsg\_FlipCoinResult\)

```csharp
public bool Equals(CDOTAUserMsg_FlipCoinResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_"></a> MergeFrom\(CDOTAUserMsg\_FlipCoinResult\)

```csharp
public void MergeFrom(CDOTAUserMsg_FlipCoinResult other)
```

#### Parameters

`other` [CDOTAUserMsg\_FlipCoinResult](Divine.Protobufs.Dota2.CDOTAUserMsg\_FlipCoinResult.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_FlipCoinResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

