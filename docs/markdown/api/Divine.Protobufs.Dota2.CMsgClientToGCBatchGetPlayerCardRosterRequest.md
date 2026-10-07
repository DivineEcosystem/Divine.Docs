# <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest"></a> Class CMsgClientToGCBatchGetPlayerCardRosterRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCBatchGetPlayerCardRosterRequest : IMessage<CMsgClientToGCBatchGetPlayerCardRosterRequest>, IEquatable<CMsgClientToGCBatchGetPlayerCardRosterRequest>, IDeepCloneable<CMsgClientToGCBatchGetPlayerCardRosterRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)

#### Implements

IMessage<CMsgClientToGCBatchGetPlayerCardRosterRequest\>, 
[IEquatable<CMsgClientToGCBatchGetPlayerCardRosterRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCBatchGetPlayerCardRosterRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCBatchGetPlayerCardRosterRequest\>\(CMsgClientToGCBatchGetPlayerCardRosterRequest, params CMsgClientToGCBatchGetPlayerCardRosterRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest__ctor"></a> CMsgClientToGCBatchGetPlayerCardRosterRequest\(\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_"></a> CMsgClientToGCBatchGetPlayerCardRosterRequest\(CMsgClientToGCBatchGetPlayerCardRosterRequest\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterRequest(CMsgClientToGCBatchGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_LeagueTimestampsFieldNumber"></a> LeagueTimestampsFieldNumber

```csharp
public const int LeagueTimestampsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_LeagueTimestamps"></a> LeagueTimestamps

```csharp
public RepeatedField<CMsgClientToGCBatchGetPlayerCardRosterRequest.Types.LeagueTimestamp> LeagueTimestamps { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.Types.md).[LeagueTimestamp](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.Types.LeagueTimestamp.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCBatchGetPlayerCardRosterRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCBatchGetPlayerCardRosterRequest Clone()
```

#### Returns

 [CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_"></a> Equals\(CMsgClientToGCBatchGetPlayerCardRosterRequest\)

```csharp
public bool Equals(CMsgClientToGCBatchGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_"></a> MergeFrom\(CMsgClientToGCBatchGetPlayerCardRosterRequest\)

```csharp
public void MergeFrom(CMsgClientToGCBatchGetPlayerCardRosterRequest other)
```

#### Parameters

`other` [CMsgClientToGCBatchGetPlayerCardRosterRequest](Divine.Protobufs.Dota2.CMsgClientToGCBatchGetPlayerCardRosterRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCBatchGetPlayerCardRosterRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

