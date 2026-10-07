# <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse"></a> Class CGCMsgMemCachedStatsResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCMsgMemCachedStatsResponse : IMessage<CGCMsgMemCachedStatsResponse>, IEquatable<CGCMsgMemCachedStatsResponse>, IDeepCloneable<CGCMsgMemCachedStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)

#### Implements

IMessage<CGCMsgMemCachedStatsResponse\>, 
[IEquatable<CGCMsgMemCachedStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCMsgMemCachedStatsResponse\>, 
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
[EnumerableExtensions.In<CGCMsgMemCachedStatsResponse\>\(CGCMsgMemCachedStatsResponse, params CGCMsgMemCachedStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse__ctor"></a> CGCMsgMemCachedStatsResponse\(\)

```csharp
public CGCMsgMemCachedStatsResponse()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse__ctor_Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_"></a> CGCMsgMemCachedStatsResponse\(CGCMsgMemCachedStatsResponse\)

```csharp
public CGCMsgMemCachedStatsResponse(CGCMsgMemCachedStatsResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_BytesFieldNumber"></a> BytesFieldNumber

```csharp
public const int BytesFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_BytesReadFieldNumber"></a> BytesReadFieldNumber

```csharp
public const int BytesReadFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_BytesWrittenFieldNumber"></a> BytesWrittenFieldNumber

```csharp
public const int BytesWrittenFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdFlushFieldNumber"></a> CmdFlushFieldNumber

```csharp
public const int CmdFlushFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdGetFieldNumber"></a> CmdGetFieldNumber

```csharp
public const int CmdGetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdSetFieldNumber"></a> CmdSetFieldNumber

```csharp
public const int CmdSetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CurrConnectionsFieldNumber"></a> CurrConnectionsFieldNumber

```csharp
public const int CurrConnectionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CurrItemsFieldNumber"></a> CurrItemsFieldNumber

```csharp
public const int CurrItemsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_DeleteHitsFieldNumber"></a> DeleteHitsFieldNumber

```csharp
public const int DeleteHitsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_DeleteMissesFieldNumber"></a> DeleteMissesFieldNumber

```csharp
public const int DeleteMissesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_EvictionsFieldNumber"></a> EvictionsFieldNumber

```csharp
public const int EvictionsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_GetHitsFieldNumber"></a> GetHitsFieldNumber

```csharp
public const int GetHitsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_GetMissesFieldNumber"></a> GetMissesFieldNumber

```csharp
public const int GetMissesFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_LimitMaxbytesFieldNumber"></a> LimitMaxbytesFieldNumber

```csharp
public const int LimitMaxbytesFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Bytes"></a> Bytes

```csharp
public ulong Bytes { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_BytesRead"></a> BytesRead

```csharp
public ulong BytesRead { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_BytesWritten"></a> BytesWritten

```csharp
public ulong BytesWritten { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdFlush"></a> CmdFlush

```csharp
public ulong CmdFlush { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdGet"></a> CmdGet

```csharp
public ulong CmdGet { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CmdSet"></a> CmdSet

```csharp
public ulong CmdSet { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CurrConnections"></a> CurrConnections

```csharp
public ulong CurrConnections { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CurrItems"></a> CurrItems

```csharp
public ulong CurrItems { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_DeleteHits"></a> DeleteHits

```csharp
public ulong DeleteHits { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_DeleteMisses"></a> DeleteMisses

```csharp
public ulong DeleteMisses { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Evictions"></a> Evictions

```csharp
public ulong Evictions { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_GetHits"></a> GetHits

```csharp
public ulong GetHits { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_GetMisses"></a> GetMisses

```csharp
public ulong GetMisses { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasBytes"></a> HasBytes

```csharp
public bool HasBytes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasBytesRead"></a> HasBytesRead

```csharp
public bool HasBytesRead { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasBytesWritten"></a> HasBytesWritten

```csharp
public bool HasBytesWritten { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasCmdFlush"></a> HasCmdFlush

```csharp
public bool HasCmdFlush { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasCmdGet"></a> HasCmdGet

```csharp
public bool HasCmdGet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasCmdSet"></a> HasCmdSet

```csharp
public bool HasCmdSet { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasCurrConnections"></a> HasCurrConnections

```csharp
public bool HasCurrConnections { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasCurrItems"></a> HasCurrItems

```csharp
public bool HasCurrItems { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasDeleteHits"></a> HasDeleteHits

```csharp
public bool HasDeleteHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasDeleteMisses"></a> HasDeleteMisses

```csharp
public bool HasDeleteMisses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasEvictions"></a> HasEvictions

```csharp
public bool HasEvictions { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasGetHits"></a> HasGetHits

```csharp
public bool HasGetHits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasGetMisses"></a> HasGetMisses

```csharp
public bool HasGetMisses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_HasLimitMaxbytes"></a> HasLimitMaxbytes

```csharp
public bool HasLimitMaxbytes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_LimitMaxbytes"></a> LimitMaxbytes

```csharp
public ulong LimitMaxbytes { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CGCMsgMemCachedStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearBytes"></a> ClearBytes\(\)

```csharp
public void ClearBytes()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearBytesRead"></a> ClearBytesRead\(\)

```csharp
public void ClearBytesRead()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearBytesWritten"></a> ClearBytesWritten\(\)

```csharp
public void ClearBytesWritten()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearCmdFlush"></a> ClearCmdFlush\(\)

```csharp
public void ClearCmdFlush()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearCmdGet"></a> ClearCmdGet\(\)

```csharp
public void ClearCmdGet()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearCmdSet"></a> ClearCmdSet\(\)

```csharp
public void ClearCmdSet()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearCurrConnections"></a> ClearCurrConnections\(\)

```csharp
public void ClearCurrConnections()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearCurrItems"></a> ClearCurrItems\(\)

```csharp
public void ClearCurrItems()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearDeleteHits"></a> ClearDeleteHits\(\)

```csharp
public void ClearDeleteHits()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearDeleteMisses"></a> ClearDeleteMisses\(\)

```csharp
public void ClearDeleteMisses()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearEvictions"></a> ClearEvictions\(\)

```csharp
public void ClearEvictions()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearGetHits"></a> ClearGetHits\(\)

```csharp
public void ClearGetHits()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearGetMisses"></a> ClearGetMisses\(\)

```csharp
public void ClearGetMisses()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ClearLimitMaxbytes"></a> ClearLimitMaxbytes\(\)

```csharp
public void ClearLimitMaxbytes()
```

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Clone"></a> Clone\(\)

```csharp
public CGCMsgMemCachedStatsResponse Clone()
```

#### Returns

 [CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_Equals_Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_"></a> Equals\(CGCMsgMemCachedStatsResponse\)

```csharp
public bool Equals(CGCMsgMemCachedStatsResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_MergeFrom_Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_"></a> MergeFrom\(CGCMsgMemCachedStatsResponse\)

```csharp
public void MergeFrom(CGCMsgMemCachedStatsResponse other)
```

#### Parameters

`other` [CGCMsgMemCachedStatsResponse](Divine.Protobufs.Steam.CGCMsgMemCachedStatsResponse.md)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCMsgMemCachedStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

