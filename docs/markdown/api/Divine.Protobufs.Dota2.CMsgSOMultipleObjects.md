# <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects"></a> Class CMsgSOMultipleObjects

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOMultipleObjects : IMessage<CMsgSOMultipleObjects>, IEquatable<CMsgSOMultipleObjects>, IDeepCloneable<CMsgSOMultipleObjects>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)

#### Implements

IMessage<CMsgSOMultipleObjects\>, 
[IEquatable<CMsgSOMultipleObjects\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOMultipleObjects\>, 
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
[EnumerableExtensions.In<CMsgSOMultipleObjects\>\(CMsgSOMultipleObjects, params CMsgSOMultipleObjects\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects__ctor"></a> CMsgSOMultipleObjects\(\)

```csharp
public CMsgSOMultipleObjects()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects__ctor_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_"></a> CMsgSOMultipleObjects\(CMsgSOMultipleObjects\)

```csharp
public CMsgSOMultipleObjects(CMsgSOMultipleObjects other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsAddedFieldNumber"></a> ObjectsAddedFieldNumber

```csharp
public const int ObjectsAddedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsModifiedFieldNumber"></a> ObjectsModifiedFieldNumber

```csharp
public const int ObjectsModifiedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsRemovedFieldNumber"></a> ObjectsRemovedFieldNumber

```csharp
public const int ObjectsRemovedFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsAdded"></a> ObjectsAdded

```csharp
public RepeatedField<CMsgSOMultipleObjects.Types.SingleObject> ObjectsAdded { get; }
```

#### Property Value

 RepeatedField<[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsModified"></a> ObjectsModified

```csharp
public RepeatedField<CMsgSOMultipleObjects.Types.SingleObject> ObjectsModified { get; }
```

#### Property Value

 RepeatedField<[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ObjectsRemoved"></a> ObjectsRemoved

```csharp
public RepeatedField<CMsgSOMultipleObjects.Types.SingleObject> ObjectsRemoved { get; }
```

#### Property Value

 RepeatedField<[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOMultipleObjects> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Clone"></a> Clone\(\)

```csharp
public CMsgSOMultipleObjects Clone()
```

#### Returns

 [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Equals_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_"></a> Equals\(CMsgSOMultipleObjects\)

```csharp
public bool Equals(CMsgSOMultipleObjects other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_MergeFrom_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_"></a> MergeFrom\(CMsgSOMultipleObjects\)

```csharp
public void MergeFrom(CMsgSOMultipleObjects other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

