# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate"></a> Class CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate : IMessage<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate>, IEquatable<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate>, IDeepCloneable<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)

#### Implements

IMessage<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate\>, 
[IEquatable<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate\>\(CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate, params CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate__ctor"></a> ReporterUpdate\(\)

```csharp
public ReporterUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_"></a> ReporterUpdate\(ReporterUpdate\)

```csharp
public ReporterUpdate(CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ReportReasonFieldNumber"></a> ReportReasonFieldNumber

```csharp
public const int ReportReasonFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HasReportReason"></a> HasReportReason

```csharp
public bool HasReportReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ReportReason"></a> ReportReason

```csharp
public uint ReportReason { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ClearReportReason"></a> ClearReportReason\(\)

```csharp
public void ClearReportReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate Clone()
```

#### Returns

 [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_"></a> Equals\(ReporterUpdate\)

```csharp
public bool Equals(CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_"></a> MergeFrom\(ReporterUpdate\)

```csharp
public void MergeFrom(CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdatesResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.md).[ReporterUpdate](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdatesResponse.Types.ReporterUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdatesResponse_Types_ReporterUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

