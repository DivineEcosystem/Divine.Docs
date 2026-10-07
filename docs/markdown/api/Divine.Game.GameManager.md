# <a id="Divine_Game_GameManager"></a> Class GameManager

Namespace: [Divine.Game](Divine.Game.md)  
Assembly: Divine.dll  

```csharp
public static class GameManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GameManager](Divine.Game.GameManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Properties

### <a id="Divine_Game_GameManager_AvgPing"></a> AvgPing

```csharp
public static float AvgPing { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_BuildVersion"></a> BuildVersion

```csharp
public static uint BuildVersion { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Game_GameManager_ExpectedPlayers"></a> ExpectedPlayers

```csharp
public static int ExpectedPlayers { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Game_GameManager_FPS"></a> FPS

```csharp
public static float FPS { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_FrameCount"></a> FrameCount

```csharp
public static int FrameCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Game_GameManager_FrameTime"></a> FrameTime

```csharp
public static float FrameTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_FullAccessGameEvent"></a> FullAccessGameEvent

```csharp
public static bool FullAccessGameEvent { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_GameMode"></a> GameMode

```csharp
public static GameMode GameMode { get; }
```

#### Property Value

 [GameMode](Divine.Game.GameMode.md)

### <a id="Divine_Game_GameManager_GameState"></a> GameState

```csharp
public static GameState GameState { get; }
```

#### Property Value

 [GameState](Divine.Game.GameState.md)

### <a id="Divine_Game_GameManager_GameTime"></a> GameTime

```csharp
public static float GameTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_GlyphCooldownDire"></a> GlyphCooldownDire

```csharp
public static float GlyphCooldownDire { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_GlyphCooldownRadiant"></a> GlyphCooldownRadiant

```csharp
public static float GlyphCooldownRadiant { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_IsChatOpen"></a> IsChatOpen

```csharp
public static bool IsChatOpen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsConnected"></a> IsConnected

```csharp
public static bool IsConnected { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsCustomGame"></a> IsCustomGame

```csharp
public static bool IsCustomGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsEventGame"></a> IsEventGame

```csharp
public static bool IsEventGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsHudFlipped"></a> IsHudFlipped

```csharp
public static bool IsHudFlipped { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsInGame"></a> IsInGame

```csharp
public static bool IsInGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsInGameLoop"></a> IsInGameLoop

```csharp
public static bool IsInGameLoop { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsLobbyGame"></a> IsLobbyGame

```csharp
public static bool IsLobbyGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsNight"></a> IsNight

```csharp
public static bool IsNight { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsPaused"></a> IsPaused

```csharp
public static bool IsPaused { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsShopOpen"></a> IsShopOpen

```csharp
public static bool IsShopOpen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_IsWatchingGame"></a> IsWatchingGame

```csharp
public static bool IsWatchingGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Game_GameManager_ItemStockInfos"></a> ItemStockInfos

```csharp
public static IEnumerable<ItemStockInfo> ItemStockInfos { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ItemStockInfo](Divine.Game.ItemStockInfo.md)\>

### <a id="Divine_Game_GameManager_LevelName"></a> LevelName

```csharp
[Obsolete("this is obsolete, use MapManager.MapFileName")]
public static string LevelName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Game_GameManager_LoadedPlayers"></a> LoadedPlayers

```csharp
public static int LoadedPlayers { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Game_GameManager_MatchId"></a> MatchId

```csharp
public static ulong MatchId { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Game_GameManager_MousePosition"></a> MousePosition

```csharp
public static Vector3 MousePosition { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Game_GameManager_MouseScreenPosition"></a> MouseScreenPosition

```csharp
public static Vector2 MouseScreenPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="Divine_Game_GameManager_NeutralCamps"></a> NeutralCamps

```csharp
public static IEnumerable<NeutralCamp> NeutralCamps { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[NeutralCamp](Divine.Game.NeutralCamp.md)\>

### <a id="Divine_Game_GameManager_Ping"></a> Ping

```csharp
public static float Ping { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_RawGameTime"></a> RawGameTime

```csharp
public static float RawGameTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_RiverType"></a> RiverType

```csharp
public static RiverType RiverType { get; set; }
```

#### Property Value

 [RiverType](Divine.Game.RiverType.md)

### <a id="Divine_Game_GameManager_ScanChargesDire"></a> ScanChargesDire

```csharp
public static float ScanChargesDire { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_ScanChargesRadiant"></a> ScanChargesRadiant

```csharp
public static int ScanChargesRadiant { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Game_GameManager_ScanCooldownDire"></a> ScanCooldownDire

```csharp
public static float ScanCooldownDire { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_ScanCooldownRadiant"></a> ScanCooldownRadiant

```csharp
public static float ScanCooldownRadiant { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Game_GameManager_ShortLevelName"></a> ShortLevelName

```csharp
[Obsolete("this is obsolete, use MapManager.MapName")]
public static string ShortLevelName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Game_GameManager_SteamId"></a> SteamId

```csharp
public static uint SteamId { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Game_GameManager_Time"></a> Time

```csharp
public static float Time { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Game_GameManager_AcceptMatch"></a> AcceptMatch\(\)

```csharp
public static void AcceptMatch()
```

### <a id="Divine_Game_GameManager_Disconnect"></a> Disconnect\(\)

```csharp
public static void Disconnect()
```

### <a id="Divine_Game_GameManager_FinishGame"></a> FinishGame\(\)

```csharp
public static void FinishGame()
```

### <a id="Divine_Game_GameManager_GetLocalize_System_String_"></a> GetLocalize\(string\)

```csharp
public static string GetLocalize(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Game_GameManager_LeaveCurrentGame"></a> LeaveCurrentGame\(\)

```csharp
public static void LeaveCurrentGame()
```

### <a id="Divine_Game_GameManager_Reconnect"></a> Reconnect\(\)

```csharp
public static void Reconnect()
```

### <a id="Divine_Game_GameManager_GameEvent"></a> GameEvent

```csharp
public static event GameManager.GameEventEventHandler GameEvent
```

#### Event Type

 [GameManager](Divine.Game.GameManager.md).[GameEventEventHandler](Divine.Game.GameManager.GameEventEventHandler.md)

### <a id="Divine_Game_GameManager_GameStateChanged"></a> GameStateChanged

```csharp
public static event GameManager.GameStateChangedEventHandler GameStateChanged
```

#### Event Type

 [GameManager](Divine.Game.GameManager.md).[GameStateChangedEventHandler](Divine.Game.GameManager.GameStateChangedEventHandler.md)

