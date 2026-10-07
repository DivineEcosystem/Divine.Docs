# <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse"></a> Class CMsgQuickJoinCustomLobbyResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgQuickJoinCustomLobbyResponse : IMessage<CMsgQuickJoinCustomLobbyResponse>, IEquatable<CMsgQuickJoinCustomLobbyResponse>, IDeepCloneable<CMsgQuickJoinCustomLobbyResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)

#### Implements

IMessage<CMsgQuickJoinCustomLobbyResponse\>, 
[IEquatable<CMsgQuickJoinCustomLobbyResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgQuickJoinCustomLobbyResponse\>, 
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
[EnumerableExtensions.In<CMsgQuickJoinCustomLobbyResponse\>\(CMsgQuickJoinCustomLobbyResponse, params CMsgQuickJoinCustomLobbyResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse__ctor"></a> CMsgQuickJoinCustomLobbyResponse\(\)

```csharp
public CMsgQuickJoinCustomLobbyResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse__ctor_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_"></a> CMsgQuickJoinCustomLobbyResponse\(CMsgQuickJoinCustomLobbyResponse\)

```csharp
public CMsgQuickJoinCustomLobbyResponse(CMsgQuickJoinCustomLobbyResponse other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgQuickJoinCustomLobbyResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Result"></a> Result

```csharp
public DOTAJoinLobbyResult Result { get; set; }
```

#### Property Value

 [DOTAJoinLobbyResult](Divine.Protobufs.Dota2.DOTAJoinLobbyResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Clone"></a> Clone\(\)

```csharp
public CMsgQuickJoinCustomLobbyResponse Clone()
```

#### Returns

 [CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_Equals_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_"></a> Equals\(CMsgQuickJoinCustomLobbyResponse\)

```csharp
public bool Equals(CMsgQuickJoinCustomLobbyResponse other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_"></a> MergeFrom\(CMsgQuickJoinCustomLobbyResponse\)

```csharp
public void MergeFrom(CMsgQuickJoinCustomLobbyResponse other)
```

#### Parameters

`other` [CMsgQuickJoinCustomLobbyResponse](Divine.Protobufs.Dota2.CMsgQuickJoinCustomLobbyResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgQuickJoinCustomLobbyResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

