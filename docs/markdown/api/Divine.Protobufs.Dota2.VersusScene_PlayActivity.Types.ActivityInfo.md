# <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo"></a> Class VersusScene\_PlayActivity.Types.ActivityInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class VersusScene_PlayActivity.Types.ActivityInfo : IMessage<VersusScene_PlayActivity.Types.ActivityInfo>, IEquatable<VersusScene_PlayActivity.Types.ActivityInfo>, IDeepCloneable<VersusScene_PlayActivity.Types.ActivityInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VersusScene\_PlayActivity.Types.ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)

#### Implements

IMessage<VersusScene\_PlayActivity.Types.ActivityInfo\>, 
[IEquatable<VersusScene\_PlayActivity.Types.ActivityInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<VersusScene\_PlayActivity.Types.ActivityInfo\>, 
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
[EnumerableExtensions.In<VersusScene\_PlayActivity.Types.ActivityInfo\>\(VersusScene\_PlayActivity.Types.ActivityInfo, params VersusScene\_PlayActivity.Types.ActivityInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo__ctor"></a> ActivityInfo\(\)

```csharp
public ActivityInfo()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo__ctor_Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_"></a> ActivityInfo\(ActivityInfo\)

```csharp
public ActivityInfo(VersusScene_PlayActivity.Types.ActivityInfo other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ActivityFieldNumber"></a> ActivityFieldNumber

```csharp
public const int ActivityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_DisableAutoKillFieldNumber"></a> DisableAutoKillFieldNumber

```csharp
public const int DisableAutoKillFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ForceLoopingFieldNumber"></a> ForceLoopingFieldNumber

```csharp
public const int ForceLoopingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Activity"></a> Activity

```csharp
public string Activity { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_DisableAutoKill"></a> DisableAutoKill

```csharp
public bool DisableAutoKill { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ForceLooping"></a> ForceLooping

```csharp
public bool ForceLooping { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_HasActivity"></a> HasActivity

```csharp
public bool HasActivity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_HasDisableAutoKill"></a> HasDisableAutoKill

```csharp
public bool HasDisableAutoKill { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_HasForceLooping"></a> HasForceLooping

```csharp
public bool HasForceLooping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Parser"></a> Parser

```csharp
public static MessageParser<VersusScene_PlayActivity.Types.ActivityInfo> Parser { get; }
```

#### Property Value

 MessageParser<[VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ClearActivity"></a> ClearActivity\(\)

```csharp
public void ClearActivity()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ClearDisableAutoKill"></a> ClearDisableAutoKill\(\)

```csharp
public void ClearDisableAutoKill()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ClearForceLooping"></a> ClearForceLooping\(\)

```csharp
public void ClearForceLooping()
```

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Clone"></a> Clone\(\)

```csharp
public VersusScene_PlayActivity.Types.ActivityInfo Clone()
```

#### Returns

 [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_Equals_Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_"></a> Equals\(ActivityInfo\)

```csharp
public bool Equals(VersusScene_PlayActivity.Types.ActivityInfo other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_MergeFrom_Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_"></a> MergeFrom\(ActivityInfo\)

```csharp
public void MergeFrom(VersusScene_PlayActivity.Types.ActivityInfo other)
```

#### Parameters

`other` [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md).[Types](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.md).[ActivityInfo](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.Types.ActivityInfo.md)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_VersusScene_PlayActivity_Types_ActivityInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

