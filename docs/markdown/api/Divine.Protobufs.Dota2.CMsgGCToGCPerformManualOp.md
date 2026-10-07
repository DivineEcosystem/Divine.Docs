# <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp"></a> Class CMsgGCToGCPerformManualOp

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCPerformManualOp : IMessage<CMsgGCToGCPerformManualOp>, IEquatable<CMsgGCToGCPerformManualOp>, IDeepCloneable<CMsgGCToGCPerformManualOp>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)

#### Implements

IMessage<CMsgGCToGCPerformManualOp\>, 
[IEquatable<CMsgGCToGCPerformManualOp\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCPerformManualOp\>, 
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
[EnumerableExtensions.In<CMsgGCToGCPerformManualOp\>\(CMsgGCToGCPerformManualOp, params CMsgGCToGCPerformManualOp\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp__ctor"></a> CMsgGCToGCPerformManualOp\(\)

```csharp
public CMsgGCToGCPerformManualOp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp__ctor_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_"></a> CMsgGCToGCPerformManualOp\(CMsgGCToGCPerformManualOp\)

```csharp
public CMsgGCToGCPerformManualOp(CMsgGCToGCPerformManualOp other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_GroupCodeFieldNumber"></a> GroupCodeFieldNumber

```csharp
public const int GroupCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_OpIdFieldNumber"></a> OpIdFieldNumber

```csharp
public const int OpIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_GroupCode"></a> GroupCode

```csharp
public uint GroupCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_HasGroupCode"></a> HasGroupCode

```csharp
public bool HasGroupCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_HasOpId"></a> HasOpId

```csharp
public bool HasOpId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_OpId"></a> OpId

```csharp
public ulong OpId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCPerformManualOp> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_ClearGroupCode"></a> ClearGroupCode\(\)

```csharp
public void ClearGroupCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_ClearOpId"></a> ClearOpId\(\)

```csharp
public void ClearOpId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCPerformManualOp Clone()
```

#### Returns

 [CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_Equals_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_"></a> Equals\(CMsgGCToGCPerformManualOp\)

```csharp
public bool Equals(CMsgGCToGCPerformManualOp other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_"></a> MergeFrom\(CMsgGCToGCPerformManualOp\)

```csharp
public void MergeFrom(CMsgGCToGCPerformManualOp other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOp](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOp.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOp_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

