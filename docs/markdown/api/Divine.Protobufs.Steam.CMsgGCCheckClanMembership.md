# <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership"></a> Class CMsgGCCheckClanMembership

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCCheckClanMembership : IMessage<CMsgGCCheckClanMembership>, IEquatable<CMsgGCCheckClanMembership>, IDeepCloneable<CMsgGCCheckClanMembership>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)

#### Implements

IMessage<CMsgGCCheckClanMembership\>, 
[IEquatable<CMsgGCCheckClanMembership\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCCheckClanMembership\>, 
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
[EnumerableExtensions.In<CMsgGCCheckClanMembership\>\(CMsgGCCheckClanMembership, params CMsgGCCheckClanMembership\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership__ctor"></a> CMsgGCCheckClanMembership\(\)

```csharp
public CMsgGCCheckClanMembership()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership__ctor_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_"></a> CMsgGCCheckClanMembership\(CMsgGCCheckClanMembership\)

```csharp
public CMsgGCCheckClanMembership(CMsgGCCheckClanMembership other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_ClanidFieldNumber"></a> ClanidFieldNumber

```csharp
public const int ClanidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Clanid"></a> Clanid

```csharp
public uint Clanid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_HasClanid"></a> HasClanid

```csharp
public bool HasClanid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCCheckClanMembership> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_ClearClanid"></a> ClearClanid\(\)

```csharp
public void ClearClanid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Clone"></a> Clone\(\)

```csharp
public CMsgGCCheckClanMembership Clone()
```

#### Returns

 [CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_Equals_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_"></a> Equals\(CMsgGCCheckClanMembership\)

```csharp
public bool Equals(CMsgGCCheckClanMembership other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_MergeFrom_Divine_Protobufs_Steam_CMsgGCCheckClanMembership_"></a> MergeFrom\(CMsgGCCheckClanMembership\)

```csharp
public void MergeFrom(CMsgGCCheckClanMembership other)
```

#### Parameters

`other` [CMsgGCCheckClanMembership](Divine.Protobufs.Steam.CMsgGCCheckClanMembership.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckClanMembership_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

