# <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated"></a> Class CMsgInvitationCreated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgInvitationCreated : IMessage<CMsgInvitationCreated>, IEquatable<CMsgInvitationCreated>, IDeepCloneable<CMsgInvitationCreated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)

#### Implements

IMessage<CMsgInvitationCreated\>, 
[IEquatable<CMsgInvitationCreated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgInvitationCreated\>, 
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
[EnumerableExtensions.In<CMsgInvitationCreated\>\(CMsgInvitationCreated, params CMsgInvitationCreated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated__ctor"></a> CMsgInvitationCreated\(\)

```csharp
public CMsgInvitationCreated()
```

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated__ctor_Divine_Protobufs_Dota2_CMsgInvitationCreated_"></a> CMsgInvitationCreated\(CMsgInvitationCreated\)

```csharp
public CMsgInvitationCreated(CMsgInvitationCreated other)
```

#### Parameters

`other` [CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_GroupIdFieldNumber"></a> GroupIdFieldNumber

```csharp
public const int GroupIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_UserOfflineFieldNumber"></a> UserOfflineFieldNumber

```csharp
public const int UserOfflineFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_GroupId"></a> GroupId

```csharp
public ulong GroupId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_HasGroupId"></a> HasGroupId

```csharp
public bool HasGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_HasUserOffline"></a> HasUserOffline

```csharp
public bool HasUserOffline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgInvitationCreated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_UserOffline"></a> UserOffline

```csharp
public bool UserOffline { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_ClearGroupId"></a> ClearGroupId\(\)

```csharp
public void ClearGroupId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_ClearUserOffline"></a> ClearUserOffline\(\)

```csharp
public void ClearUserOffline()
```

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_Clone"></a> Clone\(\)

```csharp
public CMsgInvitationCreated Clone()
```

#### Returns

 [CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_Equals_Divine_Protobufs_Dota2_CMsgInvitationCreated_"></a> Equals\(CMsgInvitationCreated\)

```csharp
public bool Equals(CMsgInvitationCreated other)
```

#### Parameters

`other` [CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_MergeFrom_Divine_Protobufs_Dota2_CMsgInvitationCreated_"></a> MergeFrom\(CMsgInvitationCreated\)

```csharp
public void MergeFrom(CMsgInvitationCreated other)
```

#### Parameters

`other` [CMsgInvitationCreated](Divine.Protobufs.Dota2.CMsgInvitationCreated.md)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgInvitationCreated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

