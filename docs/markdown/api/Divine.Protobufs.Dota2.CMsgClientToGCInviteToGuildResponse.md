# <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse"></a> Class CMsgClientToGCInviteToGuildResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCInviteToGuildResponse : IMessage<CMsgClientToGCInviteToGuildResponse>, IEquatable<CMsgClientToGCInviteToGuildResponse>, IDeepCloneable<CMsgClientToGCInviteToGuildResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)

#### Implements

IMessage<CMsgClientToGCInviteToGuildResponse\>, 
[IEquatable<CMsgClientToGCInviteToGuildResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCInviteToGuildResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCInviteToGuildResponse\>\(CMsgClientToGCInviteToGuildResponse, params CMsgClientToGCInviteToGuildResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse__ctor"></a> CMsgClientToGCInviteToGuildResponse\(\)

```csharp
public CMsgClientToGCInviteToGuildResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_"></a> CMsgClientToGCInviteToGuildResponse\(CMsgClientToGCInviteToGuildResponse\)

```csharp
public CMsgClientToGCInviteToGuildResponse(CMsgClientToGCInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCInviteToGuildResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Result"></a> Result

```csharp
public CMsgClientToGCInviteToGuildResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCInviteToGuildResponse Clone()
```

#### Returns

 [CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_"></a> Equals\(CMsgClientToGCInviteToGuildResponse\)

```csharp
public bool Equals(CMsgClientToGCInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_"></a> MergeFrom\(CMsgClientToGCInviteToGuildResponse\)

```csharp
public void MergeFrom(CMsgClientToGCInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToGuildResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

