# <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse"></a> Class CMsgClientToGCAddGuildRoleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCAddGuildRoleResponse : IMessage<CMsgClientToGCAddGuildRoleResponse>, IEquatable<CMsgClientToGCAddGuildRoleResponse>, IDeepCloneable<CMsgClientToGCAddGuildRoleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)

#### Implements

IMessage<CMsgClientToGCAddGuildRoleResponse\>, 
[IEquatable<CMsgClientToGCAddGuildRoleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCAddGuildRoleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCAddGuildRoleResponse\>\(CMsgClientToGCAddGuildRoleResponse, params CMsgClientToGCAddGuildRoleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse__ctor"></a> CMsgClientToGCAddGuildRoleResponse\(\)

```csharp
public CMsgClientToGCAddGuildRoleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_"></a> CMsgClientToGCAddGuildRoleResponse\(CMsgClientToGCAddGuildRoleResponse\)

```csharp
public CMsgClientToGCAddGuildRoleResponse(CMsgClientToGCAddGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_RoleIdFieldNumber"></a> RoleIdFieldNumber

```csharp
public const int RoleIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_HasRoleId"></a> HasRoleId

```csharp
public bool HasRoleId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCAddGuildRoleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Result"></a> Result

```csharp
public CMsgClientToGCAddGuildRoleResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_RoleId"></a> RoleId

```csharp
public uint RoleId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_ClearRoleId"></a> ClearRoleId\(\)

```csharp
public void ClearRoleId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCAddGuildRoleResponse Clone()
```

#### Returns

 [CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_"></a> Equals\(CMsgClientToGCAddGuildRoleResponse\)

```csharp
public bool Equals(CMsgClientToGCAddGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_"></a> MergeFrom\(CMsgClientToGCAddGuildRoleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCAddGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCAddGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCAddGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAddGuildRoleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

