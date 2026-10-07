# <a id="Divine_Protobufs_Dota2_CMsgClientHello"></a> Class CMsgClientHello

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientHello : IMessage<CMsgClientHello>, IEquatable<CMsgClientHello>, IDeepCloneable<CMsgClientHello>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)

#### Implements

IMessage<CMsgClientHello\>, 
[IEquatable<CMsgClientHello\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientHello\>, 
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
[EnumerableExtensions.In<CMsgClientHello\>\(CMsgClientHello, params CMsgClientHello\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientHello__ctor"></a> CMsgClientHello\(\)

```csharp
public CMsgClientHello()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello__ctor_Divine_Protobufs_Dota2_CMsgClientHello_"></a> CMsgClientHello\(CMsgClientHello\)

```csharp
public CMsgClientHello(CMsgClientHello other)
```

#### Parameters

`other` [CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientLanguageFieldNumber"></a> ClientLanguageFieldNumber

```csharp
public const int ClientLanguageFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientLauncherFieldNumber"></a> ClientLauncherFieldNumber

```csharp
public const int ClientLauncherFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientSessionNeedFieldNumber"></a> ClientSessionNeedFieldNumber

```csharp
public const int ClientSessionNeedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_EngineFieldNumber"></a> EngineFieldNumber

```csharp
public const int EngineFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_GameMsgFieldNumber"></a> GameMsgFieldNumber

```csharp
public const int GameMsgFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_IsSteamChinaClientFieldNumber"></a> IsSteamChinaClientFieldNumber

```csharp
public const int IsSteamChinaClientFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_IsSteamChinaFieldNumber"></a> IsSteamChinaFieldNumber

```csharp
public const int IsSteamChinaFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_OsTypeFieldNumber"></a> OsTypeFieldNumber

```csharp
public const int OsTypeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_PlatformIdFieldNumber"></a> PlatformIdFieldNumber

```csharp
public const int PlatformIdFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_PlatformNameFieldNumber"></a> PlatformNameFieldNumber

```csharp
public const int PlatformNameFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderHeightFieldNumber"></a> RenderHeightFieldNumber

```csharp
public const int RenderHeightFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderSystemFieldNumber"></a> RenderSystemFieldNumber

```csharp
public const int RenderSystemFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderSystemReqFieldNumber"></a> RenderSystemReqFieldNumber

```csharp
public const int RenderSystemReqFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderWidthFieldNumber"></a> RenderWidthFieldNumber

```csharp
public const int RenderWidthFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenHeightFieldNumber"></a> ScreenHeightFieldNumber

```csharp
public const int ScreenHeightFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenRefreshFieldNumber"></a> ScreenRefreshFieldNumber

```csharp
public const int ScreenRefreshFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenWidthFieldNumber"></a> ScreenWidthFieldNumber

```csharp
public const int ScreenWidthFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SocacheHaveVersionsFieldNumber"></a> SocacheHaveVersionsFieldNumber

```csharp
public const int SocacheHaveVersionsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SteamdatagramLoginFieldNumber"></a> SteamdatagramLoginFieldNumber

```csharp
public const int SteamdatagramLoginFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SwapHeightFieldNumber"></a> SwapHeightFieldNumber

```csharp
public const int SwapHeightFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SwapWidthFieldNumber"></a> SwapWidthFieldNumber

```csharp
public const int SwapWidthFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientLanguage"></a> ClientLanguage

```csharp
public uint ClientLanguage { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientLauncher"></a> ClientLauncher

```csharp
public PartnerAccountType ClientLauncher { get; set; }
```

#### Property Value

 [PartnerAccountType](Divine.Protobufs.Dota2.PartnerAccountType.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClientSessionNeed"></a> ClientSessionNeed

```csharp
public uint ClientSessionNeed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Engine"></a> Engine

```csharp
public ESourceEngine Engine { get; set; }
```

#### Property Value

 [ESourceEngine](Divine.Protobufs.Dota2.ESourceEngine.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_GameMsg"></a> GameMsg

```csharp
public ByteString GameMsg { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasClientLanguage"></a> HasClientLanguage

```csharp
public bool HasClientLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasClientLauncher"></a> HasClientLauncher

```csharp
public bool HasClientLauncher { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasClientSessionNeed"></a> HasClientSessionNeed

```csharp
public bool HasClientSessionNeed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasEngine"></a> HasEngine

```csharp
public bool HasEngine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasGameMsg"></a> HasGameMsg

```csharp
public bool HasGameMsg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasIsSteamChina"></a> HasIsSteamChina

```csharp
public bool HasIsSteamChina { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasIsSteamChinaClient"></a> HasIsSteamChinaClient

```csharp
public bool HasIsSteamChinaClient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasOsType"></a> HasOsType

```csharp
public bool HasOsType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasPlatformId"></a> HasPlatformId

```csharp
public bool HasPlatformId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasPlatformName"></a> HasPlatformName

```csharp
public bool HasPlatformName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasRenderHeight"></a> HasRenderHeight

```csharp
public bool HasRenderHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasRenderSystem"></a> HasRenderSystem

```csharp
public bool HasRenderSystem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasRenderSystemReq"></a> HasRenderSystemReq

```csharp
public bool HasRenderSystemReq { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasRenderWidth"></a> HasRenderWidth

```csharp
public bool HasRenderWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasScreenHeight"></a> HasScreenHeight

```csharp
public bool HasScreenHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasScreenRefresh"></a> HasScreenRefresh

```csharp
public bool HasScreenRefresh { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasScreenWidth"></a> HasScreenWidth

```csharp
public bool HasScreenWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasSteamdatagramLogin"></a> HasSteamdatagramLogin

```csharp
public bool HasSteamdatagramLogin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasSwapHeight"></a> HasSwapHeight

```csharp
public bool HasSwapHeight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasSwapWidth"></a> HasSwapWidth

```csharp
public bool HasSwapWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_IsSteamChina"></a> IsSteamChina

```csharp
public bool IsSteamChina { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_IsSteamChinaClient"></a> IsSteamChinaClient

```csharp
public bool IsSteamChinaClient { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_OsType"></a> OsType

```csharp
public int OsType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientHello> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_PlatformId"></a> PlatformId

```csharp
public uint PlatformId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_PlatformName"></a> PlatformName

```csharp
public string PlatformName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderHeight"></a> RenderHeight

```csharp
public uint RenderHeight { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderSystem"></a> RenderSystem

```csharp
public uint RenderSystem { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderSystemReq"></a> RenderSystemReq

```csharp
public uint RenderSystemReq { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_RenderWidth"></a> RenderWidth

```csharp
public uint RenderWidth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenHeight"></a> ScreenHeight

```csharp
public uint ScreenHeight { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenRefresh"></a> ScreenRefresh

```csharp
public uint ScreenRefresh { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ScreenWidth"></a> ScreenWidth

```csharp
public uint ScreenWidth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SocacheHaveVersions"></a> SocacheHaveVersions

```csharp
public RepeatedField<CMsgSOCacheHaveVersion> SocacheHaveVersions { get; }
```

#### Property Value

 RepeatedField<[CMsgSOCacheHaveVersion](Divine.Protobufs.Dota2.CMsgSOCacheHaveVersion.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SteamdatagramLogin"></a> SteamdatagramLogin

```csharp
public ByteString SteamdatagramLogin { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SwapHeight"></a> SwapHeight

```csharp
public uint SwapHeight { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_SwapWidth"></a> SwapWidth

```csharp
public uint SwapWidth { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearClientLanguage"></a> ClearClientLanguage\(\)

```csharp
public void ClearClientLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearClientLauncher"></a> ClearClientLauncher\(\)

```csharp
public void ClearClientLauncher()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearClientSessionNeed"></a> ClearClientSessionNeed\(\)

```csharp
public void ClearClientSessionNeed()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearEngine"></a> ClearEngine\(\)

```csharp
public void ClearEngine()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearGameMsg"></a> ClearGameMsg\(\)

```csharp
public void ClearGameMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearIsSteamChina"></a> ClearIsSteamChina\(\)

```csharp
public void ClearIsSteamChina()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearIsSteamChinaClient"></a> ClearIsSteamChinaClient\(\)

```csharp
public void ClearIsSteamChinaClient()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearOsType"></a> ClearOsType\(\)

```csharp
public void ClearOsType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearPlatformId"></a> ClearPlatformId\(\)

```csharp
public void ClearPlatformId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearPlatformName"></a> ClearPlatformName\(\)

```csharp
public void ClearPlatformName()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearRenderHeight"></a> ClearRenderHeight\(\)

```csharp
public void ClearRenderHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearRenderSystem"></a> ClearRenderSystem\(\)

```csharp
public void ClearRenderSystem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearRenderSystemReq"></a> ClearRenderSystemReq\(\)

```csharp
public void ClearRenderSystemReq()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearRenderWidth"></a> ClearRenderWidth\(\)

```csharp
public void ClearRenderWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearScreenHeight"></a> ClearScreenHeight\(\)

```csharp
public void ClearScreenHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearScreenRefresh"></a> ClearScreenRefresh\(\)

```csharp
public void ClearScreenRefresh()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearScreenWidth"></a> ClearScreenWidth\(\)

```csharp
public void ClearScreenWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearSteamdatagramLogin"></a> ClearSteamdatagramLogin\(\)

```csharp
public void ClearSteamdatagramLogin()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearSwapHeight"></a> ClearSwapHeight\(\)

```csharp
public void ClearSwapHeight()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearSwapWidth"></a> ClearSwapWidth\(\)

```csharp
public void ClearSwapWidth()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Clone"></a> Clone\(\)

```csharp
public CMsgClientHello Clone()
```

#### Returns

 [CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_Equals_Divine_Protobufs_Dota2_CMsgClientHello_"></a> Equals\(CMsgClientHello\)

```csharp
public bool Equals(CMsgClientHello other)
```

#### Parameters

`other` [CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_MergeFrom_Divine_Protobufs_Dota2_CMsgClientHello_"></a> MergeFrom\(CMsgClientHello\)

```csharp
public void MergeFrom(CMsgClientHello other)
```

#### Parameters

`other` [CMsgClientHello](Divine.Protobufs.Dota2.CMsgClientHello.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientHello_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

