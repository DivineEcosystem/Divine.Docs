# <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse"></a> Class CMsgFindGuildByTagResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgFindGuildByTagResponse : IMessage<CMsgFindGuildByTagResponse>, IEquatable<CMsgFindGuildByTagResponse>, IDeepCloneable<CMsgFindGuildByTagResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)

#### Implements

IMessage<CMsgFindGuildByTagResponse\>, 
[IEquatable<CMsgFindGuildByTagResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgFindGuildByTagResponse\>, 
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
[EnumerableExtensions.In<CMsgFindGuildByTagResponse\>\(CMsgFindGuildByTagResponse, params CMsgFindGuildByTagResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse__ctor"></a> CMsgFindGuildByTagResponse\(\)

```csharp
public CMsgFindGuildByTagResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse__ctor_Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_"></a> CMsgFindGuildByTagResponse\(CMsgFindGuildByTagResponse\)

```csharp
public CMsgFindGuildByTagResponse(CMsgFindGuildByTagResponse other)
```

#### Parameters

`other` [CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_GuildSummaryFieldNumber"></a> GuildSummaryFieldNumber

```csharp
public const int GuildSummaryFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_GuildSummary"></a> GuildSummary

```csharp
public CMsgGuildSummary GuildSummary { get; set; }
```

#### Property Value

 [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgFindGuildByTagResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Result"></a> Result

```csharp
public CMsgFindGuildByTagResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md).[Types](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Clone"></a> Clone\(\)

```csharp
public CMsgFindGuildByTagResponse Clone()
```

#### Returns

 [CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_Equals_Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_"></a> Equals\(CMsgFindGuildByTagResponse\)

```csharp
public bool Equals(CMsgFindGuildByTagResponse other)
```

#### Parameters

`other` [CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_"></a> MergeFrom\(CMsgFindGuildByTagResponse\)

```csharp
public void MergeFrom(CMsgFindGuildByTagResponse other)
```

#### Parameters

`other` [CMsgFindGuildByTagResponse](Divine.Protobufs.Dota2.CMsgFindGuildByTagResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgFindGuildByTagResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

