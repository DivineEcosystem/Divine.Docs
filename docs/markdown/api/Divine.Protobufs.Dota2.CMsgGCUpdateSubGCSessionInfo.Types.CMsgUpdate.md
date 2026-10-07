# <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate"></a> Class CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate : IMessage<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate>, IEquatable<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate>, IDeepCloneable<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)

#### Implements

IMessage<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate\>, 
[IEquatable<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate\>\(CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate, params CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate__ctor"></a> CMsgUpdate\(\)

```csharp
public CMsgUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_"></a> CMsgUpdate\(CMsgUpdate\)

```csharp
public CMsgUpdate(CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_IpFieldNumber"></a> IpFieldNumber

```csharp
public const int IpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_TrustedFieldNumber"></a> TrustedFieldNumber

```csharp
public const int TrustedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_HasIp"></a> HasIp

```csharp
public bool HasIp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_HasTrusted"></a> HasTrusted

```csharp
public bool HasTrusted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Ip"></a> Ip

```csharp
public uint Ip { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Trusted"></a> Trusted

```csharp
public bool Trusted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_ClearIp"></a> ClearIp\(\)

```csharp
public void ClearIp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_ClearTrusted"></a> ClearTrusted\(\)

```csharp
public void ClearTrusted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate Clone()
```

#### Returns

 [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_"></a> Equals\(CMsgUpdate\)

```csharp
public bool Equals(CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_"></a> MergeFrom\(CMsgUpdate\)

```csharp
public void MergeFrom(CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate other)
```

#### Parameters

`other` [CMsgGCUpdateSubGCSessionInfo](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.md).[Types](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.md).[CMsgUpdate](Divine.Protobufs.Dota2.CMsgGCUpdateSubGCSessionInfo.Types.CMsgUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCUpdateSubGCSessionInfo_Types_CMsgUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

