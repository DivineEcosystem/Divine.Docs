# <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData"></a> Class CSVCMsg\_VoiceData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_VoiceData : IMessage<CSVCMsg_VoiceData>, IEquatable<CSVCMsg_VoiceData>, IDeepCloneable<CSVCMsg_VoiceData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)

#### Implements

IMessage<CSVCMsg\_VoiceData\>, 
[IEquatable<CSVCMsg\_VoiceData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_VoiceData\>, 
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
[EnumerableExtensions.In<CSVCMsg\_VoiceData\>\(CSVCMsg\_VoiceData, params CSVCMsg\_VoiceData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData__ctor"></a> CSVCMsg\_VoiceData\(\)

```csharp
public CSVCMsg_VoiceData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData__ctor_Divine_Protobufs_Dota2_CSVCMsg_VoiceData_"></a> CSVCMsg\_VoiceData\(CSVCMsg\_VoiceData\)

```csharp
public CSVCMsg_VoiceData(CSVCMsg_VoiceData other)
```

#### Parameters

`other` [CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_AudibleMaskFieldNumber"></a> AudibleMaskFieldNumber

```csharp
public const int AudibleMaskFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_AudioFieldNumber"></a> AudioFieldNumber

```csharp
public const int AudioFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_CasterFieldNumber"></a> CasterFieldNumber

```csharp
public const int CasterFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClientDeprecatedFieldNumber"></a> ClientDeprecatedFieldNumber

```csharp
public const int ClientDeprecatedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_EntityFieldNumber"></a> EntityFieldNumber

```csharp
public const int EntityFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_PassthroughFieldNumber"></a> PassthroughFieldNumber

```csharp
public const int PassthroughFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ProximityFieldNumber"></a> ProximityFieldNumber

```csharp
public const int ProximityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_TickFieldNumber"></a> TickFieldNumber

```csharp
public const int TickFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_XuidFieldNumber"></a> XuidFieldNumber

```csharp
public const int XuidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_AudibleMask"></a> AudibleMask

```csharp
public int AudibleMask { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Audio"></a> Audio

```csharp
public CMsgVoiceAudio Audio { get; set; }
```

#### Property Value

 [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Caster"></a> Caster

```csharp
public bool Caster { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClientDeprecated"></a> ClientDeprecated

```csharp
public int ClientDeprecated { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Entity"></a> Entity

```csharp
public int Entity { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasAudibleMask"></a> HasAudibleMask

```csharp
public bool HasAudibleMask { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasCaster"></a> HasCaster

```csharp
public bool HasCaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasClientDeprecated"></a> HasClientDeprecated

```csharp
public bool HasClientDeprecated { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasEntity"></a> HasEntity

```csharp
public bool HasEntity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasPassthrough"></a> HasPassthrough

```csharp
public bool HasPassthrough { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasProximity"></a> HasProximity

```csharp
public bool HasProximity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasTick"></a> HasTick

```csharp
public bool HasTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_HasXuid"></a> HasXuid

```csharp
public bool HasXuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_VoiceData> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Passthrough"></a> Passthrough

```csharp
public int Passthrough { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Proximity"></a> Proximity

```csharp
public bool Proximity { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Xuid"></a> Xuid

```csharp
public ulong Xuid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearAudibleMask"></a> ClearAudibleMask\(\)

```csharp
public void ClearAudibleMask()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearCaster"></a> ClearCaster\(\)

```csharp
public void ClearCaster()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearClientDeprecated"></a> ClearClientDeprecated\(\)

```csharp
public void ClearClientDeprecated()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearEntity"></a> ClearEntity\(\)

```csharp
public void ClearEntity()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearPassthrough"></a> ClearPassthrough\(\)

```csharp
public void ClearPassthrough()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearProximity"></a> ClearProximity\(\)

```csharp
public void ClearProximity()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearTick"></a> ClearTick\(\)

```csharp
public void ClearTick()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ClearXuid"></a> ClearXuid\(\)

```csharp
public void ClearXuid()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_VoiceData Clone()
```

#### Returns

 [CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_Equals_Divine_Protobufs_Dota2_CSVCMsg_VoiceData_"></a> Equals\(CSVCMsg\_VoiceData\)

```csharp
public bool Equals(CSVCMsg_VoiceData other)
```

#### Parameters

`other` [CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_VoiceData_"></a> MergeFrom\(CSVCMsg\_VoiceData\)

```csharp
public void MergeFrom(CSVCMsg_VoiceData other)
```

#### Parameters

`other` [CSVCMsg\_VoiceData](Divine.Protobufs.Dota2.CSVCMsg\_VoiceData.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_VoiceData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

