# <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync"></a> Class CMsgGCToGCMasterSubscribeToCacheAsync

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCMasterSubscribeToCacheAsync : IMessage<CMsgGCToGCMasterSubscribeToCacheAsync>, IEquatable<CMsgGCToGCMasterSubscribeToCacheAsync>, IDeepCloneable<CMsgGCToGCMasterSubscribeToCacheAsync>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)

#### Implements

IMessage<CMsgGCToGCMasterSubscribeToCacheAsync\>, 
[IEquatable<CMsgGCToGCMasterSubscribeToCacheAsync\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCMasterSubscribeToCacheAsync\>, 
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
[EnumerableExtensions.In<CMsgGCToGCMasterSubscribeToCacheAsync\>\(CMsgGCToGCMasterSubscribeToCacheAsync, params CMsgGCToGCMasterSubscribeToCacheAsync\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync__ctor"></a> CMsgGCToGCMasterSubscribeToCacheAsync\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheAsync()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync__ctor_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_"></a> CMsgGCToGCMasterSubscribeToCacheAsync\(CMsgGCToGCMasterSubscribeToCacheAsync\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheAsync(CMsgGCToGCMasterSubscribeToCacheAsync other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_SubscribeMsgFieldNumber"></a> SubscribeMsgFieldNumber

```csharp
public const int SubscribeMsgFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCMasterSubscribeToCacheAsync> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_SubscribeMsg"></a> SubscribeMsg

```csharp
public CMsgGCToGCMasterSubscribeToCache SubscribeMsg { get; set; }
```

#### Property Value

 [CMsgGCToGCMasterSubscribeToCache](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCache.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCMasterSubscribeToCacheAsync Clone()
```

#### Returns

 [CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_Equals_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_"></a> Equals\(CMsgGCToGCMasterSubscribeToCacheAsync\)

```csharp
public bool Equals(CMsgGCToGCMasterSubscribeToCacheAsync other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_"></a> MergeFrom\(CMsgGCToGCMasterSubscribeToCacheAsync\)

```csharp
public void MergeFrom(CMsgGCToGCMasterSubscribeToCacheAsync other)
```

#### Parameters

`other` [CMsgGCToGCMasterSubscribeToCacheAsync](Divine.Protobufs.Dota2.CMsgGCToGCMasterSubscribeToCacheAsync.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCMasterSubscribeToCacheAsync_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

