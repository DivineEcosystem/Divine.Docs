# <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions"></a> Class CMsgPartyBuilderOptions

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPartyBuilderOptions : IMessage<CMsgPartyBuilderOptions>, IEquatable<CMsgPartyBuilderOptions>, IDeepCloneable<CMsgPartyBuilderOptions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)

#### Implements

IMessage<CMsgPartyBuilderOptions\>, 
[IEquatable<CMsgPartyBuilderOptions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPartyBuilderOptions\>, 
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
[EnumerableExtensions.In<CMsgPartyBuilderOptions\>\(CMsgPartyBuilderOptions, params CMsgPartyBuilderOptions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions__ctor"></a> CMsgPartyBuilderOptions\(\)

```csharp
public CMsgPartyBuilderOptions()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions__ctor_Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_"></a> CMsgPartyBuilderOptions\(CMsgPartyBuilderOptions\)

```csharp
public CMsgPartyBuilderOptions(CMsgPartyBuilderOptions other)
```

#### Parameters

`other` [CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_AdditionalSlotsFieldNumber"></a> AdditionalSlotsFieldNumber

```csharp
public const int AdditionalSlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_MatchgroupsFieldNumber"></a> MatchgroupsFieldNumber

```csharp
public const int MatchgroupsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_MatchTypeFieldNumber"></a> MatchTypeFieldNumber

```csharp
public const int MatchTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_AdditionalSlots"></a> AdditionalSlots

```csharp
public uint AdditionalSlots { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_HasAdditionalSlots"></a> HasAdditionalSlots

```csharp
public bool HasAdditionalSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_HasMatchgroups"></a> HasMatchgroups

```csharp
public bool HasMatchgroups { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_HasMatchType"></a> HasMatchType

```csharp
public bool HasMatchType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Language"></a> Language

```csharp
public MatchLanguages Language { get; set; }
```

#### Property Value

 [MatchLanguages](Divine.Protobufs.Dota2.MatchLanguages.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Matchgroups"></a> Matchgroups

```csharp
public uint Matchgroups { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_MatchType"></a> MatchType

```csharp
public MatchType MatchType { get; set; }
```

#### Property Value

 [MatchType](Divine.Protobufs.Dota2.MatchType.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPartyBuilderOptions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClearAdditionalSlots"></a> ClearAdditionalSlots\(\)

```csharp
public void ClearAdditionalSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClearMatchgroups"></a> ClearMatchgroups\(\)

```csharp
public void ClearMatchgroups()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ClearMatchType"></a> ClearMatchType\(\)

```csharp
public void ClearMatchType()
```

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Clone"></a> Clone\(\)

```csharp
public CMsgPartyBuilderOptions Clone()
```

#### Returns

 [CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_Equals_Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_"></a> Equals\(CMsgPartyBuilderOptions\)

```csharp
public bool Equals(CMsgPartyBuilderOptions other)
```

#### Parameters

`other` [CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_MergeFrom_Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_"></a> MergeFrom\(CMsgPartyBuilderOptions\)

```csharp
public void MergeFrom(CMsgPartyBuilderOptions other)
```

#### Parameters

`other` [CMsgPartyBuilderOptions](Divine.Protobufs.Dota2.CMsgPartyBuilderOptions.md)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPartyBuilderOptions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

