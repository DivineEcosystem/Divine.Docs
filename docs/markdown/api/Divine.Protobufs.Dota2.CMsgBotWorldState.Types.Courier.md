# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier"></a> Class CMsgBotWorldState.Types.Courier

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.Courier : IMessage<CMsgBotWorldState.Types.Courier>, IEquatable<CMsgBotWorldState.Types.Courier>, IDeepCloneable<CMsgBotWorldState.Types.Courier>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)

#### Implements

IMessage<CMsgBotWorldState.Types.Courier\>, 
[IEquatable<CMsgBotWorldState.Types.Courier\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.Courier\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.Courier\>\(CMsgBotWorldState.Types.Courier, params CMsgBotWorldState.Types.Courier\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier__ctor"></a> Courier\(\)

```csharp
public Courier()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_"></a> Courier\(Courier\)

```csharp
public Courier(CMsgBotWorldState.Types.Courier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Handle"></a> Handle

```csharp
public uint Handle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.Courier> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_State"></a> State

```csharp
public CMsgBotWorldState.Types.CourierState State { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[CourierState](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.CourierState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.Courier Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_"></a> Equals\(Courier\)

```csharp
public bool Equals(CMsgBotWorldState.Types.Courier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_"></a> MergeFrom\(Courier\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.Courier other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Courier](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Courier.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_Courier_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

