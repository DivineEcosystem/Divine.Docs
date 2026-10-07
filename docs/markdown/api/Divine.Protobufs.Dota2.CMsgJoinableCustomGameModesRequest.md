# <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest"></a> Class CMsgJoinableCustomGameModesRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgJoinableCustomGameModesRequest : IMessage<CMsgJoinableCustomGameModesRequest>, IEquatable<CMsgJoinableCustomGameModesRequest>, IDeepCloneable<CMsgJoinableCustomGameModesRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)

#### Implements

IMessage<CMsgJoinableCustomGameModesRequest\>, 
[IEquatable<CMsgJoinableCustomGameModesRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgJoinableCustomGameModesRequest\>, 
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
[EnumerableExtensions.In<CMsgJoinableCustomGameModesRequest\>\(CMsgJoinableCustomGameModesRequest, params CMsgJoinableCustomGameModesRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest__ctor"></a> CMsgJoinableCustomGameModesRequest\(\)

```csharp
public CMsgJoinableCustomGameModesRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest__ctor_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_"></a> CMsgJoinableCustomGameModesRequest\(CMsgJoinableCustomGameModesRequest\)

```csharp
public CMsgJoinableCustomGameModesRequest(CMsgJoinableCustomGameModesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_ServerRegionFieldNumber"></a> ServerRegionFieldNumber

```csharp
public const int ServerRegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_HasServerRegion"></a> HasServerRegion

```csharp
public bool HasServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgJoinableCustomGameModesRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_ServerRegion"></a> ServerRegion

```csharp
public uint ServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_ClearServerRegion"></a> ClearServerRegion\(\)

```csharp
public void ClearServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_Clone"></a> Clone\(\)

```csharp
public CMsgJoinableCustomGameModesRequest Clone()
```

#### Returns

 [CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_Equals_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_"></a> Equals\(CMsgJoinableCustomGameModesRequest\)

```csharp
public bool Equals(CMsgJoinableCustomGameModesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_"></a> MergeFrom\(CMsgJoinableCustomGameModesRequest\)

```csharp
public void MergeFrom(CMsgJoinableCustomGameModesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

