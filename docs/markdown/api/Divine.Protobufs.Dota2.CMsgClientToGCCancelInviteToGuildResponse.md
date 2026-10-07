# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse"></a> Class CMsgClientToGCCancelInviteToGuildResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCancelInviteToGuildResponse : IMessage<CMsgClientToGCCancelInviteToGuildResponse>, IEquatable<CMsgClientToGCCancelInviteToGuildResponse>, IDeepCloneable<CMsgClientToGCCancelInviteToGuildResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)

#### Implements

IMessage<CMsgClientToGCCancelInviteToGuildResponse\>, 
[IEquatable<CMsgClientToGCCancelInviteToGuildResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCancelInviteToGuildResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCancelInviteToGuildResponse\>\(CMsgClientToGCCancelInviteToGuildResponse, params CMsgClientToGCCancelInviteToGuildResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse__ctor"></a> CMsgClientToGCCancelInviteToGuildResponse\(\)

```csharp
public CMsgClientToGCCancelInviteToGuildResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_"></a> CMsgClientToGCCancelInviteToGuildResponse\(CMsgClientToGCCancelInviteToGuildResponse\)

```csharp
public CMsgClientToGCCancelInviteToGuildResponse(CMsgClientToGCCancelInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCancelInviteToGuildResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Result"></a> Result

```csharp
public CMsgClientToGCCancelInviteToGuildResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCancelInviteToGuildResponse Clone()
```

#### Returns

 [CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_"></a> Equals\(CMsgClientToGCCancelInviteToGuildResponse\)

```csharp
public bool Equals(CMsgClientToGCCancelInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_"></a> MergeFrom\(CMsgClientToGCCancelInviteToGuildResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCancelInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCCancelInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCCancelInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCancelInviteToGuildResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

