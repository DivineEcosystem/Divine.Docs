# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails"></a> Class CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails : IMessage<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails>, IEquatable<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails>, IDeepCloneable<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)

#### Implements

IMessage<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails\>, 
[IEquatable<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails\>\(CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails, params CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails__ctor"></a> AbilityDraftSpecificDetails\(\)

```csharp
public AbilityDraftSpecificDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_"></a> AbilityDraftSpecificDetails\(AbilityDraftSpecificDetails\)

```csharp
public AbilityDraftSpecificDetails(CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails other)
```

#### Parameters

`other` [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.md).[AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_ShuffleDraftOrderFieldNumber"></a> ShuffleDraftOrderFieldNumber

```csharp
public const int ShuffleDraftOrderFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_HasShuffleDraftOrder"></a> HasShuffleDraftOrder

```csharp
public bool HasShuffleDraftOrder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.md).[AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_ShuffleDraftOrder"></a> ShuffleDraftOrder

```csharp
public bool ShuffleDraftOrder { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_ClearShuffleDraftOrder"></a> ClearShuffleDraftOrder\(\)

```csharp
public void ClearShuffleDraftOrder()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails Clone()
```

#### Returns

 [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.md).[AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_"></a> Equals\(AbilityDraftSpecificDetails\)

```csharp
public bool Equals(CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails other)
```

#### Parameters

`other` [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.md).[AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_"></a> MergeFrom\(AbilityDraftSpecificDetails\)

```csharp
public void MergeFrom(CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails other)
```

#### Parameters

`other` [CMsgPracticeLobbySetDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.md).[Types](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.md).[AbilityDraftSpecificDetails](Divine.Protobufs.Dota2.CMsgPracticeLobbySetDetails.Types.AbilityDraftSpecificDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetDetails_Types_AbilityDraftSpecificDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

