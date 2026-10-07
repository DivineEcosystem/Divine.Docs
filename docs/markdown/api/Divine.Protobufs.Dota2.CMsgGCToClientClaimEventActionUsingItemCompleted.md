# <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted"></a> Class CMsgGCToClientClaimEventActionUsingItemCompleted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientClaimEventActionUsingItemCompleted : IMessage<CMsgGCToClientClaimEventActionUsingItemCompleted>, IEquatable<CMsgGCToClientClaimEventActionUsingItemCompleted>, IDeepCloneable<CMsgGCToClientClaimEventActionUsingItemCompleted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)

#### Implements

IMessage<CMsgGCToClientClaimEventActionUsingItemCompleted\>, 
[IEquatable<CMsgGCToClientClaimEventActionUsingItemCompleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientClaimEventActionUsingItemCompleted\>, 
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
[EnumerableExtensions.In<CMsgGCToClientClaimEventActionUsingItemCompleted\>\(CMsgGCToClientClaimEventActionUsingItemCompleted, params CMsgGCToClientClaimEventActionUsingItemCompleted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted__ctor"></a> CMsgGCToClientClaimEventActionUsingItemCompleted\(\)

```csharp
public CMsgGCToClientClaimEventActionUsingItemCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted__ctor_Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_"></a> CMsgGCToClientClaimEventActionUsingItemCompleted\(CMsgGCToClientClaimEventActionUsingItemCompleted\)

```csharp
public CMsgGCToClientClaimEventActionUsingItemCompleted(CMsgGCToClientClaimEventActionUsingItemCompleted other)
```

#### Parameters

`other` [CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ActionResultsFieldNumber"></a> ActionResultsFieldNumber

```csharp
public const int ActionResultsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ActionResults"></a> ActionResults

```csharp
public CMsgDOTAClaimEventActionResponse ActionResults { get; set; }
```

#### Property Value

 [CMsgDOTAClaimEventActionResponse](Divine.Protobufs.Dota2.CMsgDOTAClaimEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientClaimEventActionUsingItemCompleted> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientClaimEventActionUsingItemCompleted Clone()
```

#### Returns

 [CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_Equals_Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_"></a> Equals\(CMsgGCToClientClaimEventActionUsingItemCompleted\)

```csharp
public bool Equals(CMsgGCToClientClaimEventActionUsingItemCompleted other)
```

#### Parameters

`other` [CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_"></a> MergeFrom\(CMsgGCToClientClaimEventActionUsingItemCompleted\)

```csharp
public void MergeFrom(CMsgGCToClientClaimEventActionUsingItemCompleted other)
```

#### Parameters

`other` [CMsgGCToClientClaimEventActionUsingItemCompleted](Divine.Protobufs.Dota2.CMsgGCToClientClaimEventActionUsingItemCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientClaimEventActionUsingItemCompleted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

