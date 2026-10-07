# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert"></a> Class CDOTAUserMsg\_NeutralCampAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_NeutralCampAlert : IMessage<CDOTAUserMsg_NeutralCampAlert>, IEquatable<CDOTAUserMsg_NeutralCampAlert>, IDeepCloneable<CDOTAUserMsg_NeutralCampAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_NeutralCampAlert\>, 
[IEquatable<CDOTAUserMsg\_NeutralCampAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_NeutralCampAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_NeutralCampAlert\>\(CDOTAUserMsg\_NeutralCampAlert, params CDOTAUserMsg\_NeutralCampAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert__ctor"></a> CDOTAUserMsg\_NeutralCampAlert\(\)

```csharp
public CDOTAUserMsg_NeutralCampAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_"></a> CDOTAUserMsg\_NeutralCampAlert\(CDOTAUserMsg\_NeutralCampAlert\)

```csharp
public CDOTAUserMsg_NeutralCampAlert(CDOTAUserMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_CampTypeFieldNumber"></a> CampTypeFieldNumber

```csharp
public const int CampTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_SpawnerEntindexFieldNumber"></a> SpawnerEntindexFieldNumber

```csharp
public const int SpawnerEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackIntentionFieldNumber"></a> StackIntentionFieldNumber

```csharp
public const int StackIntentionFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackRequestFieldNumber"></a> StackRequestFieldNumber

```csharp
public const int StackRequestFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_UnitEntindexFieldNumber"></a> UnitEntindexFieldNumber

```csharp
public const int UnitEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_CampType"></a> CampType

```csharp
public int CampType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasCampType"></a> HasCampType

```csharp
public bool HasCampType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasSpawnerEntindex"></a> HasSpawnerEntindex

```csharp
public bool HasSpawnerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasStackIntention"></a> HasStackIntention

```csharp
public bool HasStackIntention { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasStackRequest"></a> HasStackRequest

```csharp
public bool HasStackRequest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_HasUnitEntindex"></a> HasUnitEntindex

```csharp
public bool HasUnitEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_NeutralCampAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_SpawnerEntindex"></a> SpawnerEntindex

```csharp
public int SpawnerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackCount"></a> StackCount

```csharp
public int StackCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackIntention"></a> StackIntention

```csharp
public bool StackIntention { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_StackRequest"></a> StackRequest

```csharp
public bool StackRequest { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_UnitEntindex"></a> UnitEntindex

```csharp
public int UnitEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearCampType"></a> ClearCampType\(\)

```csharp
public void ClearCampType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearSpawnerEntindex"></a> ClearSpawnerEntindex\(\)

```csharp
public void ClearSpawnerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearStackIntention"></a> ClearStackIntention\(\)

```csharp
public void ClearStackIntention()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearStackRequest"></a> ClearStackRequest\(\)

```csharp
public void ClearStackRequest()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ClearUnitEntindex"></a> ClearUnitEntindex\(\)

```csharp
public void ClearUnitEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_NeutralCampAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_"></a> Equals\(CDOTAUserMsg\_NeutralCampAlert\)

```csharp
public bool Equals(CDOTAUserMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_"></a> MergeFrom\(CDOTAUserMsg\_NeutralCampAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_NeutralCampAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_NeutralCampAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

