# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest"></a> Class CMsgClientToGCCreateStickerbookPageRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateStickerbookPageRequest : IMessage<CMsgClientToGCCreateStickerbookPageRequest>, IEquatable<CMsgClientToGCCreateStickerbookPageRequest>, IDeepCloneable<CMsgClientToGCCreateStickerbookPageRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)

#### Implements

IMessage<CMsgClientToGCCreateStickerbookPageRequest\>, 
[IEquatable<CMsgClientToGCCreateStickerbookPageRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateStickerbookPageRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateStickerbookPageRequest\>\(CMsgClientToGCCreateStickerbookPageRequest, params CMsgClientToGCCreateStickerbookPageRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest__ctor"></a> CMsgClientToGCCreateStickerbookPageRequest\(\)

```csharp
public CMsgClientToGCCreateStickerbookPageRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_"></a> CMsgClientToGCCreateStickerbookPageRequest\(CMsgClientToGCCreateStickerbookPageRequest\)

```csharp
public CMsgClientToGCCreateStickerbookPageRequest(CMsgClientToGCCreateStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_PageTypeFieldNumber"></a> PageTypeFieldNumber

```csharp
public const int PageTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_EventId"></a> EventId

```csharp
public EEvent EventId { get; set; }
```

#### Property Value

 [EEvent](Divine.Protobufs.Dota2.EEvent.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_HasPageType"></a> HasPageType

```csharp
public bool HasPageType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_PageType"></a> PageType

```csharp
public EStickerbookPageType PageType { get; set; }
```

#### Property Value

 [EStickerbookPageType](Divine.Protobufs.Dota2.EStickerbookPageType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateStickerbookPageRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_ClearPageType"></a> ClearPageType\(\)

```csharp
public void ClearPageType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateStickerbookPageRequest Clone()
```

#### Returns

 [CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_"></a> Equals\(CMsgClientToGCCreateStickerbookPageRequest\)

```csharp
public bool Equals(CMsgClientToGCCreateStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_"></a> MergeFrom\(CMsgClientToGCCreateStickerbookPageRequest\)

```csharp
public void MergeFrom(CMsgClientToGCCreateStickerbookPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCCreateStickerbookPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCCreateStickerbookPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateStickerbookPageRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

