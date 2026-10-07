# <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest"></a> Class CMsgJoinableCustomLobbiesRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgJoinableCustomLobbiesRequest : IMessage<CMsgJoinableCustomLobbiesRequest>, IEquatable<CMsgJoinableCustomLobbiesRequest>, IDeepCloneable<CMsgJoinableCustomLobbiesRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)

#### Implements

IMessage<CMsgJoinableCustomLobbiesRequest\>, 
[IEquatable<CMsgJoinableCustomLobbiesRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgJoinableCustomLobbiesRequest\>, 
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
[EnumerableExtensions.In<CMsgJoinableCustomLobbiesRequest\>\(CMsgJoinableCustomLobbiesRequest, params CMsgJoinableCustomLobbiesRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest__ctor"></a> CMsgJoinableCustomLobbiesRequest\(\)

```csharp
public CMsgJoinableCustomLobbiesRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest__ctor_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_"></a> CMsgJoinableCustomLobbiesRequest\(CMsgJoinableCustomLobbiesRequest\)

```csharp
public CMsgJoinableCustomLobbiesRequest(CMsgJoinableCustomLobbiesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_CustomGameIdFieldNumber"></a> CustomGameIdFieldNumber

```csharp
public const int CustomGameIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_ServerRegionFieldNumber"></a> ServerRegionFieldNumber

```csharp
public const int ServerRegionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_CustomGameId"></a> CustomGameId

```csharp
public ulong CustomGameId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_HasCustomGameId"></a> HasCustomGameId

```csharp
public bool HasCustomGameId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_HasServerRegion"></a> HasServerRegion

```csharp
public bool HasServerRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgJoinableCustomLobbiesRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_ServerRegion"></a> ServerRegion

```csharp
public uint ServerRegion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_ClearCustomGameId"></a> ClearCustomGameId\(\)

```csharp
public void ClearCustomGameId()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_ClearServerRegion"></a> ClearServerRegion\(\)

```csharp
public void ClearServerRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_Clone"></a> Clone\(\)

```csharp
public CMsgJoinableCustomLobbiesRequest Clone()
```

#### Returns

 [CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_Equals_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_"></a> Equals\(CMsgJoinableCustomLobbiesRequest\)

```csharp
public bool Equals(CMsgJoinableCustomLobbiesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_"></a> MergeFrom\(CMsgJoinableCustomLobbiesRequest\)

```csharp
public void MergeFrom(CMsgJoinableCustomLobbiesRequest other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesRequest](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

