# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled"></a> Class CMsgBotWorldState.Types.EventRoshanKilled

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.EventRoshanKilled : IMessage<CMsgBotWorldState.Types.EventRoshanKilled>, IEquatable<CMsgBotWorldState.Types.EventRoshanKilled>, IDeepCloneable<CMsgBotWorldState.Types.EventRoshanKilled>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)

#### Implements

IMessage<CMsgBotWorldState.Types.EventRoshanKilled\>, 
[IEquatable<CMsgBotWorldState.Types.EventRoshanKilled\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.EventRoshanKilled\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.EventRoshanKilled\>\(CMsgBotWorldState.Types.EventRoshanKilled, params CMsgBotWorldState.Types.EventRoshanKilled\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled__ctor"></a> EventRoshanKilled\(\)

```csharp
public EventRoshanKilled()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_"></a> EventRoshanKilled\(EventRoshanKilled\)

```csharp
public EventRoshanKilled(CMsgBotWorldState.Types.EventRoshanKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_KillerPlayerIdFieldNumber"></a> KillerPlayerIdFieldNumber

```csharp
public const int KillerPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_KillerUnitHandleFieldNumber"></a> KillerUnitHandleFieldNumber

```csharp
public const int KillerUnitHandleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_HasKillerPlayerId"></a> HasKillerPlayerId

```csharp
public bool HasKillerPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_HasKillerUnitHandle"></a> HasKillerUnitHandle

```csharp
public bool HasKillerUnitHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_KillerPlayerId"></a> KillerPlayerId

```csharp
public int KillerPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_KillerUnitHandle"></a> KillerUnitHandle

```csharp
public uint KillerUnitHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.EventRoshanKilled> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_ClearKillerPlayerId"></a> ClearKillerPlayerId\(\)

```csharp
public void ClearKillerPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_ClearKillerUnitHandle"></a> ClearKillerUnitHandle\(\)

```csharp
public void ClearKillerUnitHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.EventRoshanKilled Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_"></a> Equals\(EventRoshanKilled\)

```csharp
public bool Equals(CMsgBotWorldState.Types.EventRoshanKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_"></a> MergeFrom\(EventRoshanKilled\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.EventRoshanKilled other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[EventRoshanKilled](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.EventRoshanKilled.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_EventRoshanKilled_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

