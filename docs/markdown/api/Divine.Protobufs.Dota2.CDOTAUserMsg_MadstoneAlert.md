# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert"></a> Class CDOTAUserMsg\_MadstoneAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MadstoneAlert : IMessage<CDOTAUserMsg_MadstoneAlert>, IEquatable<CDOTAUserMsg_MadstoneAlert>, IDeepCloneable<CDOTAUserMsg_MadstoneAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_MadstoneAlert\>, 
[IEquatable<CDOTAUserMsg\_MadstoneAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MadstoneAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MadstoneAlert\>\(CDOTAUserMsg\_MadstoneAlert, params CDOTAUserMsg\_MadstoneAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert__ctor"></a> CDOTAUserMsg\_MadstoneAlert\(\)

```csharp
public CDOTAUserMsg_MadstoneAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_"></a> CDOTAUserMsg\_MadstoneAlert\(CDOTAUserMsg\_MadstoneAlert\)

```csharp
public CDOTAUserMsg_MadstoneAlert(CDOTAUserMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_MadstoneAlertTypeFieldNumber"></a> MadstoneAlertTypeFieldNumber

```csharp
public const int MadstoneAlertTypeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_TierFieldNumber"></a> TierFieldNumber

```csharp
public const int TierFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_HasMadstoneAlertType"></a> HasMadstoneAlertType

```csharp
public bool HasMadstoneAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_HasTier"></a> HasTier

```csharp
public bool HasTier { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_MadstoneAlertType"></a> MadstoneAlertType

```csharp
public CDOTAUserMsg_MadstoneAlert.Types.EMadstoneAlertType MadstoneAlertType { get; set; }
```

#### Property Value

 [CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.Types.md).[EMadstoneAlertType](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.Types.EMadstoneAlertType.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MadstoneAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Tier"></a> Tier

```csharp
public int Tier { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ClearMadstoneAlertType"></a> ClearMadstoneAlertType\(\)

```csharp
public void ClearMadstoneAlertType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ClearTier"></a> ClearTier\(\)

```csharp
public void ClearTier()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MadstoneAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_"></a> Equals\(CDOTAUserMsg\_MadstoneAlert\)

```csharp
public bool Equals(CDOTAUserMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_"></a> MergeFrom\(CDOTAUserMsg\_MadstoneAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_MadstoneAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_MadstoneAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_MadstoneAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MadstoneAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

