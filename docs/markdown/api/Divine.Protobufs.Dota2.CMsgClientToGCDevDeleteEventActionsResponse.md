# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse"></a> Class CMsgClientToGCDevDeleteEventActionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevDeleteEventActionsResponse : IMessage<CMsgClientToGCDevDeleteEventActionsResponse>, IEquatable<CMsgClientToGCDevDeleteEventActionsResponse>, IDeepCloneable<CMsgClientToGCDevDeleteEventActionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)

#### Implements

IMessage<CMsgClientToGCDevDeleteEventActionsResponse\>, 
[IEquatable<CMsgClientToGCDevDeleteEventActionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevDeleteEventActionsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevDeleteEventActionsResponse\>\(CMsgClientToGCDevDeleteEventActionsResponse, params CMsgClientToGCDevDeleteEventActionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse__ctor"></a> CMsgClientToGCDevDeleteEventActionsResponse\(\)

```csharp
public CMsgClientToGCDevDeleteEventActionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_"></a> CMsgClientToGCDevDeleteEventActionsResponse\(CMsgClientToGCDevDeleteEventActionsResponse\)

```csharp
public CMsgClientToGCDevDeleteEventActionsResponse(CMsgClientToGCDevDeleteEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevDeleteEventActionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Result"></a> Result

```csharp
public CMsgClientToGCDevDeleteEventActionsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevDeleteEventActionsResponse Clone()
```

#### Returns

 [CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_"></a> Equals\(CMsgClientToGCDevDeleteEventActionsResponse\)

```csharp
public bool Equals(CMsgClientToGCDevDeleteEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_"></a> MergeFrom\(CMsgClientToGCDevDeleteEventActionsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDevDeleteEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevDeleteEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevDeleteEventActionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevDeleteEventActionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

