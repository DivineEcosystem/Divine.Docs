# <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage"></a> Class CMsgServerToGCWarningInvalidBotAbilityUsage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCWarningInvalidBotAbilityUsage : IMessage<CMsgServerToGCWarningInvalidBotAbilityUsage>, IEquatable<CMsgServerToGCWarningInvalidBotAbilityUsage>, IDeepCloneable<CMsgServerToGCWarningInvalidBotAbilityUsage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)

#### Implements

IMessage<CMsgServerToGCWarningInvalidBotAbilityUsage\>, 
[IEquatable<CMsgServerToGCWarningInvalidBotAbilityUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCWarningInvalidBotAbilityUsage\>, 
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
[EnumerableExtensions.In<CMsgServerToGCWarningInvalidBotAbilityUsage\>\(CMsgServerToGCWarningInvalidBotAbilityUsage, params CMsgServerToGCWarningInvalidBotAbilityUsage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage__ctor"></a> CMsgServerToGCWarningInvalidBotAbilityUsage\(\)

```csharp
public CMsgServerToGCWarningInvalidBotAbilityUsage()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage__ctor_Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_"></a> CMsgServerToGCWarningInvalidBotAbilityUsage\(CMsgServerToGCWarningInvalidBotAbilityUsage\)

```csharp
public CMsgServerToGCWarningInvalidBotAbilityUsage(CMsgServerToGCWarningInvalidBotAbilityUsage other)
```

#### Parameters

`other` [CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_AbilityNameFieldNumber"></a> AbilityNameFieldNumber

```csharp
public const int AbilityNameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_UnitNameFieldNumber"></a> UnitNameFieldNumber

```csharp
public const int UnitNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_AbilityName"></a> AbilityName

```csharp
public string AbilityName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_HasAbilityName"></a> HasAbilityName

```csharp
public bool HasAbilityName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_HasUnitName"></a> HasUnitName

```csharp
public bool HasUnitName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCWarningInvalidBotAbilityUsage> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_UnitName"></a> UnitName

```csharp
public string UnitName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_ClearAbilityName"></a> ClearAbilityName\(\)

```csharp
public void ClearAbilityName()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_ClearUnitName"></a> ClearUnitName\(\)

```csharp
public void ClearUnitName()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCWarningInvalidBotAbilityUsage Clone()
```

#### Returns

 [CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_Equals_Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_"></a> Equals\(CMsgServerToGCWarningInvalidBotAbilityUsage\)

```csharp
public bool Equals(CMsgServerToGCWarningInvalidBotAbilityUsage other)
```

#### Parameters

`other` [CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_"></a> MergeFrom\(CMsgServerToGCWarningInvalidBotAbilityUsage\)

```csharp
public void MergeFrom(CMsgServerToGCWarningInvalidBotAbilityUsage other)
```

#### Parameters

`other` [CMsgServerToGCWarningInvalidBotAbilityUsage](Divine.Protobufs.Dota2.CMsgServerToGCWarningInvalidBotAbilityUsage.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCWarningInvalidBotAbilityUsage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

