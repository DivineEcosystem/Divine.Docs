# <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject"></a> Class CMsgSOSingleObject

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOSingleObject : IMessage<CMsgSOSingleObject>, IEquatable<CMsgSOSingleObject>, IDeepCloneable<CMsgSOSingleObject>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)

#### Implements

IMessage<CMsgSOSingleObject\>, 
[IEquatable<CMsgSOSingleObject\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOSingleObject\>, 
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
[EnumerableExtensions.In<CMsgSOSingleObject\>\(CMsgSOSingleObject, params CMsgSOSingleObject\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject__ctor"></a> CMsgSOSingleObject\(\)

```csharp
public CMsgSOSingleObject()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject__ctor_Divine_Protobufs_Dota2_CMsgSOSingleObject_"></a> CMsgSOSingleObject\(CMsgSOSingleObject\)

```csharp
public CMsgSOSingleObject(CMsgSOSingleObject other)
```

#### Parameters

`other` [CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ObjectDataFieldNumber"></a> ObjectDataFieldNumber

```csharp
public const int ObjectDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_OwnerSoidFieldNumber"></a> OwnerSoidFieldNumber

```csharp
public const int OwnerSoidFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ServiceIdFieldNumber"></a> ServiceIdFieldNumber

```csharp
public const int ServiceIdFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_TypeIdFieldNumber"></a> TypeIdFieldNumber

```csharp
public const int TypeIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_HasObjectData"></a> HasObjectData

```csharp
public bool HasObjectData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_HasServiceId"></a> HasServiceId

```csharp
public bool HasServiceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_HasTypeId"></a> HasTypeId

```csharp
public bool HasTypeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ObjectData"></a> ObjectData

```csharp
public ByteString ObjectData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_OwnerSoid"></a> OwnerSoid

```csharp
public CMsgSOIDOwner OwnerSoid { get; set; }
```

#### Property Value

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOSingleObject> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ServiceId"></a> ServiceId

```csharp
public uint ServiceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_TypeId"></a> TypeId

```csharp
public int TypeId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Version"></a> Version

```csharp
public ulong Version { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ClearObjectData"></a> ClearObjectData\(\)

```csharp
public void ClearObjectData()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ClearServiceId"></a> ClearServiceId\(\)

```csharp
public void ClearServiceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ClearTypeId"></a> ClearTypeId\(\)

```csharp
public void ClearTypeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Clone"></a> Clone\(\)

```csharp
public CMsgSOSingleObject Clone()
```

#### Returns

 [CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_Equals_Divine_Protobufs_Dota2_CMsgSOSingleObject_"></a> Equals\(CMsgSOSingleObject\)

```csharp
public bool Equals(CMsgSOSingleObject other)
```

#### Parameters

`other` [CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_MergeFrom_Divine_Protobufs_Dota2_CMsgSOSingleObject_"></a> MergeFrom\(CMsgSOSingleObject\)

```csharp
public void MergeFrom(CMsgSOSingleObject other)
```

#### Parameters

`other` [CMsgSOSingleObject](Divine.Protobufs.Dota2.CMsgSOSingleObject.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOSingleObject_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

