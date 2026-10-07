# <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens"></a> Class CMsgSteamLearnAccessTokens

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnAccessTokens : IMessage<CMsgSteamLearnAccessTokens>, IEquatable<CMsgSteamLearnAccessTokens>, IDeepCloneable<CMsgSteamLearnAccessTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

#### Implements

IMessage<CMsgSteamLearnAccessTokens\>, 
[IEquatable<CMsgSteamLearnAccessTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnAccessTokens\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnAccessTokens\>\(CMsgSteamLearnAccessTokens, params CMsgSteamLearnAccessTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens__ctor"></a> CMsgSteamLearnAccessTokens\(\)

```csharp
public CMsgSteamLearnAccessTokens()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens__ctor_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_"></a> CMsgSteamLearnAccessTokens\(CMsgSteamLearnAccessTokens\)

```csharp
public CMsgSteamLearnAccessTokens(CMsgSteamLearnAccessTokens other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_CacheDataAccessTokensFieldNumber"></a> CacheDataAccessTokensFieldNumber

```csharp
public const int CacheDataAccessTokensFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_InferenceAccessTokensFieldNumber"></a> InferenceAccessTokensFieldNumber

```csharp
public const int InferenceAccessTokensFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_RegisterDataSourceAccessTokenFieldNumber"></a> RegisterDataSourceAccessTokenFieldNumber

```csharp
public const int RegisterDataSourceAccessTokenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_SnapshotProjectAccessTokensFieldNumber"></a> SnapshotProjectAccessTokensFieldNumber

```csharp
public const int SnapshotProjectAccessTokensFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_CacheDataAccessTokens"></a> CacheDataAccessTokens

```csharp
public RepeatedField<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken> CacheDataAccessTokens { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_HasRegisterDataSourceAccessToken"></a> HasRegisterDataSourceAccessToken

```csharp
public bool HasRegisterDataSourceAccessToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_InferenceAccessTokens"></a> InferenceAccessTokens

```csharp
public RepeatedField<CMsgSteamLearnAccessTokens.Types.InferenceAccessToken> InferenceAccessTokens { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[InferenceAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.InferenceAccessToken.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnAccessTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_RegisterDataSourceAccessToken"></a> RegisterDataSourceAccessToken

```csharp
public string RegisterDataSourceAccessToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_SnapshotProjectAccessTokens"></a> SnapshotProjectAccessTokens

```csharp
public RepeatedField<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken> SnapshotProjectAccessTokens { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_ClearRegisterDataSourceAccessToken"></a> ClearRegisterDataSourceAccessToken\(\)

```csharp
public void ClearRegisterDataSourceAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnAccessTokens Clone()
```

#### Returns

 [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Equals_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_"></a> Equals\(CMsgSteamLearnAccessTokens\)

```csharp
public bool Equals(CMsgSteamLearnAccessTokens other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_"></a> MergeFrom\(CMsgSteamLearnAccessTokens\)

```csharp
public void MergeFrom(CMsgSteamLearnAccessTokens other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

