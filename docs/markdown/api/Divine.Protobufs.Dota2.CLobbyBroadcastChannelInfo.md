# <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo"></a> Class CLobbyBroadcastChannelInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CLobbyBroadcastChannelInfo : IMessage<CLobbyBroadcastChannelInfo>, IEquatable<CLobbyBroadcastChannelInfo>, IDeepCloneable<CLobbyBroadcastChannelInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)

#### Implements

IMessage<CLobbyBroadcastChannelInfo\>, 
[IEquatable<CLobbyBroadcastChannelInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CLobbyBroadcastChannelInfo\>, 
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
[EnumerableExtensions.In<CLobbyBroadcastChannelInfo\>\(CLobbyBroadcastChannelInfo, params CLobbyBroadcastChannelInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo__ctor"></a> CLobbyBroadcastChannelInfo\(\)

```csharp
public CLobbyBroadcastChannelInfo()
```

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo__ctor_Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_"></a> CLobbyBroadcastChannelInfo\(CLobbyBroadcastChannelInfo\)

```csharp
public CLobbyBroadcastChannelInfo(CLobbyBroadcastChannelInfo other)
```

#### Parameters

`other` [CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ChannelIdFieldNumber"></a> ChannelIdFieldNumber

```csharp
public const int ChannelIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_LanguageCodeFieldNumber"></a> LanguageCodeFieldNumber

```csharp
public const int LanguageCodeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ChannelId"></a> ChannelId

```csharp
public uint ChannelId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_HasChannelId"></a> HasChannelId

```csharp
public bool HasChannelId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_HasLanguageCode"></a> HasLanguageCode

```csharp
public bool HasLanguageCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_LanguageCode"></a> LanguageCode

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Parser"></a> Parser

```csharp
public static MessageParser<CLobbyBroadcastChannelInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ClearChannelId"></a> ClearChannelId\(\)

```csharp
public void ClearChannelId()
```

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ClearLanguageCode"></a> ClearLanguageCode\(\)

```csharp
public void ClearLanguageCode()
```

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Clone"></a> Clone\(\)

```csharp
public CLobbyBroadcastChannelInfo Clone()
```

#### Returns

 [CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_Equals_Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_"></a> Equals\(CLobbyBroadcastChannelInfo\)

```csharp
public bool Equals(CLobbyBroadcastChannelInfo other)
```

#### Parameters

`other` [CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_MergeFrom_Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_"></a> MergeFrom\(CLobbyBroadcastChannelInfo\)

```csharp
public void MergeFrom(CLobbyBroadcastChannelInfo other)
```

#### Parameters

`other` [CLobbyBroadcastChannelInfo](Divine.Protobufs.Dota2.CLobbyBroadcastChannelInfo.md)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CLobbyBroadcastChannelInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

