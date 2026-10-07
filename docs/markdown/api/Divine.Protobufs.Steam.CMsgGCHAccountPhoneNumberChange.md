# <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange"></a> Class CMsgGCHAccountPhoneNumberChange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAccountPhoneNumberChange : IMessage<CMsgGCHAccountPhoneNumberChange>, IEquatable<CMsgGCHAccountPhoneNumberChange>, IDeepCloneable<CMsgGCHAccountPhoneNumberChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)

#### Implements

IMessage<CMsgGCHAccountPhoneNumberChange\>, 
[IEquatable<CMsgGCHAccountPhoneNumberChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAccountPhoneNumberChange\>, 
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
[EnumerableExtensions.In<CMsgGCHAccountPhoneNumberChange\>\(CMsgGCHAccountPhoneNumberChange, params CMsgGCHAccountPhoneNumberChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange__ctor"></a> CMsgGCHAccountPhoneNumberChange\(\)

```csharp
public CMsgGCHAccountPhoneNumberChange()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange__ctor_Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_"></a> CMsgGCHAccountPhoneNumberChange\(CMsgGCHAccountPhoneNumberChange\)

```csharp
public CMsgGCHAccountPhoneNumberChange(CMsgGCHAccountPhoneNumberChange other)
```

#### Parameters

`other` [CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_IsIdentifyingFieldNumber"></a> IsIdentifyingFieldNumber

```csharp
public const int IsIdentifyingFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_IsVerifiedFieldNumber"></a> IsVerifiedFieldNumber

```csharp
public const int IsVerifiedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_PhoneIdFieldNumber"></a> PhoneIdFieldNumber

```csharp
public const int PhoneIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_HasIsIdentifying"></a> HasIsIdentifying

```csharp
public bool HasIsIdentifying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_HasIsVerified"></a> HasIsVerified

```csharp
public bool HasIsVerified { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_HasPhoneId"></a> HasPhoneId

```csharp
public bool HasPhoneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_IsIdentifying"></a> IsIdentifying

```csharp
public bool IsIdentifying { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_IsVerified"></a> IsVerified

```csharp
public bool IsVerified { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAccountPhoneNumberChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_PhoneId"></a> PhoneId

```csharp
public ulong PhoneId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ClearIsIdentifying"></a> ClearIsIdentifying\(\)

```csharp
public void ClearIsIdentifying()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ClearIsVerified"></a> ClearIsVerified\(\)

```csharp
public void ClearIsVerified()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ClearPhoneId"></a> ClearPhoneId\(\)

```csharp
public void ClearPhoneId()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAccountPhoneNumberChange Clone()
```

#### Returns

 [CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_Equals_Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_"></a> Equals\(CMsgGCHAccountPhoneNumberChange\)

```csharp
public bool Equals(CMsgGCHAccountPhoneNumberChange other)
```

#### Parameters

`other` [CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_"></a> MergeFrom\(CMsgGCHAccountPhoneNumberChange\)

```csharp
public void MergeFrom(CMsgGCHAccountPhoneNumberChange other)
```

#### Parameters

`other` [CMsgGCHAccountPhoneNumberChange](Divine.Protobufs.Steam.CMsgGCHAccountPhoneNumberChange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAccountPhoneNumberChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

