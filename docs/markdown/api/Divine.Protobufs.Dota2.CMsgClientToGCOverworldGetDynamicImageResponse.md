# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse"></a> Class CMsgClientToGCOverworldGetDynamicImageResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldGetDynamicImageResponse : IMessage<CMsgClientToGCOverworldGetDynamicImageResponse>, IEquatable<CMsgClientToGCOverworldGetDynamicImageResponse>, IDeepCloneable<CMsgClientToGCOverworldGetDynamicImageResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)

#### Implements

IMessage<CMsgClientToGCOverworldGetDynamicImageResponse\>, 
[IEquatable<CMsgClientToGCOverworldGetDynamicImageResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldGetDynamicImageResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldGetDynamicImageResponse\>\(CMsgClientToGCOverworldGetDynamicImageResponse, params CMsgClientToGCOverworldGetDynamicImageResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse__ctor"></a> CMsgClientToGCOverworldGetDynamicImageResponse\(\)

```csharp
public CMsgClientToGCOverworldGetDynamicImageResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_"></a> CMsgClientToGCOverworldGetDynamicImageResponse\(CMsgClientToGCOverworldGetDynamicImageResponse\)

```csharp
public CMsgClientToGCOverworldGetDynamicImageResponse(CMsgClientToGCOverworldGetDynamicImageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_ImageIdFieldNumber"></a> ImageIdFieldNumber

```csharp
public const int ImageIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_ImagesFieldNumber"></a> ImagesFieldNumber

```csharp
public const int ImagesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_HasImageId"></a> HasImageId

```csharp
public bool HasImageId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_ImageId"></a> ImageId

```csharp
public uint ImageId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Images"></a> Images

```csharp
public RepeatedField<CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image> Images { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.md).[Image](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.Types.Image.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldGetDynamicImageResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_ClearImageId"></a> ClearImageId\(\)

```csharp
public void ClearImageId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldGetDynamicImageResponse Clone()
```

#### Returns

 [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_"></a> Equals\(CMsgClientToGCOverworldGetDynamicImageResponse\)

```csharp
public bool Equals(CMsgClientToGCOverworldGetDynamicImageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_"></a> MergeFrom\(CMsgClientToGCOverworldGetDynamicImageResponse\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldGetDynamicImageResponse other)
```

#### Parameters

`other` [CMsgClientToGCOverworldGetDynamicImageResponse](Divine.Protobufs.Dota2.CMsgClientToGCOverworldGetDynamicImageResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldGetDynamicImageResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

