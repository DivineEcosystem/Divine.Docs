# <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest"></a> Class CMsgDOTADestroyLobbyRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADestroyLobbyRequest : IMessage<CMsgDOTADestroyLobbyRequest>, IEquatable<CMsgDOTADestroyLobbyRequest>, IDeepCloneable<CMsgDOTADestroyLobbyRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)

#### Implements

IMessage<CMsgDOTADestroyLobbyRequest\>, 
[IEquatable<CMsgDOTADestroyLobbyRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADestroyLobbyRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTADestroyLobbyRequest\>\(CMsgDOTADestroyLobbyRequest, params CMsgDOTADestroyLobbyRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest__ctor"></a> CMsgDOTADestroyLobbyRequest\(\)

```csharp
public CMsgDOTADestroyLobbyRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_"></a> CMsgDOTADestroyLobbyRequest\(CMsgDOTADestroyLobbyRequest\)

```csharp
public CMsgDOTADestroyLobbyRequest(CMsgDOTADestroyLobbyRequest other)
```

#### Parameters

`other` [CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADestroyLobbyRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADestroyLobbyRequest Clone()
```

#### Returns

 [CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_"></a> Equals\(CMsgDOTADestroyLobbyRequest\)

```csharp
public bool Equals(CMsgDOTADestroyLobbyRequest other)
```

#### Parameters

`other` [CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_"></a> MergeFrom\(CMsgDOTADestroyLobbyRequest\)

```csharp
public void MergeFrom(CMsgDOTADestroyLobbyRequest other)
```

#### Parameters

`other` [CMsgDOTADestroyLobbyRequest](Divine.Protobufs.Dota2.CMsgDOTADestroyLobbyRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADestroyLobbyRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

