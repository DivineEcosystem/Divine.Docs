# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse"></a> Class CMsgClientToGCGetEventPointsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetEventPointsResponse : IMessage<CMsgClientToGCGetEventPointsResponse>, IEquatable<CMsgClientToGCGetEventPointsResponse>, IDeepCloneable<CMsgClientToGCGetEventPointsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)

#### Implements

IMessage<CMsgClientToGCGetEventPointsResponse\>, 
[IEquatable<CMsgClientToGCGetEventPointsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetEventPointsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetEventPointsResponse\>\(CMsgClientToGCGetEventPointsResponse, params CMsgClientToGCGetEventPointsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse__ctor"></a> CMsgClientToGCGetEventPointsResponse\(\)

```csharp
public CMsgClientToGCGetEventPointsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_"></a> CMsgClientToGCGetEventPointsResponse\(CMsgClientToGCGetEventPointsResponse\)

```csharp
public CMsgClientToGCGetEventPointsResponse(CMsgClientToGCGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_EventPoints"></a> EventPoints

```csharp
public CMsgUserEventPoints EventPoints { get; set; }
```

#### Property Value

 [CMsgUserEventPoints](Divine.Protobufs.Dota2.CMsgUserEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetEventPointsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetEventPointsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetEventPointsResponse Clone()
```

#### Returns

 [CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_"></a> Equals\(CMsgClientToGCGetEventPointsResponse\)

```csharp
public bool Equals(CMsgClientToGCGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_"></a> MergeFrom\(CMsgClientToGCGetEventPointsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetEventPointsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetEventPointsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetEventPointsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetEventPointsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

