# <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange"></a> Class CMsgGCHAccountVacStatusChange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAccountVacStatusChange : IMessage<CMsgGCHAccountVacStatusChange>, IEquatable<CMsgGCHAccountVacStatusChange>, IDeepCloneable<CMsgGCHAccountVacStatusChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)

#### Implements

IMessage<CMsgGCHAccountVacStatusChange\>, 
[IEquatable<CMsgGCHAccountVacStatusChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAccountVacStatusChange\>, 
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
[EnumerableExtensions.In<CMsgGCHAccountVacStatusChange\>\(CMsgGCHAccountVacStatusChange, params CMsgGCHAccountVacStatusChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange__ctor"></a> CMsgGCHAccountVacStatusChange\(\)

```csharp
public CMsgGCHAccountVacStatusChange()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange__ctor_Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_"></a> CMsgGCHAccountVacStatusChange\(CMsgGCHAccountVacStatusChange\)

```csharp
public CMsgGCHAccountVacStatusChange(CMsgGCHAccountVacStatusChange other)
```

#### Parameters

`other` [CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_AppIdFieldNumber"></a> AppIdFieldNumber

```csharp
public const int AppIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_IsBannedFutureFieldNumber"></a> IsBannedFutureFieldNumber

```csharp
public const int IsBannedFutureFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_IsBannedNowFieldNumber"></a> IsBannedNowFieldNumber

```csharp
public const int IsBannedNowFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_RtimeVacbanStartsFieldNumber"></a> RtimeVacbanStartsFieldNumber

```csharp
public const int RtimeVacbanStartsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_AppId"></a> AppId

```csharp
public uint AppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_HasAppId"></a> HasAppId

```csharp
public bool HasAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_HasIsBannedFuture"></a> HasIsBannedFuture

```csharp
public bool HasIsBannedFuture { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_HasIsBannedNow"></a> HasIsBannedNow

```csharp
public bool HasIsBannedNow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_HasRtimeVacbanStarts"></a> HasRtimeVacbanStarts

```csharp
public bool HasRtimeVacbanStarts { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_IsBannedFuture"></a> IsBannedFuture

```csharp
public bool IsBannedFuture { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_IsBannedNow"></a> IsBannedNow

```csharp
public bool IsBannedNow { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAccountVacStatusChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_RtimeVacbanStarts"></a> RtimeVacbanStarts

```csharp
public uint RtimeVacbanStarts { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ClearAppId"></a> ClearAppId\(\)

```csharp
public void ClearAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ClearIsBannedFuture"></a> ClearIsBannedFuture\(\)

```csharp
public void ClearIsBannedFuture()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ClearIsBannedNow"></a> ClearIsBannedNow\(\)

```csharp
public void ClearIsBannedNow()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ClearRtimeVacbanStarts"></a> ClearRtimeVacbanStarts\(\)

```csharp
public void ClearRtimeVacbanStarts()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAccountVacStatusChange Clone()
```

#### Returns

 [CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_Equals_Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_"></a> Equals\(CMsgGCHAccountVacStatusChange\)

```csharp
public bool Equals(CMsgGCHAccountVacStatusChange other)
```

#### Parameters

`other` [CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_"></a> MergeFrom\(CMsgGCHAccountVacStatusChange\)

```csharp
public void MergeFrom(CMsgGCHAccountVacStatusChange other)
```

#### Parameters

`other` [CMsgGCHAccountVacStatusChange](Divine.Protobufs.Steam.CMsgGCHAccountVacStatusChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountVacStatusChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

