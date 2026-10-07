# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle"></a> Class CMsgClientToGCSetItemStyle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetItemStyle : IMessage<CMsgClientToGCSetItemStyle>, IEquatable<CMsgClientToGCSetItemStyle>, IDeepCloneable<CMsgClientToGCSetItemStyle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)

#### Implements

IMessage<CMsgClientToGCSetItemStyle\>, 
[IEquatable<CMsgClientToGCSetItemStyle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetItemStyle\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetItemStyle\>\(CMsgClientToGCSetItemStyle, params CMsgClientToGCSetItemStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle__ctor"></a> CMsgClientToGCSetItemStyle\(\)

```csharp
public CMsgClientToGCSetItemStyle()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_"></a> CMsgClientToGCSetItemStyle\(CMsgClientToGCSetItemStyle\)

```csharp
public CMsgClientToGCSetItemStyle(CMsgClientToGCSetItemStyle other)
```

#### Parameters

`other` [CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_StyleIndexFieldNumber"></a> StyleIndexFieldNumber

```csharp
public const int StyleIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_HasStyleIndex"></a> HasStyleIndex

```csharp
public bool HasStyleIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetItemStyle> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_StyleIndex"></a> StyleIndex

```csharp
public uint StyleIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_ClearStyleIndex"></a> ClearStyleIndex\(\)

```csharp
public void ClearStyleIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetItemStyle Clone()
```

#### Returns

 [CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_"></a> Equals\(CMsgClientToGCSetItemStyle\)

```csharp
public bool Equals(CMsgClientToGCSetItemStyle other)
```

#### Parameters

`other` [CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_"></a> MergeFrom\(CMsgClientToGCSetItemStyle\)

```csharp
public void MergeFrom(CMsgClientToGCSetItemStyle other)
```

#### Parameters

`other` [CMsgClientToGCSetItemStyle](Divine.Protobufs.Dota2.CMsgClientToGCSetItemStyle.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetItemStyle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

