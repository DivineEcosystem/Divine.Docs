# <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse"></a> Class CMsgGCGetPlayerCardItemInfoResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetPlayerCardItemInfoResponse : IMessage<CMsgGCGetPlayerCardItemInfoResponse>, IEquatable<CMsgGCGetPlayerCardItemInfoResponse>, IDeepCloneable<CMsgGCGetPlayerCardItemInfoResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)

#### Implements

IMessage<CMsgGCGetPlayerCardItemInfoResponse\>, 
[IEquatable<CMsgGCGetPlayerCardItemInfoResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetPlayerCardItemInfoResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetPlayerCardItemInfoResponse\>\(CMsgGCGetPlayerCardItemInfoResponse, params CMsgGCGetPlayerCardItemInfoResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse__ctor"></a> CMsgGCGetPlayerCardItemInfoResponse\(\)

```csharp
public CMsgGCGetPlayerCardItemInfoResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse__ctor_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_"></a> CMsgGCGetPlayerCardItemInfoResponse\(CMsgGCGetPlayerCardItemInfoResponse\)

```csharp
public CMsgGCGetPlayerCardItemInfoResponse(CMsgGCGetPlayerCardItemInfoResponse other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_PlayerCardInfosFieldNumber"></a> PlayerCardInfosFieldNumber

```csharp
public const int PlayerCardInfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetPlayerCardItemInfoResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_PlayerCardInfos"></a> PlayerCardInfos

```csharp
public RepeatedField<CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo> PlayerCardInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.md).[PlayerCardInfo](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.Types.PlayerCardInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetPlayerCardItemInfoResponse Clone()
```

#### Returns

 [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_Equals_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_"></a> Equals\(CMsgGCGetPlayerCardItemInfoResponse\)

```csharp
public bool Equals(CMsgGCGetPlayerCardItemInfoResponse other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_"></a> MergeFrom\(CMsgGCGetPlayerCardItemInfoResponse\)

```csharp
public void MergeFrom(CMsgGCGetPlayerCardItemInfoResponse other)
```

#### Parameters

`other` [CMsgGCGetPlayerCardItemInfoResponse](Divine.Protobufs.Dota2.CMsgGCGetPlayerCardItemInfoResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetPlayerCardItemInfoResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

