# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite"></a> Class CMsgClientToGCPrivateChatInvite

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPrivateChatInvite : IMessage<CMsgClientToGCPrivateChatInvite>, IEquatable<CMsgClientToGCPrivateChatInvite>, IDeepCloneable<CMsgClientToGCPrivateChatInvite>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)

#### Implements

IMessage<CMsgClientToGCPrivateChatInvite\>, 
[IEquatable<CMsgClientToGCPrivateChatInvite\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPrivateChatInvite\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPrivateChatInvite\>\(CMsgClientToGCPrivateChatInvite, params CMsgClientToGCPrivateChatInvite\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite__ctor"></a> CMsgClientToGCPrivateChatInvite\(\)

```csharp
public CMsgClientToGCPrivateChatInvite()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_"></a> CMsgClientToGCPrivateChatInvite\(CMsgClientToGCPrivateChatInvite\)

```csharp
public CMsgClientToGCPrivateChatInvite(CMsgClientToGCPrivateChatInvite other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_InvitedAccountIdFieldNumber"></a> InvitedAccountIdFieldNumber

```csharp
public const int InvitedAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_PrivateChatChannelNameFieldNumber"></a> PrivateChatChannelNameFieldNumber

```csharp
public const int PrivateChatChannelNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_HasInvitedAccountId"></a> HasInvitedAccountId

```csharp
public bool HasInvitedAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_HasPrivateChatChannelName"></a> HasPrivateChatChannelName

```csharp
public bool HasPrivateChatChannelName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_InvitedAccountId"></a> InvitedAccountId

```csharp
public uint InvitedAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPrivateChatInvite> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_PrivateChatChannelName"></a> PrivateChatChannelName

```csharp
public string PrivateChatChannelName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_ClearInvitedAccountId"></a> ClearInvitedAccountId\(\)

```csharp
public void ClearInvitedAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_ClearPrivateChatChannelName"></a> ClearPrivateChatChannelName\(\)

```csharp
public void ClearPrivateChatChannelName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPrivateChatInvite Clone()
```

#### Returns

 [CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_"></a> Equals\(CMsgClientToGCPrivateChatInvite\)

```csharp
public bool Equals(CMsgClientToGCPrivateChatInvite other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_"></a> MergeFrom\(CMsgClientToGCPrivateChatInvite\)

```csharp
public void MergeFrom(CMsgClientToGCPrivateChatInvite other)
```

#### Parameters

`other` [CMsgClientToGCPrivateChatInvite](Divine.Protobufs.Dota2.CMsgClientToGCPrivateChatInvite.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPrivateChatInvite_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

