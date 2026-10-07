# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback"></a> Class CMsgClientToGCDotaLabsFeedback

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDotaLabsFeedback : IMessage<CMsgClientToGCDotaLabsFeedback>, IEquatable<CMsgClientToGCDotaLabsFeedback>, IDeepCloneable<CMsgClientToGCDotaLabsFeedback>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)

#### Implements

IMessage<CMsgClientToGCDotaLabsFeedback\>, 
[IEquatable<CMsgClientToGCDotaLabsFeedback\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDotaLabsFeedback\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDotaLabsFeedback\>\(CMsgClientToGCDotaLabsFeedback, params CMsgClientToGCDotaLabsFeedback\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback__ctor"></a> CMsgClientToGCDotaLabsFeedback\(\)

```csharp
public CMsgClientToGCDotaLabsFeedback()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_"></a> CMsgClientToGCDotaLabsFeedback\(CMsgClientToGCDotaLabsFeedback\)

```csharp
public CMsgClientToGCDotaLabsFeedback(CMsgClientToGCDotaLabsFeedback other)
```

#### Parameters

`other` [CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_FeedbackFieldNumber"></a> FeedbackFieldNumber

```csharp
public const int FeedbackFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_FeedbackItemFieldNumber"></a> FeedbackItemFieldNumber

```csharp
public const int FeedbackItemFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Feedback"></a> Feedback

```csharp
public string Feedback { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_FeedbackItem"></a> FeedbackItem

```csharp
public uint FeedbackItem { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_HasFeedback"></a> HasFeedback

```csharp
public bool HasFeedback { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_HasFeedbackItem"></a> HasFeedbackItem

```csharp
public bool HasFeedbackItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Language"></a> Language

```csharp
public uint Language { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDotaLabsFeedback> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_ClearFeedback"></a> ClearFeedback\(\)

```csharp
public void ClearFeedback()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_ClearFeedbackItem"></a> ClearFeedbackItem\(\)

```csharp
public void ClearFeedbackItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDotaLabsFeedback Clone()
```

#### Returns

 [CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_"></a> Equals\(CMsgClientToGCDotaLabsFeedback\)

```csharp
public bool Equals(CMsgClientToGCDotaLabsFeedback other)
```

#### Parameters

`other` [CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_"></a> MergeFrom\(CMsgClientToGCDotaLabsFeedback\)

```csharp
public void MergeFrom(CMsgClientToGCDotaLabsFeedback other)
```

#### Parameters

`other` [CMsgClientToGCDotaLabsFeedback](Divine.Protobufs.Dota2.CMsgClientToGCDotaLabsFeedback.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDotaLabsFeedback_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

