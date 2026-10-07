# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse"></a> Class CMsgGCToClientPrivateChatResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPrivateChatResponse : IMessage<CMsgGCToClientPrivateChatResponse>, IEquatable<CMsgGCToClientPrivateChatResponse>, IDeepCloneable<CMsgGCToClientPrivateChatResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)

#### Implements

IMessage<CMsgGCToClientPrivateChatResponse\>, 
[IEquatable<CMsgGCToClientPrivateChatResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPrivateChatResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPrivateChatResponse\>\(CMsgGCToClientPrivateChatResponse, params CMsgGCToClientPrivateChatResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse__ctor"></a> CMsgGCToClientPrivateChatResponse\(\)

```csharp
public CMsgGCToClientPrivateChatResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_"></a> CMsgGCToClientPrivateChatResponse\(CMsgGCToClientPrivateChatResponse\)

```csharp
public CMsgGCToClientPrivateChatResponse(CMsgGCToClientPrivateChatResponse other)
```

#### Parameters

`other` [CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_PrivateChatChannelNameFieldNumber"></a> PrivateChatChannelNameFieldNumber

```csharp
public const int PrivateChatChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_UsernameFieldNumber"></a> UsernameFieldNumber

```csharp
public const int UsernameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_HasPrivateChatChannelName"></a> HasPrivateChatChannelName

```csharp
public bool HasPrivateChatChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_HasUsername"></a> HasUsername

```csharp
public bool HasUsername { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPrivateChatResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_PrivateChatChannelName"></a> PrivateChatChannelName

```csharp
public string PrivateChatChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Result"></a> Result

```csharp
public CMsgGCToClientPrivateChatResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.Types.Result.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Username"></a> Username

```csharp
public string Username { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_ClearPrivateChatChannelName"></a> ClearPrivateChatChannelName\(\)

```csharp
public void ClearPrivateChatChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_ClearUsername"></a> ClearUsername\(\)

```csharp
public void ClearUsername()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPrivateChatResponse Clone()
```

#### Returns

 [CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_"></a> Equals\(CMsgGCToClientPrivateChatResponse\)

```csharp
public bool Equals(CMsgGCToClientPrivateChatResponse other)
```

#### Parameters

`other` [CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_"></a> MergeFrom\(CMsgGCToClientPrivateChatResponse\)

```csharp
public void MergeFrom(CMsgGCToClientPrivateChatResponse other)
```

#### Parameters

`other` [CMsgGCToClientPrivateChatResponse](Divine.Protobufs.Dota2.CMsgGCToClientPrivateChatResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateChatResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

