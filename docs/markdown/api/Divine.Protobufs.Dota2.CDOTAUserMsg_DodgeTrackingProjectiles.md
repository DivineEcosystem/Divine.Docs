# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles"></a> Class CDOTAUserMsg\_DodgeTrackingProjectiles

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DodgeTrackingProjectiles : IMessage<CDOTAUserMsg_DodgeTrackingProjectiles>, IEquatable<CDOTAUserMsg_DodgeTrackingProjectiles>, IDeepCloneable<CDOTAUserMsg_DodgeTrackingProjectiles>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)

#### Implements

IMessage<CDOTAUserMsg\_DodgeTrackingProjectiles\>, 
[IEquatable<CDOTAUserMsg\_DodgeTrackingProjectiles\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DodgeTrackingProjectiles\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DodgeTrackingProjectiles\>\(CDOTAUserMsg\_DodgeTrackingProjectiles, params CDOTAUserMsg\_DodgeTrackingProjectiles\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles__ctor"></a> CDOTAUserMsg\_DodgeTrackingProjectiles\(\)

```csharp
public CDOTAUserMsg_DodgeTrackingProjectiles()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_"></a> CDOTAUserMsg\_DodgeTrackingProjectiles\(CDOTAUserMsg\_DodgeTrackingProjectiles\)

```csharp
public CDOTAUserMsg_DodgeTrackingProjectiles(CDOTAUserMsg_DodgeTrackingProjectiles other)
```

#### Parameters

`other` [CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_AttacksOnlyFieldNumber"></a> AttacksOnlyFieldNumber

```csharp
public const int AttacksOnlyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_EntindexFieldNumber"></a> EntindexFieldNumber

```csharp
public const int EntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_AttacksOnly"></a> AttacksOnly

```csharp
public bool AttacksOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Entindex"></a> Entindex

```csharp
public int Entindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_HasAttacksOnly"></a> HasAttacksOnly

```csharp
public bool HasAttacksOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_HasEntindex"></a> HasEntindex

```csharp
public bool HasEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DodgeTrackingProjectiles> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_ClearAttacksOnly"></a> ClearAttacksOnly\(\)

```csharp
public void ClearAttacksOnly()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_ClearEntindex"></a> ClearEntindex\(\)

```csharp
public void ClearEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DodgeTrackingProjectiles Clone()
```

#### Returns

 [CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_"></a> Equals\(CDOTAUserMsg\_DodgeTrackingProjectiles\)

```csharp
public bool Equals(CDOTAUserMsg_DodgeTrackingProjectiles other)
```

#### Parameters

`other` [CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_"></a> MergeFrom\(CDOTAUserMsg\_DodgeTrackingProjectiles\)

```csharp
public void MergeFrom(CDOTAUserMsg_DodgeTrackingProjectiles other)
```

#### Parameters

`other` [CDOTAUserMsg\_DodgeTrackingProjectiles](Divine.Protobufs.Dota2.CDOTAUserMsg\_DodgeTrackingProjectiles.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DodgeTrackingProjectiles_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

