# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse"></a> Class CMsgClientToGCCreateTeamPlayerCardPackResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCreateTeamPlayerCardPackResponse : IMessage<CMsgClientToGCCreateTeamPlayerCardPackResponse>, IEquatable<CMsgClientToGCCreateTeamPlayerCardPackResponse>, IDeepCloneable<CMsgClientToGCCreateTeamPlayerCardPackResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)

#### Implements

IMessage<CMsgClientToGCCreateTeamPlayerCardPackResponse\>, 
[IEquatable<CMsgClientToGCCreateTeamPlayerCardPackResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCreateTeamPlayerCardPackResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCreateTeamPlayerCardPackResponse\>\(CMsgClientToGCCreateTeamPlayerCardPackResponse, params CMsgClientToGCCreateTeamPlayerCardPackResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse__ctor"></a> CMsgClientToGCCreateTeamPlayerCardPackResponse\(\)

```csharp
public CMsgClientToGCCreateTeamPlayerCardPackResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_"></a> CMsgClientToGCCreateTeamPlayerCardPackResponse\(CMsgClientToGCCreateTeamPlayerCardPackResponse\)

```csharp
public CMsgClientToGCCreateTeamPlayerCardPackResponse(CMsgClientToGCCreateTeamPlayerCardPackResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCreateTeamPlayerCardPackResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Result"></a> Result

```csharp
public CMsgClientToGCCreateTeamPlayerCardPackResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCreateTeamPlayerCardPackResponse Clone()
```

#### Returns

 [CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_"></a> Equals\(CMsgClientToGCCreateTeamPlayerCardPackResponse\)

```csharp
public bool Equals(CMsgClientToGCCreateTeamPlayerCardPackResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_"></a> MergeFrom\(CMsgClientToGCCreateTeamPlayerCardPackResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCreateTeamPlayerCardPackResponse other)
```

#### Parameters

`other` [CMsgClientToGCCreateTeamPlayerCardPackResponse](Divine.Protobufs.Dota2.CMsgClientToGCCreateTeamPlayerCardPackResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCreateTeamPlayerCardPackResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

