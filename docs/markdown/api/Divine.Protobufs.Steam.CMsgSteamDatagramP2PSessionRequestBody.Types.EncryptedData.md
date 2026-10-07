# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData"></a> Class CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData : IMessage<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData>, IEquatable<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData>, IDeepCloneable<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)

#### Implements

IMessage<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData\>, 
[IEquatable<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData\>\(CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData, params CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData__ctor"></a> EncryptedData\(\)

```csharp
public EncryptedData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_"></a> EncryptedData\(EncryptedData\)

```csharp
public EncryptedData(CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.md).[EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_PeerIdentityStringFieldNumber"></a> PeerIdentityStringFieldNumber

```csharp
public const int PeerIdentityStringFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_HasPeerIdentityString"></a> HasPeerIdentityString

```csharp
public bool HasPeerIdentityString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.md).[EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_PeerIdentityString"></a> PeerIdentityString

```csharp
public string PeerIdentityString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_ClearPeerIdentityString"></a> ClearPeerIdentityString\(\)

```csharp
public void ClearPeerIdentityString()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData Clone()
```

#### Returns

 [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.md).[EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_"></a> Equals\(EncryptedData\)

```csharp
public bool Equals(CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.md).[EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_"></a> MergeFrom\(EncryptedData\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PSessionRequestBody](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.md).[Types](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.md).[EncryptedData](Divine.Protobufs.Steam.CMsgSteamDatagramP2PSessionRequestBody.Types.EncryptedData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PSessionRequestBody_Types_EncryptedData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

