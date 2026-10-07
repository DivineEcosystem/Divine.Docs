# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData"></a> Class CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData : IMessage<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData>, IEquatable<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData>, IDeepCloneable<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)

#### Implements

IMessage<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData\>, 
[IEquatable<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData\>\(CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData, params CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData__ctor"></a> CCustomGameData\(\)

```csharp
public CCustomGameData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_"></a> CCustomGameData\(CCustomGameData\)

```csharp
public CCustomGameData(CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_DotaTeamFieldNumber"></a> DotaTeamFieldNumber

```csharp
public const int DotaTeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_WinnerFieldNumber"></a> WinnerFieldNumber

```csharp
public const int WinnerFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_DotaTeam"></a> DotaTeam

```csharp
public uint DotaTeam { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_HasDotaTeam"></a> HasDotaTeam

```csharp
public bool HasDotaTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_HasWinner"></a> HasWinner

```csharp
public bool HasWinner { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Winner"></a> Winner

```csharp
public bool Winner { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_ClearDotaTeam"></a> ClearDotaTeam\(\)

```csharp
public void ClearDotaTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_ClearWinner"></a> ClearWinner\(\)

```csharp
public void ClearWinner()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_"></a> Equals\(CCustomGameData\)

```csharp
public bool Equals(CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_"></a> MergeFrom\(CCustomGameData\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CTeam](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.md).[CPlayer](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.md).[CCustomGameData](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CTeam.Types.CPlayer.Types.CCustomGameData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CTeam_Types_CPlayer_Types_CCustomGameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

