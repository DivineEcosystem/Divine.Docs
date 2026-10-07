# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2"></a> Class CMsgClientToGCRequestEventPointLogV2

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestEventPointLogV2 : IMessage<CMsgClientToGCRequestEventPointLogV2>, IEquatable<CMsgClientToGCRequestEventPointLogV2>, IDeepCloneable<CMsgClientToGCRequestEventPointLogV2>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)

#### Implements

IMessage<CMsgClientToGCRequestEventPointLogV2\>, 
[IEquatable<CMsgClientToGCRequestEventPointLogV2\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestEventPointLogV2\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestEventPointLogV2\>\(CMsgClientToGCRequestEventPointLogV2, params CMsgClientToGCRequestEventPointLogV2\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2__ctor"></a> CMsgClientToGCRequestEventPointLogV2\(\)

```csharp
public CMsgClientToGCRequestEventPointLogV2()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_"></a> CMsgClientToGCRequestEventPointLogV2\(CMsgClientToGCRequestEventPointLogV2\)

```csharp
public CMsgClientToGCRequestEventPointLogV2(CMsgClientToGCRequestEventPointLogV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestEventPointLogV2> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestEventPointLogV2 Clone()
```

#### Returns

 [CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_"></a> Equals\(CMsgClientToGCRequestEventPointLogV2\)

```csharp
public bool Equals(CMsgClientToGCRequestEventPointLogV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_"></a> MergeFrom\(CMsgClientToGCRequestEventPointLogV2\)

```csharp
public void MergeFrom(CMsgClientToGCRequestEventPointLogV2 other)
```

#### Parameters

`other` [CMsgClientToGCRequestEventPointLogV2](Divine.Protobufs.Dota2.CMsgClientToGCRequestEventPointLogV2.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestEventPointLogV2_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

