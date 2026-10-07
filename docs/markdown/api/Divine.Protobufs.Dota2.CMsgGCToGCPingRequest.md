# <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest"></a> Class CMsgGCToGCPingRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCPingRequest : IMessage<CMsgGCToGCPingRequest>, IEquatable<CMsgGCToGCPingRequest>, IDeepCloneable<CMsgGCToGCPingRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)

#### Implements

IMessage<CMsgGCToGCPingRequest\>, 
[IEquatable<CMsgGCToGCPingRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCPingRequest\>, 
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
[EnumerableExtensions.In<CMsgGCToGCPingRequest\>\(CMsgGCToGCPingRequest, params CMsgGCToGCPingRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest__ctor"></a> CMsgGCToGCPingRequest\(\)

```csharp
public CMsgGCToGCPingRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest__ctor_Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_"></a> CMsgGCToGCPingRequest\(CMsgGCToGCPingRequest\)

```csharp
public CMsgGCToGCPingRequest(CMsgGCToGCPingRequest other)
```

#### Parameters

`other` [CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCPingRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCPingRequest Clone()
```

#### Returns

 [CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_Equals_Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_"></a> Equals\(CMsgGCToGCPingRequest\)

```csharp
public bool Equals(CMsgGCToGCPingRequest other)
```

#### Parameters

`other` [CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_"></a> MergeFrom\(CMsgGCToGCPingRequest\)

```csharp
public void MergeFrom(CMsgGCToGCPingRequest other)
```

#### Parameters

`other` [CMsgGCToGCPingRequest](Divine.Protobufs.Dota2.CMsgGCToGCPingRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPingRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

