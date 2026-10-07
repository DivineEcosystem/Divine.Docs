# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse"></a> Class CMsgClientToGCDeclineInviteToGuildResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDeclineInviteToGuildResponse : IMessage<CMsgClientToGCDeclineInviteToGuildResponse>, IEquatable<CMsgClientToGCDeclineInviteToGuildResponse>, IDeepCloneable<CMsgClientToGCDeclineInviteToGuildResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)

#### Implements

IMessage<CMsgClientToGCDeclineInviteToGuildResponse\>, 
[IEquatable<CMsgClientToGCDeclineInviteToGuildResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDeclineInviteToGuildResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDeclineInviteToGuildResponse\>\(CMsgClientToGCDeclineInviteToGuildResponse, params CMsgClientToGCDeclineInviteToGuildResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse__ctor"></a> CMsgClientToGCDeclineInviteToGuildResponse\(\)

```csharp
public CMsgClientToGCDeclineInviteToGuildResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_"></a> CMsgClientToGCDeclineInviteToGuildResponse\(CMsgClientToGCDeclineInviteToGuildResponse\)

```csharp
public CMsgClientToGCDeclineInviteToGuildResponse(CMsgClientToGCDeclineInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDeclineInviteToGuildResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Result"></a> Result

```csharp
public CMsgClientToGCDeclineInviteToGuildResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDeclineInviteToGuildResponse Clone()
```

#### Returns

 [CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_"></a> Equals\(CMsgClientToGCDeclineInviteToGuildResponse\)

```csharp
public bool Equals(CMsgClientToGCDeclineInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_"></a> MergeFrom\(CMsgClientToGCDeclineInviteToGuildResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDeclineInviteToGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCDeclineInviteToGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCDeclineInviteToGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDeclineInviteToGuildResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

