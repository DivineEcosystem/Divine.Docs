# <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest"></a> Class CMsgSocialFeedRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSocialFeedRequest : IMessage<CMsgSocialFeedRequest>, IEquatable<CMsgSocialFeedRequest>, IDeepCloneable<CMsgSocialFeedRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)

#### Implements

IMessage<CMsgSocialFeedRequest\>, 
[IEquatable<CMsgSocialFeedRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSocialFeedRequest\>, 
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
[EnumerableExtensions.In<CMsgSocialFeedRequest\>\(CMsgSocialFeedRequest, params CMsgSocialFeedRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest__ctor"></a> CMsgSocialFeedRequest\(\)

```csharp
public CMsgSocialFeedRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest__ctor_Divine_Protobufs_Dota2_CMsgSocialFeedRequest_"></a> CMsgSocialFeedRequest\(CMsgSocialFeedRequest\)

```csharp
public CMsgSocialFeedRequest(CMsgSocialFeedRequest other)
```

#### Parameters

`other` [CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_SelfOnlyFieldNumber"></a> SelfOnlyFieldNumber

```csharp
public const int SelfOnlyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_HasSelfOnly"></a> HasSelfOnly

```csharp
public bool HasSelfOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSocialFeedRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_SelfOnly"></a> SelfOnly

```csharp
public bool SelfOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_ClearSelfOnly"></a> ClearSelfOnly\(\)

```csharp
public void ClearSelfOnly()
```

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_Clone"></a> Clone\(\)

```csharp
public CMsgSocialFeedRequest Clone()
```

#### Returns

 [CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_Equals_Divine_Protobufs_Dota2_CMsgSocialFeedRequest_"></a> Equals\(CMsgSocialFeedRequest\)

```csharp
public bool Equals(CMsgSocialFeedRequest other)
```

#### Parameters

`other` [CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgSocialFeedRequest_"></a> MergeFrom\(CMsgSocialFeedRequest\)

```csharp
public void MergeFrom(CMsgSocialFeedRequest other)
```

#### Parameters

`other` [CMsgSocialFeedRequest](Divine.Protobufs.Dota2.CMsgSocialFeedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSocialFeedRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

