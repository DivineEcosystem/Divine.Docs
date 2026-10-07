# <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration"></a> Class CSVCMsg\_GameSessionConfiguration

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_GameSessionConfiguration : IMessage<CSVCMsg_GameSessionConfiguration>, IEquatable<CSVCMsg_GameSessionConfiguration>, IDeepCloneable<CSVCMsg_GameSessionConfiguration>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

#### Implements

IMessage<CSVCMsg\_GameSessionConfiguration\>, 
[IEquatable<CSVCMsg\_GameSessionConfiguration\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_GameSessionConfiguration\>, 
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
[EnumerableExtensions.In<CSVCMsg\_GameSessionConfiguration\>\(CSVCMsg\_GameSessionConfiguration, params CSVCMsg\_GameSessionConfiguration\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration__ctor"></a> CSVCMsg\_GameSessionConfiguration\(\)

```csharp
public CSVCMsg_GameSessionConfiguration()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration__ctor_Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_"></a> CSVCMsg\_GameSessionConfiguration\(CSVCMsg\_GameSessionConfiguration\)

```csharp
public CSVCMsg_GameSessionConfiguration(CSVCMsg_GameSessionConfiguration other)
```

#### Parameters

`other` [CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_GamemodeFieldNumber"></a> GamemodeFieldNumber

```csharp
public const int GamemodeFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HostnameFieldNumber"></a> HostnameFieldNumber

```csharp
public const int HostnameFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsBackgroundMapFieldNumber"></a> IsBackgroundMapFieldNumber

```csharp
public const int IsBackgroundMapFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsHeadlessFieldNumber"></a> IsHeadlessFieldNumber

```csharp
public const int IsHeadlessFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsLoadsavegameFieldNumber"></a> IsLoadsavegameFieldNumber

```csharp
public const int IsLoadsavegameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsLocalonlyFieldNumber"></a> IsLocalonlyFieldNumber

```csharp
public const int IsLocalonlyFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsMultiplayerFieldNumber"></a> IsMultiplayerFieldNumber

```csharp
public const int IsMultiplayerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsTransitionFieldNumber"></a> IsTransitionFieldNumber

```csharp
public const int IsTransitionFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_LandmarknameFieldNumber"></a> LandmarknameFieldNumber

```csharp
public const int LandmarknameFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxClientLimitFieldNumber"></a> MaxClientLimitFieldNumber

```csharp
public const int MaxClientLimitFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxClientsFieldNumber"></a> MaxClientsFieldNumber

```csharp
public const int MaxClientsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxCoordFieldNumber"></a> MaxCoordFieldNumber

```csharp
public const int MaxCoordFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MinClientLimitFieldNumber"></a> MinClientLimitFieldNumber

```csharp
public const int MinClientLimitFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_NoSteamServerFieldNumber"></a> NoSteamServerFieldNumber

```csharp
public const int NoSteamServerFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_PreviouslevelFieldNumber"></a> PreviouslevelFieldNumber

```csharp
public const int PreviouslevelFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_QuantizedFloatEncoderAliasesFieldNumber"></a> QuantizedFloatEncoderAliasesFieldNumber

```csharp
public const int QuantizedFloatEncoderAliasesFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_S1MapnameFieldNumber"></a> S1MapnameFieldNumber

```csharp
public const int S1MapnameFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_SavegamenameFieldNumber"></a> SavegamenameFieldNumber

```csharp
public const int SavegamenameFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ServerIpAddressFieldNumber"></a> ServerIpAddressFieldNumber

```csharp
public const int ServerIpAddressFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_TickIntervalFieldNumber"></a> TickIntervalFieldNumber

```csharp
public const int TickIntervalFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Gamemode"></a> Gamemode

```csharp
public string Gamemode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasGamemode"></a> HasGamemode

```csharp
public bool HasGamemode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasHostname"></a> HasHostname

```csharp
public bool HasHostname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsBackgroundMap"></a> HasIsBackgroundMap

```csharp
public bool HasIsBackgroundMap { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsHeadless"></a> HasIsHeadless

```csharp
public bool HasIsHeadless { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsLoadsavegame"></a> HasIsLoadsavegame

```csharp
public bool HasIsLoadsavegame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsLocalonly"></a> HasIsLocalonly

```csharp
public bool HasIsLocalonly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsMultiplayer"></a> HasIsMultiplayer

```csharp
public bool HasIsMultiplayer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasIsTransition"></a> HasIsTransition

```csharp
public bool HasIsTransition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasLandmarkname"></a> HasLandmarkname

```csharp
public bool HasLandmarkname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasMaxClientLimit"></a> HasMaxClientLimit

```csharp
public bool HasMaxClientLimit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasMaxClients"></a> HasMaxClients

```csharp
public bool HasMaxClients { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasMaxCoord"></a> HasMaxCoord

```csharp
public bool HasMaxCoord { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasMinClientLimit"></a> HasMinClientLimit

```csharp
public bool HasMinClientLimit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasNoSteamServer"></a> HasNoSteamServer

```csharp
public bool HasNoSteamServer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasPreviouslevel"></a> HasPreviouslevel

```csharp
public bool HasPreviouslevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasS1Mapname"></a> HasS1Mapname

```csharp
public bool HasS1Mapname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasSavegamename"></a> HasSavegamename

```csharp
public bool HasSavegamename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasServerIpAddress"></a> HasServerIpAddress

```csharp
public bool HasServerIpAddress { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_HasTickInterval"></a> HasTickInterval

```csharp
public bool HasTickInterval { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Hostname"></a> Hostname

```csharp
public string Hostname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsBackgroundMap"></a> IsBackgroundMap

```csharp
public bool IsBackgroundMap { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsHeadless"></a> IsHeadless

```csharp
public bool IsHeadless { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsLoadsavegame"></a> IsLoadsavegame

```csharp
public bool IsLoadsavegame { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsLocalonly"></a> IsLocalonly

```csharp
public bool IsLocalonly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsMultiplayer"></a> IsMultiplayer

```csharp
public bool IsMultiplayer { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_IsTransition"></a> IsTransition

```csharp
public bool IsTransition { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Landmarkname"></a> Landmarkname

```csharp
public string Landmarkname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxClientLimit"></a> MaxClientLimit

```csharp
public uint MaxClientLimit { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxClients"></a> MaxClients

```csharp
public uint MaxClients { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MaxCoord"></a> MaxCoord

```csharp
public float MaxCoord { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MinClientLimit"></a> MinClientLimit

```csharp
public uint MinClientLimit { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_NoSteamServer"></a> NoSteamServer

```csharp
public bool NoSteamServer { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_GameSessionConfiguration> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Previouslevel"></a> Previouslevel

```csharp
public string Previouslevel { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_QuantizedFloatEncoderAliases"></a> QuantizedFloatEncoderAliases

```csharp
public RepeatedField<QuantizedFloatEncoderAlias_t> QuantizedFloatEncoderAliases { get; }
```

#### Property Value

 RepeatedField<[QuantizedFloatEncoderAlias\_t](Divine.Protobufs.Dota2.QuantizedFloatEncoderAlias\_t.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_S1Mapname"></a> S1Mapname

```csharp
public string S1Mapname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Savegamename"></a> Savegamename

```csharp
public string Savegamename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ServerIpAddress"></a> ServerIpAddress

```csharp
public string ServerIpAddress { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_TickInterval"></a> TickInterval

```csharp
public uint TickInterval { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearGamemode"></a> ClearGamemode\(\)

```csharp
public void ClearGamemode()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearHostname"></a> ClearHostname\(\)

```csharp
public void ClearHostname()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsBackgroundMap"></a> ClearIsBackgroundMap\(\)

```csharp
public void ClearIsBackgroundMap()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsHeadless"></a> ClearIsHeadless\(\)

```csharp
public void ClearIsHeadless()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsLoadsavegame"></a> ClearIsLoadsavegame\(\)

```csharp
public void ClearIsLoadsavegame()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsLocalonly"></a> ClearIsLocalonly\(\)

```csharp
public void ClearIsLocalonly()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsMultiplayer"></a> ClearIsMultiplayer\(\)

```csharp
public void ClearIsMultiplayer()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearIsTransition"></a> ClearIsTransition\(\)

```csharp
public void ClearIsTransition()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearLandmarkname"></a> ClearLandmarkname\(\)

```csharp
public void ClearLandmarkname()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearMaxClientLimit"></a> ClearMaxClientLimit\(\)

```csharp
public void ClearMaxClientLimit()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearMaxClients"></a> ClearMaxClients\(\)

```csharp
public void ClearMaxClients()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearMaxCoord"></a> ClearMaxCoord\(\)

```csharp
public void ClearMaxCoord()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearMinClientLimit"></a> ClearMinClientLimit\(\)

```csharp
public void ClearMinClientLimit()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearNoSteamServer"></a> ClearNoSteamServer\(\)

```csharp
public void ClearNoSteamServer()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearPreviouslevel"></a> ClearPreviouslevel\(\)

```csharp
public void ClearPreviouslevel()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearS1Mapname"></a> ClearS1Mapname\(\)

```csharp
public void ClearS1Mapname()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearSavegamename"></a> ClearSavegamename\(\)

```csharp
public void ClearSavegamename()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearServerIpAddress"></a> ClearServerIpAddress\(\)

```csharp
public void ClearServerIpAddress()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ClearTickInterval"></a> ClearTickInterval\(\)

```csharp
public void ClearTickInterval()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_GameSessionConfiguration Clone()
```

#### Returns

 [CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_Equals_Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_"></a> Equals\(CSVCMsg\_GameSessionConfiguration\)

```csharp
public bool Equals(CSVCMsg_GameSessionConfiguration other)
```

#### Parameters

`other` [CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_"></a> MergeFrom\(CSVCMsg\_GameSessionConfiguration\)

```csharp
public void MergeFrom(CSVCMsg_GameSessionConfiguration other)
```

#### Parameters

`other` [CSVCMsg\_GameSessionConfiguration](Divine.Protobufs.Dota2.CSVCMsg\_GameSessionConfiguration.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_GameSessionConfiguration_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

