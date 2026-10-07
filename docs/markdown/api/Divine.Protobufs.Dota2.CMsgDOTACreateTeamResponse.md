# <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse"></a> Class CMsgDOTACreateTeamResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACreateTeamResponse : IMessage<CMsgDOTACreateTeamResponse>, IEquatable<CMsgDOTACreateTeamResponse>, IDeepCloneable<CMsgDOTACreateTeamResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)

#### Implements

IMessage<CMsgDOTACreateTeamResponse\>, 
[IEquatable<CMsgDOTACreateTeamResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACreateTeamResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTACreateTeamResponse\>\(CMsgDOTACreateTeamResponse, params CMsgDOTACreateTeamResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse__ctor"></a> CMsgDOTACreateTeamResponse\(\)

```csharp
public CMsgDOTACreateTeamResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_"></a> CMsgDOTACreateTeamResponse\(CMsgDOTACreateTeamResponse\)

```csharp
public CMsgDOTACreateTeamResponse(CMsgDOTACreateTeamResponse other)
```

#### Parameters

`other` [CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACreateTeamResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Result"></a> Result

```csharp
public CMsgDOTACreateTeamResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACreateTeamResponse Clone()
```

#### Returns

 [CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_"></a> Equals\(CMsgDOTACreateTeamResponse\)

```csharp
public bool Equals(CMsgDOTACreateTeamResponse other)
```

#### Parameters

`other` [CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_"></a> MergeFrom\(CMsgDOTACreateTeamResponse\)

```csharp
public void MergeFrom(CMsgDOTACreateTeamResponse other)
```

#### Parameters

`other` [CMsgDOTACreateTeamResponse](Divine.Protobufs.Dota2.CMsgDOTACreateTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACreateTeamResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

