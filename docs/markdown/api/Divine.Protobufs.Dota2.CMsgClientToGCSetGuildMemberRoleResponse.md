# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse"></a> Class CMsgClientToGCSetGuildMemberRoleResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetGuildMemberRoleResponse : IMessage<CMsgClientToGCSetGuildMemberRoleResponse>, IEquatable<CMsgClientToGCSetGuildMemberRoleResponse>, IDeepCloneable<CMsgClientToGCSetGuildMemberRoleResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)

#### Implements

IMessage<CMsgClientToGCSetGuildMemberRoleResponse\>, 
[IEquatable<CMsgClientToGCSetGuildMemberRoleResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetGuildMemberRoleResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetGuildMemberRoleResponse\>\(CMsgClientToGCSetGuildMemberRoleResponse, params CMsgClientToGCSetGuildMemberRoleResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse__ctor"></a> CMsgClientToGCSetGuildMemberRoleResponse\(\)

```csharp
public CMsgClientToGCSetGuildMemberRoleResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_"></a> CMsgClientToGCSetGuildMemberRoleResponse\(CMsgClientToGCSetGuildMemberRoleResponse\)

```csharp
public CMsgClientToGCSetGuildMemberRoleResponse(CMsgClientToGCSetGuildMemberRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetGuildMemberRoleResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Result"></a> Result

```csharp
public CMsgClientToGCSetGuildMemberRoleResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetGuildMemberRoleResponse Clone()
```

#### Returns

 [CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_"></a> Equals\(CMsgClientToGCSetGuildMemberRoleResponse\)

```csharp
public bool Equals(CMsgClientToGCSetGuildMemberRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_"></a> MergeFrom\(CMsgClientToGCSetGuildMemberRoleResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetGuildMemberRoleResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildMemberRoleResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildMemberRoleResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildMemberRoleResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

