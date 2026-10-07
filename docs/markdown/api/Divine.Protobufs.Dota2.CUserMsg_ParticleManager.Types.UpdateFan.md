# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan"></a> Class CUserMsg\_ParticleManager.Types.UpdateFan

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.UpdateFan : IMessage<CUserMsg_ParticleManager.Types.UpdateFan>, IEquatable<CUserMsg_ParticleManager.Types.UpdateFan>, IDeepCloneable<CUserMsg_ParticleManager.Types.UpdateFan>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.UpdateFan\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.UpdateFan\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.UpdateFan\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.UpdateFan\>\(CUserMsg\_ParticleManager.Types.UpdateFan, params CUserMsg\_ParticleManager.Types.UpdateFan\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan__ctor"></a> UpdateFan\(\)

```csharp
public UpdateFan()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_"></a> UpdateFan\(UpdateFan\)

```csharp
public UpdateFan(CUserMsg_ParticleManager.Types.UpdateFan other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_ActiveFieldNumber"></a> ActiveFieldNumber

```csharp
public const int ActiveFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_BoundsMaxsFieldNumber"></a> BoundsMaxsFieldNumber

```csharp
public const int BoundsMaxsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_BoundsMinsFieldNumber"></a> BoundsMinsFieldNumber

```csharp
public const int BoundsMinsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanDirectionFieldNumber"></a> FanDirectionFieldNumber

```csharp
public const int FanDirectionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanOriginFieldNumber"></a> FanOriginFieldNumber

```csharp
public const int FanOriginFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanOriginOffsetFieldNumber"></a> FanOriginOffsetFieldNumber

```csharp
public const int FanOriginOffsetFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanRampRatioFieldNumber"></a> FanRampRatioFieldNumber

```csharp
public const int FanRampRatioFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Active"></a> Active

```csharp
public bool Active { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_BoundsMaxs"></a> BoundsMaxs

```csharp
public CMsgVector BoundsMaxs { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_BoundsMins"></a> BoundsMins

```csharp
public CMsgVector BoundsMins { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanDirection"></a> FanDirection

```csharp
public CMsgVector FanDirection { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanOrigin"></a> FanOrigin

```csharp
public CMsgVector FanOrigin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanOriginOffset"></a> FanOriginOffset

```csharp
public CMsgVector FanOriginOffset { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_FanRampRatio"></a> FanRampRatio

```csharp
public float FanRampRatio { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_HasActive"></a> HasActive

```csharp
public bool HasActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_HasFanRampRatio"></a> HasFanRampRatio

```csharp
public bool HasFanRampRatio { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.UpdateFan> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_ClearActive"></a> ClearActive\(\)

```csharp
public void ClearActive()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_ClearFanRampRatio"></a> ClearFanRampRatio\(\)

```csharp
public void ClearFanRampRatio()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.UpdateFan Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_"></a> Equals\(UpdateFan\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.UpdateFan other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_"></a> MergeFrom\(UpdateFan\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.UpdateFan other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[UpdateFan](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.UpdateFan.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_UpdateFan_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

