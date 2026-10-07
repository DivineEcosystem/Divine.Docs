# <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick"></a> Class CMsgDOTAChatMessage.Types.PlayerDraftPick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAChatMessage.Types.PlayerDraftPick : IMessage<CMsgDOTAChatMessage.Types.PlayerDraftPick>, IEquatable<CMsgDOTAChatMessage.Types.PlayerDraftPick>, IDeepCloneable<CMsgDOTAChatMessage.Types.PlayerDraftPick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAChatMessage.Types.PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

#### Implements

IMessage<CMsgDOTAChatMessage.Types.PlayerDraftPick\>, 
[IEquatable<CMsgDOTAChatMessage.Types.PlayerDraftPick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAChatMessage.Types.PlayerDraftPick\>, 
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
[EnumerableExtensions.In<CMsgDOTAChatMessage.Types.PlayerDraftPick\>\(CMsgDOTAChatMessage.Types.PlayerDraftPick, params CMsgDOTAChatMessage.Types.PlayerDraftPick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick__ctor"></a> PlayerDraftPick\(\)

```csharp
public PlayerDraftPick()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick__ctor_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_"></a> PlayerDraftPick\(PlayerDraftPick\)

```csharp
public PlayerDraftPick(CMsgDOTAChatMessage.Types.PlayerDraftPick other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAChatMessage.Types.PlayerDraftPick> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Team"></a> Team

```csharp
public int Team { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAChatMessage.Types.PlayerDraftPick Clone()
```

#### Returns

 [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_Equals_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_"></a> Equals\(PlayerDraftPick\)

```csharp
public bool Equals(CMsgDOTAChatMessage.Types.PlayerDraftPick other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_"></a> MergeFrom\(PlayerDraftPick\)

```csharp
public void MergeFrom(CMsgDOTAChatMessage.Types.PlayerDraftPick other)
```

#### Parameters

`other` [CMsgDOTAChatMessage](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.md).[PlayerDraftPick](Divine.Protobufs.Dota2.CMsgDOTAChatMessage.Types.PlayerDraftPick.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAChatMessage_Types_PlayerDraftPick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

