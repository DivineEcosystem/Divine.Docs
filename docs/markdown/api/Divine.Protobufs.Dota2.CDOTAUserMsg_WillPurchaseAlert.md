# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert"></a> Class CDOTAUserMsg\_WillPurchaseAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_WillPurchaseAlert : IMessage<CDOTAUserMsg_WillPurchaseAlert>, IEquatable<CDOTAUserMsg_WillPurchaseAlert>, IDeepCloneable<CDOTAUserMsg_WillPurchaseAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_WillPurchaseAlert\>, 
[IEquatable<CDOTAUserMsg\_WillPurchaseAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_WillPurchaseAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_WillPurchaseAlert\>\(CDOTAUserMsg\_WillPurchaseAlert, params CDOTAUserMsg\_WillPurchaseAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert__ctor"></a> CDOTAUserMsg\_WillPurchaseAlert\(\)

```csharp
public CDOTAUserMsg_WillPurchaseAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_"></a> CDOTAUserMsg\_WillPurchaseAlert\(CDOTAUserMsg\_WillPurchaseAlert\)

```csharp
public CDOTAUserMsg_WillPurchaseAlert(CDOTAUserMsg_WillPurchaseAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_GoldRemainingFieldNumber"></a> GoldRemainingFieldNumber

```csharp
public const int GoldRemainingFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ItemAbilityIdFieldNumber"></a> ItemAbilityIdFieldNumber

```csharp
public const int ItemAbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_SuggestionPlayerIdFieldNumber"></a> SuggestionPlayerIdFieldNumber

```csharp
public const int SuggestionPlayerIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_GoldRemaining"></a> GoldRemaining

```csharp
public uint GoldRemaining { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_HasGoldRemaining"></a> HasGoldRemaining

```csharp
public bool HasGoldRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_HasItemAbilityId"></a> HasItemAbilityId

```csharp
public bool HasItemAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_HasSuggestionPlayerId"></a> HasSuggestionPlayerId

```csharp
public bool HasSuggestionPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ItemAbilityId"></a> ItemAbilityId

```csharp
public int ItemAbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_WillPurchaseAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_SuggestionPlayerId"></a> SuggestionPlayerId

```csharp
public int SuggestionPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ClearGoldRemaining"></a> ClearGoldRemaining\(\)

```csharp
public void ClearGoldRemaining()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ClearItemAbilityId"></a> ClearItemAbilityId\(\)

```csharp
public void ClearItemAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ClearSuggestionPlayerId"></a> ClearSuggestionPlayerId\(\)

```csharp
public void ClearSuggestionPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_WillPurchaseAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_"></a> Equals\(CDOTAUserMsg\_WillPurchaseAlert\)

```csharp
public bool Equals(CDOTAUserMsg_WillPurchaseAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_"></a> MergeFrom\(CDOTAUserMsg\_WillPurchaseAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_WillPurchaseAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_WillPurchaseAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_WillPurchaseAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_WillPurchaseAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

