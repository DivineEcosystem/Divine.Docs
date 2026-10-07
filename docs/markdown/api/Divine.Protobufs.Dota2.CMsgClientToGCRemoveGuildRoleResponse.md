# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse"></a> Class CMsgClientToGCRemoveGuildRoleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRemoveGuildRoleResponse : IMessage<CMsgClientToGCRemoveGuildRoleResponse>, IEquatable<CMsgClientToGCRemoveGuildRoleResponse>, IDeepCloneable<CMsgClientToGCRemoveGuildRoleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)

#### Implements

IMessage<CMsgClientToGCRemoveGuildRoleResponse\>, 
[IEquatable<CMsgClientToGCRemoveGuildRoleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRemoveGuildRoleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRemoveGuildRoleResponse\>\(CMsgClientToGCRemoveGuildRoleResponse, params CMsgClientToGCRemoveGuildRoleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse__ctor"></a> CMsgClientToGCRemoveGuildRoleResponse\(\)

```csharp
public CMsgClientToGCRemoveGuildRoleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_"></a> CMsgClientToGCRemoveGuildRoleResponse\(CMsgClientToGCRemoveGuildRoleResponse\)

```csharp
public CMsgClientToGCRemoveGuildRoleResponse(CMsgClientToGCRemoveGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRemoveGuildRoleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Result"></a> Result

```csharp
public CMsgClientToGCRemoveGuildRoleResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRemoveGuildRoleResponse Clone()
```

#### Returns

 [CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_"></a> Equals\(CMsgClientToGCRemoveGuildRoleResponse\)

```csharp
public bool Equals(CMsgClientToGCRemoveGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_"></a> MergeFrom\(CMsgClientToGCRemoveGuildRoleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRemoveGuildRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCRemoveGuildRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCRemoveGuildRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRemoveGuildRoleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

