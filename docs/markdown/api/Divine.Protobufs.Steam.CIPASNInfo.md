# <a id="Divine_Protobufs_Steam_CIPASNInfo"></a> Class CIPASNInfo

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CIPASNInfo : IMessage<CIPASNInfo>, IEquatable<CIPASNInfo>, IDeepCloneable<CIPASNInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)

#### Implements

IMessage<CIPASNInfo\>, 
[IEquatable<CIPASNInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CIPASNInfo\>, 
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
[EnumerableExtensions.In<CIPASNInfo\>\(CIPASNInfo, params CIPASNInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CIPASNInfo__ctor"></a> CIPASNInfo\(\)

```csharp
public CIPASNInfo()
```

### <a id="Divine_Protobufs_Steam_CIPASNInfo__ctor_Divine_Protobufs_Steam_CIPASNInfo_"></a> CIPASNInfo\(CIPASNInfo\)

```csharp
public CIPASNInfo(CIPASNInfo other)
```

#### Parameters

`other` [CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)

## Fields

### <a id="Divine_Protobufs_Steam_CIPASNInfo_AsnFieldNumber"></a> AsnFieldNumber

```csharp
public const int AsnFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_IpFieldNumber"></a> IpFieldNumber

```csharp
public const int IpFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Asn"></a> Asn

```csharp
public uint Asn { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CIPASNInfo_HasAsn"></a> HasAsn

```csharp
public bool HasAsn { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_HasIp"></a> HasIp

```csharp
public bool HasIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Ip"></a> Ip

```csharp
public uint Ip { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Parser"></a> Parser

```csharp
public static MessageParser<CIPASNInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CIPASNInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_ClearAsn"></a> ClearAsn\(\)

```csharp
public void ClearAsn()
```

### <a id="Divine_Protobufs_Steam_CIPASNInfo_ClearIp"></a> ClearIp\(\)

```csharp
public void ClearIp()
```

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Clone"></a> Clone\(\)

```csharp
public CIPASNInfo Clone()
```

#### Returns

 [CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_Equals_Divine_Protobufs_Steam_CIPASNInfo_"></a> Equals\(CIPASNInfo\)

```csharp
public bool Equals(CIPASNInfo other)
```

#### Parameters

`other` [CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_MergeFrom_Divine_Protobufs_Steam_CIPASNInfo_"></a> MergeFrom\(CIPASNInfo\)

```csharp
public void MergeFrom(CIPASNInfo other)
```

#### Parameters

`other` [CIPASNInfo](Divine.Protobufs.Steam.CIPASNInfo.md)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CIPASNInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CIPASNInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

