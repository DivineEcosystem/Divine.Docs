# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse"></a> Class CMsgClientToGCOverworldVisitEncounterResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldVisitEncounterResponse : IMessage<CMsgClientToGCOverworldVisitEncounterResponse>, IEquatable<CMsgClientToGCOverworldVisitEncounterResponse>, IDeepCloneable<CMsgClientToGCOverworldVisitEncounterResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldVisitEncounterResponse\>, 
[IEquatable<CMsgClientToGCOverworldVisitEncounterResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldVisitEncounterResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldVisitEncounterResponse\>\(CMsgClientToGCOverworldVisitEncounterResponse, params CMsgClientToGCOverworldVisitEncounterResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse__ctor"></a> CMsgClientToGCOverworldVisitEncounterResponse\(\)

```csharp
public CMsgClientToGCOverworldVisitEncounterResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_"></a> CMsgClientToGCOverworldVisitEncounterResponse\(CMsgClientToGCOverworldVisitEncounterResponse\)

```csharp
public CMsgClientToGCOverworldVisitEncounterResponse(CMsgClientToGCOverworldVisitEncounterResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldVisitEncounterResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Response"></a> Response

```csharp
public CMsgClientToGCOverworldVisitEncounterResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldVisitEncounterResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_"></a> Equals\(CMsgClientToGCOverworldVisitEncounterResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldVisitEncounterResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_"></a> MergeFrom\(CMsgClientToGCOverworldVisitEncounterResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldVisitEncounterResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldVisitEncounterResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldVisitEncounterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldVisitEncounterResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

