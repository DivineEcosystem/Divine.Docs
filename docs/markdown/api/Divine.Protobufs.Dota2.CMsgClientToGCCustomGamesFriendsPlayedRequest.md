# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest"></a> Class CMsgClientToGCCustomGamesFriendsPlayedRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCustomGamesFriendsPlayedRequest : IMessage<CMsgClientToGCCustomGamesFriendsPlayedRequest>, IEquatable<CMsgClientToGCCustomGamesFriendsPlayedRequest>, IDeepCloneable<CMsgClientToGCCustomGamesFriendsPlayedRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)

#### Implements

IMessage<CMsgClientToGCCustomGamesFriendsPlayedRequest\>, 
[IEquatable<CMsgClientToGCCustomGamesFriendsPlayedRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCustomGamesFriendsPlayedRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCustomGamesFriendsPlayedRequest\>\(CMsgClientToGCCustomGamesFriendsPlayedRequest, params CMsgClientToGCCustomGamesFriendsPlayedRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest__ctor"></a> CMsgClientToGCCustomGamesFriendsPlayedRequest\(\)

```csharp
public CMsgClientToGCCustomGamesFriendsPlayedRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_"></a> CMsgClientToGCCustomGamesFriendsPlayedRequest\(CMsgClientToGCCustomGamesFriendsPlayedRequest\)

```csharp
public CMsgClientToGCCustomGamesFriendsPlayedRequest(CMsgClientToGCCustomGamesFriendsPlayedRequest other)
```

#### Parameters

`other` [CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCustomGamesFriendsPlayedRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCustomGamesFriendsPlayedRequest Clone()
```

#### Returns

 [CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_"></a> Equals\(CMsgClientToGCCustomGamesFriendsPlayedRequest\)

```csharp
public bool Equals(CMsgClientToGCCustomGamesFriendsPlayedRequest other)
```

#### Parameters

`other` [CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_"></a> MergeFrom\(CMsgClientToGCCustomGamesFriendsPlayedRequest\)

```csharp
public void MergeFrom(CMsgClientToGCCustomGamesFriendsPlayedRequest other)
```

#### Parameters

`other` [CMsgClientToGCCustomGamesFriendsPlayedRequest](Divine.Protobufs.Dota2.CMsgClientToGCCustomGamesFriendsPlayedRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCustomGamesFriendsPlayedRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

