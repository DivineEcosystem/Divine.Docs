# <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject"></a> Class CMsgSOMultipleObjects.Types.SingleObject

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOMultipleObjects.Types.SingleObject : IMessage<CMsgSOMultipleObjects.Types.SingleObject>, IEquatable<CMsgSOMultipleObjects.Types.SingleObject>, IDeepCloneable<CMsgSOMultipleObjects.Types.SingleObject>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOMultipleObjects.Types.SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)

#### Implements

IMessage<CMsgSOMultipleObjects.Types.SingleObject\>, 
[IEquatable<CMsgSOMultipleObjects.Types.SingleObject\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOMultipleObjects.Types.SingleObject\>, 
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
[EnumerableExtensions.In<CMsgSOMultipleObjects.Types.SingleObject\>\(CMsgSOMultipleObjects.Types.SingleObject, params CMsgSOMultipleObjects.Types.SingleObject\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject__ctor"></a> SingleObject\(\)

```csharp
public SingleObject()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject__ctor_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_"></a> SingleObject\(SingleObject\)

```csharp
public SingleObject(CMsgSOMultipleObjects.Types.SingleObject other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_ObjectDataFieldNumber"></a> ObjectDataFieldNumber

```csharp
public const int ObjectDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_TypeIdFieldNumber"></a> TypeIdFieldNumber

```csharp
public const int TypeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_HasObjectData"></a> HasObjectData

```csharp
public bool HasObjectData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_HasTypeId"></a> HasTypeId

```csharp
public bool HasTypeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_ObjectData"></a> ObjectData

```csharp
public ByteString ObjectData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOMultipleObjects.Types.SingleObject> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_TypeId"></a> TypeId

```csharp
public int TypeId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_ClearObjectData"></a> ClearObjectData\(\)

```csharp
public void ClearObjectData()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_ClearTypeId"></a> ClearTypeId\(\)

```csharp
public void ClearTypeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_Clone"></a> Clone\(\)

```csharp
public CMsgSOMultipleObjects.Types.SingleObject Clone()
```

#### Returns

 [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_Equals_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_"></a> Equals\(SingleObject\)

```csharp
public bool Equals(CMsgSOMultipleObjects.Types.SingleObject other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_MergeFrom_Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_"></a> MergeFrom\(SingleObject\)

```csharp
public void MergeFrom(CMsgSOMultipleObjects.Types.SingleObject other)
```

#### Parameters

`other` [CMsgSOMultipleObjects](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.md).[Types](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.md).[SingleObject](Divine.Protobufs.Dota2.CMsgSOMultipleObjects.Types.SingleObject.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOMultipleObjects_Types_SingleObject_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

