# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse"></a> Class CMsgDOTAGetPeriodicResourceResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetPeriodicResourceResponse : IMessage<CMsgDOTAGetPeriodicResourceResponse>, IEquatable<CMsgDOTAGetPeriodicResourceResponse>, IDeepCloneable<CMsgDOTAGetPeriodicResourceResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

#### Implements

IMessage<CMsgDOTAGetPeriodicResourceResponse\>, 
[IEquatable<CMsgDOTAGetPeriodicResourceResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetPeriodicResourceResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetPeriodicResourceResponse\>\(CMsgDOTAGetPeriodicResourceResponse, params CMsgDOTAGetPeriodicResourceResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse__ctor"></a> CMsgDOTAGetPeriodicResourceResponse\(\)

```csharp
public CMsgDOTAGetPeriodicResourceResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_"></a> CMsgDOTAGetPeriodicResourceResponse\(CMsgDOTAGetPeriodicResourceResponse\)

```csharp
public CMsgDOTAGetPeriodicResourceResponse(CMsgDOTAGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_PeriodicResourceMaxFieldNumber"></a> PeriodicResourceMaxFieldNumber

```csharp
public const int PeriodicResourceMaxFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_PeriodicResourceUsedFieldNumber"></a> PeriodicResourceUsedFieldNumber

```csharp
public const int PeriodicResourceUsedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_HasPeriodicResourceMax"></a> HasPeriodicResourceMax

```csharp
public bool HasPeriodicResourceMax { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_HasPeriodicResourceUsed"></a> HasPeriodicResourceUsed

```csharp
public bool HasPeriodicResourceUsed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetPeriodicResourceResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_PeriodicResourceMax"></a> PeriodicResourceMax

```csharp
public uint PeriodicResourceMax { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_PeriodicResourceUsed"></a> PeriodicResourceUsed

```csharp
public uint PeriodicResourceUsed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_ClearPeriodicResourceMax"></a> ClearPeriodicResourceMax\(\)

```csharp
public void ClearPeriodicResourceMax()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_ClearPeriodicResourceUsed"></a> ClearPeriodicResourceUsed\(\)

```csharp
public void ClearPeriodicResourceUsed()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetPeriodicResourceResponse Clone()
```

#### Returns

 [CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_"></a> Equals\(CMsgDOTAGetPeriodicResourceResponse\)

```csharp
public bool Equals(CMsgDOTAGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_"></a> MergeFrom\(CMsgDOTAGetPeriodicResourceResponse\)

```csharp
public void MergeFrom(CMsgDOTAGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResourceResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResourceResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

