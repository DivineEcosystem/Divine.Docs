# <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails"></a> Class CMsgSetSpectatorLobbyDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSetSpectatorLobbyDetails : IMessage<CMsgSetSpectatorLobbyDetails>, IEquatable<CMsgSetSpectatorLobbyDetails>, IDeepCloneable<CMsgSetSpectatorLobbyDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

#### Implements

IMessage<CMsgSetSpectatorLobbyDetails\>, 
[IEquatable<CMsgSetSpectatorLobbyDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSetSpectatorLobbyDetails\>, 
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
[EnumerableExtensions.In<CMsgSetSpectatorLobbyDetails\>\(CMsgSetSpectatorLobbyDetails, params CMsgSetSpectatorLobbyDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails__ctor"></a> CMsgSetSpectatorLobbyDetails\(\)

```csharp
public CMsgSetSpectatorLobbyDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails__ctor_Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_"></a> CMsgSetSpectatorLobbyDetails\(CMsgSetSpectatorLobbyDetails\)

```csharp
public CMsgSetSpectatorLobbyDetails(CMsgSetSpectatorLobbyDetails other)
```

#### Parameters

`other` [CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_GameDetailsFieldNumber"></a> GameDetailsFieldNumber

```csharp
public const int GameDetailsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_LobbyNameFieldNumber"></a> LobbyNameFieldNumber

```csharp
public const int LobbyNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_PassKeyFieldNumber"></a> PassKeyFieldNumber

```csharp
public const int PassKeyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_GameDetails"></a> GameDetails

```csharp
public CMsgSpectatorLobbyGameDetails GameDetails { get; set; }
```

#### Property Value

 [CMsgSpectatorLobbyGameDetails](Divine.Protobufs.Dota2.CMsgSpectatorLobbyGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_HasLobbyName"></a> HasLobbyName

```csharp
public bool HasLobbyName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_HasPassKey"></a> HasPassKey

```csharp
public bool HasPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_LobbyName"></a> LobbyName

```csharp
public string LobbyName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSetSpectatorLobbyDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_PassKey"></a> PassKey

```csharp
public string PassKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_ClearLobbyName"></a> ClearLobbyName\(\)

```csharp
public void ClearLobbyName()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_ClearPassKey"></a> ClearPassKey\(\)

```csharp
public void ClearPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_Clone"></a> Clone\(\)

```csharp
public CMsgSetSpectatorLobbyDetails Clone()
```

#### Returns

 [CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_Equals_Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_"></a> Equals\(CMsgSetSpectatorLobbyDetails\)

```csharp
public bool Equals(CMsgSetSpectatorLobbyDetails other)
```

#### Parameters

`other` [CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_"></a> MergeFrom\(CMsgSetSpectatorLobbyDetails\)

```csharp
public void MergeFrom(CMsgSetSpectatorLobbyDetails other)
```

#### Parameters

`other` [CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSetSpectatorLobbyDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

