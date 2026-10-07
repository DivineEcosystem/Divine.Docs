# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert"></a> Class CDOTAUserMsg\_MonsterHunter\_HuntAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MonsterHunter_HuntAlert : IMessage<CDOTAUserMsg_MonsterHunter_HuntAlert>, IEquatable<CDOTAUserMsg_MonsterHunter_HuntAlert>, IDeepCloneable<CDOTAUserMsg_MonsterHunter_HuntAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_MonsterHunter\_HuntAlert\>, 
[IEquatable<CDOTAUserMsg\_MonsterHunter\_HuntAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MonsterHunter\_HuntAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MonsterHunter\_HuntAlert\>\(CDOTAUserMsg\_MonsterHunter\_HuntAlert, params CDOTAUserMsg\_MonsterHunter\_HuntAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert__ctor"></a> CDOTAUserMsg\_MonsterHunter\_HuntAlert\(\)

```csharp
public CDOTAUserMsg_MonsterHunter_HuntAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_"></a> CDOTAUserMsg\_MonsterHunter\_HuntAlert\(CDOTAUserMsg\_MonsterHunter\_HuntAlert\)

```csharp
public CDOTAUserMsg_MonsterHunter_HuntAlert(CDOTAUserMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HuntAlertTypeFieldNumber"></a> HuntAlertTypeFieldNumber

```csharp
public const int HuntAlertTypeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HuntStatusTypeFieldNumber"></a> HuntStatusTypeFieldNumber

```csharp
public const int HuntStatusTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_IndexFieldNumber"></a> IndexFieldNumber

```csharp
public const int IndexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HasHuntAlertType"></a> HasHuntAlertType

```csharp
public bool HasHuntAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HasHuntStatusType"></a> HasHuntStatusType

```csharp
public bool HasHuntStatusType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HasIndex"></a> HasIndex

```csharp
public bool HasIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HuntAlertType"></a> HuntAlertType

```csharp
public CDOTAUserMsg_MonsterHunter_HuntAlert.Types.EHuntAlertType HuntAlertType { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.Types.md).[EHuntAlertType](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.Types.EHuntAlertType.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_HuntStatusType"></a> HuntStatusType

```csharp
public CDOTAUserMsg_MonsterHunter_HuntAlert.Types.EHuntStatusType HuntStatusType { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.Types.md).[EHuntStatusType](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.Types.EHuntStatusType.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Index"></a> Index

```csharp
public int Index { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MonsterHunter_HuntAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ClearHuntAlertType"></a> ClearHuntAlertType\(\)

```csharp
public void ClearHuntAlertType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ClearHuntStatusType"></a> ClearHuntStatusType\(\)

```csharp
public void ClearHuntStatusType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ClearIndex"></a> ClearIndex\(\)

```csharp
public void ClearIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MonsterHunter_HuntAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_"></a> Equals\(CDOTAUserMsg\_MonsterHunter\_HuntAlert\)

```csharp
public bool Equals(CDOTAUserMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_"></a> MergeFrom\(CDOTAUserMsg\_MonsterHunter\_HuntAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_MonsterHunter_HuntAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_HuntAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_HuntAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_HuntAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

