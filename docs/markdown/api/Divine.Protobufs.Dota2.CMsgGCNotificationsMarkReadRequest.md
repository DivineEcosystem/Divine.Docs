# <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest"></a> Class CMsgGCNotificationsMarkReadRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCNotificationsMarkReadRequest : IMessage<CMsgGCNotificationsMarkReadRequest>, IEquatable<CMsgGCNotificationsMarkReadRequest>, IDeepCloneable<CMsgGCNotificationsMarkReadRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)

#### Implements

IMessage<CMsgGCNotificationsMarkReadRequest\>, 
[IEquatable<CMsgGCNotificationsMarkReadRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCNotificationsMarkReadRequest\>, 
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
[EnumerableExtensions.In<CMsgGCNotificationsMarkReadRequest\>\(CMsgGCNotificationsMarkReadRequest, params CMsgGCNotificationsMarkReadRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest__ctor"></a> CMsgGCNotificationsMarkReadRequest\(\)

```csharp
public CMsgGCNotificationsMarkReadRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest__ctor_Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_"></a> CMsgGCNotificationsMarkReadRequest\(CMsgGCNotificationsMarkReadRequest\)

```csharp
public CMsgGCNotificationsMarkReadRequest(CMsgGCNotificationsMarkReadRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCNotificationsMarkReadRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCNotificationsMarkReadRequest Clone()
```

#### Returns

 [CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_Equals_Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_"></a> Equals\(CMsgGCNotificationsMarkReadRequest\)

```csharp
public bool Equals(CMsgGCNotificationsMarkReadRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_"></a> MergeFrom\(CMsgGCNotificationsMarkReadRequest\)

```csharp
public void MergeFrom(CMsgGCNotificationsMarkReadRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsMarkReadRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsMarkReadRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsMarkReadRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

