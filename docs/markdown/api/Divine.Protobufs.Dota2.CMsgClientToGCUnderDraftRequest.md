# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest"></a> Class CMsgClientToGCUnderDraftRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftRequest : IMessage<CMsgClientToGCUnderDraftRequest>, IEquatable<CMsgClientToGCUnderDraftRequest>, IDeepCloneable<CMsgClientToGCUnderDraftRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftRequest\>, 
[IEquatable<CMsgClientToGCUnderDraftRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftRequest\>\(CMsgClientToGCUnderDraftRequest, params CMsgClientToGCUnderDraftRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest__ctor"></a> CMsgClientToGCUnderDraftRequest\(\)

```csharp
public CMsgClientToGCUnderDraftRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_"></a> CMsgClientToGCUnderDraftRequest\(CMsgClientToGCUnderDraftRequest\)

```csharp
public CMsgClientToGCUnderDraftRequest(CMsgClientToGCUnderDraftRequest other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftRequest Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_"></a> Equals\(CMsgClientToGCUnderDraftRequest\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftRequest other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_"></a> MergeFrom\(CMsgClientToGCUnderDraftRequest\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftRequest other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftRequest](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

