# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo"></a> Class CMsgClientToGCSetGuildInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetGuildInfo : IMessage<CMsgClientToGCSetGuildInfo>, IEquatable<CMsgClientToGCSetGuildInfo>, IDeepCloneable<CMsgClientToGCSetGuildInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)

#### Implements

IMessage<CMsgClientToGCSetGuildInfo\>, 
[IEquatable<CMsgClientToGCSetGuildInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetGuildInfo\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetGuildInfo\>\(CMsgClientToGCSetGuildInfo, params CMsgClientToGCSetGuildInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo__ctor"></a> CMsgClientToGCSetGuildInfo\(\)

```csharp
public CMsgClientToGCSetGuildInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_"></a> CMsgClientToGCSetGuildInfo\(CMsgClientToGCSetGuildInfo\)

```csharp
public CMsgClientToGCSetGuildInfo(CMsgClientToGCSetGuildInfo other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildChatTypeFieldNumber"></a> GuildChatTypeFieldNumber

```csharp
public const int GuildChatTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildInfoFieldNumber"></a> GuildInfoFieldNumber

```csharp
public const int GuildInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildChatType"></a> GuildChatType

```csharp
public EGuildChatType GuildChatType { get; set; }
```

#### Property Value

 [EGuildChatType](Divine.Protobufs.Dota2.EGuildChatType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GuildInfo"></a> GuildInfo

```csharp
public CMsgGuildInfo GuildInfo { get; set; }
```

#### Property Value

 [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_HasGuildChatType"></a> HasGuildChatType

```csharp
public bool HasGuildChatType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetGuildInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_ClearGuildChatType"></a> ClearGuildChatType\(\)

```csharp
public void ClearGuildChatType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetGuildInfo Clone()
```

#### Returns

 [CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_"></a> Equals\(CMsgClientToGCSetGuildInfo\)

```csharp
public bool Equals(CMsgClientToGCSetGuildInfo other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_"></a> MergeFrom\(CMsgClientToGCSetGuildInfo\)

```csharp
public void MergeFrom(CMsgClientToGCSetGuildInfo other)
```

#### Parameters

`other` [CMsgClientToGCSetGuildInfo](Divine.Protobufs.Dota2.CMsgClientToGCSetGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetGuildInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

