# <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse"></a> Class CMsgClientToGCJoinPlaytestResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCJoinPlaytestResponse : IMessage<CMsgClientToGCJoinPlaytestResponse>, IEquatable<CMsgClientToGCJoinPlaytestResponse>, IDeepCloneable<CMsgClientToGCJoinPlaytestResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)

#### Implements

IMessage<CMsgClientToGCJoinPlaytestResponse\>, 
[IEquatable<CMsgClientToGCJoinPlaytestResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCJoinPlaytestResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCJoinPlaytestResponse\>\(CMsgClientToGCJoinPlaytestResponse, params CMsgClientToGCJoinPlaytestResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse__ctor"></a> CMsgClientToGCJoinPlaytestResponse\(\)

```csharp
public CMsgClientToGCJoinPlaytestResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_"></a> CMsgClientToGCJoinPlaytestResponse\(CMsgClientToGCJoinPlaytestResponse\)

```csharp
public CMsgClientToGCJoinPlaytestResponse(CMsgClientToGCJoinPlaytestResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_ErrorFieldNumber"></a> ErrorFieldNumber

```csharp
public const int ErrorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Error"></a> Error

```csharp
public string Error { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_HasError"></a> HasError

```csharp
public bool HasError { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCJoinPlaytestResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_ClearError"></a> ClearError\(\)

```csharp
public void ClearError()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCJoinPlaytestResponse Clone()
```

#### Returns

 [CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_"></a> Equals\(CMsgClientToGCJoinPlaytestResponse\)

```csharp
public bool Equals(CMsgClientToGCJoinPlaytestResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_"></a> MergeFrom\(CMsgClientToGCJoinPlaytestResponse\)

```csharp
public void MergeFrom(CMsgClientToGCJoinPlaytestResponse other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytestResponse](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytestResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytestResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

