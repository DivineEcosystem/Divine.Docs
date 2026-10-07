# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse"></a> Class CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse : IMessage<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse>, IEquatable<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse>, IDeepCloneable<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\>, 
[IEquatable<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\>\(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse, params CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse__ctor"></a> CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\(\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_"></a> CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_PlayerAccomplishmentsFieldNumber"></a> PlayerAccomplishmentsFieldNumber

```csharp
public const int PlayerAccomplishmentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_PlayerAccomplishments"></a> PlayerAccomplishments

```csharp
public CMsgPlayerRecentAccomplishments PlayerAccomplishments { get; set; }
```

#### Property Value

 [CMsgPlayerRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_"></a> Equals\(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_"></a> MergeFrom\(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerRecentAccomplishmentsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

