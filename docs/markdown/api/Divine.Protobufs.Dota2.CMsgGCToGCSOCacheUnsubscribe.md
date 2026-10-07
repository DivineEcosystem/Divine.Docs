# <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe"></a> Class CMsgGCToGCSOCacheUnsubscribe

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCSOCacheUnsubscribe : IMessage<CMsgGCToGCSOCacheUnsubscribe>, IEquatable<CMsgGCToGCSOCacheUnsubscribe>, IDeepCloneable<CMsgGCToGCSOCacheUnsubscribe>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)

#### Implements

IMessage<CMsgGCToGCSOCacheUnsubscribe\>, 
[IEquatable<CMsgGCToGCSOCacheUnsubscribe\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCSOCacheUnsubscribe\>, 
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
[EnumerableExtensions.In<CMsgGCToGCSOCacheUnsubscribe\>\(CMsgGCToGCSOCacheUnsubscribe, params CMsgGCToGCSOCacheUnsubscribe\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe__ctor"></a> CMsgGCToGCSOCacheUnsubscribe\(\)

```csharp
public CMsgGCToGCSOCacheUnsubscribe()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe__ctor_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_"></a> CMsgGCToGCSOCacheUnsubscribe\(CMsgGCToGCSOCacheUnsubscribe\)

```csharp
public CMsgGCToGCSOCacheUnsubscribe(CMsgGCToGCSOCacheUnsubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_SubscriberFieldNumber"></a> SubscriberFieldNumber

```csharp
public const int SubscriberFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_UnsubscribeFromIdFieldNumber"></a> UnsubscribeFromIdFieldNumber

```csharp
public const int UnsubscribeFromIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_UnsubscribeFromTypeFieldNumber"></a> UnsubscribeFromTypeFieldNumber

```csharp
public const int UnsubscribeFromTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_HasSubscriber"></a> HasSubscriber

```csharp
public bool HasSubscriber { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_HasUnsubscribeFromId"></a> HasUnsubscribeFromId

```csharp
public bool HasUnsubscribeFromId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_HasUnsubscribeFromType"></a> HasUnsubscribeFromType

```csharp
public bool HasUnsubscribeFromType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCSOCacheUnsubscribe> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Subscriber"></a> Subscriber

```csharp
public ulong Subscriber { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_UnsubscribeFromId"></a> UnsubscribeFromId

```csharp
public ulong UnsubscribeFromId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_UnsubscribeFromType"></a> UnsubscribeFromType

```csharp
public uint UnsubscribeFromType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_ClearSubscriber"></a> ClearSubscriber\(\)

```csharp
public void ClearSubscriber()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_ClearUnsubscribeFromId"></a> ClearUnsubscribeFromId\(\)

```csharp
public void ClearUnsubscribeFromId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_ClearUnsubscribeFromType"></a> ClearUnsubscribeFromType\(\)

```csharp
public void ClearUnsubscribeFromType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCSOCacheUnsubscribe Clone()
```

#### Returns

 [CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_Equals_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_"></a> Equals\(CMsgGCToGCSOCacheUnsubscribe\)

```csharp
public bool Equals(CMsgGCToGCSOCacheUnsubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_"></a> MergeFrom\(CMsgGCToGCSOCacheUnsubscribe\)

```csharp
public void MergeFrom(CMsgGCToGCSOCacheUnsubscribe other)
```

#### Parameters

`other` [CMsgGCToGCSOCacheUnsubscribe](Divine.Protobufs.Dota2.CMsgGCToGCSOCacheUnsubscribe.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCSOCacheUnsubscribe_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

