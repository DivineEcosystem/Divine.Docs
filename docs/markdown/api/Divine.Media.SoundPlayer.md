# <a id="Divine_Media_SoundPlayer"></a> Class SoundPlayer

Namespace: [Divine.Media](Divine.Media.md)  
Assembly: Divine.dll  

```csharp
public sealed class SoundPlayer : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SoundPlayer](Divine.Media.SoundPlayer.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<SoundPlayer\>\(SoundPlayer, params SoundPlayer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Media_SoundPlayer_MasteringVoice"></a> MasteringVoice

```csharp
public static IXAudio2MasteringVoice* MasteringVoice { get; }
```

#### Property Value

 IXAudio2MasteringVoice\*

### <a id="Divine_Media_SoundPlayer_XAudio2"></a> XAudio2

```csharp
public static IXAudio2* XAudio2 { get; }
```

#### Property Value

 IXAudio2\*

## Methods

### <a id="Divine_Media_SoundPlayer_CreateSourceVoice_Vortice_Win32_Media_Audio_WaveFormatEx_"></a> CreateSourceVoice\(WaveFormatEx\)

```csharp
public static IXAudio2SourceVoice* CreateSourceVoice(WaveFormatEx format)
```

#### Parameters

`format` WaveFormatEx

#### Returns

 IXAudio2SourceVoice\*

### <a id="Divine_Media_SoundPlayer_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="Divine_Media_SoundPlayer_Play_Divine_Media_SoundData_System_Single_"></a> Play\(SoundData, float\)

```csharp
public static void Play(SoundData soundData, float volume = 1)
```

#### Parameters

`soundData` [SoundData](Divine.Media.SoundData.md)

`volume` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Media_SoundPlayer_Play_Vortice_Win32_Media_Audio_XAudio2_IXAudio2SourceVoice__Divine_Media_SoundData_System_Single_"></a> Play\(IXAudio2SourceVoice\*, SoundData, float\)

```csharp
public static void Play(IXAudio2SourceVoice* sourceVoice, SoundData soundData, float volume = 1)
```

#### Parameters

`sourceVoice` IXAudio2SourceVoice\*

`soundData` [SoundData](Divine.Media.SoundData.md)

`volume` [float](https://learn.microsoft.com/dotnet/api/system.single)

