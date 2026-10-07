# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility"></a> Class CDOTAUserMsg\_AbilityDraftRequestAbility

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_AbilityDraftRequestAbility : IMessage<CDOTAUserMsg_AbilityDraftRequestAbility>, IEquatable<CDOTAUserMsg_AbilityDraftRequestAbility>, IDeepCloneable<CDOTAUserMsg_AbilityDraftRequestAbility>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)

#### Implements

IMessage<CDOTAUserMsg\_AbilityDraftRequestAbility\>, 
[IEquatable<CDOTAUserMsg\_AbilityDraftRequestAbility\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_AbilityDraftRequestAbility\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_AbilityDraftRequestAbility\>\(CDOTAUserMsg\_AbilityDraftRequestAbility, params CDOTAUserMsg\_AbilityDraftRequestAbility\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility__ctor"></a> CDOTAUserMsg\_AbilityDraftRequestAbility\(\)

```csharp
public CDOTAUserMsg_AbilityDraftRequestAbility()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_"></a> CDOTAUserMsg\_AbilityDraftRequestAbility\(CDOTAUserMsg\_AbilityDraftRequestAbility\)

```csharp
public CDOTAUserMsg_AbilityDraftRequestAbility(CDOTAUserMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_CtrlIsDownFieldNumber"></a> CtrlIsDownFieldNumber

```csharp
public const int CtrlIsDownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedAbilityIdFieldNumber"></a> RequestedAbilityIdFieldNumber

```csharp
public const int RequestedAbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedFacetKeyFieldNumber"></a> RequestedFacetKeyFieldNumber

```csharp
public const int RequestedFacetKeyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedHeroIdFieldNumber"></a> RequestedHeroIdFieldNumber

```csharp
public const int RequestedHeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_CtrlIsDown"></a> CtrlIsDown

```csharp
public bool CtrlIsDown { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_HasCtrlIsDown"></a> HasCtrlIsDown

```csharp
public bool HasCtrlIsDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_HasRequestedAbilityId"></a> HasRequestedAbilityId

```csharp
public bool HasRequestedAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_HasRequestedFacetKey"></a> HasRequestedFacetKey

```csharp
public bool HasRequestedFacetKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_HasRequestedHeroId"></a> HasRequestedHeroId

```csharp
public bool HasRequestedHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_AbilityDraftRequestAbility> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedAbilityId"></a> RequestedAbilityId

```csharp
public int RequestedAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedFacetKey"></a> RequestedFacetKey

```csharp
public ulong RequestedFacetKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_RequestedHeroId"></a> RequestedHeroId

```csharp
public int RequestedHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ClearCtrlIsDown"></a> ClearCtrlIsDown\(\)

```csharp
public void ClearCtrlIsDown()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ClearRequestedAbilityId"></a> ClearRequestedAbilityId\(\)

```csharp
public void ClearRequestedAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ClearRequestedFacetKey"></a> ClearRequestedFacetKey\(\)

```csharp
public void ClearRequestedFacetKey()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ClearRequestedHeroId"></a> ClearRequestedHeroId\(\)

```csharp
public void ClearRequestedHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_AbilityDraftRequestAbility Clone()
```

#### Returns

 [CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_"></a> Equals\(CDOTAUserMsg\_AbilityDraftRequestAbility\)

```csharp
public bool Equals(CDOTAUserMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_"></a> MergeFrom\(CDOTAUserMsg\_AbilityDraftRequestAbility\)

```csharp
public void MergeFrom(CDOTAUserMsg_AbilityDraftRequestAbility other)
```

#### Parameters

`other` [CDOTAUserMsg\_AbilityDraftRequestAbility](Divine.Protobufs.Dota2.CDOTAUserMsg\_AbilityDraftRequestAbility.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_AbilityDraftRequestAbility_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

