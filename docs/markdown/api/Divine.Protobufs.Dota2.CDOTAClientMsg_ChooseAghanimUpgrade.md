# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade"></a> Class CDOTAClientMsg\_ChooseAghanimUpgrade

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ChooseAghanimUpgrade : IMessage<CDOTAClientMsg_ChooseAghanimUpgrade>, IEquatable<CDOTAClientMsg_ChooseAghanimUpgrade>, IDeepCloneable<CDOTAClientMsg_ChooseAghanimUpgrade>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)

#### Implements

IMessage<CDOTAClientMsg\_ChooseAghanimUpgrade\>, 
[IEquatable<CDOTAClientMsg\_ChooseAghanimUpgrade\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ChooseAghanimUpgrade\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ChooseAghanimUpgrade\>\(CDOTAClientMsg\_ChooseAghanimUpgrade, params CDOTAClientMsg\_ChooseAghanimUpgrade\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade__ctor"></a> CDOTAClientMsg\_ChooseAghanimUpgrade\(\)

```csharp
public CDOTAClientMsg_ChooseAghanimUpgrade()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_"></a> CDOTAClientMsg\_ChooseAghanimUpgrade\(CDOTAClientMsg\_ChooseAghanimUpgrade\)

```csharp
public CDOTAClientMsg_ChooseAghanimUpgrade(CDOTAClientMsg_ChooseAghanimUpgrade other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_AghanimIdFieldNumber"></a> AghanimIdFieldNumber

```csharp
public const int AghanimIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_ScepterFieldNumber"></a> ScepterFieldNumber

```csharp
public const int ScepterFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_AghanimId"></a> AghanimId

```csharp
public uint AghanimId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_HasAghanimId"></a> HasAghanimId

```csharp
public bool HasAghanimId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_HasScepter"></a> HasScepter

```csharp
public bool HasScepter { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ChooseAghanimUpgrade> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Scepter"></a> Scepter

```csharp
public bool Scepter { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_ClearAghanimId"></a> ClearAghanimId\(\)

```csharp
public void ClearAghanimId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_ClearScepter"></a> ClearScepter\(\)

```csharp
public void ClearScepter()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ChooseAghanimUpgrade Clone()
```

#### Returns

 [CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_"></a> Equals\(CDOTAClientMsg\_ChooseAghanimUpgrade\)

```csharp
public bool Equals(CDOTAClientMsg_ChooseAghanimUpgrade other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_"></a> MergeFrom\(CDOTAClientMsg\_ChooseAghanimUpgrade\)

```csharp
public void MergeFrom(CDOTAClientMsg_ChooseAghanimUpgrade other)
```

#### Parameters

`other` [CDOTAClientMsg\_ChooseAghanimUpgrade](Divine.Protobufs.Dota2.CDOTAClientMsg\_ChooseAghanimUpgrade.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ChooseAghanimUpgrade_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

