# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse"></a> Class CMsgClientToGCGetQuestProgressResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetQuestProgressResponse : IMessage<CMsgClientToGCGetQuestProgressResponse>, IEquatable<CMsgClientToGCGetQuestProgressResponse>, IDeepCloneable<CMsgClientToGCGetQuestProgressResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)

#### Implements

IMessage<CMsgClientToGCGetQuestProgressResponse\>, 
[IEquatable<CMsgClientToGCGetQuestProgressResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetQuestProgressResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetQuestProgressResponse\>\(CMsgClientToGCGetQuestProgressResponse, params CMsgClientToGCGetQuestProgressResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse__ctor"></a> CMsgClientToGCGetQuestProgressResponse\(\)

```csharp
public CMsgClientToGCGetQuestProgressResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_"></a> CMsgClientToGCGetQuestProgressResponse\(CMsgClientToGCGetQuestProgressResponse\)

```csharp
public CMsgClientToGCGetQuestProgressResponse(CMsgClientToGCGetQuestProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_QuestsFieldNumber"></a> QuestsFieldNumber

```csharp
public const int QuestsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetQuestProgressResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Quests"></a> Quests

```csharp
public RepeatedField<CMsgClientToGCGetQuestProgressResponse.Types.Quest> Quests { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.md).[Quest](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.Types.Quest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetQuestProgressResponse Clone()
```

#### Returns

 [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_"></a> Equals\(CMsgClientToGCGetQuestProgressResponse\)

```csharp
public bool Equals(CMsgClientToGCGetQuestProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_"></a> MergeFrom\(CMsgClientToGCGetQuestProgressResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetQuestProgressResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetQuestProgressResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetQuestProgressResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetQuestProgressResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

