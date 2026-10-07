# <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo"></a> Class CMsgMonsterHunterCodexUpdateData.Types.KillInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMonsterHunterCodexUpdateData.Types.KillInfo : IMessage<CMsgMonsterHunterCodexUpdateData.Types.KillInfo>, IEquatable<CMsgMonsterHunterCodexUpdateData.Types.KillInfo>, IDeepCloneable<CMsgMonsterHunterCodexUpdateData.Types.KillInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMonsterHunterCodexUpdateData.Types.KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)

#### Implements

IMessage<CMsgMonsterHunterCodexUpdateData.Types.KillInfo\>, 
[IEquatable<CMsgMonsterHunterCodexUpdateData.Types.KillInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMonsterHunterCodexUpdateData.Types.KillInfo\>, 
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
[EnumerableExtensions.In<CMsgMonsterHunterCodexUpdateData.Types.KillInfo\>\(CMsgMonsterHunterCodexUpdateData.Types.KillInfo, params CMsgMonsterHunterCodexUpdateData.Types.KillInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo__ctor"></a> KillInfo\(\)

```csharp
public KillInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo__ctor_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_"></a> KillInfo\(KillInfo\)

```csharp
public KillInfo(CMsgMonsterHunterCodexUpdateData.Types.KillInfo other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_KillCountFieldNumber"></a> KillCountFieldNumber

```csharp
public const int KillCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_HasKillCount"></a> HasKillCount

```csharp
public bool HasKillCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_KillCount"></a> KillCount

```csharp
public int KillCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMonsterHunterCodexUpdateData.Types.KillInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_ClearKillCount"></a> ClearKillCount\(\)

```csharp
public void ClearKillCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_Clone"></a> Clone\(\)

```csharp
public CMsgMonsterHunterCodexUpdateData.Types.KillInfo Clone()
```

#### Returns

 [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_Equals_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_"></a> Equals\(KillInfo\)

```csharp
public bool Equals(CMsgMonsterHunterCodexUpdateData.Types.KillInfo other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_"></a> MergeFrom\(KillInfo\)

```csharp
public void MergeFrom(CMsgMonsterHunterCodexUpdateData.Types.KillInfo other)
```

#### Parameters

`other` [CMsgMonsterHunterCodexUpdateData](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.md).[Types](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.md).[KillInfo](Divine.Protobufs.Dota2.CMsgMonsterHunterCodexUpdateData.Types.KillInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMonsterHunterCodexUpdateData_Types_KillInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

