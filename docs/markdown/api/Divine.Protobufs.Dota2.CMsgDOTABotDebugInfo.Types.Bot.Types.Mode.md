# <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode"></a> Class CMsgDOTABotDebugInfo.Types.Bot.Types.Mode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTABotDebugInfo.Types.Bot.Types.Mode : IMessage<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode>, IEquatable<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode>, IDeepCloneable<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTABotDebugInfo.Types.Bot.Types.Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)

#### Implements

IMessage<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode\>, 
[IEquatable<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode\>, 
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
[EnumerableExtensions.In<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode\>\(CMsgDOTABotDebugInfo.Types.Bot.Types.Mode, params CMsgDOTABotDebugInfo.Types.Bot.Types.Mode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode__ctor"></a> Mode\(\)

```csharp
public Mode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode__ctor_Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_"></a> Mode\(Mode\)

```csharp
public Mode(CMsgDOTABotDebugInfo.Types.Bot.Types.Mode other)
```

#### Parameters

`other` [CMsgDOTABotDebugInfo](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.md).[Bot](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.md).[Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_DesireFieldNumber"></a> DesireFieldNumber

```csharp
public const int DesireFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ModeIdFieldNumber"></a> ModeIdFieldNumber

```csharp
public const int ModeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetEntityFieldNumber"></a> TargetEntityFieldNumber

```csharp
public const int TargetEntityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetXFieldNumber"></a> TargetXFieldNumber

```csharp
public const int TargetXFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetYFieldNumber"></a> TargetYFieldNumber

```csharp
public const int TargetYFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetZFieldNumber"></a> TargetZFieldNumber

```csharp
public const int TargetZFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Desire"></a> Desire

```csharp
public float Desire { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasDesire"></a> HasDesire

```csharp
public bool HasDesire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasModeId"></a> HasModeId

```csharp
public bool HasModeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasTargetEntity"></a> HasTargetEntity

```csharp
public bool HasTargetEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasTargetX"></a> HasTargetX

```csharp
public bool HasTargetX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasTargetY"></a> HasTargetY

```csharp
public bool HasTargetY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_HasTargetZ"></a> HasTargetZ

```csharp
public bool HasTargetZ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ModeId"></a> ModeId

```csharp
public uint ModeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTABotDebugInfo.Types.Bot.Types.Mode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTABotDebugInfo](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.md).[Bot](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.md).[Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetEntity"></a> TargetEntity

```csharp
public int TargetEntity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetX"></a> TargetX

```csharp
public uint TargetX { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetY"></a> TargetY

```csharp
public uint TargetY { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_TargetZ"></a> TargetZ

```csharp
public uint TargetZ { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearDesire"></a> ClearDesire\(\)

```csharp
public void ClearDesire()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearModeId"></a> ClearModeId\(\)

```csharp
public void ClearModeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearTargetEntity"></a> ClearTargetEntity\(\)

```csharp
public void ClearTargetEntity()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearTargetX"></a> ClearTargetX\(\)

```csharp
public void ClearTargetX()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearTargetY"></a> ClearTargetY\(\)

```csharp
public void ClearTargetY()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ClearTargetZ"></a> ClearTargetZ\(\)

```csharp
public void ClearTargetZ()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Clone"></a> Clone\(\)

```csharp
public CMsgDOTABotDebugInfo.Types.Bot.Types.Mode Clone()
```

#### Returns

 [CMsgDOTABotDebugInfo](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.md).[Bot](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.md).[Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_Equals_Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_"></a> Equals\(Mode\)

```csharp
public bool Equals(CMsgDOTABotDebugInfo.Types.Bot.Types.Mode other)
```

#### Parameters

`other` [CMsgDOTABotDebugInfo](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.md).[Bot](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.md).[Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_"></a> MergeFrom\(Mode\)

```csharp
public void MergeFrom(CMsgDOTABotDebugInfo.Types.Bot.Types.Mode other)
```

#### Parameters

`other` [CMsgDOTABotDebugInfo](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.md).[Bot](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.md).[Types](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.md).[Mode](Divine.Protobufs.Dota2.CMsgDOTABotDebugInfo.Types.Bot.Types.Mode.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABotDebugInfo_Types_Bot_Types_Mode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

