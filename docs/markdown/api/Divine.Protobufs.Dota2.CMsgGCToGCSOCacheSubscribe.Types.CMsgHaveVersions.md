# <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions"></a> Class CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions : IMessage<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions>, IEquatable<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions>, IDeepCloneable<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)

#### Implements

IMessage<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions\>, 
[IEquatable<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions\>, 
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
[EnumerableExtensions.In<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions\>\(CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions, params CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions__ctor"></a> CMsgHaveVersions\(\)

```csharp
public CMsgHaveVersions()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions__ctor_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_"></a> CMsgHaveVersions\(CMsgHaveVersions\)

```csharp
public CMsgHaveVersions(CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions Clone()
```

#### Returns

 [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_Equals_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_"></a> Equals\(CMsgHaveVersions\)

```csharp
public bool Equals(CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_"></a> MergeFrom\(CMsgHaveVersions\)

```csharp
public void MergeFrom(CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheSubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.md).[Types](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.md).[CMsgHaveVersions](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheSubscribe.Types.CMsgHaveVersions.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheSubscribe_Types_CMsgHaveVersions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

