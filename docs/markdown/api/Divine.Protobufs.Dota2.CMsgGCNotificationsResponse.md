# <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse"></a> Class CMsgGCNotificationsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCNotificationsResponse : IMessage<CMsgGCNotificationsResponse>, IEquatable<CMsgGCNotificationsResponse>, IDeepCloneable<CMsgGCNotificationsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)

#### Implements

IMessage<CMsgGCNotificationsResponse\>, 
[IEquatable<CMsgGCNotificationsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCNotificationsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCNotificationsResponse\>\(CMsgGCNotificationsResponse, params CMsgGCNotificationsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse__ctor"></a> CMsgGCNotificationsResponse\(\)

```csharp
public CMsgGCNotificationsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_"></a> CMsgGCNotificationsResponse\(CMsgGCNotificationsResponse\)

```csharp
public CMsgGCNotificationsResponse(CMsgGCNotificationsResponse other)
```

#### Parameters

`other` [CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_UpdateFieldNumber"></a> UpdateFieldNumber

```csharp
public const int UpdateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCNotificationsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Update"></a> Update

```csharp
public CMsgGCNotificationsUpdate Update { get; set; }
```

#### Property Value

 [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCNotificationsResponse Clone()
```

#### Returns

 [CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_"></a> Equals\(CMsgGCNotificationsResponse\)

```csharp
public bool Equals(CMsgGCNotificationsResponse other)
```

#### Parameters

`other` [CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_"></a> MergeFrom\(CMsgGCNotificationsResponse\)

```csharp
public void MergeFrom(CMsgGCNotificationsResponse other)
```

#### Parameters

`other` [CMsgGCNotificationsResponse](Divine.Protobufs.Dota2.CMsgGCNotificationsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

