# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse"></a> Class CMsgClientToGCCoachFriendResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCoachFriendResponse : IMessage<CMsgClientToGCCoachFriendResponse>, IEquatable<CMsgClientToGCCoachFriendResponse>, IDeepCloneable<CMsgClientToGCCoachFriendResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)

#### Implements

IMessage<CMsgClientToGCCoachFriendResponse\>, 
[IEquatable<CMsgClientToGCCoachFriendResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCoachFriendResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCoachFriendResponse\>\(CMsgClientToGCCoachFriendResponse, params CMsgClientToGCCoachFriendResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse__ctor"></a> CMsgClientToGCCoachFriendResponse\(\)

```csharp
public CMsgClientToGCCoachFriendResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_"></a> CMsgClientToGCCoachFriendResponse\(CMsgClientToGCCoachFriendResponse\)

```csharp
public CMsgClientToGCCoachFriendResponse(CMsgClientToGCCoachFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCoachFriendResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Result"></a> Result

```csharp
public CMsgClientToGCCoachFriendResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCoachFriendResponse Clone()
```

#### Returns

 [CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_"></a> Equals\(CMsgClientToGCCoachFriendResponse\)

```csharp
public bool Equals(CMsgClientToGCCoachFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_"></a> MergeFrom\(CMsgClientToGCCoachFriendResponse\)

```csharp
public void MergeFrom(CMsgClientToGCCoachFriendResponse other)
```

#### Parameters

`other` [CMsgClientToGCCoachFriendResponse](Divine.Protobufs.Dota2.CMsgClientToGCCoachFriendResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCoachFriendResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

