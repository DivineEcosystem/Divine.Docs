# <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp"></a> Class CMsgItemAges.Types.MaxItemIDTimestamp

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgItemAges.Types.MaxItemIDTimestamp : IMessage<CMsgItemAges.Types.MaxItemIDTimestamp>, IEquatable<CMsgItemAges.Types.MaxItemIDTimestamp>, IDeepCloneable<CMsgItemAges.Types.MaxItemIDTimestamp>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgItemAges.Types.MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)

#### Implements

IMessage<CMsgItemAges.Types.MaxItemIDTimestamp\>, 
[IEquatable<CMsgItemAges.Types.MaxItemIDTimestamp\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgItemAges.Types.MaxItemIDTimestamp\>, 
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
[EnumerableExtensions.In<CMsgItemAges.Types.MaxItemIDTimestamp\>\(CMsgItemAges.Types.MaxItemIDTimestamp, params CMsgItemAges.Types.MaxItemIDTimestamp\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp__ctor"></a> MaxItemIDTimestamp\(\)

```csharp
public MaxItemIDTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp__ctor_Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_"></a> MaxItemIDTimestamp\(MaxItemIDTimestamp\)

```csharp
public MaxItemIDTimestamp(CMsgItemAges.Types.MaxItemIDTimestamp other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_MaxItemIdFieldNumber"></a> MaxItemIdFieldNumber

```csharp
public const int MaxItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_HasMaxItemId"></a> HasMaxItemId

```csharp
public bool HasMaxItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_MaxItemId"></a> MaxItemId

```csharp
public ulong MaxItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Parser"></a> Parser

```csharp
public static MessageParser<CMsgItemAges.Types.MaxItemIDTimestamp> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_ClearMaxItemId"></a> ClearMaxItemId\(\)

```csharp
public void ClearMaxItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Clone"></a> Clone\(\)

```csharp
public CMsgItemAges.Types.MaxItemIDTimestamp Clone()
```

#### Returns

 [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_Equals_Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_"></a> Equals\(MaxItemIDTimestamp\)

```csharp
public bool Equals(CMsgItemAges.Types.MaxItemIDTimestamp other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_MergeFrom_Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_"></a> MergeFrom\(MaxItemIDTimestamp\)

```csharp
public void MergeFrom(CMsgItemAges.Types.MaxItemIDTimestamp other)
```

#### Parameters

`other` [CMsgItemAges](Divine.Protobufs.Dota2.CMsgItemAges.md).[Types](Divine.Protobufs.Dota2.CMsgItemAges.Types.md).[MaxItemIDTimestamp](Divine.Protobufs.Dota2.CMsgItemAges.Types.MaxItemIDTimestamp.md)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgItemAges_Types_MaxItemIDTimestamp_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

