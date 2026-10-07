# <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo"></a> Class CMsgGCLobbyUpdateBroadcastChannelInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCLobbyUpdateBroadcastChannelInfo : IMessage<CMsgGCLobbyUpdateBroadcastChannelInfo>, IEquatable<CMsgGCLobbyUpdateBroadcastChannelInfo>, IDeepCloneable<CMsgGCLobbyUpdateBroadcastChannelInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)

#### Implements

IMessage<CMsgGCLobbyUpdateBroadcastChannelInfo\>, 
[IEquatable<CMsgGCLobbyUpdateBroadcastChannelInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCLobbyUpdateBroadcastChannelInfo\>, 
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
[EnumerableExtensions.In<CMsgGCLobbyUpdateBroadcastChannelInfo\>\(CMsgGCLobbyUpdateBroadcastChannelInfo, params CMsgGCLobbyUpdateBroadcastChannelInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo__ctor"></a> CMsgGCLobbyUpdateBroadcastChannelInfo\(\)

```csharp
public CMsgGCLobbyUpdateBroadcastChannelInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo__ctor_Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_"></a> CMsgGCLobbyUpdateBroadcastChannelInfo\(CMsgGCLobbyUpdateBroadcastChannelInfo\)

```csharp
public CMsgGCLobbyUpdateBroadcastChannelInfo(CMsgGCLobbyUpdateBroadcastChannelInfo other)
```

#### Parameters

`other` [CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_LanguageCodeFieldNumber"></a> LanguageCodeFieldNumber

```csharp
public const int LanguageCodeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ChannelId"></a> ChannelId

```csharp
public uint ChannelId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_HasLanguageCode"></a> HasLanguageCode

```csharp
public bool HasLanguageCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_LanguageCode"></a> LanguageCode

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCLobbyUpdateBroadcastChannelInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ClearLanguageCode"></a> ClearLanguageCode\(\)

```csharp
public void ClearLanguageCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Clone"></a> Clone\(\)

```csharp
public CMsgGCLobbyUpdateBroadcastChannelInfo Clone()
```

#### Returns

 [CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_Equals_Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_"></a> Equals\(CMsgGCLobbyUpdateBroadcastChannelInfo\)

```csharp
public bool Equals(CMsgGCLobbyUpdateBroadcastChannelInfo other)
```

#### Parameters

`other` [CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_"></a> MergeFrom\(CMsgGCLobbyUpdateBroadcastChannelInfo\)

```csharp
public void MergeFrom(CMsgGCLobbyUpdateBroadcastChannelInfo other)
```

#### Parameters

`other` [CMsgGCLobbyUpdateBroadcastChannelInfo](Divine.Protobufs.Dota2.CMsgGCLobbyUpdateBroadcastChannelInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCLobbyUpdateBroadcastChannelInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

