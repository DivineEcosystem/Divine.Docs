# <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode"></a> Class CMsgClientToGCInviteToDemoMode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCInviteToDemoMode : IMessage<CMsgClientToGCInviteToDemoMode>, IEquatable<CMsgClientToGCInviteToDemoMode>, IDeepCloneable<CMsgClientToGCInviteToDemoMode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)

#### Implements

IMessage<CMsgClientToGCInviteToDemoMode\>, 
[IEquatable<CMsgClientToGCInviteToDemoMode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCInviteToDemoMode\>, 
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
[EnumerableExtensions.In<CMsgClientToGCInviteToDemoMode\>\(CMsgClientToGCInviteToDemoMode, params CMsgClientToGCInviteToDemoMode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode__ctor"></a> CMsgClientToGCInviteToDemoMode\(\)

```csharp
public CMsgClientToGCInviteToDemoMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode__ctor_Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_"></a> CMsgClientToGCInviteToDemoMode\(CMsgClientToGCInviteToDemoMode\)

```csharp
public CMsgClientToGCInviteToDemoMode(CMsgClientToGCInviteToDemoMode other)
```

#### Parameters

`other` [CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_InvitedPlayerIdFieldNumber"></a> InvitedPlayerIdFieldNumber

```csharp
public const int InvitedPlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_ServerIdFieldNumber"></a> ServerIdFieldNumber

```csharp
public const int ServerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_HasInvitedPlayerId"></a> HasInvitedPlayerId

```csharp
public bool HasInvitedPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_HasServerId"></a> HasServerId

```csharp
public bool HasServerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_InvitedPlayerId"></a> InvitedPlayerId

```csharp
public ulong InvitedPlayerId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCInviteToDemoMode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_ServerId"></a> ServerId

```csharp
public ulong ServerId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_ClearInvitedPlayerId"></a> ClearInvitedPlayerId\(\)

```csharp
public void ClearInvitedPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_ClearServerId"></a> ClearServerId\(\)

```csharp
public void ClearServerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCInviteToDemoMode Clone()
```

#### Returns

 [CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_Equals_Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_"></a> Equals\(CMsgClientToGCInviteToDemoMode\)

```csharp
public bool Equals(CMsgClientToGCInviteToDemoMode other)
```

#### Parameters

`other` [CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_"></a> MergeFrom\(CMsgClientToGCInviteToDemoMode\)

```csharp
public void MergeFrom(CMsgClientToGCInviteToDemoMode other)
```

#### Parameters

`other` [CMsgClientToGCInviteToDemoMode](Divine.Protobufs.Dota2.CMsgClientToGCInviteToDemoMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCInviteToDemoMode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

