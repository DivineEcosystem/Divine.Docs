# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest"></a> Class CMsgGCToClientPollConvarRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPollConvarRequest : IMessage<CMsgGCToClientPollConvarRequest>, IEquatable<CMsgGCToClientPollConvarRequest>, IDeepCloneable<CMsgGCToClientPollConvarRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)

#### Implements

IMessage<CMsgGCToClientPollConvarRequest\>, 
[IEquatable<CMsgGCToClientPollConvarRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPollConvarRequest\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPollConvarRequest\>\(CMsgGCToClientPollConvarRequest, params CMsgGCToClientPollConvarRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest__ctor"></a> CMsgGCToClientPollConvarRequest\(\)

```csharp
public CMsgGCToClientPollConvarRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_"></a> CMsgGCToClientPollConvarRequest\(CMsgGCToClientPollConvarRequest\)

```csharp
public CMsgGCToClientPollConvarRequest(CMsgGCToClientPollConvarRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_ConvarNameFieldNumber"></a> ConvarNameFieldNumber

```csharp
public const int ConvarNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_PollIdFieldNumber"></a> PollIdFieldNumber

```csharp
public const int PollIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_ConvarName"></a> ConvarName

```csharp
public string ConvarName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_HasConvarName"></a> HasConvarName

```csharp
public bool HasConvarName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_HasPollId"></a> HasPollId

```csharp
public bool HasPollId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPollConvarRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_PollId"></a> PollId

```csharp
public uint PollId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_ClearConvarName"></a> ClearConvarName\(\)

```csharp
public void ClearConvarName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_ClearPollId"></a> ClearPollId\(\)

```csharp
public void ClearPollId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPollConvarRequest Clone()
```

#### Returns

 [CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_"></a> Equals\(CMsgGCToClientPollConvarRequest\)

```csharp
public bool Equals(CMsgGCToClientPollConvarRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_"></a> MergeFrom\(CMsgGCToClientPollConvarRequest\)

```csharp
public void MergeFrom(CMsgGCToClientPollConvarRequest other)
```

#### Parameters

`other` [CMsgGCToClientPollConvarRequest](Divine.Protobufs.Dota2.CMsgGCToClientPollConvarRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPollConvarRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

