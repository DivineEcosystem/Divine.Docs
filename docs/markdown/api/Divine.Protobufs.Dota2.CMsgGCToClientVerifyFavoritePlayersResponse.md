# <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse"></a> Class CMsgGCToClientVerifyFavoritePlayersResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientVerifyFavoritePlayersResponse : IMessage<CMsgGCToClientVerifyFavoritePlayersResponse>, IEquatable<CMsgGCToClientVerifyFavoritePlayersResponse>, IDeepCloneable<CMsgGCToClientVerifyFavoritePlayersResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)

#### Implements

IMessage<CMsgGCToClientVerifyFavoritePlayersResponse\>, 
[IEquatable<CMsgGCToClientVerifyFavoritePlayersResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientVerifyFavoritePlayersResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientVerifyFavoritePlayersResponse\>\(CMsgGCToClientVerifyFavoritePlayersResponse, params CMsgGCToClientVerifyFavoritePlayersResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse__ctor"></a> CMsgGCToClientVerifyFavoritePlayersResponse\(\)

```csharp
public CMsgGCToClientVerifyFavoritePlayersResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_"></a> CMsgGCToClientVerifyFavoritePlayersResponse\(CMsgGCToClientVerifyFavoritePlayersResponse\)

```csharp
public CMsgGCToClientVerifyFavoritePlayersResponse(CMsgGCToClientVerifyFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientVerifyFavoritePlayersResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Results"></a> Results

```csharp
public RepeatedField<CMsgGCToClientVerifyFavoritePlayersResponse.Types.Result> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.Types.Result.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientVerifyFavoritePlayersResponse Clone()
```

#### Returns

 [CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_"></a> Equals\(CMsgGCToClientVerifyFavoritePlayersResponse\)

```csharp
public bool Equals(CMsgGCToClientVerifyFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_"></a> MergeFrom\(CMsgGCToClientVerifyFavoritePlayersResponse\)

```csharp
public void MergeFrom(CMsgGCToClientVerifyFavoritePlayersResponse other)
```

#### Parameters

`other` [CMsgGCToClientVerifyFavoritePlayersResponse](Divine.Protobufs.Dota2.CMsgGCToClientVerifyFavoritePlayersResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientVerifyFavoritePlayersResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

