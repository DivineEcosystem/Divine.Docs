# <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby"></a> Class CMsgCreateSpectatorLobby

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCreateSpectatorLobby : IMessage<CMsgCreateSpectatorLobby>, IEquatable<CMsgCreateSpectatorLobby>, IDeepCloneable<CMsgCreateSpectatorLobby>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)

#### Implements

IMessage<CMsgCreateSpectatorLobby\>, 
[IEquatable<CMsgCreateSpectatorLobby\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCreateSpectatorLobby\>, 
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
[EnumerableExtensions.In<CMsgCreateSpectatorLobby\>\(CMsgCreateSpectatorLobby, params CMsgCreateSpectatorLobby\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby__ctor"></a> CMsgCreateSpectatorLobby\(\)

```csharp
public CMsgCreateSpectatorLobby()
```

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby__ctor_Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_"></a> CMsgCreateSpectatorLobby\(CMsgCreateSpectatorLobby\)

```csharp
public CMsgCreateSpectatorLobby(CMsgCreateSpectatorLobby other)
```

#### Parameters

`other` [CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_DetailsFieldNumber"></a> DetailsFieldNumber

```csharp
public const int DetailsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Details"></a> Details

```csharp
public CMsgSetSpectatorLobbyDetails Details { get; set; }
```

#### Property Value

 [CMsgSetSpectatorLobbyDetails](Divine.Protobufs.Dota2.CMsgSetSpectatorLobbyDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCreateSpectatorLobby> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Clone"></a> Clone\(\)

```csharp
public CMsgCreateSpectatorLobby Clone()
```

#### Returns

 [CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_Equals_Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_"></a> Equals\(CMsgCreateSpectatorLobby\)

```csharp
public bool Equals(CMsgCreateSpectatorLobby other)
```

#### Parameters

`other` [CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_MergeFrom_Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_"></a> MergeFrom\(CMsgCreateSpectatorLobby\)

```csharp
public void MergeFrom(CMsgCreateSpectatorLobby other)
```

#### Parameters

`other` [CMsgCreateSpectatorLobby](Divine.Protobufs.Dota2.CMsgCreateSpectatorLobby.md)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCreateSpectatorLobby_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

