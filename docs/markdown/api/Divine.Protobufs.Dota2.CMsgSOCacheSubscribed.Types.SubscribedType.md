# <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType"></a> Class CMsgSOCacheSubscribed.Types.SubscribedType

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOCacheSubscribed.Types.SubscribedType : IMessage<CMsgSOCacheSubscribed.Types.SubscribedType>, IEquatable<CMsgSOCacheSubscribed.Types.SubscribedType>, IDeepCloneable<CMsgSOCacheSubscribed.Types.SubscribedType>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOCacheSubscribed.Types.SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)

#### Implements

IMessage<CMsgSOCacheSubscribed.Types.SubscribedType\>, 
[IEquatable<CMsgSOCacheSubscribed.Types.SubscribedType\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOCacheSubscribed.Types.SubscribedType\>, 
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
[EnumerableExtensions.In<CMsgSOCacheSubscribed.Types.SubscribedType\>\(CMsgSOCacheSubscribed.Types.SubscribedType, params CMsgSOCacheSubscribed.Types.SubscribedType\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType__ctor"></a> SubscribedType\(\)

```csharp
public SubscribedType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType__ctor_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_"></a> SubscribedType\(SubscribedType\)

```csharp
public SubscribedType(CMsgSOCacheSubscribed.Types.SubscribedType other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_ObjectDataFieldNumber"></a> ObjectDataFieldNumber

```csharp
public const int ObjectDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_TypeIdFieldNumber"></a> TypeIdFieldNumber

```csharp
public const int TypeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_HasTypeId"></a> HasTypeId

```csharp
public bool HasTypeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_ObjectData"></a> ObjectData

```csharp
public RepeatedField<ByteString> ObjectData { get; }
```

#### Property Value

 RepeatedField<ByteString\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOCacheSubscribed.Types.SubscribedType> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_TypeId"></a> TypeId

```csharp
public int TypeId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_ClearTypeId"></a> ClearTypeId\(\)

```csharp
public void ClearTypeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_Clone"></a> Clone\(\)

```csharp
public CMsgSOCacheSubscribed.Types.SubscribedType Clone()
```

#### Returns

 [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_Equals_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_"></a> Equals\(SubscribedType\)

```csharp
public bool Equals(CMsgSOCacheSubscribed.Types.SubscribedType other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_MergeFrom_Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_"></a> MergeFrom\(SubscribedType\)

```csharp
public void MergeFrom(CMsgSOCacheSubscribed.Types.SubscribedType other)
```

#### Parameters

`other` [CMsgSOCacheSubscribed](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.md).[Types](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.md).[SubscribedType](Divine.Protobufs.Dota2.CMsgSOCacheSubscribed.Types.SubscribedType.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOCacheSubscribed_Types_SubscribedType_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

