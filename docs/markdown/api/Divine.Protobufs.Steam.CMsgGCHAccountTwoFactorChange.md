# <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange"></a> Class CMsgGCHAccountTwoFactorChange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAccountTwoFactorChange : IMessage<CMsgGCHAccountTwoFactorChange>, IEquatable<CMsgGCHAccountTwoFactorChange>, IDeepCloneable<CMsgGCHAccountTwoFactorChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)

#### Implements

IMessage<CMsgGCHAccountTwoFactorChange\>, 
[IEquatable<CMsgGCHAccountTwoFactorChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAccountTwoFactorChange\>, 
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
[EnumerableExtensions.In<CMsgGCHAccountTwoFactorChange\>\(CMsgGCHAccountTwoFactorChange, params CMsgGCHAccountTwoFactorChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange__ctor"></a> CMsgGCHAccountTwoFactorChange\(\)

```csharp
public CMsgGCHAccountTwoFactorChange()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange__ctor_Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_"></a> CMsgGCHAccountTwoFactorChange\(CMsgGCHAccountTwoFactorChange\)

```csharp
public CMsgGCHAccountTwoFactorChange(CMsgGCHAccountTwoFactorChange other)
```

#### Parameters

`other` [CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_TwofactorEnabledFieldNumber"></a> TwofactorEnabledFieldNumber

```csharp
public const int TwofactorEnabledFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_HasTwofactorEnabled"></a> HasTwofactorEnabled

```csharp
public bool HasTwofactorEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAccountTwoFactorChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_TwofactorEnabled"></a> TwofactorEnabled

```csharp
public bool TwofactorEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_ClearTwofactorEnabled"></a> ClearTwofactorEnabled\(\)

```csharp
public void ClearTwofactorEnabled()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAccountTwoFactorChange Clone()
```

#### Returns

 [CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_Equals_Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_"></a> Equals\(CMsgGCHAccountTwoFactorChange\)

```csharp
public bool Equals(CMsgGCHAccountTwoFactorChange other)
```

#### Parameters

`other` [CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_"></a> MergeFrom\(CMsgGCHAccountTwoFactorChange\)

```csharp
public void MergeFrom(CMsgGCHAccountTwoFactorChange other)
```

#### Parameters

`other` [CMsgGCHAccountTwoFactorChange](Divine.Protobufs.Steam.CMsgGCHAccountTwoFactorChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountTwoFactorChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

