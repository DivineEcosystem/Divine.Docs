# <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult"></a> Class CMsgGCToClientHeroStatueCreateResult

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientHeroStatueCreateResult : IMessage<CMsgGCToClientHeroStatueCreateResult>, IEquatable<CMsgGCToClientHeroStatueCreateResult>, IDeepCloneable<CMsgGCToClientHeroStatueCreateResult>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)

#### Implements

IMessage<CMsgGCToClientHeroStatueCreateResult\>, 
[IEquatable<CMsgGCToClientHeroStatueCreateResult\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientHeroStatueCreateResult\>, 
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
[EnumerableExtensions.In<CMsgGCToClientHeroStatueCreateResult\>\(CMsgGCToClientHeroStatueCreateResult, params CMsgGCToClientHeroStatueCreateResult\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult__ctor"></a> CMsgGCToClientHeroStatueCreateResult\(\)

```csharp
public CMsgGCToClientHeroStatueCreateResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult__ctor_Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_"></a> CMsgGCToClientHeroStatueCreateResult\(CMsgGCToClientHeroStatueCreateResult\)

```csharp
public CMsgGCToClientHeroStatueCreateResult(CMsgGCToClientHeroStatueCreateResult other)
```

#### Parameters

`other` [CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_ResultingItemIdFieldNumber"></a> ResultingItemIdFieldNumber

```csharp
public const int ResultingItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_HasResultingItemId"></a> HasResultingItemId

```csharp
public bool HasResultingItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientHeroStatueCreateResult> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_ResultingItemId"></a> ResultingItemId

```csharp
public ulong ResultingItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_ClearResultingItemId"></a> ClearResultingItemId\(\)

```csharp
public void ClearResultingItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientHeroStatueCreateResult Clone()
```

#### Returns

 [CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_Equals_Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_"></a> Equals\(CMsgGCToClientHeroStatueCreateResult\)

```csharp
public bool Equals(CMsgGCToClientHeroStatueCreateResult other)
```

#### Parameters

`other` [CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_"></a> MergeFrom\(CMsgGCToClientHeroStatueCreateResult\)

```csharp
public void MergeFrom(CMsgGCToClientHeroStatueCreateResult other)
```

#### Parameters

`other` [CMsgGCToClientHeroStatueCreateResult](Divine.Protobufs.Dota2.CMsgGCToClientHeroStatueCreateResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientHeroStatueCreateResult_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

