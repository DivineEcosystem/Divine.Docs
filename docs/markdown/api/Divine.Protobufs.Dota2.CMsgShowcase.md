# <a id="Divine_Protobufs_Dota2_CMsgShowcase"></a> Class CMsgShowcase

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcase : IMessage<CMsgShowcase>, IEquatable<CMsgShowcase>, IDeepCloneable<CMsgShowcase>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

#### Implements

IMessage<CMsgShowcase\>, 
[IEquatable<CMsgShowcase\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcase\>, 
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
[EnumerableExtensions.In<CMsgShowcase\>\(CMsgShowcase, params CMsgShowcase\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcase__ctor"></a> CMsgShowcase\(\)

```csharp
public CMsgShowcase()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcase__ctor_Divine_Protobufs_Dota2_CMsgShowcase_"></a> CMsgShowcase\(CMsgShowcase\)

```csharp
public CMsgShowcase(CMsgShowcase other)
```

#### Parameters

`other` [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_BackgroundFieldNumber"></a> BackgroundFieldNumber

```csharp
public const int BackgroundFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ModerationStateFieldNumber"></a> ModerationStateFieldNumber

```csharp
public const int ModerationStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ShowcaseItemsFieldNumber"></a> ShowcaseItemsFieldNumber

```csharp
public const int ShowcaseItemsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Background"></a> Background

```csharp
public CMsgShowcaseItem Background { get; set; }
```

#### Property Value

 [CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_HasModerationState"></a> HasModerationState

```csharp
public bool HasModerationState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ModerationState"></a> ModerationState

```csharp
public CMsgShowcase.Types.EModerationState ModerationState { get; set; }
```

#### Property Value

 [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md).[Types](Divine.Protobufs.Dota2.CMsgShowcase.Types.md).[EModerationState](Divine.Protobufs.Dota2.CMsgShowcase.Types.EModerationState.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcase> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ShowcaseItems"></a> ShowcaseItems

```csharp
public RepeatedField<CMsgShowcaseItem> ShowcaseItems { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseItem](Divine.Protobufs.Dota2.CMsgShowcaseItem.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ClearModerationState"></a> ClearModerationState\(\)

```csharp
public void ClearModerationState()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Clone"></a> Clone\(\)

```csharp
public CMsgShowcase Clone()
```

#### Returns

 [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_Equals_Divine_Protobufs_Dota2_CMsgShowcase_"></a> Equals\(CMsgShowcase\)

```csharp
public bool Equals(CMsgShowcase other)
```

#### Parameters

`other` [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcase_"></a> MergeFrom\(CMsgShowcase\)

```csharp
public void MergeFrom(CMsgShowcase other)
```

#### Parameters

`other` [CMsgShowcase](Divine.Protobufs.Dota2.CMsgShowcase.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcase_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

