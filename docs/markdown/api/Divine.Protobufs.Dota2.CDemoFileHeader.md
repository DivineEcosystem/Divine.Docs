# <a id="Divine_Protobufs_Dota2_CDemoFileHeader"></a> Class CDemoFileHeader

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDemoFileHeader : IMessage<CDemoFileHeader>, IEquatable<CDemoFileHeader>, IDeepCloneable<CDemoFileHeader>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)

#### Implements

IMessage<CDemoFileHeader\>, 
[IEquatable<CDemoFileHeader\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDemoFileHeader\>, 
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
[EnumerableExtensions.In<CDemoFileHeader\>\(CDemoFileHeader, params CDemoFileHeader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader__ctor"></a> CDemoFileHeader\(\)

```csharp
public CDemoFileHeader()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader__ctor_Divine_Protobufs_Dota2_CDemoFileHeader_"></a> CDemoFileHeader\(CDemoFileHeader\)

```csharp
public CDemoFileHeader(CDemoFileHeader other)
```

#### Parameters

`other` [CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_AddonsFieldNumber"></a> AddonsFieldNumber

```csharp
public const int AddonsFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_AllowClientsideEntitiesFieldNumber"></a> AllowClientsideEntitiesFieldNumber

```csharp
public const int AllowClientsideEntitiesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_AllowClientsideParticlesFieldNumber"></a> AllowClientsideParticlesFieldNumber

```csharp
public const int AllowClientsideParticlesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_BuildNumFieldNumber"></a> BuildNumFieldNumber

```csharp
public const int BuildNumFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClientNameFieldNumber"></a> ClientNameFieldNumber

```csharp
public const int ClientNameFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoFileStampFieldNumber"></a> DemoFileStampFieldNumber

```csharp
public const int DemoFileStampFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoVersionGuidFieldNumber"></a> DemoVersionGuidFieldNumber

```csharp
public const int DemoVersionGuidFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoVersionNameFieldNumber"></a> DemoVersionNameFieldNumber

```csharp
public const int DemoVersionNameFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_FullpacketsVersionFieldNumber"></a> FullpacketsVersionFieldNumber

```csharp
public const int FullpacketsVersionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_GameDirectoryFieldNumber"></a> GameDirectoryFieldNumber

```csharp
public const int GameDirectoryFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_GameFieldNumber"></a> GameFieldNumber

```csharp
public const int GameFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_MapNameFieldNumber"></a> MapNameFieldNumber

```csharp
public const int MapNameFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_PatchVersionFieldNumber"></a> PatchVersionFieldNumber

```csharp
public const int PatchVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ServerNameFieldNumber"></a> ServerNameFieldNumber

```csharp
public const int ServerNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ServerStartTickFieldNumber"></a> ServerStartTickFieldNumber

```csharp
public const int ServerStartTickFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Addons"></a> Addons

```csharp
public string Addons { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_AllowClientsideEntities"></a> AllowClientsideEntities

```csharp
public bool AllowClientsideEntities { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_AllowClientsideParticles"></a> AllowClientsideParticles

```csharp
public bool AllowClientsideParticles { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_BuildNum"></a> BuildNum

```csharp
public int BuildNum { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClientName"></a> ClientName

```csharp
public string ClientName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoFileStamp"></a> DemoFileStamp

```csharp
public string DemoFileStamp { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoVersionGuid"></a> DemoVersionGuid

```csharp
public string DemoVersionGuid { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_DemoVersionName"></a> DemoVersionName

```csharp
public string DemoVersionName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_FullpacketsVersion"></a> FullpacketsVersion

```csharp
public int FullpacketsVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Game"></a> Game

```csharp
public string Game { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_GameDirectory"></a> GameDirectory

```csharp
public string GameDirectory { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasAddons"></a> HasAddons

```csharp
public bool HasAddons { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasAllowClientsideEntities"></a> HasAllowClientsideEntities

```csharp
public bool HasAllowClientsideEntities { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasAllowClientsideParticles"></a> HasAllowClientsideParticles

```csharp
public bool HasAllowClientsideParticles { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasBuildNum"></a> HasBuildNum

```csharp
public bool HasBuildNum { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasClientName"></a> HasClientName

```csharp
public bool HasClientName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasDemoFileStamp"></a> HasDemoFileStamp

```csharp
public bool HasDemoFileStamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasDemoVersionGuid"></a> HasDemoVersionGuid

```csharp
public bool HasDemoVersionGuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasDemoVersionName"></a> HasDemoVersionName

```csharp
public bool HasDemoVersionName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasFullpacketsVersion"></a> HasFullpacketsVersion

```csharp
public bool HasFullpacketsVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasGame"></a> HasGame

```csharp
public bool HasGame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasGameDirectory"></a> HasGameDirectory

```csharp
public bool HasGameDirectory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasMapName"></a> HasMapName

```csharp
public bool HasMapName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasPatchVersion"></a> HasPatchVersion

```csharp
public bool HasPatchVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasServerName"></a> HasServerName

```csharp
public bool HasServerName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_HasServerStartTick"></a> HasServerStartTick

```csharp
public bool HasServerStartTick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_MapName"></a> MapName

```csharp
public string MapName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Parser"></a> Parser

```csharp
public static MessageParser<CDemoFileHeader> Parser { get; }
```

#### Property Value

 MessageParser<[CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)\>

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_PatchVersion"></a> PatchVersion

```csharp
public int PatchVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ServerName"></a> ServerName

```csharp
public string ServerName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ServerStartTick"></a> ServerStartTick

```csharp
public int ServerStartTick { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearAddons"></a> ClearAddons\(\)

```csharp
public void ClearAddons()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearAllowClientsideEntities"></a> ClearAllowClientsideEntities\(\)

```csharp
public void ClearAllowClientsideEntities()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearAllowClientsideParticles"></a> ClearAllowClientsideParticles\(\)

```csharp
public void ClearAllowClientsideParticles()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearBuildNum"></a> ClearBuildNum\(\)

```csharp
public void ClearBuildNum()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearClientName"></a> ClearClientName\(\)

```csharp
public void ClearClientName()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearDemoFileStamp"></a> ClearDemoFileStamp\(\)

```csharp
public void ClearDemoFileStamp()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearDemoVersionGuid"></a> ClearDemoVersionGuid\(\)

```csharp
public void ClearDemoVersionGuid()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearDemoVersionName"></a> ClearDemoVersionName\(\)

```csharp
public void ClearDemoVersionName()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearFullpacketsVersion"></a> ClearFullpacketsVersion\(\)

```csharp
public void ClearFullpacketsVersion()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearGame"></a> ClearGame\(\)

```csharp
public void ClearGame()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearGameDirectory"></a> ClearGameDirectory\(\)

```csharp
public void ClearGameDirectory()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearMapName"></a> ClearMapName\(\)

```csharp
public void ClearMapName()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearPatchVersion"></a> ClearPatchVersion\(\)

```csharp
public void ClearPatchVersion()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearServerName"></a> ClearServerName\(\)

```csharp
public void ClearServerName()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ClearServerStartTick"></a> ClearServerStartTick\(\)

```csharp
public void ClearServerStartTick()
```

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Clone"></a> Clone\(\)

```csharp
public CDemoFileHeader Clone()
```

#### Returns

 [CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_Equals_Divine_Protobufs_Dota2_CDemoFileHeader_"></a> Equals\(CDemoFileHeader\)

```csharp
public bool Equals(CDemoFileHeader other)
```

#### Parameters

`other` [CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_MergeFrom_Divine_Protobufs_Dota2_CDemoFileHeader_"></a> MergeFrom\(CDemoFileHeader\)

```csharp
public void MergeFrom(CDemoFileHeader other)
```

#### Parameters

`other` [CDemoFileHeader](Divine.Protobufs.Dota2.CDemoFileHeader.md)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDemoFileHeader_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

