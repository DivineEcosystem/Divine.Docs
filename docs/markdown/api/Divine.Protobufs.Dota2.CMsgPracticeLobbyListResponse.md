# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse"></a> Class CMsgPracticeLobbyListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyListResponse : IMessage<CMsgPracticeLobbyListResponse>, IEquatable<CMsgPracticeLobbyListResponse>, IDeepCloneable<CMsgPracticeLobbyListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)

#### Implements

IMessage<CMsgPracticeLobbyListResponse\>, 
[IEquatable<CMsgPracticeLobbyListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyListResponse\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyListResponse\>\(CMsgPracticeLobbyListResponse, params CMsgPracticeLobbyListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse__ctor"></a> CMsgPracticeLobbyListResponse\(\)

```csharp
public CMsgPracticeLobbyListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_"></a> CMsgPracticeLobbyListResponse\(CMsgPracticeLobbyListResponse\)

```csharp
public CMsgPracticeLobbyListResponse(CMsgPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_LobbiesFieldNumber"></a> LobbiesFieldNumber

```csharp
public const int LobbiesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Lobbies"></a> Lobbies

```csharp
public RepeatedField<CMsgPracticeLobbyListResponseEntry> Lobbies { get; }
```

#### Property Value

 RepeatedField<[CMsgPracticeLobbyListResponseEntry](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponseEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyListResponse Clone()
```

#### Returns

 [CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_"></a> Equals\(CMsgPracticeLobbyListResponse\)

```csharp
public bool Equals(CMsgPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_"></a> MergeFrom\(CMsgPracticeLobbyListResponse\)

```csharp
public void MergeFrom(CMsgPracticeLobbyListResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyListResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

