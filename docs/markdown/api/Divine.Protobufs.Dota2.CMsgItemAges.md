# <a id="Divine_Protobufs_Dota2_CMsgItemAges"></a> Class CMsgItemAges

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemAges : IMessage<CMsgItemAges>, IEquatable<CMsgItemAges>, IDeepCloneable<CMsgItemAges>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)

#### Implements

IMessage<CMsgItemAges\>, 
[IEquatable<CMsgItemAges\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemAges\>, 
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
[EnumerableExtensions.In<CMsgItemAges\>\(CMsgItemAges, params CMsgItemAges\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemAges__ctor"></a> CMsgItemAges\(\)

```csharp
public CMsgItemAges()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAges__ctor_Divine_Protobufs_Dota2_CMsgItemAges_"></a> CMsgItemAges\(CMsgItemAges\)

```csharp
public CMsgItemAges(CMsgItemAges other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_MaxItemIdTimestampsFieldNumber"></a> MaxItemIdTimestampsFieldNumber

```csharp
public const int MaxItemIdTimestampsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_MaxItemIdTimestamps"></a> MaxItemIdTimestamps

```csharp
public RepeatedField<CMsgItemAges.Types.MaxItemIDTimestamp> MaxItemIdTimestamps { get; }
```

#### Property Value

 RepeatedField<[CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemAges> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Clone"></a> Clone\(\)

```csharp
public CMsgItemAges Clone()
```

#### Returns

 [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Equals_Divine_Protobufs_Dota2_CMsgItemAges_"></a> Equals\(CMsgItemAges\)

```csharp
public bool Equals(CMsgItemAges other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_MergeFrom_Divine_Protobufs_Dota2_CMsgItemAges_"></a> MergeFrom\(CMsgItemAges\)

```csharp
public void MergeFrom(CMsgItemAges other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

