# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse"></a> Class CMsgDOTASubmitPlayerAvoidRequestResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerAvoidRequestResponse : IMessage<CMsgDOTASubmitPlayerAvoidRequestResponse>, IEquatable<CMsgDOTASubmitPlayerAvoidRequestResponse>, IDeepCloneable<CMsgDOTASubmitPlayerAvoidRequestResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerAvoidRequestResponse\>, 
[IEquatable<CMsgDOTASubmitPlayerAvoidRequestResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerAvoidRequestResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerAvoidRequestResponse\>\(CMsgDOTASubmitPlayerAvoidRequestResponse, params CMsgDOTASubmitPlayerAvoidRequestResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse__ctor"></a> CMsgDOTASubmitPlayerAvoidRequestResponse\(\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequestResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_"></a> CMsgDOTASubmitPlayerAvoidRequestResponse\(CMsgDOTASubmitPlayerAvoidRequestResponse\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequestResponse(CMsgDOTASubmitPlayerAvoidRequestResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_DebugMessageFieldNumber"></a> DebugMessageFieldNumber

```csharp
public const int DebugMessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_DebugMessage"></a> DebugMessage

```csharp
public string DebugMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_HasDebugMessage"></a> HasDebugMessage

```csharp
public bool HasDebugMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerAvoidRequestResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_ClearDebugMessage"></a> ClearDebugMessage\(\)

```csharp
public void ClearDebugMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequestResponse Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_"></a> Equals\(CMsgDOTASubmitPlayerAvoidRequestResponse\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerAvoidRequestResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_"></a> MergeFrom\(CMsgDOTASubmitPlayerAvoidRequestResponse\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerAvoidRequestResponse other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequestResponse](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequestResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

