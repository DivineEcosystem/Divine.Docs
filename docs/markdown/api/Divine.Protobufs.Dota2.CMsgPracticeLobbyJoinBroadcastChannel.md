# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel"></a> Class CMsgPracticeLobbyJoinBroadcastChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyJoinBroadcastChannel : IMessage<CMsgPracticeLobbyJoinBroadcastChannel>, IEquatable<CMsgPracticeLobbyJoinBroadcastChannel>, IDeepCloneable<CMsgPracticeLobbyJoinBroadcastChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)

#### Implements

IMessage<CMsgPracticeLobbyJoinBroadcastChannel\>, 
[IEquatable<CMsgPracticeLobbyJoinBroadcastChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyJoinBroadcastChannel\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyJoinBroadcastChannel\>\(CMsgPracticeLobbyJoinBroadcastChannel, params CMsgPracticeLobbyJoinBroadcastChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel__ctor"></a> CMsgPracticeLobbyJoinBroadcastChannel\(\)

```csharp
public CMsgPracticeLobbyJoinBroadcastChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_"></a> CMsgPracticeLobbyJoinBroadcastChannel\(CMsgPracticeLobbyJoinBroadcastChannel\)

```csharp
public CMsgPracticeLobbyJoinBroadcastChannel(CMsgPracticeLobbyJoinBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredCountryCodeFieldNumber"></a> PreferredCountryCodeFieldNumber

```csharp
public const int PreferredCountryCodeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredDescriptionFieldNumber"></a> PreferredDescriptionFieldNumber

```csharp
public const int PreferredDescriptionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredLanguageCodeFieldNumber"></a> PreferredLanguageCodeFieldNumber

```csharp
public const int PreferredLanguageCodeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Channel"></a> Channel

```csharp
public uint Channel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_HasPreferredCountryCode"></a> HasPreferredCountryCode

```csharp
public bool HasPreferredCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_HasPreferredDescription"></a> HasPreferredDescription

```csharp
public bool HasPreferredDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_HasPreferredLanguageCode"></a> HasPreferredLanguageCode

```csharp
public bool HasPreferredLanguageCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyJoinBroadcastChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredCountryCode"></a> PreferredCountryCode

```csharp
public string PreferredCountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredDescription"></a> PreferredDescription

```csharp
public string PreferredDescription { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_PreferredLanguageCode"></a> PreferredLanguageCode

```csharp
public string PreferredLanguageCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ClearPreferredCountryCode"></a> ClearPreferredCountryCode\(\)

```csharp
public void ClearPreferredCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ClearPreferredDescription"></a> ClearPreferredDescription\(\)

```csharp
public void ClearPreferredDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ClearPreferredLanguageCode"></a> ClearPreferredLanguageCode\(\)

```csharp
public void ClearPreferredLanguageCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyJoinBroadcastChannel Clone()
```

#### Returns

 [CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_"></a> Equals\(CMsgPracticeLobbyJoinBroadcastChannel\)

```csharp
public bool Equals(CMsgPracticeLobbyJoinBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_"></a> MergeFrom\(CMsgPracticeLobbyJoinBroadcastChannel\)

```csharp
public void MergeFrom(CMsgPracticeLobbyJoinBroadcastChannel other)
```

#### Parameters

`other` [CMsgPracticeLobbyJoinBroadcastChannel](Divine.Protobufs.Dota2.CMsgPracticeLobbyJoinBroadcastChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyJoinBroadcastChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

