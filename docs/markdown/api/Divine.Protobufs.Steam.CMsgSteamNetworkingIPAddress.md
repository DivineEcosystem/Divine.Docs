# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress"></a> Class CMsgSteamNetworkingIPAddress

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingIPAddress : IMessage<CMsgSteamNetworkingIPAddress>, IEquatable<CMsgSteamNetworkingIPAddress>, IDeepCloneable<CMsgSteamNetworkingIPAddress>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

#### Implements

IMessage<CMsgSteamNetworkingIPAddress\>, 
[IEquatable<CMsgSteamNetworkingIPAddress\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingIPAddress\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingIPAddress\>\(CMsgSteamNetworkingIPAddress, params CMsgSteamNetworkingIPAddress\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress__ctor"></a> CMsgSteamNetworkingIPAddress\(\)

```csharp
public CMsgSteamNetworkingIPAddress()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_"></a> CMsgSteamNetworkingIPAddress\(CMsgSteamNetworkingIPAddress\)

```csharp
public CMsgSteamNetworkingIPAddress(CMsgSteamNetworkingIPAddress other)
```

#### Parameters

`other` [CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_V4FieldNumber"></a> V4FieldNumber

```csharp
public const int V4FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_V6FieldNumber"></a> V6FieldNumber

```csharp
public const int V6FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_HasV4"></a> HasV4

```csharp
public bool HasV4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_HasV6"></a> HasV6

```csharp
public bool HasV6 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingIPAddress> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_V4"></a> V4

```csharp
public uint V4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_V6"></a> V6

```csharp
public ByteString V6 { get; set; }
```

#### Property Value

 ByteString

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_ClearV4"></a> ClearV4\(\)

```csharp
public void ClearV4()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_ClearV6"></a> ClearV6\(\)

```csharp
public void ClearV6()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingIPAddress Clone()
```

#### Returns

 [CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_"></a> Equals\(CMsgSteamNetworkingIPAddress\)

```csharp
public bool Equals(CMsgSteamNetworkingIPAddress other)
```

#### Parameters

`other` [CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_"></a> MergeFrom\(CMsgSteamNetworkingIPAddress\)

```csharp
public void MergeFrom(CMsgSteamNetworkingIPAddress other)
```

#### Parameters

`other` [CMsgSteamNetworkingIPAddress](Divine.Protobufs.Steam.CMsgSteamNetworkingIPAddress.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingIPAddress_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

