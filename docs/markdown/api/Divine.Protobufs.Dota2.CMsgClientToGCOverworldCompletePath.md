# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath"></a> Class CMsgClientToGCOverworldCompletePath

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldCompletePath : IMessage<CMsgClientToGCOverworldCompletePath>, IEquatable<CMsgClientToGCOverworldCompletePath>, IDeepCloneable<CMsgClientToGCOverworldCompletePath>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)

#### Implements

IMessage<CMsgClientToGCOverworldCompletePath\>, 
[IEquatable<CMsgClientToGCOverworldCompletePath\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldCompletePath\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldCompletePath\>\(CMsgClientToGCOverworldCompletePath, params CMsgClientToGCOverworldCompletePath\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath__ctor"></a> CMsgClientToGCOverworldCompletePath\(\)

```csharp
public CMsgClientToGCOverworldCompletePath()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_"></a> CMsgClientToGCOverworldCompletePath\(CMsgClientToGCOverworldCompletePath\)

```csharp
public CMsgClientToGCOverworldCompletePath(CMsgClientToGCOverworldCompletePath other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_DevIgnoreReleaseScheduleFieldNumber"></a> DevIgnoreReleaseScheduleFieldNumber

```csharp
public const int DevIgnoreReleaseScheduleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_PathIdFieldNumber"></a> PathIdFieldNumber

```csharp
public const int PathIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_UsePathUnlockerFieldNumber"></a> UsePathUnlockerFieldNumber

```csharp
public const int UsePathUnlockerFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_DevIgnoreReleaseSchedule"></a> DevIgnoreReleaseSchedule

```csharp
public bool DevIgnoreReleaseSchedule { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_HasDevIgnoreReleaseSchedule"></a> HasDevIgnoreReleaseSchedule

```csharp
public bool HasDevIgnoreReleaseSchedule { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_HasPathId"></a> HasPathId

```csharp
public bool HasPathId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_HasUsePathUnlocker"></a> HasUsePathUnlocker

```csharp
public bool HasUsePathUnlocker { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldCompletePath> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_PathId"></a> PathId

```csharp
public uint PathId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_UsePathUnlocker"></a> UsePathUnlocker

```csharp
public bool UsePathUnlocker { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_ClearDevIgnoreReleaseSchedule"></a> ClearDevIgnoreReleaseSchedule\(\)

```csharp
public void ClearDevIgnoreReleaseSchedule()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_ClearPathId"></a> ClearPathId\(\)

```csharp
public void ClearPathId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_ClearUsePathUnlocker"></a> ClearUsePathUnlocker\(\)

```csharp
public void ClearUsePathUnlocker()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldCompletePath Clone()
```

#### Returns

 [CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_"></a> Equals\(CMsgClientToGCOverworldCompletePath\)

```csharp
public bool Equals(CMsgClientToGCOverworldCompletePath other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_"></a> MergeFrom\(CMsgClientToGCOverworldCompletePath\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldCompletePath other)
```

#### Parameters

`other` [CMsgClientToGCOverworldCompletePath](Divine.Protobufs.Dota2.CMsgClientToGCOverworldCompletePath.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldCompletePath_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

