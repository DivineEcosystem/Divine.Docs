# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo"></a> Class CMsgBotWorldState.Types.TeleportInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.TeleportInfo : IMessage<CMsgBotWorldState.Types.TeleportInfo>, IEquatable<CMsgBotWorldState.Types.TeleportInfo>, IDeepCloneable<CMsgBotWorldState.Types.TeleportInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)

#### Implements

IMessage<CMsgBotWorldState.Types.TeleportInfo\>, 
[IEquatable<CMsgBotWorldState.Types.TeleportInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.TeleportInfo\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.TeleportInfo\>\(CMsgBotWorldState.Types.TeleportInfo, params CMsgBotWorldState.Types.TeleportInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo__ctor"></a> TeleportInfo\(\)

```csharp
public TeleportInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_"></a> TeleportInfo\(TeleportInfo\)

```csharp
public TeleportInfo(CMsgBotWorldState.Types.TeleportInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_TimeRemainingFieldNumber"></a> TimeRemainingFieldNumber

```csharp
public const int TimeRemainingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_HasTimeRemaining"></a> HasTimeRemaining

```csharp
public bool HasTimeRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.TeleportInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_TimeRemaining"></a> TimeRemaining

```csharp
public float TimeRemaining { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_ClearTimeRemaining"></a> ClearTimeRemaining\(\)

```csharp
public void ClearTimeRemaining()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.TeleportInfo Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_"></a> Equals\(TeleportInfo\)

```csharp
public bool Equals(CMsgBotWorldState.Types.TeleportInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_"></a> MergeFrom\(TeleportInfo\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.TeleportInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[TeleportInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.TeleportInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_TeleportInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

