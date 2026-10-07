# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse"></a> Class CMsgClientToGCMonsterHunterDevResetAllResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMonsterHunterDevResetAllResponse : IMessage<CMsgClientToGCMonsterHunterDevResetAllResponse>, IEquatable<CMsgClientToGCMonsterHunterDevResetAllResponse>, IDeepCloneable<CMsgClientToGCMonsterHunterDevResetAllResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)

#### Implements

IMessage<CMsgClientToGCMonsterHunterDevResetAllResponse\>, 
[IEquatable<CMsgClientToGCMonsterHunterDevResetAllResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMonsterHunterDevResetAllResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMonsterHunterDevResetAllResponse\>\(CMsgClientToGCMonsterHunterDevResetAllResponse, params CMsgClientToGCMonsterHunterDevResetAllResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse__ctor"></a> CMsgClientToGCMonsterHunterDevResetAllResponse\(\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAllResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_"></a> CMsgClientToGCMonsterHunterDevResetAllResponse\(CMsgClientToGCMonsterHunterDevResetAllResponse\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAllResponse(CMsgClientToGCMonsterHunterDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMonsterHunterDevResetAllResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Response"></a> Response

```csharp
public CMsgClientToGCMonsterHunterDevResetAllResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMonsterHunterDevResetAllResponse Clone()
```

#### Returns

 [CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_"></a> Equals\(CMsgClientToGCMonsterHunterDevResetAllResponse\)

```csharp
public bool Equals(CMsgClientToGCMonsterHunterDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_"></a> MergeFrom\(CMsgClientToGCMonsterHunterDevResetAllResponse\)

```csharp
public void MergeFrom(CMsgClientToGCMonsterHunterDevResetAllResponse other)
```

#### Parameters

`other` [CMsgClientToGCMonsterHunterDevResetAllResponse](Divine.Protobufs.Dota2.CMsgClientToGCMonsterHunterDevResetAllResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMonsterHunterDevResetAllResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

