# <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo"></a> Class CMsgPlayerInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerInfo : IMessage<CMsgPlayerInfo>, IEquatable<CMsgPlayerInfo>, IDeepCloneable<CMsgPlayerInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)

#### Implements

IMessage<CMsgPlayerInfo\>, 
[IEquatable<CMsgPlayerInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerInfo\>, 
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
[EnumerableExtensions.In<CMsgPlayerInfo\>\(CMsgPlayerInfo, params CMsgPlayerInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo__ctor"></a> CMsgPlayerInfo\(\)

```csharp
public CMsgPlayerInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo__ctor_Divine_Protobufs_Dota2_CMsgPlayerInfo_"></a> CMsgPlayerInfo\(CMsgPlayerInfo\)

```csharp
public CMsgPlayerInfo(CMsgPlayerInfo other)
```

#### Parameters

`other` [CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClanMemberFieldNumber"></a> ClanMemberFieldNumber

```csharp
public const int ClanMemberFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClanOfficerFieldNumber"></a> ClanOfficerFieldNumber

```csharp
public const int ClanOfficerFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_FakeplayerFieldNumber"></a> FakeplayerFieldNumber

```csharp
public const int FakeplayerFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_IshltvFieldNumber"></a> IshltvFieldNumber

```csharp
public const int IshltvFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_UseridFieldNumber"></a> UseridFieldNumber

```csharp
public const int UseridFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_XuidFieldNumber"></a> XuidFieldNumber

```csharp
public const int XuidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClanMember"></a> ClanMember

```csharp
public bool ClanMember { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClanOfficer"></a> ClanOfficer

```csharp
public bool ClanOfficer { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Fakeplayer"></a> Fakeplayer

```csharp
public bool Fakeplayer { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasClanMember"></a> HasClanMember

```csharp
public bool HasClanMember { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasClanOfficer"></a> HasClanOfficer

```csharp
public bool HasClanOfficer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasFakeplayer"></a> HasFakeplayer

```csharp
public bool HasFakeplayer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasIshltv"></a> HasIshltv

```csharp
public bool HasIshltv { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasUserid"></a> HasUserid

```csharp
public bool HasUserid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_HasXuid"></a> HasXuid

```csharp
public bool HasXuid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Ishltv"></a> Ishltv

```csharp
public bool Ishltv { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Userid"></a> Userid

```csharp
public int Userid { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Xuid"></a> Xuid

```csharp
public ulong Xuid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearClanMember"></a> ClearClanMember\(\)

```csharp
public void ClearClanMember()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearClanOfficer"></a> ClearClanOfficer\(\)

```csharp
public void ClearClanOfficer()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearFakeplayer"></a> ClearFakeplayer\(\)

```csharp
public void ClearFakeplayer()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearIshltv"></a> ClearIshltv\(\)

```csharp
public void ClearIshltv()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearUserid"></a> ClearUserid\(\)

```csharp
public void ClearUserid()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ClearXuid"></a> ClearXuid\(\)

```csharp
public void ClearXuid()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerInfo Clone()
```

#### Returns

 [CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_Equals_Divine_Protobufs_Dota2_CMsgPlayerInfo_"></a> Equals\(CMsgPlayerInfo\)

```csharp
public bool Equals(CMsgPlayerInfo other)
```

#### Parameters

`other` [CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerInfo_"></a> MergeFrom\(CMsgPlayerInfo\)

```csharp
public void MergeFrom(CMsgPlayerInfo other)
```

#### Parameters

`other` [CMsgPlayerInfo](Divine.Protobufs.Dota2.CMsgPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

