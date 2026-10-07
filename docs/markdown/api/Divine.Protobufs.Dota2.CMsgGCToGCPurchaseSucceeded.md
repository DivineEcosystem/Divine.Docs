# <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded"></a> Class CMsgGCToGCPurchaseSucceeded

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCPurchaseSucceeded : IMessage<CMsgGCToGCPurchaseSucceeded>, IEquatable<CMsgGCToGCPurchaseSucceeded>, IDeepCloneable<CMsgGCToGCPurchaseSucceeded>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)

#### Implements

IMessage<CMsgGCToGCPurchaseSucceeded\>, 
[IEquatable<CMsgGCToGCPurchaseSucceeded\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCPurchaseSucceeded\>, 
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
[EnumerableExtensions.In<CMsgGCToGCPurchaseSucceeded\>\(CMsgGCToGCPurchaseSucceeded, params CMsgGCToGCPurchaseSucceeded\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded__ctor"></a> CMsgGCToGCPurchaseSucceeded\(\)

```csharp
public CMsgGCToGCPurchaseSucceeded()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded__ctor_Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_"></a> CMsgGCToGCPurchaseSucceeded\(CMsgGCToGCPurchaseSucceeded\)

```csharp
public CMsgGCToGCPurchaseSucceeded(CMsgGCToGCPurchaseSucceeded other)
```

#### Parameters

`other` [CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCPurchaseSucceeded> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCPurchaseSucceeded Clone()
```

#### Returns

 [CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_Equals_Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_"></a> Equals\(CMsgGCToGCPurchaseSucceeded\)

```csharp
public bool Equals(CMsgGCToGCPurchaseSucceeded other)
```

#### Parameters

`other` [CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_"></a> MergeFrom\(CMsgGCToGCPurchaseSucceeded\)

```csharp
public void MergeFrom(CMsgGCToGCPurchaseSucceeded other)
```

#### Parameters

`other` [CMsgGCToGCPurchaseSucceeded](Divine.Protobufs.Dota2.CMsgGCToGCPurchaseSucceeded.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPurchaseSucceeded_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

