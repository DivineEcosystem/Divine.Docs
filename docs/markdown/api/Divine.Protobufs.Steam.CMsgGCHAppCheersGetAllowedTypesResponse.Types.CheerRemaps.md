# <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps"></a> Class CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps : IMessage<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps>, IEquatable<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps>, IDeepCloneable<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)

#### Implements

IMessage<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps\>, 
[IEquatable<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps\>, 
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
[EnumerableExtensions.In<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps\>\(CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps, params CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps__ctor"></a> CheerRemaps\(\)

```csharp
public CheerRemaps()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps__ctor_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_"></a> CheerRemaps\(CheerRemaps\)

```csharp
public CheerRemaps(CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_OriginalCheerTypeFieldNumber"></a> OriginalCheerTypeFieldNumber

```csharp
public const int OriginalCheerTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_RemappedCheerTypeFieldNumber"></a> RemappedCheerTypeFieldNumber

```csharp
public const int RemappedCheerTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_HasOriginalCheerType"></a> HasOriginalCheerType

```csharp
public bool HasOriginalCheerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_HasRemappedCheerType"></a> HasRemappedCheerType

```csharp
public bool HasRemappedCheerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_OriginalCheerType"></a> OriginalCheerType

```csharp
public uint OriginalCheerType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_RemappedCheerType"></a> RemappedCheerType

```csharp
public uint RemappedCheerType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_ClearOriginalCheerType"></a> ClearOriginalCheerType\(\)

```csharp
public void ClearOriginalCheerType()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_ClearRemappedCheerType"></a> ClearRemappedCheerType\(\)

```csharp
public void ClearRemappedCheerType()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps Clone()
```

#### Returns

 [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_Equals_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_"></a> Equals\(CheerRemaps\)

```csharp
public bool Equals(CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_"></a> MergeFrom\(CheerRemaps\)

```csharp
public void MergeFrom(CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps other)
```

#### Parameters

`other` [CMsgGCHAppCheersGetAllowedTypesResponse](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.md).[CheerRemaps](Divine.Protobufs.Steam.CMsgGCHAppCheersGetAllowedTypesResponse.Types.CheerRemaps.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersGetAllowedTypesResponse_Types_CheerRemaps_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

