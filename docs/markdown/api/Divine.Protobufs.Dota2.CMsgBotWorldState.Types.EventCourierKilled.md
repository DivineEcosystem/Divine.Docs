# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled"></a> Class CMsgBotWorldState.Types.EventCourierKilled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.EventCourierKilled : IMessage<CMsgBotWorldState.Types.EventCourierKilled>, IEquatable<CMsgBotWorldState.Types.EventCourierKilled>, IDeepCloneable<CMsgBotWorldState.Types.EventCourierKilled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)

#### Implements

IMessage<CMsgBotWorldState.Types.EventCourierKilled\>, 
[IEquatable<CMsgBotWorldState.Types.EventCourierKilled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.EventCourierKilled\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.EventCourierKilled\>\(CMsgBotWorldState.Types.EventCourierKilled, params CMsgBotWorldState.Types.EventCourierKilled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled__ctor"></a> EventCourierKilled\(\)

```csharp
public EventCourierKilled()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_"></a> EventCourierKilled\(EventCourierKilled\)

```csharp
public EventCourierKilled(CMsgBotWorldState.Types.EventCourierKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_CourierUnitHandleFieldNumber"></a> CourierUnitHandleFieldNumber

```csharp
public const int CourierUnitHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_KillerPlayerIdFieldNumber"></a> KillerPlayerIdFieldNumber

```csharp
public const int KillerPlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_KillerUnitHandleFieldNumber"></a> KillerUnitHandleFieldNumber

```csharp
public const int KillerUnitHandleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_CourierUnitHandle"></a> CourierUnitHandle

```csharp
public uint CourierUnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_HasCourierUnitHandle"></a> HasCourierUnitHandle

```csharp
public bool HasCourierUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_HasKillerPlayerId"></a> HasKillerPlayerId

```csharp
public bool HasKillerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_HasKillerUnitHandle"></a> HasKillerUnitHandle

```csharp
public bool HasKillerUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_KillerPlayerId"></a> KillerPlayerId

```csharp
public int KillerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_KillerUnitHandle"></a> KillerUnitHandle

```csharp
public uint KillerUnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.EventCourierKilled> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_ClearCourierUnitHandle"></a> ClearCourierUnitHandle\(\)

```csharp
public void ClearCourierUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_ClearKillerPlayerId"></a> ClearKillerPlayerId\(\)

```csharp
public void ClearKillerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_ClearKillerUnitHandle"></a> ClearKillerUnitHandle\(\)

```csharp
public void ClearKillerUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.EventCourierKilled Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_"></a> Equals\(EventCourierKilled\)

```csharp
public bool Equals(CMsgBotWorldState.Types.EventCourierKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_"></a> MergeFrom\(EventCourierKilled\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.EventCourierKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventCourierKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventCourierKilled.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventCourierKilled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

