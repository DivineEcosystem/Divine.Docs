# <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken"></a> Class CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken : IMessage<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken>, IEquatable<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken>, IDeepCloneable<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)

#### Implements

IMessage<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken\>, 
[IEquatable<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken\>\(CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken, params CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken__ctor"></a> CacheDataAccessToken\(\)

```csharp
public CacheDataAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken__ctor_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_"></a> CacheDataAccessToken\(CacheDataAccessToken\)

```csharp
public CacheDataAccessToken(CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_AccessTokenFieldNumber"></a> AccessTokenFieldNumber

```csharp
public const int AccessTokenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_DataSourceIdFieldNumber"></a> DataSourceIdFieldNumber

```csharp
public const int DataSourceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_AccessToken"></a> AccessToken

```csharp
public string AccessToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_DataSourceId"></a> DataSourceId

```csharp
public uint DataSourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_HasAccessToken"></a> HasAccessToken

```csharp
public bool HasAccessToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_HasDataSourceId"></a> HasDataSourceId

```csharp
public bool HasDataSourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_ClearAccessToken"></a> ClearAccessToken\(\)

```csharp
public void ClearAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_ClearDataSourceId"></a> ClearDataSourceId\(\)

```csharp
public void ClearDataSourceId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken Clone()
```

#### Returns

 [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_Equals_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_"></a> Equals\(CacheDataAccessToken\)

```csharp
public bool Equals(CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_"></a> MergeFrom\(CacheDataAccessToken\)

```csharp
public void MergeFrom(CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[CacheDataAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.CacheDataAccessToken.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_CacheDataAccessToken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

