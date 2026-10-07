# <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate"></a> Class CMsgBotGameCreate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotGameCreate : IMessage<CMsgBotGameCreate>, IEquatable<CMsgBotGameCreate>, IDeepCloneable<CMsgBotGameCreate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)

#### Implements

IMessage<CMsgBotGameCreate\>, 
[IEquatable<CMsgBotGameCreate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotGameCreate\>, 
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
[EnumerableExtensions.In<CMsgBotGameCreate\>\(CMsgBotGameCreate, params CMsgBotGameCreate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate__ctor"></a> CMsgBotGameCreate\(\)

```csharp
public CMsgBotGameCreate()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate__ctor_Divine_Protobufs_Dota2_CMsgBotGameCreate_"></a> CMsgBotGameCreate\(CMsgBotGameCreate\)

```csharp
public CMsgBotGameCreate(CMsgBotGameCreate other)
```

#### Parameters

`other` [CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_DifficultyDireFieldNumber"></a> DifficultyDireFieldNumber

```csharp
public const int DifficultyDireFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_DifficultyRadiantFieldNumber"></a> DifficultyRadiantFieldNumber

```csharp
public const int DifficultyRadiantFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_SearchKeyFieldNumber"></a> SearchKeyFieldNumber

```csharp
public const int SearchKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_DifficultyDire"></a> DifficultyDire

```csharp
public DOTABotDifficulty DifficultyDire { get; set; }
```

#### Property Value

 [DOTABotDifficulty](Divine.Protobufs.Dota2.DOTABotDifficulty.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_DifficultyRadiant"></a> DifficultyRadiant

```csharp
public DOTABotDifficulty DifficultyRadiant { get; set; }
```

#### Property Value

 [DOTABotDifficulty](Divine.Protobufs.Dota2.DOTABotDifficulty.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_GameMode"></a> GameMode

```csharp
public uint GameMode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasDifficultyDire"></a> HasDifficultyDire

```csharp
public bool HasDifficultyDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasDifficultyRadiant"></a> HasDifficultyRadiant

```csharp
public bool HasDifficultyRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasSearchKey"></a> HasSearchKey

```csharp
public bool HasSearchKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotGameCreate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_SearchKey"></a> SearchKey

```csharp
public string SearchKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Team"></a> Team

```csharp
public DOTA_GC_TEAM Team { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearDifficultyDire"></a> ClearDifficultyDire\(\)

```csharp
public void ClearDifficultyDire()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearDifficultyRadiant"></a> ClearDifficultyRadiant\(\)

```csharp
public void ClearDifficultyRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearSearchKey"></a> ClearSearchKey\(\)

```csharp
public void ClearSearchKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Clone"></a> Clone\(\)

```csharp
public CMsgBotGameCreate Clone()
```

#### Returns

 [CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_Equals_Divine_Protobufs_Dota2_CMsgBotGameCreate_"></a> Equals\(CMsgBotGameCreate\)

```csharp
public bool Equals(CMsgBotGameCreate other)
```

#### Parameters

`other` [CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_MergeFrom_Divine_Protobufs_Dota2_CMsgBotGameCreate_"></a> MergeFrom\(CMsgBotGameCreate\)

```csharp
public void MergeFrom(CMsgBotGameCreate other)
```

#### Parameters

`other` [CMsgBotGameCreate](Divine.Protobufs.Dota2.CMsgBotGameCreate.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotGameCreate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

