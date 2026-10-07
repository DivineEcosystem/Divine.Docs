# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert"></a> Class CDOTAClientMsg\_NeutralCampAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_NeutralCampAlert : IMessage<CDOTAClientMsg_NeutralCampAlert>, IEquatable<CDOTAClientMsg_NeutralCampAlert>, IDeepCloneable<CDOTAClientMsg_NeutralCampAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_NeutralCampAlert\>, 
[IEquatable<CDOTAClientMsg\_NeutralCampAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_NeutralCampAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_NeutralCampAlert\>\(CDOTAClientMsg\_NeutralCampAlert, params CDOTAClientMsg\_NeutralCampAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert__ctor"></a> CDOTAClientMsg\_NeutralCampAlert\(\)

```csharp
public CDOTAClientMsg_NeutralCampAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_"></a> CDOTAClientMsg\_NeutralCampAlert\(CDOTAClientMsg\_NeutralCampAlert\)

```csharp
public CDOTAClientMsg_NeutralCampAlert(CDOTAClientMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_SpawnerEntindexFieldNumber"></a> SpawnerEntindexFieldNumber

```csharp
public const int SpawnerEntindexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_StackRequestFieldNumber"></a> StackRequestFieldNumber

```csharp
public const int StackRequestFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_UnitEntindexFieldNumber"></a> UnitEntindexFieldNumber

```csharp
public const int UnitEntindexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_HasSpawnerEntindex"></a> HasSpawnerEntindex

```csharp
public bool HasSpawnerEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_HasStackRequest"></a> HasStackRequest

```csharp
public bool HasStackRequest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_HasUnitEntindex"></a> HasUnitEntindex

```csharp
public bool HasUnitEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_NeutralCampAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_SpawnerEntindex"></a> SpawnerEntindex

```csharp
public int SpawnerEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_StackRequest"></a> StackRequest

```csharp
public bool StackRequest { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_UnitEntindex"></a> UnitEntindex

```csharp
public int UnitEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_ClearSpawnerEntindex"></a> ClearSpawnerEntindex\(\)

```csharp
public void ClearSpawnerEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_ClearStackRequest"></a> ClearStackRequest\(\)

```csharp
public void ClearStackRequest()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_ClearUnitEntindex"></a> ClearUnitEntindex\(\)

```csharp
public void ClearUnitEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_NeutralCampAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_"></a> Equals\(CDOTAClientMsg\_NeutralCampAlert\)

```csharp
public bool Equals(CDOTAClientMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_"></a> MergeFrom\(CDOTAClientMsg\_NeutralCampAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_NeutralCampAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_NeutralCampAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_NeutralCampAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_NeutralCampAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

