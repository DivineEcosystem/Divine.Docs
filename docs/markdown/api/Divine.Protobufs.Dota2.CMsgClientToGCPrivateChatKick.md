# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick"></a> Class CMsgClientToGCPrivateChatKick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPrivateChatKick : IMessage<CMsgClientToGCPrivateChatKick>, IEquatable<CMsgClientToGCPrivateChatKick>, IDeepCloneable<CMsgClientToGCPrivateChatKick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)

#### Implements

IMessage<CMsgClientToGCPrivateChatKick\>, 
[IEquatable<CMsgClientToGCPrivateChatKick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPrivateChatKick\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPrivateChatKick\>\(CMsgClientToGCPrivateChatKick, params CMsgClientToGCPrivateChatKick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick__ctor"></a> CMsgClientToGCPrivateChatKick\(\)

```csharp
public CMsgClientToGCPrivateChatKick()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_"></a> CMsgClientToGCPrivateChatKick\(CMsgClientToGCPrivateChatKick\)

```csharp
public CMsgClientToGCPrivateChatKick(CMsgClientToGCPrivateChatKick other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_KickAccountIdFieldNumber"></a> KickAccountIdFieldNumber

```csharp
public const int KickAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_PrivateChatChannelNameFieldNumber"></a> PrivateChatChannelNameFieldNumber

```csharp
public const int PrivateChatChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_HasKickAccountId"></a> HasKickAccountId

```csharp
public bool HasKickAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_HasPrivateChatChannelName"></a> HasPrivateChatChannelName

```csharp
public bool HasPrivateChatChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_KickAccountId"></a> KickAccountId

```csharp
public uint KickAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPrivateChatKick> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_PrivateChatChannelName"></a> PrivateChatChannelName

```csharp
public string PrivateChatChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_ClearKickAccountId"></a> ClearKickAccountId\(\)

```csharp
public void ClearKickAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_ClearPrivateChatChannelName"></a> ClearPrivateChatChannelName\(\)

```csharp
public void ClearPrivateChatChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPrivateChatKick Clone()
```

#### Returns

 [CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_"></a> Equals\(CMsgClientToGCPrivateChatKick\)

```csharp
public bool Equals(CMsgClientToGCPrivateChatKick other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_"></a> MergeFrom\(CMsgClientToGCPrivateChatKick\)

```csharp
public void MergeFrom(CMsgClientToGCPrivateChatKick other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatKick](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatKick.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatKick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

