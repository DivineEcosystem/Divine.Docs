# <a id="Divine_Sound_SoundManager"></a> Class SoundManager

Namespace: [Divine.Sound](Divine.Sound.md)  
Assembly: Divine.dll  

```csharp
public static class SoundManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SoundManager](Divine.Sound.SoundManager.md)

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

## Methods

### <a id="Divine_Sound_SoundManager_GetSoundEventHash_System_ReadOnlySpan_System_Byte__"></a> GetSoundEventHash\(ReadOnlySpan<byte\>\)

```csharp
public static uint GetSoundEventHash(ReadOnlySpan<byte> name)
```

#### Parameters

`name` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_GetSoundEventHash_System_ReadOnlySpan_System_Char__"></a> GetSoundEventHash\(ReadOnlySpan<char\>\)

```csharp
public static uint GetSoundEventHash(ReadOnlySpan<char> name)
```

#### Parameters

`name` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[char](https://learn.microsoft.com/dotnet/api/system.char)\>

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_GetSoundEventName_System_UInt32_"></a> GetSoundEventName\(uint\)

```csharp
public static string GetSoundEventName(uint hash)
```

#### Parameters

`hash` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Sound_SoundManager_StartSound_System_String_Divine_Entity_Entities_Entity_"></a> StartSound\(string, Entity?\)

```csharp
public static uint StartSound(string name, Entity? entity = null)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`entity` [Entity](Divine.Entity.Entities.Entity.md)?

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_StartSound_System_String_System_Int32_"></a> StartSound\(string, int\)

```csharp
public static uint StartSound(string name, int entityIndex)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`entityIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_StartSound_System_String_System_Numerics_Vector3_"></a> StartSound\(string, Vector3\)

```csharp
public static uint StartSound(string name, Vector3 position)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_StopSound_System_UInt32_"></a> StopSound\(uint\)

```csharp
public static void StopSound(uint soundEvent)
```

#### Parameters

`soundEvent` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Sound_SoundManager_SoundEventStarting"></a> SoundEventStarting

```csharp
public static event SoundManager.SoundEventStartingEventHandler? SoundEventStarting
```

#### Event Type

 [SoundManager](Divine.Sound.SoundManager.md).[SoundEventStartingEventHandler](Divine.Sound.SoundManager.SoundEventStartingEventHandler.md)?

