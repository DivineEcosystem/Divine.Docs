# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse"></a> Class CMsgClientToGCShowcaseSetUserDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseSetUserDataResponse : IMessage<CMsgClientToGCShowcaseSetUserDataResponse>, IEquatable<CMsgClientToGCShowcaseSetUserDataResponse>, IDeepCloneable<CMsgClientToGCShowcaseSetUserDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)

#### Implements

IMessage<CMsgClientToGCShowcaseSetUserDataResponse\>, 
[IEquatable<CMsgClientToGCShowcaseSetUserDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseSetUserDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseSetUserDataResponse\>\(CMsgClientToGCShowcaseSetUserDataResponse, params CMsgClientToGCShowcaseSetUserDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse__ctor"></a> CMsgClientToGCShowcaseSetUserDataResponse\(\)

```csharp
public CMsgClientToGCShowcaseSetUserDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_"></a> CMsgClientToGCShowcaseSetUserDataResponse\(CMsgClientToGCShowcaseSetUserDataResponse\)

```csharp
public CMsgClientToGCShowcaseSetUserDataResponse(CMsgClientToGCShowcaseSetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_LockedUntilTimestampFieldNumber"></a> LockedUntilTimestampFieldNumber

```csharp
public const int LockedUntilTimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ValidatedShowcaseFieldNumber"></a> ValidatedShowcaseFieldNumber

```csharp
public const int ValidatedShowcaseFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_HasLockedUntilTimestamp"></a> HasLockedUntilTimestamp

```csharp
public bool HasLockedUntilTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_LockedUntilTimestamp"></a> LockedUntilTimestamp

```csharp
public uint LockedUntilTimestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseSetUserDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCShowcaseSetUserDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ValidatedShowcase"></a> ValidatedShowcase

```csharp
public CMsgShowcase ValidatedShowcase { get; set; }
```

#### Property Value

 [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ClearLockedUntilTimestamp"></a> ClearLockedUntilTimestamp\(\)

```csharp
public void ClearLockedUntilTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseSetUserDataResponse Clone()
```

#### Returns

 [CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_"></a> Equals\(CMsgClientToGCShowcaseSetUserDataResponse\)

```csharp
public bool Equals(CMsgClientToGCShowcaseSetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_"></a> MergeFrom\(CMsgClientToGCShowcaseSetUserDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseSetUserDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseSetUserDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseSetUserDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseSetUserDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

