# <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo"></a> Class CMsgSignOutBotInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutBotInfo : IMessage<CMsgSignOutBotInfo>, IEquatable<CMsgSignOutBotInfo>, IDeepCloneable<CMsgSignOutBotInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)

#### Implements

IMessage<CMsgSignOutBotInfo\>, 
[IEquatable<CMsgSignOutBotInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutBotInfo\>, 
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
[EnumerableExtensions.In<CMsgSignOutBotInfo\>\(CMsgSignOutBotInfo, params CMsgSignOutBotInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo__ctor"></a> CMsgSignOutBotInfo\(\)

```csharp
public CMsgSignOutBotInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo__ctor_Divine_Protobufs_Dota2_CMsgSignOutBotInfo_"></a> CMsgSignOutBotInfo\(CMsgSignOutBotInfo\)

```csharp
public CMsgSignOutBotInfo(CMsgSignOutBotInfo other)
```

#### Parameters

`other` [CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_AllowCheatsFieldNumber"></a> AllowCheatsFieldNumber

```csharp
public const int AllowCheatsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_BotDifficultyDireFieldNumber"></a> BotDifficultyDireFieldNumber

```csharp
public const int BotDifficultyDireFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_BotDifficultyRadiantFieldNumber"></a> BotDifficultyRadiantFieldNumber

```csharp
public const int BotDifficultyRadiantFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_CreatedLobbyFieldNumber"></a> CreatedLobbyFieldNumber

```csharp
public const int CreatedLobbyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_AllowCheats"></a> AllowCheats

```csharp
public bool AllowCheats { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_BotDifficultyDire"></a> BotDifficultyDire

```csharp
public DOTABotDifficulty BotDifficultyDire { get; set; }
```

#### Property Value

 [DOTABotDifficulty](Divine.Protobufs.Dota2.DOTABotDifficulty.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_BotDifficultyRadiant"></a> BotDifficultyRadiant

```csharp
public DOTABotDifficulty BotDifficultyRadiant { get; set; }
```

#### Property Value

 [DOTABotDifficulty](Divine.Protobufs.Dota2.DOTABotDifficulty.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_CreatedLobby"></a> CreatedLobby

```csharp
public bool CreatedLobby { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_HasAllowCheats"></a> HasAllowCheats

```csharp
public bool HasAllowCheats { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_HasBotDifficultyDire"></a> HasBotDifficultyDire

```csharp
public bool HasBotDifficultyDire { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_HasBotDifficultyRadiant"></a> HasBotDifficultyRadiant

```csharp
public bool HasBotDifficultyRadiant { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_HasCreatedLobby"></a> HasCreatedLobby

```csharp
public bool HasCreatedLobby { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutBotInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_ClearAllowCheats"></a> ClearAllowCheats\(\)

```csharp
public void ClearAllowCheats()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_ClearBotDifficultyDire"></a> ClearBotDifficultyDire\(\)

```csharp
public void ClearBotDifficultyDire()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_ClearBotDifficultyRadiant"></a> ClearBotDifficultyRadiant\(\)

```csharp
public void ClearBotDifficultyRadiant()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_ClearCreatedLobby"></a> ClearCreatedLobby\(\)

```csharp
public void ClearCreatedLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutBotInfo Clone()
```

#### Returns

 [CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_Equals_Divine_Protobufs_Dota2_CMsgSignOutBotInfo_"></a> Equals\(CMsgSignOutBotInfo\)

```csharp
public bool Equals(CMsgSignOutBotInfo other)
```

#### Parameters

`other` [CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutBotInfo_"></a> MergeFrom\(CMsgSignOutBotInfo\)

```csharp
public void MergeFrom(CMsgSignOutBotInfo other)
```

#### Parameters

`other` [CMsgSignOutBotInfo](Divine.Protobufs.Dota2.CMsgSignOutBotInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBotInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

