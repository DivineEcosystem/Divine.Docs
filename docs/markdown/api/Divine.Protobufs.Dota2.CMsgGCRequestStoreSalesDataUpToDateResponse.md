# <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse"></a> Class CMsgGCRequestStoreSalesDataUpToDateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRequestStoreSalesDataUpToDateResponse : IMessage<CMsgGCRequestStoreSalesDataUpToDateResponse>, IEquatable<CMsgGCRequestStoreSalesDataUpToDateResponse>, IDeepCloneable<CMsgGCRequestStoreSalesDataUpToDateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)

#### Implements

IMessage<CMsgGCRequestStoreSalesDataUpToDateResponse\>, 
[IEquatable<CMsgGCRequestStoreSalesDataUpToDateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRequestStoreSalesDataUpToDateResponse\>, 
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
[EnumerableExtensions.In<CMsgGCRequestStoreSalesDataUpToDateResponse\>\(CMsgGCRequestStoreSalesDataUpToDateResponse, params CMsgGCRequestStoreSalesDataUpToDateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse__ctor"></a> CMsgGCRequestStoreSalesDataUpToDateResponse\(\)

```csharp
public CMsgGCRequestStoreSalesDataUpToDateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse__ctor_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_"></a> CMsgGCRequestStoreSalesDataUpToDateResponse\(CMsgGCRequestStoreSalesDataUpToDateResponse\)

```csharp
public CMsgGCRequestStoreSalesDataUpToDateResponse(CMsgGCRequestStoreSalesDataUpToDateResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_ExpirationTimeFieldNumber"></a> ExpirationTimeFieldNumber

```csharp
public const int ExpirationTimeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_ExpirationTime"></a> ExpirationTime

```csharp
public uint ExpirationTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_HasExpirationTime"></a> HasExpirationTime

```csharp
public bool HasExpirationTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRequestStoreSalesDataUpToDateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_ClearExpirationTime"></a> ClearExpirationTime\(\)

```csharp
public void ClearExpirationTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCRequestStoreSalesDataUpToDateResponse Clone()
```

#### Returns

 [CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_Equals_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_"></a> Equals\(CMsgGCRequestStoreSalesDataUpToDateResponse\)

```csharp
public bool Equals(CMsgGCRequestStoreSalesDataUpToDateResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_"></a> MergeFrom\(CMsgGCRequestStoreSalesDataUpToDateResponse\)

```csharp
public void MergeFrom(CMsgGCRequestStoreSalesDataUpToDateResponse other)
```

#### Parameters

`other` [CMsgGCRequestStoreSalesDataUpToDateResponse](Divine.Protobufs.Dota2.CMsgGCRequestStoreSalesDataUpToDateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRequestStoreSalesDataUpToDateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

