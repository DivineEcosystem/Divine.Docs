# <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange"></a> Class CMsgGCHVacVerificationChange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHVacVerificationChange : IMessage<CMsgGCHVacVerificationChange>, IEquatable<CMsgGCHVacVerificationChange>, IDeepCloneable<CMsgGCHVacVerificationChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)

#### Implements

IMessage<CMsgGCHVacVerificationChange\>, 
[IEquatable<CMsgGCHVacVerificationChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHVacVerificationChange\>, 
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
[EnumerableExtensions.In<CMsgGCHVacVerificationChange\>\(CMsgGCHVacVerificationChange, params CMsgGCHVacVerificationChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange__ctor"></a> CMsgGCHVacVerificationChange\(\)

```csharp
public CMsgGCHVacVerificationChange()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange__ctor_Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_"></a> CMsgGCHVacVerificationChange\(CMsgGCHVacVerificationChange\)

```csharp
public CMsgGCHVacVerificationChange(CMsgGCHVacVerificationChange other)
```

#### Parameters

`other` [CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_IsVerifiedFieldNumber"></a> IsVerifiedFieldNumber

```csharp
public const int IsVerifiedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_HasIsVerified"></a> HasIsVerified

```csharp
public bool HasIsVerified { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_IsVerified"></a> IsVerified

```csharp
public bool IsVerified { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHVacVerificationChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_ClearIsVerified"></a> ClearIsVerified\(\)

```csharp
public void ClearIsVerified()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Clone"></a> Clone\(\)

```csharp
public CMsgGCHVacVerificationChange Clone()
```

#### Returns

 [CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_Equals_Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_"></a> Equals\(CMsgGCHVacVerificationChange\)

```csharp
public bool Equals(CMsgGCHVacVerificationChange other)
```

#### Parameters

`other` [CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_MergeFrom_Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_"></a> MergeFrom\(CMsgGCHVacVerificationChange\)

```csharp
public void MergeFrom(CMsgGCHVacVerificationChange other)
```

#### Parameters

`other` [CMsgGCHVacVerificationChange](Divine.Protobufs.Steam.CMsgGCHVacVerificationChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHVacVerificationChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

