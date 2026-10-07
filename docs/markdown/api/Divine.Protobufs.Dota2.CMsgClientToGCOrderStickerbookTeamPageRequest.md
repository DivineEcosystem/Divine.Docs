# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest"></a> Class CMsgClientToGCOrderStickerbookTeamPageRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOrderStickerbookTeamPageRequest : IMessage<CMsgClientToGCOrderStickerbookTeamPageRequest>, IEquatable<CMsgClientToGCOrderStickerbookTeamPageRequest>, IDeepCloneable<CMsgClientToGCOrderStickerbookTeamPageRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)

#### Implements

IMessage<CMsgClientToGCOrderStickerbookTeamPageRequest\>, 
[IEquatable<CMsgClientToGCOrderStickerbookTeamPageRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOrderStickerbookTeamPageRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOrderStickerbookTeamPageRequest\>\(CMsgClientToGCOrderStickerbookTeamPageRequest, params CMsgClientToGCOrderStickerbookTeamPageRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest__ctor"></a> CMsgClientToGCOrderStickerbookTeamPageRequest\(\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_"></a> CMsgClientToGCOrderStickerbookTeamPageRequest\(CMsgClientToGCOrderStickerbookTeamPageRequest\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageRequest(CMsgClientToGCOrderStickerbookTeamPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_PageOrderSequenceFieldNumber"></a> PageOrderSequenceFieldNumber

```csharp
public const int PageOrderSequenceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_PageOrderSequence"></a> PageOrderSequence

```csharp
public CMsgStickerbookTeamPageOrderSequence PageOrderSequence { get; set; }
```

#### Property Value

 [CMsgStickerbookTeamPageOrderSequence](Divine.Protobufs.Dota2.CMsgStickerbookTeamPageOrderSequence.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOrderStickerbookTeamPageRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOrderStickerbookTeamPageRequest Clone()
```

#### Returns

 [CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_"></a> Equals\(CMsgClientToGCOrderStickerbookTeamPageRequest\)

```csharp
public bool Equals(CMsgClientToGCOrderStickerbookTeamPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_"></a> MergeFrom\(CMsgClientToGCOrderStickerbookTeamPageRequest\)

```csharp
public void MergeFrom(CMsgClientToGCOrderStickerbookTeamPageRequest other)
```

#### Parameters

`other` [CMsgClientToGCOrderStickerbookTeamPageRequest](Divine.Protobufs.Dota2.CMsgClientToGCOrderStickerbookTeamPageRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOrderStickerbookTeamPageRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

