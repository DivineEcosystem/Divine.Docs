# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema"></a> Class CMsgClientToGCDevReloadEventSchema

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevReloadEventSchema : IMessage<CMsgClientToGCDevReloadEventSchema>, IEquatable<CMsgClientToGCDevReloadEventSchema>, IDeepCloneable<CMsgClientToGCDevReloadEventSchema>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)

#### Implements

IMessage<CMsgClientToGCDevReloadEventSchema\>, 
[IEquatable<CMsgClientToGCDevReloadEventSchema\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevReloadEventSchema\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevReloadEventSchema\>\(CMsgClientToGCDevReloadEventSchema, params CMsgClientToGCDevReloadEventSchema\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema__ctor"></a> CMsgClientToGCDevReloadEventSchema\(\)

```csharp
public CMsgClientToGCDevReloadEventSchema()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_"></a> CMsgClientToGCDevReloadEventSchema\(CMsgClientToGCDevReloadEventSchema\)

```csharp
public CMsgClientToGCDevReloadEventSchema(CMsgClientToGCDevReloadEventSchema other)
```

#### Parameters

`other` [CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevReloadEventSchema> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevReloadEventSchema Clone()
```

#### Returns

 [CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_"></a> Equals\(CMsgClientToGCDevReloadEventSchema\)

```csharp
public bool Equals(CMsgClientToGCDevReloadEventSchema other)
```

#### Parameters

`other` [CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_"></a> MergeFrom\(CMsgClientToGCDevReloadEventSchema\)

```csharp
public void MergeFrom(CMsgClientToGCDevReloadEventSchema other)
```

#### Parameters

`other` [CMsgClientToGCDevReloadEventSchema](Divine.Protobufs.Dota2.CMsgClientToGCDevReloadEventSchema.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevReloadEventSchema_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

