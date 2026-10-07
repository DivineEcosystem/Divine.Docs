# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary"></a> Class CMsgSteamDatagramP2PRoutingSummary

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramP2PRoutingSummary : IMessage<CMsgSteamDatagramP2PRoutingSummary>, IEquatable<CMsgSteamDatagramP2PRoutingSummary>, IDeepCloneable<CMsgSteamDatagramP2PRoutingSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

#### Implements

IMessage<CMsgSteamDatagramP2PRoutingSummary\>, 
[IEquatable<CMsgSteamDatagramP2PRoutingSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramP2PRoutingSummary\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramP2PRoutingSummary\>\(CMsgSteamDatagramP2PRoutingSummary, params CMsgSteamDatagramP2PRoutingSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary__ctor"></a> CMsgSteamDatagramP2PRoutingSummary\(\)

```csharp
public CMsgSteamDatagramP2PRoutingSummary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_"></a> CMsgSteamDatagramP2PRoutingSummary\(CMsgSteamDatagramP2PRoutingSummary\)

```csharp
public CMsgSteamDatagramP2PRoutingSummary(CMsgSteamDatagramP2PRoutingSummary other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_IceFieldNumber"></a> IceFieldNumber

```csharp
public const int IceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_SdrFieldNumber"></a> SdrFieldNumber

```csharp
public const int SdrFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Ice"></a> Ice

```csharp
public CMsgSteamNetworkingICESessionSummary Ice { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramP2PRoutingSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Sdr"></a> Sdr

```csharp
public CMsgSteamNetworkingP2PSDRRoutingSummary Sdr { get; set; }
```

#### Property Value

 [CMsgSteamNetworkingP2PSDRRoutingSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingP2PSDRRoutingSummary.md)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramP2PRoutingSummary Clone()
```

#### Returns

 [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_"></a> Equals\(CMsgSteamDatagramP2PRoutingSummary\)

```csharp
public bool Equals(CMsgSteamDatagramP2PRoutingSummary other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_"></a> MergeFrom\(CMsgSteamDatagramP2PRoutingSummary\)

```csharp
public void MergeFrom(CMsgSteamDatagramP2PRoutingSummary other)
```

#### Parameters

`other` [CMsgSteamDatagramP2PRoutingSummary](Divine.Protobufs.Steam.CMsgSteamDatagramP2PRoutingSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramP2PRoutingSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

