# <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource"></a> Class CMsgDOTAGetPeriodicResource

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGetPeriodicResource : IMessage<CMsgDOTAGetPeriodicResource>, IEquatable<CMsgDOTAGetPeriodicResource>, IDeepCloneable<CMsgDOTAGetPeriodicResource>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

#### Implements

IMessage<CMsgDOTAGetPeriodicResource\>, 
[IEquatable<CMsgDOTAGetPeriodicResource\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGetPeriodicResource\>, 
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
[EnumerableExtensions.In<CMsgDOTAGetPeriodicResource\>\(CMsgDOTAGetPeriodicResource, params CMsgDOTAGetPeriodicResource\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource__ctor"></a> CMsgDOTAGetPeriodicResource\(\)

```csharp
public CMsgDOTAGetPeriodicResource()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource__ctor_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_"></a> CMsgDOTAGetPeriodicResource\(CMsgDOTAGetPeriodicResource\)

```csharp
public CMsgDOTAGetPeriodicResource(CMsgDOTAGetPeriodicResource other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_PeriodicResourceIdFieldNumber"></a> PeriodicResourceIdFieldNumber

```csharp
public const int PeriodicResourceIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_HasPeriodicResourceId"></a> HasPeriodicResourceId

```csharp
public bool HasPeriodicResourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGetPeriodicResource> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_PeriodicResourceId"></a> PeriodicResourceId

```csharp
public uint PeriodicResourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_ClearPeriodicResourceId"></a> ClearPeriodicResourceId\(\)

```csharp
public void ClearPeriodicResourceId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGetPeriodicResource Clone()
```

#### Returns

 [CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_Equals_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_"></a> Equals\(CMsgDOTAGetPeriodicResource\)

```csharp
public bool Equals(CMsgDOTAGetPeriodicResource other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_"></a> MergeFrom\(CMsgDOTAGetPeriodicResource\)

```csharp
public void MergeFrom(CMsgDOTAGetPeriodicResource other)
```

#### Parameters

`other` [CMsgDOTAGetPeriodicResource](Divine.Protobufs.Dota2.CMsgDOTAGetPeriodicResource.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGetPeriodicResource_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

