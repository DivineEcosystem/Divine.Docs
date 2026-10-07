# <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable"></a> Class CMsgLANServerAvailable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLANServerAvailable : IMessage<CMsgLANServerAvailable>, IEquatable<CMsgLANServerAvailable>, IDeepCloneable<CMsgLANServerAvailable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)

#### Implements

IMessage<CMsgLANServerAvailable\>, 
[IEquatable<CMsgLANServerAvailable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLANServerAvailable\>, 
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
[EnumerableExtensions.In<CMsgLANServerAvailable\>\(CMsgLANServerAvailable, params CMsgLANServerAvailable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable__ctor"></a> CMsgLANServerAvailable\(\)

```csharp
public CMsgLANServerAvailable()
```

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable__ctor_Divine_Protobufs_Dota2_CMsgLANServerAvailable_"></a> CMsgLANServerAvailable\(CMsgLANServerAvailable\)

```csharp
public CMsgLANServerAvailable(CMsgLANServerAvailable other)
```

#### Parameters

`other` [CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_NonceFieldNumber"></a> NonceFieldNumber

```csharp
public const int NonceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_HasNonce"></a> HasNonce

```csharp
public bool HasNonce { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Nonce"></a> Nonce

```csharp
public ulong Nonce { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLANServerAvailable> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_ClearNonce"></a> ClearNonce\(\)

```csharp
public void ClearNonce()
```

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Clone"></a> Clone\(\)

```csharp
public CMsgLANServerAvailable Clone()
```

#### Returns

 [CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_Equals_Divine_Protobufs_Dota2_CMsgLANServerAvailable_"></a> Equals\(CMsgLANServerAvailable\)

```csharp
public bool Equals(CMsgLANServerAvailable other)
```

#### Parameters

`other` [CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_MergeFrom_Divine_Protobufs_Dota2_CMsgLANServerAvailable_"></a> MergeFrom\(CMsgLANServerAvailable\)

```csharp
public void MergeFrom(CMsgLANServerAvailable other)
```

#### Parameters

`other` [CMsgLANServerAvailable](Divine.Protobufs.Dota2.CMsgLANServerAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLANServerAvailable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

