# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse"></a> Class CMsgClientToGCRequestGuildDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestGuildDataResponse : IMessage<CMsgClientToGCRequestGuildDataResponse>, IEquatable<CMsgClientToGCRequestGuildDataResponse>, IDeepCloneable<CMsgClientToGCRequestGuildDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestGuildDataResponse\>, 
[IEquatable<CMsgClientToGCRequestGuildDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestGuildDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestGuildDataResponse\>\(CMsgClientToGCRequestGuildDataResponse, params CMsgClientToGCRequestGuildDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse__ctor"></a> CMsgClientToGCRequestGuildDataResponse\(\)

```csharp
public CMsgClientToGCRequestGuildDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_"></a> CMsgClientToGCRequestGuildDataResponse\(CMsgClientToGCRequestGuildDataResponse\)

```csharp
public CMsgClientToGCRequestGuildDataResponse(CMsgClientToGCRequestGuildDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_GuildDataFieldNumber"></a> GuildDataFieldNumber

```csharp
public const int GuildDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_GuildData"></a> GuildData

```csharp
public CMsgGuildData GuildData { get; set; }
```

#### Property Value

 [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestGuildDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestGuildDataResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestGuildDataResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_"></a> Equals\(CMsgClientToGCRequestGuildDataResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestGuildDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_"></a> MergeFrom\(CMsgClientToGCRequestGuildDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestGuildDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

