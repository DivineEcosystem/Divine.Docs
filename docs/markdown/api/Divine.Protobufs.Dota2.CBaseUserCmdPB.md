# <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB"></a> Class CBaseUserCmdPB

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CBaseUserCmdPB : IMessage<CBaseUserCmdPB>, IEquatable<CBaseUserCmdPB>, IDeepCloneable<CBaseUserCmdPB>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

#### Implements

IMessage<CBaseUserCmdPB\>, 
[IEquatable<CBaseUserCmdPB\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CBaseUserCmdPB\>, 
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
[EnumerableExtensions.In<CBaseUserCmdPB\>\(CBaseUserCmdPB, params CBaseUserCmdPB\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB__ctor"></a> CBaseUserCmdPB\(\)

```csharp
public CBaseUserCmdPB()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB__ctor_Divine_Protobufs_Dota2_CBaseUserCmdPB_"></a> CBaseUserCmdPB\(CBaseUserCmdPB\)

```csharp
public CBaseUserCmdPB(CBaseUserCmdPB other)
```

#### Parameters

`other` [CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ButtonsPbFieldNumber"></a> ButtonsPbFieldNumber

```csharp
public const int ButtonsPbFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClientTickFieldNumber"></a> ClientTickFieldNumber

```csharp
public const int ClientTickFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_CmdFlagsFieldNumber"></a> CmdFlagsFieldNumber

```csharp
public const int CmdFlagsFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ConsumedServerAngleChangesFieldNumber"></a> ConsumedServerAngleChangesFieldNumber

```csharp
public const int ConsumedServerAngleChangesFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ExecutionNotesFieldNumber"></a> ExecutionNotesFieldNumber

```csharp
public const int ExecutionNotesFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ForwardmoveFieldNumber"></a> ForwardmoveFieldNumber

```csharp
public const int ForwardmoveFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ImpulseFieldNumber"></a> ImpulseFieldNumber

```csharp
public const int ImpulseFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_LeftmoveFieldNumber"></a> LeftmoveFieldNumber

```csharp
public const int LeftmoveFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_LegacyCommandNumberFieldNumber"></a> LegacyCommandNumberFieldNumber

```csharp
public const int LegacyCommandNumberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MousedxFieldNumber"></a> MousedxFieldNumber

```csharp
public const int MousedxFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MousedyFieldNumber"></a> MousedyFieldNumber

```csharp
public const int MousedyFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MoveCrcFieldNumber"></a> MoveCrcFieldNumber

```csharp
public const int MoveCrcFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_PawnEntityHandleFieldNumber"></a> PawnEntityHandleFieldNumber

```csharp
public const int PawnEntityHandleFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_PredictionOffsetTicksX256FieldNumber"></a> PredictionOffsetTicksX256FieldNumber

```csharp
public const int PredictionOffsetTicksX256FieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_RandomSeedFieldNumber"></a> RandomSeedFieldNumber

```csharp
public const int RandomSeedFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_SubtickMovesFieldNumber"></a> SubtickMovesFieldNumber

```csharp
public const int SubtickMovesFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_UpmoveFieldNumber"></a> UpmoveFieldNumber

```csharp
public const int UpmoveFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ViewanglesFieldNumber"></a> ViewanglesFieldNumber

```csharp
public const int ViewanglesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_WeaponselectFieldNumber"></a> WeaponselectFieldNumber

```csharp
public const int WeaponselectFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ButtonsPb"></a> ButtonsPb

```csharp
public CInButtonStatePB ButtonsPb { get; set; }
```

#### Property Value

 [CInButtonStatePB](Divine.Protobufs.Dota2.CInButtonStatePB.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClientTick"></a> ClientTick

```csharp
public int ClientTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_CmdFlags"></a> CmdFlags

```csharp
public int CmdFlags { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ConsumedServerAngleChanges"></a> ConsumedServerAngleChanges

```csharp
public uint ConsumedServerAngleChanges { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ExecutionNotes"></a> ExecutionNotes

```csharp
public CBaseUserCmdExecutionNotes ExecutionNotes { get; set; }
```

#### Property Value

 [CBaseUserCmdExecutionNotes](Divine.Protobufs.Dota2.CBaseUserCmdExecutionNotes.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Forwardmove"></a> Forwardmove

```csharp
public float Forwardmove { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasClientTick"></a> HasClientTick

```csharp
public bool HasClientTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasCmdFlags"></a> HasCmdFlags

```csharp
public bool HasCmdFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasConsumedServerAngleChanges"></a> HasConsumedServerAngleChanges

```csharp
public bool HasConsumedServerAngleChanges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasForwardmove"></a> HasForwardmove

```csharp
public bool HasForwardmove { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasImpulse"></a> HasImpulse

```csharp
public bool HasImpulse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasLeftmove"></a> HasLeftmove

```csharp
public bool HasLeftmove { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasLegacyCommandNumber"></a> HasLegacyCommandNumber

```csharp
public bool HasLegacyCommandNumber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasMousedx"></a> HasMousedx

```csharp
public bool HasMousedx { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasMousedy"></a> HasMousedy

```csharp
public bool HasMousedy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasMoveCrc"></a> HasMoveCrc

```csharp
public bool HasMoveCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasPawnEntityHandle"></a> HasPawnEntityHandle

```csharp
public bool HasPawnEntityHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasPredictionOffsetTicksX256"></a> HasPredictionOffsetTicksX256

```csharp
public bool HasPredictionOffsetTicksX256 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasRandomSeed"></a> HasRandomSeed

```csharp
public bool HasRandomSeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasUpmove"></a> HasUpmove

```csharp
public bool HasUpmove { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_HasWeaponselect"></a> HasWeaponselect

```csharp
public bool HasWeaponselect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Impulse"></a> Impulse

```csharp
public int Impulse { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Leftmove"></a> Leftmove

```csharp
public float Leftmove { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_LegacyCommandNumber"></a> LegacyCommandNumber

```csharp
public int LegacyCommandNumber { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Mousedx"></a> Mousedx

```csharp
public int Mousedx { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Mousedy"></a> Mousedy

```csharp
public int Mousedy { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MoveCrc"></a> MoveCrc

```csharp
public ByteString MoveCrc { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Parser"></a> Parser

```csharp
public static MessageParser<CBaseUserCmdPB> Parser { get; }
```

#### Property Value

 MessageParser<[CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)\>

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_PawnEntityHandle"></a> PawnEntityHandle

```csharp
public uint PawnEntityHandle { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_PredictionOffsetTicksX256"></a> PredictionOffsetTicksX256

```csharp
public uint PredictionOffsetTicksX256 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_RandomSeed"></a> RandomSeed

```csharp
public int RandomSeed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_SubtickMoves"></a> SubtickMoves

```csharp
public RepeatedField<CSubtickMoveStep> SubtickMoves { get; }
```

#### Property Value

 RepeatedField<[CSubtickMoveStep](Divine.Protobufs.Dota2.CSubtickMoveStep.md)\>

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Upmove"></a> Upmove

```csharp
public float Upmove { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Viewangles"></a> Viewangles

```csharp
public CMsgQAngle Viewangles { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Weaponselect"></a> Weaponselect

```csharp
public int Weaponselect { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearClientTick"></a> ClearClientTick\(\)

```csharp
public void ClearClientTick()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearCmdFlags"></a> ClearCmdFlags\(\)

```csharp
public void ClearCmdFlags()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearConsumedServerAngleChanges"></a> ClearConsumedServerAngleChanges\(\)

```csharp
public void ClearConsumedServerAngleChanges()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearForwardmove"></a> ClearForwardmove\(\)

```csharp
public void ClearForwardmove()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearImpulse"></a> ClearImpulse\(\)

```csharp
public void ClearImpulse()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearLeftmove"></a> ClearLeftmove\(\)

```csharp
public void ClearLeftmove()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearLegacyCommandNumber"></a> ClearLegacyCommandNumber\(\)

```csharp
public void ClearLegacyCommandNumber()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearMousedx"></a> ClearMousedx\(\)

```csharp
public void ClearMousedx()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearMousedy"></a> ClearMousedy\(\)

```csharp
public void ClearMousedy()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearMoveCrc"></a> ClearMoveCrc\(\)

```csharp
public void ClearMoveCrc()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearPawnEntityHandle"></a> ClearPawnEntityHandle\(\)

```csharp
public void ClearPawnEntityHandle()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearPredictionOffsetTicksX256"></a> ClearPredictionOffsetTicksX256\(\)

```csharp
public void ClearPredictionOffsetTicksX256()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearRandomSeed"></a> ClearRandomSeed\(\)

```csharp
public void ClearRandomSeed()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearUpmove"></a> ClearUpmove\(\)

```csharp
public void ClearUpmove()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ClearWeaponselect"></a> ClearWeaponselect\(\)

```csharp
public void ClearWeaponselect()
```

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Clone"></a> Clone\(\)

```csharp
public CBaseUserCmdPB Clone()
```

#### Returns

 [CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_Equals_Divine_Protobufs_Dota2_CBaseUserCmdPB_"></a> Equals\(CBaseUserCmdPB\)

```csharp
public bool Equals(CBaseUserCmdPB other)
```

#### Parameters

`other` [CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MergeFrom_Divine_Protobufs_Dota2_CBaseUserCmdPB_"></a> MergeFrom\(CBaseUserCmdPB\)

```csharp
public void MergeFrom(CBaseUserCmdPB other)
```

#### Parameters

`other` [CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CBaseUserCmdPB_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

