# <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version"></a> Class CMsgSerializedSOCache.Types.Cache.Types.Version

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSerializedSOCache.Types.Cache.Types.Version : IMessage<CMsgSerializedSOCache.Types.Cache.Types.Version>, IEquatable<CMsgSerializedSOCache.Types.Cache.Types.Version>, IDeepCloneable<CMsgSerializedSOCache.Types.Cache.Types.Version>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSerializedSOCache.Types.Cache.Types.Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)

#### Implements

IMessage<CMsgSerializedSOCache.Types.Cache.Types.Version\>, 
[IEquatable<CMsgSerializedSOCache.Types.Cache.Types.Version\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSerializedSOCache.Types.Cache.Types.Version\>, 
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
[EnumerableExtensions.In<CMsgSerializedSOCache.Types.Cache.Types.Version\>\(CMsgSerializedSOCache.Types.Cache.Types.Version, params CMsgSerializedSOCache.Types.Cache.Types.Version\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version__ctor"></a> Version\(\)

```csharp
public Version()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version__ctor_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_"></a> Version\(Version\)

```csharp
public Version(CMsgSerializedSOCache.Types.Cache.Types.Version other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_ServiceFieldNumber"></a> ServiceFieldNumber

```csharp
public const int ServiceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Version_FieldNumber"></a> Version\_FieldNumber

```csharp
public const int Version_FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_HasService"></a> HasService

```csharp
public bool HasService { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_HasVersion_"></a> HasVersion\_

```csharp
public bool HasVersion_ { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSerializedSOCache.Types.Cache.Types.Version> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Service"></a> Service

```csharp
public uint Service { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Version_"></a> Version\_

```csharp
public ulong Version_ { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_ClearService"></a> ClearService\(\)

```csharp
public void ClearService()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_ClearVersion_"></a> ClearVersion\_\(\)

```csharp
public void ClearVersion_()
```

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Clone"></a> Clone\(\)

```csharp
public CMsgSerializedSOCache.Types.Cache.Types.Version Clone()
```

#### Returns

 [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_Equals_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_"></a> Equals\(Version\)

```csharp
public bool Equals(CMsgSerializedSOCache.Types.Cache.Types.Version other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_MergeFrom_Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_"></a> MergeFrom\(Version\)

```csharp
public void MergeFrom(CMsgSerializedSOCache.Types.Cache.Types.Version other)
```

#### Parameters

`other` [CMsgSerializedSOCache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.md).[Cache](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.md).[Types](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.md).[Version](Divine.Protobufs.Dota2.CMsgSerializedSOCache.Types.Cache.Types.Version.md)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSerializedSOCache_Types_Cache_Types_Version_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

