# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse"></a> Class CMsgClientToGCDevGrantEventPointsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevGrantEventPointsResponse : IMessage<CMsgClientToGCDevGrantEventPointsResponse>, IEquatable<CMsgClientToGCDevGrantEventPointsResponse>, IDeepCloneable<CMsgClientToGCDevGrantEventPointsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)

#### Implements

IMessage<CMsgClientToGCDevGrantEventPointsResponse\>, 
[IEquatable<CMsgClientToGCDevGrantEventPointsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevGrantEventPointsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevGrantEventPointsResponse\>\(CMsgClientToGCDevGrantEventPointsResponse, params CMsgClientToGCDevGrantEventPointsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse__ctor"></a> CMsgClientToGCDevGrantEventPointsResponse\(\)

```csharp
public CMsgClientToGCDevGrantEventPointsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_"></a> CMsgClientToGCDevGrantEventPointsResponse\(CMsgClientToGCDevGrantEventPointsResponse\)

```csharp
public CMsgClientToGCDevGrantEventPointsResponse(CMsgClientToGCDevGrantEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevGrantEventPointsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Result"></a> Result

```csharp
public CMsgClientToGCDevGrantEventPointsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevGrantEventPointsResponse Clone()
```

#### Returns

 [CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_"></a> Equals\(CMsgClientToGCDevGrantEventPointsResponse\)

```csharp
public bool Equals(CMsgClientToGCDevGrantEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_"></a> MergeFrom\(CMsgClientToGCDevGrantEventPointsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDevGrantEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventPointsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

