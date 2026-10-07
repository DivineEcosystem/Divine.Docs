# <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse"></a> Class CMsgJoinableCustomLobbiesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgJoinableCustomLobbiesResponse : IMessage<CMsgJoinableCustomLobbiesResponse>, IEquatable<CMsgJoinableCustomLobbiesResponse>, IDeepCloneable<CMsgJoinableCustomLobbiesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)

#### Implements

IMessage<CMsgJoinableCustomLobbiesResponse\>, 
[IEquatable<CMsgJoinableCustomLobbiesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgJoinableCustomLobbiesResponse\>, 
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
[EnumerableExtensions.In<CMsgJoinableCustomLobbiesResponse\>\(CMsgJoinableCustomLobbiesResponse, params CMsgJoinableCustomLobbiesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse__ctor"></a> CMsgJoinableCustomLobbiesResponse\(\)

```csharp
public CMsgJoinableCustomLobbiesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse__ctor_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_"></a> CMsgJoinableCustomLobbiesResponse\(CMsgJoinableCustomLobbiesResponse\)

```csharp
public CMsgJoinableCustomLobbiesResponse(CMsgJoinableCustomLobbiesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_LobbiesFieldNumber"></a> LobbiesFieldNumber

```csharp
public const int LobbiesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Lobbies"></a> Lobbies

```csharp
public RepeatedField<CMsgJoinableCustomLobbiesResponseEntry> Lobbies { get; }
```

#### Property Value

 RepeatedField<[CMsgJoinableCustomLobbiesResponseEntry](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponseEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgJoinableCustomLobbiesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgJoinableCustomLobbiesResponse Clone()
```

#### Returns

 [CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_Equals_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_"></a> Equals\(CMsgJoinableCustomLobbiesResponse\)

```csharp
public bool Equals(CMsgJoinableCustomLobbiesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_"></a> MergeFrom\(CMsgJoinableCustomLobbiesResponse\)

```csharp
public void MergeFrom(CMsgJoinableCustomLobbiesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomLobbiesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomLobbiesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomLobbiesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

