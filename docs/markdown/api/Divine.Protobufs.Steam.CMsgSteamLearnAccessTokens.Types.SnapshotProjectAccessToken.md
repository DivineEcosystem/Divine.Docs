# <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken"></a> Class CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken : IMessage<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken>, IEquatable<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken>, IDeepCloneable<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)

#### Implements

IMessage<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken\>, 
[IEquatable<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken\>\(CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken, params CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken__ctor"></a> SnapshotProjectAccessToken\(\)

```csharp
public SnapshotProjectAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken__ctor_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_"></a> SnapshotProjectAccessToken\(SnapshotProjectAccessToken\)

```csharp
public SnapshotProjectAccessToken(CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_AccessTokenFieldNumber"></a> AccessTokenFieldNumber

```csharp
public const int AccessTokenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_ProjectIdFieldNumber"></a> ProjectIdFieldNumber

```csharp
public const int ProjectIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_AccessToken"></a> AccessToken

```csharp
public string AccessToken { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_HasAccessToken"></a> HasAccessToken

```csharp
public bool HasAccessToken { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_HasProjectId"></a> HasProjectId

```csharp
public bool HasProjectId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_ProjectId"></a> ProjectId

```csharp
public uint ProjectId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_ClearAccessToken"></a> ClearAccessToken\(\)

```csharp
public void ClearAccessToken()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_ClearProjectId"></a> ClearProjectId\(\)

```csharp
public void ClearProjectId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken Clone()
```

#### Returns

 [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_Equals_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_"></a> Equals\(SnapshotProjectAccessToken\)

```csharp
public bool Equals(CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_"></a> MergeFrom\(SnapshotProjectAccessToken\)

```csharp
public void MergeFrom(CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken other)
```

#### Parameters

`other` [CMsgSteamLearnAccessTokens](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.md).[SnapshotProjectAccessToken](Divine.Protobufs.Steam.CMsgSteamLearnAccessTokens.Types.SnapshotProjectAccessToken.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnAccessTokens_Types_SnapshotProjectAccessToken_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

