# <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition"></a> Class CMsgGCSetItemPosition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCSetItemPosition : IMessage<CMsgGCSetItemPosition>, IEquatable<CMsgGCSetItemPosition>, IDeepCloneable<CMsgGCSetItemPosition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)

#### Implements

IMessage<CMsgGCSetItemPosition\>, 
[IEquatable<CMsgGCSetItemPosition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCSetItemPosition\>, 
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
[EnumerableExtensions.In<CMsgGCSetItemPosition\>\(CMsgGCSetItemPosition, params CMsgGCSetItemPosition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition__ctor"></a> CMsgGCSetItemPosition\(\)

```csharp
public CMsgGCSetItemPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition__ctor_Divine_Protobufs_Dota2_CMsgGCSetItemPosition_"></a> CMsgGCSetItemPosition\(CMsgGCSetItemPosition\)

```csharp
public CMsgGCSetItemPosition(CMsgGCSetItemPosition other)
```

#### Parameters

`other` [CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_NewPositionFieldNumber"></a> NewPositionFieldNumber

```csharp
public const int NewPositionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_HasNewPosition"></a> HasNewPosition

```csharp
public bool HasNewPosition { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_NewPosition"></a> NewPosition

```csharp
public uint NewPosition { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCSetItemPosition> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_ClearNewPosition"></a> ClearNewPosition\(\)

```csharp
public void ClearNewPosition()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_Clone"></a> Clone\(\)

```csharp
public CMsgGCSetItemPosition Clone()
```

#### Returns

 [CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_Equals_Divine_Protobufs_Dota2_CMsgGCSetItemPosition_"></a> Equals\(CMsgGCSetItemPosition\)

```csharp
public bool Equals(CMsgGCSetItemPosition other)
```

#### Parameters

`other` [CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_MergeFrom_Divine_Protobufs_Dota2_CMsgGCSetItemPosition_"></a> MergeFrom\(CMsgGCSetItemPosition\)

```csharp
public void MergeFrom(CMsgGCSetItemPosition other)
```

#### Parameters

`other` [CMsgGCSetItemPosition](Divine.Protobufs.Dota2.CMsgGCSetItemPosition.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCSetItemPosition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

