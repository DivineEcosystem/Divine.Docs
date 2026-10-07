# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest"></a> Class CMsgClientToGCGetPlayerCardRosterRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetPlayerCardRosterRequest : IMessage<CMsgClientToGCGetPlayerCardRosterRequest>, IEquatable<CMsgClientToGCGetPlayerCardRosterRequest>, IDeepCloneable<CMsgClientToGCGetPlayerCardRosterRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)

#### Implements

IMessage<CMsgClientToGCGetPlayerCardRosterRequest\>, 
[IEquatable<CMsgClientToGCGetPlayerCardRosterRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetPlayerCardRosterRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetPlayerCardRosterRequest\>\(CMsgClientToGCGetPlayerCardRosterRequest, params CMsgClientToGCGetPlayerCardRosterRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest__ctor"></a> CMsgClientToGCGetPlayerCardRosterRequest\(\)

```csharp
public CMsgClientToGCGetPlayerCardRosterRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_"></a> CMsgClientToGCGetPlayerCardRosterRequest\(CMsgClientToGCGetPlayerCardRosterRequest\)

```csharp
public CMsgClientToGCGetPlayerCardRosterRequest(CMsgClientToGCGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_FantasyPeriodFieldNumber"></a> FantasyPeriodFieldNumber

```csharp
public const int FantasyPeriodFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_FantasyPeriod"></a> FantasyPeriod

```csharp
public uint FantasyPeriod { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_HasFantasyPeriod"></a> HasFantasyPeriod

```csharp
public bool HasFantasyPeriod { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetPlayerCardRosterRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_ClearFantasyPeriod"></a> ClearFantasyPeriod\(\)

```csharp
public void ClearFantasyPeriod()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetPlayerCardRosterRequest Clone()
```

#### Returns

 [CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_"></a> Equals\(CMsgClientToGCGetPlayerCardRosterRequest\)

```csharp
public bool Equals(CMsgClientToGCGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_"></a> MergeFrom\(CMsgClientToGCGetPlayerCardRosterRequest\)

```csharp
public void MergeFrom(CMsgClientToGCGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPlayerCardRosterRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

