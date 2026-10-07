# <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart"></a> Class CMsgApplyStrangePart

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgApplyStrangePart : IMessage<CMsgApplyStrangePart>, IEquatable<CMsgApplyStrangePart>, IDeepCloneable<CMsgApplyStrangePart>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)

#### Implements

IMessage<CMsgApplyStrangePart\>, 
[IEquatable<CMsgApplyStrangePart\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgApplyStrangePart\>, 
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
[EnumerableExtensions.In<CMsgApplyStrangePart\>\(CMsgApplyStrangePart, params CMsgApplyStrangePart\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart__ctor"></a> CMsgApplyStrangePart\(\)

```csharp
public CMsgApplyStrangePart()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart__ctor_Divine_Protobufs_Dota2_CMsgApplyStrangePart_"></a> CMsgApplyStrangePart\(CMsgApplyStrangePart\)

```csharp
public CMsgApplyStrangePart(CMsgApplyStrangePart other)
```

#### Parameters

`other` [CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_ItemItemIdFieldNumber"></a> ItemItemIdFieldNumber

```csharp
public const int ItemItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_StrangePartItemIdFieldNumber"></a> StrangePartItemIdFieldNumber

```csharp
public const int StrangePartItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_HasItemItemId"></a> HasItemItemId

```csharp
public bool HasItemItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_HasStrangePartItemId"></a> HasStrangePartItemId

```csharp
public bool HasStrangePartItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_ItemItemId"></a> ItemItemId

```csharp
public ulong ItemItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_Parser"></a> Parser

```csharp
public static MessageParser<CMsgApplyStrangePart> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_StrangePartItemId"></a> StrangePartItemId

```csharp
public ulong StrangePartItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_ClearItemItemId"></a> ClearItemItemId\(\)

```csharp
public void ClearItemItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_ClearStrangePartItemId"></a> ClearStrangePartItemId\(\)

```csharp
public void ClearStrangePartItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_Clone"></a> Clone\(\)

```csharp
public CMsgApplyStrangePart Clone()
```

#### Returns

 [CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_Equals_Divine_Protobufs_Dota2_CMsgApplyStrangePart_"></a> Equals\(CMsgApplyStrangePart\)

```csharp
public bool Equals(CMsgApplyStrangePart other)
```

#### Parameters

`other` [CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_MergeFrom_Divine_Protobufs_Dota2_CMsgApplyStrangePart_"></a> MergeFrom\(CMsgApplyStrangePart\)

```csharp
public void MergeFrom(CMsgApplyStrangePart other)
```

#### Parameters

`other` [CMsgApplyStrangePart](Divine.Protobufs.Dota2.CMsgApplyStrangePart.md)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgApplyStrangePart_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

