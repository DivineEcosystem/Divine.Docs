# <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo"></a> Class CSVCMsg\_ServerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_ServerInfo : IMessage<CSVCMsg_ServerInfo>, IEquatable<CSVCMsg_ServerInfo>, IDeepCloneable<CSVCMsg_ServerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)

#### Implements

IMessage<CSVCMsg\_ServerInfo\>, 
[IEquatable<CSVCMsg\_ServerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_ServerInfo\>, 
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
[EnumerableExtensions.In<CSVCMsg\_ServerInfo\>\(CSVCMsg\_ServerInfo, params CSVCMsg\_ServerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo__ctor"></a> CSVCMsg\_ServerInfo\(\)

```csharp
public CSVCMsg_ServerInfo()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo__ctor_Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_"></a> CSVCMsg\_ServerInfo\(CSVCMsg\_ServerInfo\)

```csharp
public CSVCMsg_ServerInfo(CSVCMsg_ServerInfo other)
```

#### Parameters

`other` [CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_AddonNameFieldNumber"></a> AddonNameFieldNumber

```csharp
public const int AddonNameFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_COsFieldNumber"></a> COsFieldNumber

```csharp
public const int COsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameDirFieldNumber"></a> GameDirFieldNumber

```csharp
public const int GameDirFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameSessionConfigFieldNumber"></a> GameSessionConfigFieldNumber

```csharp
public const int GameSessionConfigFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameSessionManifestFieldNumber"></a> GameSessionManifestFieldNumber

```csharp
public const int GameSessionManifestFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HostNameFieldNumber"></a> HostNameFieldNumber

```csharp
public const int HostNameFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_IsDedicatedFieldNumber"></a> IsDedicatedFieldNumber

```csharp
public const int IsDedicatedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_IsHltvFieldNumber"></a> IsHltvFieldNumber

```csharp
public const int IsHltvFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MapNameFieldNumber"></a> MapNameFieldNumber

```csharp
public const int MapNameFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MaxClassesFieldNumber"></a> MaxClassesFieldNumber

```csharp
public const int MaxClassesFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MaxClientsFieldNumber"></a> MaxClientsFieldNumber

```csharp
public const int MaxClientsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ProtocolFieldNumber"></a> ProtocolFieldNumber

```csharp
public const int ProtocolFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ServerCountFieldNumber"></a> ServerCountFieldNumber

```csharp
public const int ServerCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_SkyNameFieldNumber"></a> SkyNameFieldNumber

```csharp
public const int SkyNameFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_TickIntervalFieldNumber"></a> TickIntervalFieldNumber

```csharp
public const int TickIntervalFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_AddonName"></a> AddonName

```csharp
public string AddonName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_COs"></a> COs

```csharp
public int COs { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameDir"></a> GameDir

```csharp
public string GameDir { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameSessionConfig"></a> GameSessionConfig

```csharp
public CSVCMsg_GameSessionConfiguration GameSessionConfig { get; set; }
```

#### Property Value

 [CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GameSessionManifest"></a> GameSessionManifest

```csharp
public ByteString GameSessionManifest { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasAddonName"></a> HasAddonName

```csharp
public bool HasAddonName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasCOs"></a> HasCOs

```csharp
public bool HasCOs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasGameDir"></a> HasGameDir

```csharp
public bool HasGameDir { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasGameSessionManifest"></a> HasGameSessionManifest

```csharp
public bool HasGameSessionManifest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasHostName"></a> HasHostName

```csharp
public bool HasHostName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasIsDedicated"></a> HasIsDedicated

```csharp
public bool HasIsDedicated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasIsHltv"></a> HasIsHltv

```csharp
public bool HasIsHltv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasMapName"></a> HasMapName

```csharp
public bool HasMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasMaxClasses"></a> HasMaxClasses

```csharp
public bool HasMaxClasses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasMaxClients"></a> HasMaxClients

```csharp
public bool HasMaxClients { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasProtocol"></a> HasProtocol

```csharp
public bool HasProtocol { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasServerCount"></a> HasServerCount

```csharp
public bool HasServerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasSkyName"></a> HasSkyName

```csharp
public bool HasSkyName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HasTickInterval"></a> HasTickInterval

```csharp
public bool HasTickInterval { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_HostName"></a> HostName

```csharp
public string HostName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_IsDedicated"></a> IsDedicated

```csharp
public bool IsDedicated { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_IsHltv"></a> IsHltv

```csharp
public bool IsHltv { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MapName"></a> MapName

```csharp
public string MapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MaxClasses"></a> MaxClasses

```csharp
public int MaxClasses { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MaxClients"></a> MaxClients

```csharp
public int MaxClients { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_ServerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_PlayerSlot"></a> PlayerSlot

```csharp
public int PlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Protocol"></a> Protocol

```csharp
public int Protocol { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ServerCount"></a> ServerCount

```csharp
public int ServerCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_SkyName"></a> SkyName

```csharp
public string SkyName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_TickInterval"></a> TickInterval

```csharp
public float TickInterval { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearAddonName"></a> ClearAddonName\(\)

```csharp
public void ClearAddonName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearCOs"></a> ClearCOs\(\)

```csharp
public void ClearCOs()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearGameDir"></a> ClearGameDir\(\)

```csharp
public void ClearGameDir()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearGameSessionManifest"></a> ClearGameSessionManifest\(\)

```csharp
public void ClearGameSessionManifest()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearHostName"></a> ClearHostName\(\)

```csharp
public void ClearHostName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearIsDedicated"></a> ClearIsDedicated\(\)

```csharp
public void ClearIsDedicated()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearIsHltv"></a> ClearIsHltv\(\)

```csharp
public void ClearIsHltv()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearMapName"></a> ClearMapName\(\)

```csharp
public void ClearMapName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearMaxClasses"></a> ClearMaxClasses\(\)

```csharp
public void ClearMaxClasses()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearMaxClients"></a> ClearMaxClients\(\)

```csharp
public void ClearMaxClients()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearProtocol"></a> ClearProtocol\(\)

```csharp
public void ClearProtocol()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearServerCount"></a> ClearServerCount\(\)

```csharp
public void ClearServerCount()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearSkyName"></a> ClearSkyName\(\)

```csharp
public void ClearSkyName()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ClearTickInterval"></a> ClearTickInterval\(\)

```csharp
public void ClearTickInterval()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_ServerInfo Clone()
```

#### Returns

 [CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_Equals_Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_"></a> Equals\(CSVCMsg\_ServerInfo\)

```csharp
public bool Equals(CSVCMsg_ServerInfo other)
```

#### Parameters

`other` [CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_"></a> MergeFrom\(CSVCMsg\_ServerInfo\)

```csharp
public void MergeFrom(CSVCMsg_ServerInfo other)
```

#### Parameters

`other` [CSVCMsg\_ServerInfo](Divine.Protobufs.Dota2.CSVCMsg\_ServerInfo.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_ServerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

