# <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse"></a> Class CMsgClientToGCTeammateStatsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCTeammateStatsResponse : IMessage<CMsgClientToGCTeammateStatsResponse>, IEquatable<CMsgClientToGCTeammateStatsResponse>, IDeepCloneable<CMsgClientToGCTeammateStatsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)

#### Implements

IMessage<CMsgClientToGCTeammateStatsResponse\>, 
[IEquatable<CMsgClientToGCTeammateStatsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCTeammateStatsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCTeammateStatsResponse\>\(CMsgClientToGCTeammateStatsResponse, params CMsgClientToGCTeammateStatsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse__ctor"></a> CMsgClientToGCTeammateStatsResponse\(\)

```csharp
public CMsgClientToGCTeammateStatsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_"></a> CMsgClientToGCTeammateStatsResponse\(CMsgClientToGCTeammateStatsResponse\)

```csharp
public CMsgClientToGCTeammateStatsResponse(CMsgClientToGCTeammateStatsResponse other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_TeammateStatsFieldNumber"></a> TeammateStatsFieldNumber

```csharp
public const int TeammateStatsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCTeammateStatsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_TeammateStats"></a> TeammateStats

```csharp
public RepeatedField<CMsgClientToGCTeammateStatsResponse.Types.TeammateStat> TeammateStats { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.md).[TeammateStat](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.Types.TeammateStat.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCTeammateStatsResponse Clone()
```

#### Returns

 [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_"></a> Equals\(CMsgClientToGCTeammateStatsResponse\)

```csharp
public bool Equals(CMsgClientToGCTeammateStatsResponse other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_"></a> MergeFrom\(CMsgClientToGCTeammateStatsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCTeammateStatsResponse other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsResponse](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

