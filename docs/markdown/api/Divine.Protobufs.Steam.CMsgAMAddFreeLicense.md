# <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense"></a> Class CMsgAMAddFreeLicense

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMAddFreeLicense : IMessage<CMsgAMAddFreeLicense>, IEquatable<CMsgAMAddFreeLicense>, IDeepCloneable<CMsgAMAddFreeLicense>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)

#### Implements

IMessage<CMsgAMAddFreeLicense\>, 
[IEquatable<CMsgAMAddFreeLicense\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMAddFreeLicense\>, 
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
[EnumerableExtensions.In<CMsgAMAddFreeLicense\>\(CMsgAMAddFreeLicense, params CMsgAMAddFreeLicense\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense__ctor"></a> CMsgAMAddFreeLicense\(\)

```csharp
public CMsgAMAddFreeLicense()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense__ctor_Divine_Protobufs_Steam_CMsgAMAddFreeLicense_"></a> CMsgAMAddFreeLicense\(CMsgAMAddFreeLicense\)

```csharp
public CMsgAMAddFreeLicense(CMsgAMAddFreeLicense other)
```

#### Parameters

`other` [CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_IpPublicFieldNumber"></a> IpPublicFieldNumber

```csharp
public const int IpPublicFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_PackageidFieldNumber"></a> PackageidFieldNumber

```csharp
public const int PackageidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_StoreCountryCodeFieldNumber"></a> StoreCountryCodeFieldNumber

```csharp
public const int StoreCountryCodeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_HasIpPublic"></a> HasIpPublic

```csharp
public bool HasIpPublic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_HasPackageid"></a> HasPackageid

```csharp
public bool HasPackageid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_HasStoreCountryCode"></a> HasStoreCountryCode

```csharp
public bool HasStoreCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_IpPublic"></a> IpPublic

```csharp
public uint IpPublic { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Packageid"></a> Packageid

```csharp
public uint Packageid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMAddFreeLicense> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_StoreCountryCode"></a> StoreCountryCode

```csharp
public string StoreCountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_ClearIpPublic"></a> ClearIpPublic\(\)

```csharp
public void ClearIpPublic()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_ClearPackageid"></a> ClearPackageid\(\)

```csharp
public void ClearPackageid()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_ClearStoreCountryCode"></a> ClearStoreCountryCode\(\)

```csharp
public void ClearStoreCountryCode()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Clone"></a> Clone\(\)

```csharp
public CMsgAMAddFreeLicense Clone()
```

#### Returns

 [CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_Equals_Divine_Protobufs_Steam_CMsgAMAddFreeLicense_"></a> Equals\(CMsgAMAddFreeLicense\)

```csharp
public bool Equals(CMsgAMAddFreeLicense other)
```

#### Parameters

`other` [CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_MergeFrom_Divine_Protobufs_Steam_CMsgAMAddFreeLicense_"></a> MergeFrom\(CMsgAMAddFreeLicense\)

```csharp
public void MergeFrom(CMsgAMAddFreeLicense other)
```

#### Parameters

`other` [CMsgAMAddFreeLicense](Divine.Protobufs.Steam.CMsgAMAddFreeLicense.md)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicense_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

