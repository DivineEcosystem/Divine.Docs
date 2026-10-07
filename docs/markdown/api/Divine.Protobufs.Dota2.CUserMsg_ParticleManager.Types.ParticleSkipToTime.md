# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime"></a> Class CUserMsg\_ParticleManager.Types.ParticleSkipToTime

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.ParticleSkipToTime : IMessage<CUserMsg_ParticleManager.Types.ParticleSkipToTime>, IEquatable<CUserMsg_ParticleManager.Types.ParticleSkipToTime>, IDeepCloneable<CUserMsg_ParticleManager.Types.ParticleSkipToTime>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.ParticleSkipToTime\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.ParticleSkipToTime\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.ParticleSkipToTime\>, 
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
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.ParticleSkipToTime\>\(CUserMsg\_ParticleManager.Types.ParticleSkipToTime, params CUserMsg\_ParticleManager.Types.ParticleSkipToTime\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime__ctor"></a> ParticleSkipToTime\(\)

```csharp
public ParticleSkipToTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_"></a> ParticleSkipToTime\(ParticleSkipToTime\)

```csharp
public ParticleSkipToTime(CUserMsg_ParticleManager.Types.ParticleSkipToTime other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_SkipToTimeFieldNumber"></a> SkipToTimeFieldNumber

```csharp
public const int SkipToTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_HasSkipToTime"></a> HasSkipToTime

```csharp
public bool HasSkipToTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.ParticleSkipToTime> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_SkipToTime"></a> SkipToTime

```csharp
public float SkipToTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_ClearSkipToTime"></a> ClearSkipToTime\(\)

```csharp
public void ClearSkipToTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.ParticleSkipToTime Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_"></a> Equals\(ParticleSkipToTime\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.ParticleSkipToTime other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_"></a> MergeFrom\(ParticleSkipToTime\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.ParticleSkipToTime other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[ParticleSkipToTime](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.ParticleSkipToTime.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_ParticleSkipToTime_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

