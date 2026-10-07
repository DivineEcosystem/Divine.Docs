# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel"></a> Class CMsgDOTAMatch.Types.BroadcasterChannel

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatch.Types.BroadcasterChannel : IMessage<CMsgDOTAMatch.Types.BroadcasterChannel>, IEquatable<CMsgDOTAMatch.Types.BroadcasterChannel>, IDeepCloneable<CMsgDOTAMatch.Types.BroadcasterChannel>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatch.Types.BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)

#### Implements

IMessage<CMsgDOTAMatch.Types.BroadcasterChannel\>, 
[IEquatable<CMsgDOTAMatch.Types.BroadcasterChannel\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatch.Types.BroadcasterChannel\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatch.Types.BroadcasterChannel\>\(CMsgDOTAMatch.Types.BroadcasterChannel, params CMsgDOTAMatch.Types.BroadcasterChannel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel__ctor"></a> BroadcasterChannel\(\)

```csharp
public BroadcasterChannel()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_"></a> BroadcasterChannel\(BroadcasterChannel\)

```csharp
public BroadcasterChannel(CMsgDOTAMatch.Types.BroadcasterChannel other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_BroadcasterInfosFieldNumber"></a> BroadcasterInfosFieldNumber

```csharp
public const int BroadcasterInfosFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_LanguageCodeFieldNumber"></a> LanguageCodeFieldNumber

```csharp
public const int LanguageCodeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_BroadcasterInfos"></a> BroadcasterInfos

```csharp
public RepeatedField<CMsgDOTAMatch.Types.BroadcasterInfo> BroadcasterInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterInfo](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_HasLanguageCode"></a> HasLanguageCode

```csharp
public bool HasLanguageCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_LanguageCode"></a> LanguageCode

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatch.Types.BroadcasterChannel> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_ClearLanguageCode"></a> ClearLanguageCode\(\)

```csharp
public void ClearLanguageCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatch.Types.BroadcasterChannel Clone()
```

#### Returns

 [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_"></a> Equals\(BroadcasterChannel\)

```csharp
public bool Equals(CMsgDOTAMatch.Types.BroadcasterChannel other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_"></a> MergeFrom\(BroadcasterChannel\)

```csharp
public void MergeFrom(CMsgDOTAMatch.Types.BroadcasterChannel other)
```

#### Parameters

`other` [CMsgDOTAMatch](Divine.Protobufs.Dota2.CMsgDOTAMatch.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.md).[BroadcasterChannel](Divine.Protobufs.Dota2.CMsgDOTAMatch.Types.BroadcasterChannel.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatch_Types_BroadcasterChannel_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

