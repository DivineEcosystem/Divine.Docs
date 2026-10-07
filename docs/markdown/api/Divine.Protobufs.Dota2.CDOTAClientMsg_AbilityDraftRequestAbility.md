# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility"></a> Class CDOTAClientMsg\_AbilityDraftRequestAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AbilityDraftRequestAbility : IMessage<CDOTAClientMsg_AbilityDraftRequestAbility>, IEquatable<CDOTAClientMsg_AbilityDraftRequestAbility>, IDeepCloneable<CDOTAClientMsg_AbilityDraftRequestAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)

#### Implements

IMessage<CDOTAClientMsg\_AbilityDraftRequestAbility\>, 
[IEquatable<CDOTAClientMsg\_AbilityDraftRequestAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AbilityDraftRequestAbility\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AbilityDraftRequestAbility\>\(CDOTAClientMsg\_AbilityDraftRequestAbility, params CDOTAClientMsg\_AbilityDraftRequestAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility__ctor"></a> CDOTAClientMsg\_AbilityDraftRequestAbility\(\)

```csharp
public CDOTAClientMsg_AbilityDraftRequestAbility()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_"></a> CDOTAClientMsg\_AbilityDraftRequestAbility\(CDOTAClientMsg\_AbilityDraftRequestAbility\)

```csharp
public CDOTAClientMsg_AbilityDraftRequestAbility(CDOTAClientMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_CtrlIsDownFieldNumber"></a> CtrlIsDownFieldNumber

```csharp
public const int CtrlIsDownFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedAbilityIdFieldNumber"></a> RequestedAbilityIdFieldNumber

```csharp
public const int RequestedAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedFacetKeyFieldNumber"></a> RequestedFacetKeyFieldNumber

```csharp
public const int RequestedFacetKeyFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedHeroIdFieldNumber"></a> RequestedHeroIdFieldNumber

```csharp
public const int RequestedHeroIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_CtrlIsDown"></a> CtrlIsDown

```csharp
public bool CtrlIsDown { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_HasCtrlIsDown"></a> HasCtrlIsDown

```csharp
public bool HasCtrlIsDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_HasRequestedAbilityId"></a> HasRequestedAbilityId

```csharp
public bool HasRequestedAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_HasRequestedFacetKey"></a> HasRequestedFacetKey

```csharp
public bool HasRequestedFacetKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_HasRequestedHeroId"></a> HasRequestedHeroId

```csharp
public bool HasRequestedHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AbilityDraftRequestAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedAbilityId"></a> RequestedAbilityId

```csharp
public int RequestedAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedFacetKey"></a> RequestedFacetKey

```csharp
public ulong RequestedFacetKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_RequestedHeroId"></a> RequestedHeroId

```csharp
public int RequestedHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_ClearCtrlIsDown"></a> ClearCtrlIsDown\(\)

```csharp
public void ClearCtrlIsDown()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_ClearRequestedAbilityId"></a> ClearRequestedAbilityId\(\)

```csharp
public void ClearRequestedAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_ClearRequestedFacetKey"></a> ClearRequestedFacetKey\(\)

```csharp
public void ClearRequestedFacetKey()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_ClearRequestedHeroId"></a> ClearRequestedHeroId\(\)

```csharp
public void ClearRequestedHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AbilityDraftRequestAbility Clone()
```

#### Returns

 [CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_"></a> Equals\(CDOTAClientMsg\_AbilityDraftRequestAbility\)

```csharp
public bool Equals(CDOTAClientMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_"></a> MergeFrom\(CDOTAClientMsg\_AbilityDraftRequestAbility\)

```csharp
public void MergeFrom(CDOTAClientMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilityDraftRequestAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilityDraftRequestAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

