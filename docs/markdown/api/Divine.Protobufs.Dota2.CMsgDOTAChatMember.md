# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember"></a> Class CMsgDOTAChatMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMember : IMessage<CMsgDOTAChatMember>, IEquatable<CMsgDOTAChatMember>, IDeepCloneable<CMsgDOTAChatMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)

#### Implements

IMessage<CMsgDOTAChatMember\>, 
[IEquatable<CMsgDOTAChatMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMember\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMember\>\(CMsgDOTAChatMember, params CMsgDOTAChatMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember__ctor"></a> CMsgDOTAChatMember\(\)

```csharp
public CMsgDOTAChatMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMember_"></a> CMsgDOTAChatMember\(CMsgDOTAChatMember\)

```csharp
public CMsgDOTAChatMember(CMsgDOTAChatMember other)
```

#### Parameters

`other` [CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ChannelUserIdFieldNumber"></a> ChannelUserIdFieldNumber

```csharp
public const int ChannelUserIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_PersonaNameFieldNumber"></a> PersonaNameFieldNumber

```csharp
public const int PersonaNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ChannelUserId"></a> ChannelUserId

```csharp
public uint ChannelUserId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_HasChannelUserId"></a> HasChannelUserId

```csharp
public bool HasChannelUserId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_HasPersonaName"></a> HasPersonaName

```csharp
public bool HasPersonaName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMember> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_PersonaName"></a> PersonaName

```csharp
public string PersonaName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ClearChannelUserId"></a> ClearChannelUserId\(\)

```csharp
public void ClearChannelUserId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ClearPersonaName"></a> ClearPersonaName\(\)

```csharp
public void ClearPersonaName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMember Clone()
```

#### Returns

 [CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMember_"></a> Equals\(CMsgDOTAChatMember\)

```csharp
public bool Equals(CMsgDOTAChatMember other)
```

#### Parameters

`other` [CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMember_"></a> MergeFrom\(CMsgDOTAChatMember\)

```csharp
public void MergeFrom(CMsgDOTAChatMember other)
```

#### Parameters

`other` [CMsgDOTAChatMember](Divine.Protobufs.Dota2.CMsgDOTAChatMember.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

