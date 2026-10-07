# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse"></a> Class CMsgPracticeLobbyJoinResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyJoinResponse : IMessage<CMsgPracticeLobbyJoinResponse>, IEquatable<CMsgPracticeLobbyJoinResponse>, IDeepCloneable<CMsgPracticeLobbyJoinResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)

#### Implements

IMessage<CMsgPracticeLobbyJoinResponse\>, 
[IEquatable<CMsgPracticeLobbyJoinResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyJoinResponse\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyJoinResponse\>\(CMsgPracticeLobbyJoinResponse, params CMsgPracticeLobbyJoinResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse__ctor"></a> CMsgPracticeLobbyJoinResponse\(\)

```csharp
public CMsgPracticeLobbyJoinResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_"></a> CMsgPracticeLobbyJoinResponse\(CMsgPracticeLobbyJoinResponse\)

```csharp
public CMsgPracticeLobbyJoinResponse(CMsgPracticeLobbyJoinResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyJoinResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Result"></a> Result

```csharp
public DOTAJoinLobbyResult Result { get; set; }
```

#### Property Value

 [DOTAJoinLobbyResult](Divine.Protobufs.Dota2.DOTAJoinLobbyResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyJoinResponse Clone()
```

#### Returns

 [CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_"></a> Equals\(CMsgPracticeLobbyJoinResponse\)

```csharp
public bool Equals(CMsgPracticeLobbyJoinResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_"></a> MergeFrom\(CMsgPracticeLobbyJoinResponse\)

```csharp
public void MergeFrom(CMsgPracticeLobbyJoinResponse other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinResponse](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

