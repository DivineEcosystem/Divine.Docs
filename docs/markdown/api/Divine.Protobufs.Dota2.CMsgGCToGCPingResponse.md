# <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse"></a> Class CMsgGCToGCPingResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCPingResponse : IMessage<CMsgGCToGCPingResponse>, IEquatable<CMsgGCToGCPingResponse>, IDeepCloneable<CMsgGCToGCPingResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)

#### Implements

IMessage<CMsgGCToGCPingResponse\>, 
[IEquatable<CMsgGCToGCPingResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCPingResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToGCPingResponse\>\(CMsgGCToGCPingResponse, params CMsgGCToGCPingResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse__ctor"></a> CMsgGCToGCPingResponse\(\)

```csharp
public CMsgGCToGCPingResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_"></a> CMsgGCToGCPingResponse\(CMsgGCToGCPingResponse\)

```csharp
public CMsgGCToGCPingResponse(CMsgGCToGCPingResponse other)
```

#### Parameters

`other` [CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCPingResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCPingResponse Clone()
```

#### Returns

 [CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_"></a> Equals\(CMsgGCToGCPingResponse\)

```csharp
public bool Equals(CMsgGCToGCPingResponse other)
```

#### Parameters

`other` [CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_"></a> MergeFrom\(CMsgGCToGCPingResponse\)

```csharp
public void MergeFrom(CMsgGCToGCPingResponse other)
```

#### Parameters

`other` [CMsgGCToGCPingResponse](Divine.Protobufs.Dota2.CMsgGCToGCPingResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

