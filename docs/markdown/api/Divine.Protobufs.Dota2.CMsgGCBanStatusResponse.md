# <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse"></a> Class CMsgGCBanStatusResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCBanStatusResponse : IMessage<CMsgGCBanStatusResponse>, IEquatable<CMsgGCBanStatusResponse>, IDeepCloneable<CMsgGCBanStatusResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)

#### Implements

IMessage<CMsgGCBanStatusResponse\>, 
[IEquatable<CMsgGCBanStatusResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCBanStatusResponse\>, 
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
[EnumerableExtensions.In<CMsgGCBanStatusResponse\>\(CMsgGCBanStatusResponse, params CMsgGCBanStatusResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse__ctor"></a> CMsgGCBanStatusResponse\(\)

```csharp
public CMsgGCBanStatusResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse__ctor_Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_"></a> CMsgGCBanStatusResponse\(CMsgGCBanStatusResponse\)

```csharp
public CMsgGCBanStatusResponse(CMsgGCBanStatusResponse other)
```

#### Parameters

`other` [CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_LowPriorityFieldNumber"></a> LowPriorityFieldNumber

```csharp
public const int LowPriorityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_TextChatBannedFieldNumber"></a> TextChatBannedFieldNumber

```csharp
public const int TextChatBannedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_VoiceChatBannedFieldNumber"></a> VoiceChatBannedFieldNumber

```csharp
public const int VoiceChatBannedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_HasLowPriority"></a> HasLowPriority

```csharp
public bool HasLowPriority { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_HasTextChatBanned"></a> HasTextChatBanned

```csharp
public bool HasTextChatBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_HasVoiceChatBanned"></a> HasVoiceChatBanned

```csharp
public bool HasVoiceChatBanned { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_LowPriority"></a> LowPriority

```csharp
public bool LowPriority { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCBanStatusResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_TextChatBanned"></a> TextChatBanned

```csharp
public bool TextChatBanned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_VoiceChatBanned"></a> VoiceChatBanned

```csharp
public bool VoiceChatBanned { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ClearLowPriority"></a> ClearLowPriority\(\)

```csharp
public void ClearLowPriority()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ClearTextChatBanned"></a> ClearTextChatBanned\(\)

```csharp
public void ClearTextChatBanned()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ClearVoiceChatBanned"></a> ClearVoiceChatBanned\(\)

```csharp
public void ClearVoiceChatBanned()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCBanStatusResponse Clone()
```

#### Returns

 [CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_Equals_Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_"></a> Equals\(CMsgGCBanStatusResponse\)

```csharp
public bool Equals(CMsgGCBanStatusResponse other)
```

#### Parameters

`other` [CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_"></a> MergeFrom\(CMsgGCBanStatusResponse\)

```csharp
public void MergeFrom(CMsgGCBanStatusResponse other)
```

#### Parameters

`other` [CMsgGCBanStatusResponse](Divine.Protobufs.Dota2.CMsgGCBanStatusResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCBanStatusResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

