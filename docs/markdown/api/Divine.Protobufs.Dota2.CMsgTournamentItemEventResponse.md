# <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse"></a> Class CMsgTournamentItemEventResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTournamentItemEventResponse : IMessage<CMsgTournamentItemEventResponse>, IEquatable<CMsgTournamentItemEventResponse>, IDeepCloneable<CMsgTournamentItemEventResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)

#### Implements

IMessage<CMsgTournamentItemEventResponse\>, 
[IEquatable<CMsgTournamentItemEventResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTournamentItemEventResponse\>, 
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
[EnumerableExtensions.In<CMsgTournamentItemEventResponse\>\(CMsgTournamentItemEventResponse, params CMsgTournamentItemEventResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse__ctor"></a> CMsgTournamentItemEventResponse\(\)

```csharp
public CMsgTournamentItemEventResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse__ctor_Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_"></a> CMsgTournamentItemEventResponse\(CMsgTournamentItemEventResponse\)

```csharp
public CMsgTournamentItemEventResponse(CMsgTournamentItemEventResponse other)
```

#### Parameters

`other` [CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_EventTypeFieldNumber"></a> EventTypeFieldNumber

```csharp
public const int EventTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_ViewersGrantedFieldNumber"></a> ViewersGrantedFieldNumber

```csharp
public const int ViewersGrantedFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_EventType"></a> EventType

```csharp
public DOTA_TournamentEvents EventType { get; set; }
```

#### Property Value

 [DOTA\_TournamentEvents](Divine.Protobufs.Dota2.DOTA\_TournamentEvents.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_HasEventType"></a> HasEventType

```csharp
public bool HasEventType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_HasViewersGranted"></a> HasViewersGranted

```csharp
public bool HasViewersGranted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTournamentItemEventResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_ViewersGranted"></a> ViewersGranted

```csharp
public uint ViewersGranted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_ClearEventType"></a> ClearEventType\(\)

```csharp
public void ClearEventType()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_ClearViewersGranted"></a> ClearViewersGranted\(\)

```csharp
public void ClearViewersGranted()
```

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_Clone"></a> Clone\(\)

```csharp
public CMsgTournamentItemEventResponse Clone()
```

#### Returns

 [CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_Equals_Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_"></a> Equals\(CMsgTournamentItemEventResponse\)

```csharp
public bool Equals(CMsgTournamentItemEventResponse other)
```

#### Parameters

`other` [CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_"></a> MergeFrom\(CMsgTournamentItemEventResponse\)

```csharp
public void MergeFrom(CMsgTournamentItemEventResponse other)
```

#### Parameters

`other` [CMsgTournamentItemEventResponse](Divine.Protobufs.Dota2.CMsgTournamentItemEventResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTournamentItemEventResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

