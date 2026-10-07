# <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest"></a> Class CMsgClientToGCWageringRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCWageringRequest : IMessage<CMsgClientToGCWageringRequest>, IEquatable<CMsgClientToGCWageringRequest>, IDeepCloneable<CMsgClientToGCWageringRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)

#### Implements

IMessage<CMsgClientToGCWageringRequest\>, 
[IEquatable<CMsgClientToGCWageringRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCWageringRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCWageringRequest\>\(CMsgClientToGCWageringRequest, params CMsgClientToGCWageringRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest__ctor"></a> CMsgClientToGCWageringRequest\(\)

```csharp
public CMsgClientToGCWageringRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_"></a> CMsgClientToGCWageringRequest\(CMsgClientToGCWageringRequest\)

```csharp
public CMsgClientToGCWageringRequest(CMsgClientToGCWageringRequest other)
```

#### Parameters

`other` [CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCWageringRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCWageringRequest Clone()
```

#### Returns

 [CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_"></a> Equals\(CMsgClientToGCWageringRequest\)

```csharp
public bool Equals(CMsgClientToGCWageringRequest other)
```

#### Parameters

`other` [CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_"></a> MergeFrom\(CMsgClientToGCWageringRequest\)

```csharp
public void MergeFrom(CMsgClientToGCWageringRequest other)
```

#### Parameters

`other` [CMsgClientToGCWageringRequest](Divine.Protobufs.Dota2.CMsgClientToGCWageringRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCWageringRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

