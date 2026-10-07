# <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse"></a> Class CMsgClientToGCModifyGuildRoleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCModifyGuildRoleResponse : IMessage<CMsgClientToGCModifyGuildRoleResponse>, IEquatable<CMsgClientToGCModifyGuildRoleResponse>, IDeepCloneable<CMsgClientToGCModifyGuildRoleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)

#### Implements

IMessage<CMsgClientToGCModifyGuildRoleResponse\>, 
[IEquatable<CMsgClientToGCModifyGuildRoleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCModifyGuildRoleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCModifyGuildRoleResponse\>\(CMsgClientToGCModifyGuildRoleResponse, params CMsgClientToGCModifyGuildRoleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse__ctor"></a> CMsgClientToGCModifyGuildRoleResponse\(\)

```csharp
public CMsgClientToGCModifyGuildRoleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_"></a> CMsgClientToGCModifyGuildRoleResponse\(CMsgClientToGCModifyGuildRoleResponse\)

```csharp
public CMsgClientToGCModifyGuildRoleResponse(CMsgClientToGCModifyGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCModifyGuildRoleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Result"></a> Result

```csharp
public CMsgClientToGCModifyGuildRoleResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCModifyGuildRoleResponse Clone()
```

#### Returns

 [CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_"></a> Equals\(CMsgClientToGCModifyGuildRoleResponse\)

```csharp
public bool Equals(CMsgClientToGCModifyGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_"></a> MergeFrom\(CMsgClientToGCModifyGuildRoleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCModifyGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCModifyGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCModifyGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCModifyGuildRoleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

