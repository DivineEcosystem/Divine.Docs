# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo"></a> Class CMsgClientToGCMMInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMMInfo : IMessage<CMsgClientToGCMMInfo>, IEquatable<CMsgClientToGCMMInfo>, IDeepCloneable<CMsgClientToGCMMInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)

#### Implements

IMessage<CMsgClientToGCMMInfo\>, 
[IEquatable<CMsgClientToGCMMInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMMInfo\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMMInfo\>\(CMsgClientToGCMMInfo, params CMsgClientToGCMMInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo__ctor"></a> CMsgClientToGCMMInfo\(\)

```csharp
public CMsgClientToGCMMInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_"></a> CMsgClientToGCMMInfo\(CMsgClientToGCMMInfo\)

```csharp
public CMsgClientToGCMMInfo(CMsgClientToGCMMInfo other)
```

#### Parameters

`other` [CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_HighPriorityDisabledFieldNumber"></a> HighPriorityDisabledFieldNumber

```csharp
public const int HighPriorityDisabledFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_HasHighPriorityDisabled"></a> HasHighPriorityDisabled

```csharp
public bool HasHighPriorityDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_HighPriorityDisabled"></a> HighPriorityDisabled

```csharp
public bool HighPriorityDisabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMMInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_ClearHighPriorityDisabled"></a> ClearHighPriorityDisabled\(\)

```csharp
public void ClearHighPriorityDisabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMMInfo Clone()
```

#### Returns

 [CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_"></a> Equals\(CMsgClientToGCMMInfo\)

```csharp
public bool Equals(CMsgClientToGCMMInfo other)
```

#### Parameters

`other` [CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_"></a> MergeFrom\(CMsgClientToGCMMInfo\)

```csharp
public void MergeFrom(CMsgClientToGCMMInfo other)
```

#### Parameters

`other` [CMsgClientToGCMMInfo](Divine.Protobufs.Dota2.CMsgClientToGCMMInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMMInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

