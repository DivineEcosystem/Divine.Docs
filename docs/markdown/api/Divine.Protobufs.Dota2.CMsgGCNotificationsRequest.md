# <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest"></a> Class CMsgGCNotificationsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCNotificationsRequest : IMessage<CMsgGCNotificationsRequest>, IEquatable<CMsgGCNotificationsRequest>, IDeepCloneable<CMsgGCNotificationsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)

#### Implements

IMessage<CMsgGCNotificationsRequest\>, 
[IEquatable<CMsgGCNotificationsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCNotificationsRequest\>, 
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
[EnumerableExtensions.In<CMsgGCNotificationsRequest\>\(CMsgGCNotificationsRequest, params CMsgGCNotificationsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest__ctor"></a> CMsgGCNotificationsRequest\(\)

```csharp
public CMsgGCNotificationsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest__ctor_Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_"></a> CMsgGCNotificationsRequest\(CMsgGCNotificationsRequest\)

```csharp
public CMsgGCNotificationsRequest(CMsgGCNotificationsRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCNotificationsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCNotificationsRequest Clone()
```

#### Returns

 [CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_Equals_Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_"></a> Equals\(CMsgGCNotificationsRequest\)

```csharp
public bool Equals(CMsgGCNotificationsRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_"></a> MergeFrom\(CMsgGCNotificationsRequest\)

```csharp
public void MergeFrom(CMsgGCNotificationsRequest other)
```

#### Parameters

`other` [CMsgGCNotificationsRequest](Divine.Protobufs.Dota2.CMsgGCNotificationsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

